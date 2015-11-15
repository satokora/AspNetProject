using FestivalOfTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace FestivalOfTrees
{
    internal class SessionManager
    {
        private readonly HttpSessionState _session;
        private readonly SessionEnum? _sessionKey;

        private string SessionName
        {
            get
            {
                if (_sessionKey == null)
                {
                    throw new NullReferenceException("No sessionKey provided at the constructor");
                }
                return _sessionKey.ToString();
            }
        }

        internal SessionManager()
        {
            _session = HttpContext.Current.Session;
        }

        internal SessionManager(SessionEnum sessionKey) : this()
        {
            _sessionKey = sessionKey;
        }

        #region Depends on SessionKey provided using constructor
        internal bool DoesKeyExist()
        {
            if (!HasAnySessions())
            {
                return false;
            }
            bool exist = false;
            for (int i = 0; i < _session.Count; i++)
            {
                exist = _session.Keys[i] == SessionName;
                if (exist)
                {
                    break;
                }
            }
            return exist;
        }

        internal bool IsNull()
        {
            return _session[SessionName] == null;
        }

        internal void setNull()
        {
            _session[SessionName] = null;
        }

        internal TSource Get<TSource>()
        {
            return (TSource)_session[SessionName];
        }

        internal void Add<TSource>(TSource model)
        {
            _session.Add(SessionName, model);
        }

        internal void Replace<TSource>(TSource model)
        {
            _session[SessionName] = model;
        }

        internal void Remove()
        {
            _session.Remove(SessionName);
        }

        #endregion

        internal string GetSessionId()
        {
            return _session.SessionID;
        }

        internal bool HasAnySessions()
        {
            return _session.Count > 0;
        }

        internal void RemoveAll()
        {
            _session.RemoveAll();
        }

        internal void AbandonSessions()
        {
            _session.Abandon();
        }

    }
}