// Copyright (C) 2012 Winterleaf Entertainment L,L,C.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.RightsManagement;
using System.Text;
using System.Windows;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;
using WinterLeaf.Engine.Classes.Extensions;


namespace WinterLeaf.Engine.Classes.Interopt
    {
    /// <summary>
    /// This class is a function organizer for the externs.  All calls to Torque from C# go through this helper class.
    /// </summary>
    public class pInvokes
        {
		        /// <summary>
        /// 
        /// </summary>
        public class muglobals
            {
            /// <summary>
            /// /
            /// </summary>
            /// <param name="key"></param>
            /// <returns></returns>
            public uint this[string key]
                {
                get { return m_ts.GetVar(key).AsUint(); }
                set { m_ts.SetVar(key, value); }
                }
            }
        private readonly muglobals _muglobals = new muglobals();
        /// <summary>
        /// used to set/get bool globals
        /// </summary>
        public muglobals uGlobal
            {
            get { return _muglobals; }
            }

		/// <summary>
        /// 
        /// </summary>
        public class mglobalsIsDefined
            {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="key"></param>
            /// <returns></returns>
            public bool this[string key]
                {
                get { return m_ts.fn_isDefined(key, string.Empty); }
                }
            }

        public override string ToString()
            {
            return base.ToString();
            }

        readonly mglobalsIsDefined _mglobalsIsDefined = new mglobalsIsDefined();

        /// <summary>
        /// Used to grab string globals
        /// </summary>
        public mglobalsIsDefined isGlobal
            {
            get { return _mglobalsIsDefined; }
            }
        /// <summary>
        /// 
        /// </summary>
        public class msglobals
            {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="key"></param>
            /// <returns></returns>
            public string this[string key]
                {
                get { return m_ts.GetVar(key); }
                set { m_ts.SetVar(key, value); }
                }
            }
        public readonly msglobals _msglobals = new msglobals();
        /// <summary>
        /// Used to grab string globals
        /// </summary>
        public msglobals sGlobal
            {
            get { return _msglobals; }
            }

        /// <summary>
        /// 
        /// </summary>
        public class miglobals
            {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="key"></param>
            /// <returns></returns>
            public int this[string key]
                {
                get { return m_ts.GetVar(key).AsInt(); }
                set { m_ts.SetVar(key, value); }
                }
            }

        private readonly miglobals _miglobals = new miglobals();
        /// <summary>
        /// used to set/get int globals
        /// </summary>
        public miglobals iGlobal
            {
            get { return _miglobals; }
            }
        /// <summary>
        /// 
        /// </summary>
        public class mbglobals
            {
            /// <summary>
            /// /
            /// </summary>
            /// <param name="key"></param>
            /// <returns></returns>
            public bool this[string key]
                {
                get { return m_ts.GetVar(key).AsBool(); }
                set { m_ts.SetVar(key, value); }
                }
            }
        private readonly mbglobals _mbglobals = new mbglobals();
        /// <summary>
        /// used to set/get bool globals
        /// </summary>
        public mbglobals bGlobal
            {
            get { return _mbglobals; }
            }


		/// <summary>
        /// 
        /// </summary>
        public class mfglobals
            {
            /// <summary>
            /// /
            /// </summary>
            /// <param name="key"></param>
            /// <returns></returns>
            public float this[string key]
                {
                get { return m_ts.GetVar(key).AsFloat(); }
                set { m_ts.SetVar(key, value); }
                }
            }
        private readonly mfglobals _mfglobals = new mfglobals();
        /// <summary>
        /// used to set/get bool globals
        /// </summary>
        public mfglobals fGlobal
            {
            get { return _mfglobals; }
            }


			/// <summary>
        /// 
        /// </summary>
        public class mdglobals
            {
            /// <summary>
            /// /
            /// </summary>
            /// <param name="key"></param>
            /// <returns></returns>
            public double this[string key]
                {
                get { return m_ts.GetVar(key).AsDouble(); }
                set { m_ts.SetVar(key, value); }
                }
            }
        public readonly mdglobals _mdglobals = new mdglobals();
        /// <summary>
        /// used to set/get bool globals
        /// </summary>
        public mdglobals dGlobal
            {
            get { return _mdglobals; }
            }

		
        /// <summary>
        /// A reference to the dnTorque Object, this must be set at construction time.
        /// </summary>
        public static Omni m_ts;

        /// <summary>
        /// A property exposing Custom dnTorque Console Functions.
        /// </summary>
        private ConsoleObject _mConsoleobject;

        /// <summary>
        /// A property exposing Custom Math console functions.
        /// </summary>
        private tMath _mMathobject;

        /// <summary>
        /// A property exposing Custom dnTorque Console Functions.
        /// </summary>
        public ConsoleObject console
            {
            get { return _mConsoleobject; }
            }

        /// <summary>
        /// A property exposing Custom Math console functions.
        /// </summary>
        public tMath math
            {
            get { return _mMathobject; }
            }
        #region

        /// <summary>
        /// A list of all the Connection Object ID's active in Torque at the moment of request.
        /// </summary>
        public List<UInt32> ClientGroup
            {
            get
                {
                var temp = new List<uint>();
                for (uint i = 0; i < ClientGroup__GetCount(); i++)
                    {
                    temp.Add(ClientGroup__GetItem(i));
                    }
                return temp;
                }
            }

        /// <summary>
        /// The count of connection ID's
        /// </summary>
        /// <returns></returns>
        public UInt32 ClientGroup__GetCount()
            {
            return m_ts.ClientGroupGetCount();
            }

        /// <summary>
        /// Gets the object id at the index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public uint ClientGroup__GetItem(UInt32 index)
            {
            return m_ts.ClientGroupGetObject(index);
            }

        /// <summary>
        /// Removes the tagged string from Torque.
        /// </summary>
        /// <param name="tag"></param>
        public void removeTaggedString(string tag)
            {
            m_ts._removeTaggedString(tag);
            }

        /// <summary>
        /// Custom console commands.
        /// </summary>
        public class ConsoleObject
            {
            private Omni m_ts;

          
            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            internal IntPtr torque_gethwnd()
                {
                return m_ts._torque_gethwnd();

                }

            /// <summary>
            /// Determines if the method is defined in the namespace.
            /// </summary>
            /// <param name="NameSpace"></param>
            /// <param name="method"></param>
            /// <returns></returns>
            public bool isMethodInNamespace(string NameSpace, string method)
                {
                //if they pass us an id, lets convert it to a name
                //before checking it.
                if (NameSpace.IsNumeric())
                    NameSpace = getName(NameSpace);
                return m_ts.NameSpaceIsMethod(NameSpace, method);
                }

            /// <summary>
            /// Removes the tagged string from Torque.
            /// </summary>
            /// <param name="tag"></param>
            public void removeTaggedString(string tag)
                {
                m_ts._removeTaggedString(tag);
                }

            /// <summary>
            /// 
            /// Executes the function on the simobject but a previous version of it.
            /// For example in TorqueScript you have:
            /// 
            /// function AIPlayer::Somefunction(%this)
            /// {
            /// Parent::SomeFunction(%this);
            /// }
            /// 
            /// Would translate to:
            /// 
            /// ParentExecute(thisobj,"SomeFunction",1,new string[]{thisobj});
            /// 
            /// </summary>
            /// <param name="simobject">This can be a simple type like "Player", or a complex type like "Client.Player"</param>
            /// <param name="function">Function to call</param>
            /// <param name="namespacedepth">how many generations up to go from the LAST generation.</param>
            /// <param name="parameters">Parameters to pass</param>
            /// <param name="DoNotPassDepth">By default, this will append a parameter to the end, telling the called function what depth it is currently at, setting this will turn that off.</param>
            /// <returns></returns>
            public string ParentExecute(string simobject, string function, int namespacedepth, string[] parameters, bool DoNotPassDepth = false)
                {
                return m_ts.ConsoleCallParent(simobject, function, namespacedepth, parameters, DoNotPassDepth);
                }

            /// <summary>
            /// Executes the global function  but a previous version of it.
            /// For example in TorqueScript you have:
            /// 
            /// function Somefunction(%Version1)
            /// {
            /// }
            /// 
            /// function Somefunction(%this)
            /// {
            /// Parent::SomeFunction(%this);
            /// }
            /// 
            /// Would translate to:
            /// 
            /// ParentExecute("SomeFunction",1,new string[]{thisobj});
            /// 
            /// </summary>
            /// <param name="function">Function to call</param>
            /// <param name="namespacedepth">how many generations up to go from the LAST generation.</param>
            /// <param name="parameters">Parameters to pass</param>
            /// <param name="DoNotPassDepth">By default, this will append a parameter to the end, telling the called function what depth it is currently at, setting this will turn that off.</param>
            /// <returns></returns>
            public string ParentExecute(string function, int namespacedepth, string[] parameters, bool DoNotPassDepth = false)
                {
                return m_ts.ConsoleCallParent(function, namespacedepth, parameters, DoNotPassDepth);
                }

            /// <summary>
            /// Executes the global function  but a previous version of it.
            /// For example in TorqueScript you have:
            /// 
            /// function Somefunction(%Version1)
            /// {
            /// }
            /// 
            /// function Somefunction(%this)
            /// {
            /// Parent::SomeFunction(%this);
            /// }
            /// 
            /// Would translate to:
            /// 
            /// ParentExecute("SomeFunction",1,new string[]{thisobj});
            /// 
            /// </summary>
			/// <param name="simobject">This can be a simple type like "Player", or a complex type like "Client.Player"</param>
            /// <param name="function"></param>
            /// <param name="namespacedepth">how many generations up to go from the LAST generation.</param>
            /// <param name="parameters">Parameters to pass</param>
            public string ParentExecute(string simobject, string function, int namespacedepth, string[] parameters)
                {
                return m_ts.ConsoleCallParent(simobject, function, namespacedepth, parameters);
                }


            /// <summary>
            /// The name is a slight misnormer, the classname can be:
            /// -A Simobject
            /// -A Class
            /// -A Package
            ///  </summary>
            /// <param name="classname">Simobject,Class or Package</param>
            /// <param name="function">Function to call</param>
            /// <returns></returns>
            public string Call_Classname(string classname, string function)
                {
                return m_ts.ConsoleCallCn(classname, function, new string[] { });
                }

            /// <summary>
            /// The name is a slight misnormer, the classname can be:
            /// -A Simobject
            /// -A Class
            /// -A Package
            ///  </summary>
            /// <param name="classname">Simobject,Class or Package</param>
            /// <param name="function">Function to call</param>
            /// <param name="parameters">Parameters to pass.</param>
            /// <returns></returns>
            public string Call_Classname(string classname, string function, string[] parameters)
                {
                return m_ts.ConsoleCallCn(classname, function, parameters);
                }

            /// <summary>
            /// Calls the function inside the Torque Dll.
            /// </summary>
            /// <param name="function">Global function to call</param>
            /// <param name="parameters">Parameters to pass.</param>
            /// <returns></returns>
            public string Call(string function, string[] parameters)
                {
                return m_ts.Execute(function, parameters);
                }

            /// <summary>
            /// Calls a function with no parameters.
            /// </summary>
            /// <param name="function"></param>
            /// <returns></returns>
            public string Call(string function)
                {
                return m_ts.Execute(function, new string[] { });
                }

            /// <summary>
            /// Calls the member function on the object with parameters.
            /// </summary>
            /// <param name="simobject">Torque object, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="function"></param>
            /// <param name="parameters"></param>
            /// <returns></returns>
            public string Call(string simobject, string function, string[] parameters)
                {
                return m_ts.SimObjectCall(simobject, function, parameters);
                }

            /// <summary>
            /// Calls the member function on the object without parameters.
            /// </summary>
            /// <param name="simobject">Torque object, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="function"></param>
            /// <returns></returns>
            public string Call(string simobject, string function)
                {
                return m_ts.SimObjectCall(simobject, function, new string[] { });
                }


            /// <summary>
            /// Constructor.
            /// </summary>
            /// <param name="ts"></param>
            public ConsoleObject(ref Omni ts)
                {
                m_ts = ts;
                }

            /// <summary>
            /// Returns the string for the passed tag.
            /// </summary>
            /// <param name="tag"></param>
            /// <returns></returns>
            public string getTaggedString(string tag)
                {
                return m_ts.GetTaggedString(tag);
                }

            /// <summary>
            /// Returns the current sim time.
            /// </summary>
            /// <returns></returns>
            public int getSimTime()
                {
                return m_ts.ConsoleGetSimTime();
                }

            /// <summary>
            /// Deprecated: Should probally use the Util class version
            /// Spawns a object in the world.
            /// </summary>
            /// <param name="spawnClass"></param>
            /// <param name="spawnDataBlock"></param>
            /// <param name="spawnName"></param>
            /// <param name="spawnProperties"></param>
            /// <param name="spawnScript"></param>
            /// <returns></returns>
            public UInt32 SpawnObject(string spawnClass, string spawnDataBlock, string spawnName, string spawnProperties, string spawnScript)
                {
                return m_ts.SpawnObject(spawnClass, spawnDataBlock, spawnName, spawnProperties, spawnScript);
                }

            /// <summary>
            /// Determines if function is in the namespace Hierarchy.
            /// </summary>
            /// <param name="simobject_id"></param>
            /// <param name="name"></param>
            /// <returns></returns>
            public bool isInNamespaceHierarchy(string simobject_id, string name)
                {
                return m_ts.NameSpaceIsInNamespaceHierarchy(simobject_id, name);
                }

            /// <summary>
            /// Returns the mask type for the passed simobject name or id.
            /// </summary>
            /// <param name="SceneObject"></param>
            /// <returns></returns>
            public UInt32 getTypeMask(string SceneObject)
                {
                return m_ts.SceneObjectGetTypeMask(SceneObject);
                }

            /// <summary>
            /// Returns a dictionary of the objects around the a point with their id and distance.
            /// </summary>
            /// <param name="pos"></param>
            /// <param name="raidus"></param>
            /// <param name="mask"></param>
            /// <param name="useclientcontainer"></param>
            /// <returns></returns>
            public Dictionary<uint, float> initContainerRadiusSearch(Point3F pos, float raidus, UInt32 mask, bool useclientcontainer = false)
                {
                return m_ts.SceneObjectInitContainerRadiusSearch(pos, raidus, mask, useclientcontainer);
                }

      
            /// <summary>
            /// This function will take a normal string with torque color
            /// encoding commands and convert it to the correct format for color encoding
            /// inside of torque.
            /// </summary>
            /// <param name="mystring"></param>
            /// <returns></returns>
            public string ColorEncode(string mystring)
                {
                StringBuilder newstring = new StringBuilder();
                for (int i = 0; i < mystring.Length; i++)
                    {
                    if (mystring[i] == '\\')
                        {
                        if ((mystring[i + 1] == 't'))
                            {
                            newstring.Append("\t");
                            }
                        else if ((mystring[i + 1] == 'n'))
                            {
                            newstring.Append("\n");
                            }
                        else if ((mystring[i + 1] == 'r'))
                            {
                            newstring.Append("\r");
                            }

                        else if ((mystring[i + 1] == 'c') || (mystring[i + 1] == 'C'))
                            {
                            switch (mystring[i + 2].ToString(CultureInfo.InvariantCulture).ToLower())
                                {
                                case "0":
                                    newstring.Append((char)2);
                                    newstring.Append((char)1);
                                    i = i + 2;
                                    break;
                                case "1":
                                    newstring.Append((char)2);
                                    i = i + 2;
                                    break;
                                case "2":
                                    newstring.Append((char)3);
                                    i = i + 2;
                                    break;
                                case "3":
                                    newstring.Append((char)4);
                                    i = i + 2;
                                    break;
                                case "4":
                                    newstring.Append((char)5);
                                    i = i + 2;
                                    break;
                                case "5":
                                    newstring.Append((char)6);
                                    i = i + 2;
                                    break;
                                case "6":
                                    newstring.Append((char)7);
                                    i = i + 2;
                                    break;
                                case "7":
                                    newstring.Append((char)11);
                                    i = i + 2;
                                    break;
                                case "8":
                                    newstring.Append((char)12);
                                    i = i + 2;
                                    break;
                                case "9":
                                    newstring.Append((char)14);
                                    i = i + 2;
                                    break;
                                case "r":
                                    newstring.Append((char)15);
                                    i = i + 2;
                                    break;
                                case "p":
                                    newstring.Append((char)16);
                                    i = i + 2;
                                    break;
                                case "o":
                                    newstring.Append((char)17);
                                    i = i + 2;
                                    break;

                                default:
                                    newstring.Append(mystring[i]);
                                    break;
                                }
                            }
                        else
                            {
                            newstring.Append(mystring[i]);
                            }
                        }
                    else
                        {
                        newstring.Append(mystring[i]);
                        }
                    }
                return newstring.ToString();
                }

            /// <summary>
            /// Send a command to the client to execute the function
            /// </summary>
            /// <param name="client">Client connection ID, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="function">Function to execute.</param>
            public void commandToClient(string client, string function)
                {
                commandToClient(client, function, new string[] { });
                }

            /// <summary>
            /// Send a command to the client to execute the function
            /// </summary>
            /// <param name="client">Client connection ID, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="function">Function to execute.</param>
            /// <param name="parameters">Parameters to pass</param>
            public void commandToClient(string client, string function, string[] parameters)
                {
                m_ts.CommandToClient(client, function, parameters);
                }

            /// <summary>
            /// Sets the passed torque variable to the value
            /// </summary>
            /// <param name="variable">Torque Variable to change, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="value"></param>
            public void SetVar(string variable, float value)
                {
                m_ts.SetVar(variable, value.AsString());
                }

            /// <summary>
            /// Sets the passed torque variable to the value
            /// </summary>
            /// <param name="variable">Torque Variable to change, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="value"></param>
            public void SetVar(string variable, double value)
                {
                m_ts.SetVar(variable, value.AsString());
                }

            /// <summary>
            /// Sets the passed torque variable to the value
            /// </summary>
            /// <param name="variable">Torque Variable to change, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="value"></param>
            public void SetVar(UInt32 variable, string value)
                {
                m_ts.SetVar(variable.AsString(), value);
                }

            /// <summary>
            /// Sets the passed torque variable to the value
            /// </summary>
            /// <param name="variable">Torque Variable to change, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="value"></param>
            public void SetVar(UInt32 variable, Int16 value)
                {
                m_ts.SetVar(variable.AsString(), value.AsString());
                }

            /// <summary>
            /// Sets the passed torque variable to the value
            /// </summary>
            /// <param name="variable">Torque Variable to change, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="value"></param>
            public void SetVar(UInt32 variable, Int32 value)
                {
                m_ts.SetVar(variable.AsString(), value.AsString());
                }

            /// <summary>
            /// Sets the passed torque variable to the value
            /// </summary>
            /// <param name="variable">Torque Variable to change, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="value"></param>
            public void SetVar(UInt32 variable, Int64 value)
                {
                m_ts.SetVar(variable.AsString(), value.AsString());
                }

            /// <summary>
            /// Sets the passed torque variable to the value
            /// </summary>
            /// <param name="variable">Torque Variable to change, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="value"></param>
            public void SetVar(UInt32 variable, UInt16 value)
                {
                m_ts.SetVar(variable.AsString(), value.AsString());
                }

            /// <summary>
            /// Sets the passed torque variable to the value
            /// </summary>
            /// <param name="variable">Torque Variable to change, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="value"></param>
            public void SetVar(UInt32 variable, UInt32 value)
                {
                m_ts.SetVar(variable.AsString(), value.AsString());
                }

            /// <summary>
            /// Sets the passed torque variable to the value
            /// </summary>
            /// <param name="variable">Torque Variable to change, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="value"></param>
            public void SetVar(UInt32 variable, UInt64 value)
                {
                m_ts.SetVar(variable.AsString(), value.AsString());
                }

            /// <summary>
            /// Sets the passed torque variable to the value
            /// </summary>
            /// <param name="variable">Torque Variable to change, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="value"></param>
            public void SetVar(UInt32 variable, bool value)
                {
                m_ts.SetVar(variable.AsString(), value.AsString());
                }

            /// <summary>
            /// Sets the passed torque variable to the value
            /// </summary>
            /// <param name="variable">Torque Variable to change, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="value"></param>
            public void SetVar(string variable, string value)
                {
                m_ts.SetVar(variable, value);
                }

            /// <summary>
            /// Sets the passed torque variable to the value
            /// </summary>
            /// <param name="variable">Torque Variable to change, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="value"></param>
            public void SetVar(string variable, Int16 value)
                {
                m_ts.SetVar(variable, value.AsString());
                }

            /// <summary>
            /// Sets the passed torque variable to the value
            /// </summary>
            /// <param name="variable">Torque Variable to change, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="value"></param>
            public void SetVar(string variable, Int32 value)
                {
                m_ts.SetVar(variable, value.AsString());
                }

            /// <summary>
            /// Sets the passed torque variable to the value
            /// </summary>
            /// <param name="variable">Torque Variable to change, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="value"></param>
            public void SetVar(string variable, Int64 value)
                {
                m_ts.SetVar(variable, value.AsString());
                }

            /// <summary>
            /// Sets the passed torque variable to the value
            /// </summary>
            /// <param name="variable">Torque Variable to change, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="value"></param>
            public void SetVar(string variable, UInt16 value)
                {
                m_ts.SetVar(variable, value.AsString());
                }

            /// <summary>
            /// Sets the passed torque variable to the value
            /// </summary>
            /// <param name="variable">Torque Variable to change, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="value"></param>
            public void SetVar(string variable, UInt32 value)
                {
                m_ts.SetVar(variable, value.AsString());
                }

            /// <summary>
            /// Sets the passed torque variable to the value
            /// </summary>
            /// <param name="variable">Torque Variable to change, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="value"></param>
            public void SetVar(string variable, UInt64 value)
                {
                m_ts.SetVar(variable, value.AsString());
                }

            /// <summary>
            /// Sets the passed torque variable to the value
            /// </summary>
            /// <param name="variable">Torque Variable to change, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="value"></param>
            public void SetVar(string variable, bool value)
                {
                m_ts.SetVar(variable, value.AsString());
                }

            /// <summary>
            /// Sends a command to the server to call the function
            /// </summary>
            /// <param name="function"></param>
            public void commandToServer(string function)
                {
                commandToServer(function, new string[] { });
                }

            /// <summary>
            /// Sends a command to the server to call the function with passed parameters.
            /// </summary>
            /// <param name="function"></param>
            /// <param name="parameters"></param>
            public void commandToServer(string function, string[] parameters)
                {
                m_ts.CommandToServer(function, parameters);
                }

            /// <summary>
            /// Gets the passed variable from torque
            /// Can be object.property.
            /// </summary>
            /// <param name="variable">Torque Variable to retrieve, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <returns></returns>
            public string GetVarString(string variable)
                {
                return m_ts.GetVar(variable);
                }

            /// <summary>
            /// Gets the passed variable from torque
            /// Can be object.property.
            /// </summary>
            /// <param name="variable">Torque Variable to retrieve, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <returns></returns>
            public bool GetVarBool(string variable)
                {
                int t = 0;
                string result = m_ts.GetVar(variable);
                if (result.Trim().ToLower() == "true")
                    return true;
                if (result.Trim().ToLower() == "false")
                    return false;
                if (result.Trim().ToLower() == "1")
                    return true;
                if (result.Trim().ToLower() == "0")
                    return false;
                if (int.TryParse(result, out t))
                    {
                    return t > 0;
                    }
                return false;
                }

            /// <summary>
            /// Gets the passed variable from torque
            /// Can be object.property.
            /// </summary>
            /// <param name="variable">Torque Variable to retrieve, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <returns></returns>
            public int GetVarInt(string variable)
                {
               
                string result = m_ts.GetVar(variable);
                if (result.Trim().ToLower() == "true")
                    return 1;
                if (result.Trim().ToLower() == "false")
                    return 0;
                return result.AsInt();
                }

            /// <summary>
            /// Gets the passed variable from torque
            /// Can be object.property.
            /// </summary>
            /// <param name="variable">Torque Variable to retrieve, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <returns></returns>
            public float GetVarFloat(string variable)
                {
                return m_ts.GetVar(variable).AsFloat();
                }

            /// <summary>
            /// Gets the passed variable from torque
            /// Can be object.property.
            /// </summary>
            /// <param name="variable">Torque Variable to retrieve, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <returns></returns>
            public uint GetVarUint(string variable)
                {
                return  m_ts.GetVar(variable).AsUint();
                }

            /// <summary>
            /// Gets the passed variable from torque
            /// Can be object.property.
            /// </summary>
            /// <param name="variable">Torque Variable to retrieve, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <returns></returns>
            public long GetVarLong(string variable)
                {
                return m_ts.GetVar(variable).AsLong();
                }

            /// <summary>
            /// Gets the passed variable from torque
            /// Can be object.property.
            /// </summary>
            /// <param name="variable">Torque Variable to retrieve, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <returns></returns>
            internal double GetVarDouble(string variable)
                {
                return m_ts.GetVar(variable).AsDouble();
                }

            /// <summary>
            /// Posts a warning inside of Torque.
            /// </summary>
            /// <param name="msg"></param>
            public void warn(string msg)
                {
                m_ts.Warn(msg);
                }

            /// <summary>
            /// Posts a debug message inside of Torque.
            /// </summary>
            /// <param name="msg"></param>
            public void debug(string msg)
                {
                if (m_ts.Debugging)
                    m_ts.Warn(msg);
                }

            /// <summary>
            /// Posts a Print message inside of Torque.
            /// </summary>
            /// <param name="msg"></param>
            public void print(string msg)
                {
                m_ts.Print(msg);
                }

            /// <summary>
            /// Posts an Error  message inside of Torque.
            /// </summary>
            /// <param name="msg"></param>
            public void error(string msg)
                {
                m_ts.Error(msg);
                }

            /// <summary>
            /// Determines if the number or string is a object.
            /// </summary>
            /// <param name="simobject">Torque Variable to check, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <returns></returns>
            public bool isObject(string simobject)
                {
                return m_ts.IsObject(simobject);
                }

            /// <summary>
            /// Calls clearServerPaths on the console.
            /// </summary>
            public void clearServerPaths()
                {
                m_ts.ClearServerPaths();
                }

            /// <summary>
            /// Deletes the variable inside of torque.
            /// </summary>
            /// <param name="var_name"></param>
            public void deleteVariables(string var_name)
                {
                m_ts.DeleteVariables(var_name);
                }

            /// <summary>
            /// Determines if the class is a member of the superclass.
            /// </summary>
            /// <param name="classname"></param>
            /// <param name="superclassname"></param>
            /// <returns></returns>
            public bool isMemberOfClass(string classname, string superclassname)
                {
                return m_ts.IsMemberOfClass(classname, superclassname);
                }

            /// <summary>
            /// Determines if the object has the passed method.
            /// </summary>
            /// <param name="simobject">Torque Variable to check, can be a simple or complex type.  i.e. "Client" or "Player.client"</param>
            /// <param name="method"></param>
            /// <returns></returns>
            public bool objectHasMethod(string simobject, string method)
                {
                return m_ts.ObjectHasMethod(simobject, method);
                }

            /// <summary>
            /// Adds a tagged string into the dictionary and returns it's tag id.
            /// </summary>
            /// <param name="mystring"></param>
            /// <returns></returns>
            public string addTaggedString(string mystring)
                {
                return m_ts.AddTaggedString(mystring);
                }

            /// <summary>
            /// Returns the classname for the simobject.
            /// </summary>
            /// <param name="simobject"></param>
            /// <returns></returns>
            public string GetClassName(string simobject)
                {
                return m_ts.GetClassName(simobject);
                }

            /// <summary>
            /// Returns the simobjectid for the simobject name.
            /// </summary>
            /// <param name="simobj_id"></param>
            /// <returns></returns>
            public UInt32 GetObjectID(string simobj_id)
                {
                return m_ts.GetObjectID(simobj_id);
                }

            /// <summary>
            /// Returns the name of the object (passed by id)
            /// </summary>
            /// <param name="name"></param>
            /// <returns></returns>
            public Int32 nameToID(string name)
                {
                return m_ts.NameToId(name);
                }

            /// <summary>
            /// Gets the name of the id.
            /// </summary>
            /// <param name="simobject"></param>
            /// <returns></returns>
            public string getName(string simobject)
                {
                return m_ts.GetName(simobject);
                }

            /// <summary>
            /// Evaluates the passed script and returns the resultant.
            /// </summary>
            /// <param name="script"></param>
            /// <param name="retval"></param>
            /// <returns></returns>
            public string Eval(string script, bool retval)
                {
                return m_ts.Evaluate(script, retval);
                }

            /// <summary>
            /// Executes the passed script.
            /// </summary>
            /// <param name="script"></param>
            public void Eval(string script)
                {
                m_ts.Evaluate(script, false);
                }


            /// <summary>
            /// Determines if the function is in the global name space.
            /// </summary>
            /// <param name="function_name"></param>
            /// <returns></returns>
            public bool isFunction(string function_name)
                {
                return m_ts.IsFunction(function_name);
                }

            /// <summary>
            /// Returns the Euler Rotation to the object.
            /// </summary>
            /// <param name="simobject"></param>
            /// <returns></returns>
            public TransformF getEulerRotation(string simobject)
                {
                return m_ts.GetEulerRotation(simobject);
                }

            /// <summary>
            /// Returns a list of simobject id's in the radius of the search.
            /// </summary>
            /// <param name="p"></param>
            /// <param name="searchradius"></param>
            /// <param name="searchmask"></param>
            /// <param name="useclientcontainer"></param>
            /// <returns></returns>
            public List<UInt32> ContainerRadiusSearch(Point3F p, double searchradius, UInt32 searchmask, bool useclientcontainer)
                {
                return m_ts.ContainerRadiusSearch(p, searchradius, searchmask, useclientcontainer);
                }

            /// <summary>
            /// Calls pathOnMissionLoadDone inside of Torque.
            /// </summary>
            public void pathOnMissionLoadDone()
                {
                m_ts.PathOnMissionLoadDone();
                }

            /// <summary>
            /// Returns the datablock associated with the simobject.
            /// </summary>
            /// <param name="simobject"></param>
            /// <returns></returns>
            public UInt32 getDatablock(string simobject)
                {
                return m_ts.GetDatablock(simobject);
                }

            /// <summary>
            /// Determines if the field is a member of the object.
            /// </summary>
            /// <param name="simobject_id"></param>
            /// <param name="fieldname"></param>
            /// <returns></returns>
            public bool isField(string simobject_id, string fieldname)
                {
                return m_ts.SimObjectIsField(simobject_id, fieldname);
                }


            }
               /// <summary>
        /// 
        /// </summary>
        public class tMath
            {
            /// <summary>
            /// 
            /// </summary>
            private Omni m_ts;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            public tMath(ref Omni ts)
                {
                m_ts = ts;
                }
            /// <summary>
            /// 
            /// </summary>
            public static double M_2PI_F
                {
                get { return 3.1415926535897932384626433f * 2.0f; }
                }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="transform"></param>
            /// <param name="vector"></param>
            /// <returns></returns>
            public TransformF MatrixMulVector(TransformF transform, Point3F vector)
                {
                return m_ts.MathMatrixMulVector(transform, vector);
                }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="d"></param>
            /// <returns></returns>
            public static double mDegToRad(double d)
                {
                return ((d * Math.PI) / 180.0);
                }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="r"></param>
            /// <returns></returns>
            public static double mRadToDeg(double r)
                {
                return ((r * 180.0) / Math.PI);
                }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="transform"></param>
            /// <returns></returns>
            public TransformF MatrixCreateFromEuler(TransformF transform)
                {
                return m_ts.MathMatrixCreateFromEuler(transform);
                }
            }
        #endregion
		/// <summary>
        /// 
        /// </summary>
        public pInvokes()
            {
            m_ts = Omni.self;
            SetUp(ref m_ts);
            }

        /// <summary>
        /// Container Class for all the properties for organization.
        /// </summary>
        /// <param name="c"></param>
        public pInvokes(ref Omni c)
            {
			SetUp(ref c);
			}

		public void SetUp(ref Omni c)
            {
            m_ts = c;
            _mConsoleobject = new ConsoleObject(ref c);
            _mMathobject = new tMath(ref c);
            	_mUtil = new UtilObject(ref c);
	_mAIClient = new AIClientObject(ref c);
	_mAIConnection = new AIConnectionObject(ref c);
	_mAIPlayer = new AIPlayerObject(ref c);
	_mCompoundUndoAction = new CompoundUndoActionObject(ref c);
	_mConsoleLogger = new ConsoleLoggerObject(ref c);
	_mCreatorTree = new CreatorTreeObject(ref c);
	_mDbgFileView = new DbgFileViewObject(ref c);
	_mEditManager = new EditManagerObject(ref c);
	_mEventManager = new EventManagerObject(ref c);
	_mFieldBrushObject = new FieldBrushObjectObject(ref c);
	_mFileObject = new FileObjectObject(ref c);
	_mForest = new ForestObject(ref c);
	_mForestBrush = new ForestBrushObject(ref c);
	_mForestBrushTool = new ForestBrushToolObject(ref c);
	_mForestEditorCtrl = new ForestEditorCtrlObject(ref c);
	_mForestSelectionTool = new ForestSelectionToolObject(ref c);
	_mGuiBitmapCtrl = new GuiBitmapCtrlObject(ref c);
	_mGuiCanvas = new GuiCanvasObject(ref c);
	_mGuiColorPickerCtrl = new GuiColorPickerCtrlObject(ref c);
	_mGuiControl = new GuiControlObject(ref c);
	_mGuiControlProfile = new GuiControlProfileObject(ref c);
	_mGuiConvexEditorCtrl = new GuiConvexEditorCtrlObject(ref c);
	_mGuiDecalEditorCtrl = new GuiDecalEditorCtrlObject(ref c);
	_mGuiEditCtrl = new GuiEditCtrlObject(ref c);
	_mGuiFileTreeCtrl = new GuiFileTreeCtrlObject(ref c);
	_mGuiFilterCtrl = new GuiFilterCtrlObject(ref c);
	_mGuiGradientCtrl = new GuiGradientCtrlObject(ref c);
	_mGuiIdleCamFadeBitmapCtrl = new GuiIdleCamFadeBitmapCtrlObject(ref c);
	_mGuiInspector = new GuiInspectorObject(ref c);
	_mGuiInspectorDynamicField = new GuiInspectorDynamicFieldObject(ref c);
	_mGuiInspectorDynamicGroup = new GuiInspectorDynamicGroupObject(ref c);
	_mGuiInspectorField = new GuiInspectorFieldObject(ref c);
	_mGuiMaterialCtrl = new GuiMaterialCtrlObject(ref c);
	_mGuiMeshRoadEditorCtrl = new GuiMeshRoadEditorCtrlObject(ref c);
	_mGuiMissionAreaEditorCtrl = new GuiMissionAreaEditorCtrlObject(ref c);
	_mGuiNavEditorCtrl = new GuiNavEditorCtrlObject(ref c);
	_mGuiParticleGraphCtrl = new GuiParticleGraphCtrlObject(ref c);
	_mGuiPopUpMenuCtrl = new GuiPopUpMenuCtrlObject(ref c);
	_mGuiPopUpMenuCtrlEx = new GuiPopUpMenuCtrlExObject(ref c);
	_mGuiRiverEditorCtrl = new GuiRiverEditorCtrlObject(ref c);
	_mGuiRoadEditorCtrl = new GuiRoadEditorCtrlObject(ref c);
	_mGuiTerrPreviewCtrl = new GuiTerrPreviewCtrlObject(ref c);
	_mGuiTextEditCtrl = new GuiTextEditCtrlObject(ref c);
	_mGuiTickCtrl = new GuiTickCtrlObject(ref c);
	_mGuiToolboxButtonCtrl = new GuiToolboxButtonCtrlObject(ref c);
	_mGuiTreeViewCtrl = new GuiTreeViewCtrlObject(ref c);
	_mGuiVariableInspector = new GuiVariableInspectorObject(ref c);
	_mLangTable = new LangTableObject(ref c);
	_mLightBase = new LightBaseObject(ref c);
	_mMaterial = new MaterialObject(ref c);
	_mMECreateUndoAction = new MECreateUndoActionObject(ref c);
	_mMEDeleteUndoAction = new MEDeleteUndoActionObject(ref c);
	_mMenuBar = new MenuBarObject(ref c);
	_mMessage = new MessageObject(ref c);
	_mMessageVector = new MessageVectorObject(ref c);
	_mPersistenceManager = new PersistenceManagerObject(ref c);
	_mPhysicsDebrisData = new PhysicsDebrisDataObject(ref c);
	_mPopupMenu = new PopupMenuObject(ref c);
	_mReadXML = new ReadXMLObject(ref c);
	_mSettings = new SettingsObject(ref c);
	_mSFXSource = new SFXSourceObject(ref c);
	_mSimComponent = new SimComponentObject(ref c);
	_mSimDataBlock = new SimDataBlockObject(ref c);
	_mSimObject = new SimObjectObject(ref c);
	_mSimPersistSet = new SimPersistSetObject(ref c);
	_mSimResponseCurve = new SimResponseCurveObject(ref c);
	_mSimSet = new SimSetObject(ref c);
	_mSimXMLDocument = new SimXMLDocumentObject(ref c);
	_mSkyBox = new SkyBoxObject(ref c);
	_mSpawnSphere = new SpawnSphereObject(ref c);
	_mStaticShape = new StaticShapeObject(ref c);
	_mSun = new SunObject(ref c);
	_mTerrainBlock = new TerrainBlockObject(ref c);
	_mTerrainEditor = new TerrainEditorObject(ref c);
	_mTerrainSmoothAction = new TerrainSmoothActionObject(ref c);
	_mTerrainSolderEdgesAction = new TerrainSolderEdgesActionObject(ref c);
	_mTheoraTextureObject = new TheoraTextureObjectObject(ref c);
	_mUndoAction = new UndoActionObject(ref c);
	_mUndoManager = new UndoManagerObject(ref c);
	_mWorldEditor = new WorldEditorObject(ref c);
	_mActionMap = new ActionMapObject(ref c);
	_mAITurretShape = new AITurretShapeObject(ref c);
	_mArrayObject = new ArrayObjectObject(ref c);
	_mCamera = new CameraObject(ref c);
	_mCloudLayer = new CloudLayerObject(ref c);
	_mCoverPoint = new CoverPointObject(ref c);
	_mCubemapData = new CubemapDataObject(ref c);
	_mDebris = new DebrisObject(ref c);
	_mDebugDrawer = new DebugDrawerObject(ref c);
	_mDecalData = new DecalDataObject(ref c);
	_mDecalRoad = new DecalRoadObject(ref c);
	_mDynamicConsoleMethodComponent = new DynamicConsoleMethodComponentObject(ref c);
	_mEditTSCtrl = new EditTSCtrlObject(ref c);
	_mFileDialog = new FileDialogObject(ref c);
	_mFileStreamObject = new FileStreamObjectObject(ref c);
	_mFlyingVehicle = new FlyingVehicleObject(ref c);
	_mForestWindEmitter = new ForestWindEmitterObject(ref c);
	_mGameBase = new GameBaseObject(ref c);
	_mGameConnection = new GameConnectionObject(ref c);
	_mGroundPlane = new GroundPlaneObject(ref c);
	_mGuiAutoCompleteCtrl = new GuiAutoCompleteCtrlObject(ref c);
	_mGuiAutoScrollCtrl = new GuiAutoScrollCtrlObject(ref c);
	_mGuiBitmapButtonCtrl = new GuiBitmapButtonCtrlObject(ref c);
	_mGuiButtonBaseCtrl = new GuiButtonBaseCtrlObject(ref c);
	_mGuiCheckBoxCtrl = new GuiCheckBoxCtrlObject(ref c);
	_mGuiChunkedBitmapCtrl = new GuiChunkedBitmapCtrlObject(ref c);
	_mGuiClockHud = new GuiClockHudObject(ref c);
	_mGuiDirectoryFileListCtrl = new GuiDirectoryFileListCtrlObject(ref c);
	_mGuiDragAndDropControl = new GuiDragAndDropControlObject(ref c);
	_mGuiDynamicCtrlArrayControl = new GuiDynamicCtrlArrayControlObject(ref c);
	_mGuiFormCtrl = new GuiFormCtrlObject(ref c);
	_mGuiFrameSetCtrl = new GuiFrameSetCtrlObject(ref c);
	_mGuiGameListMenuCtrl = new GuiGameListMenuCtrlObject(ref c);
	_mGuiGameListOptionsCtrl = new GuiGameListOptionsCtrlObject(ref c);
	_mGuiGraphCtrl = new GuiGraphCtrlObject(ref c);
	_mGuiIconButtonCtrl = new GuiIconButtonCtrlObject(ref c);
	_mGuiImageList = new GuiImageListObject(ref c);
	_mGuiInspectorTypeBitMask32 = new GuiInspectorTypeBitMask32Object(ref c);
	_mGuiInspectorTypeFileName = new GuiInspectorTypeFileNameObject(ref c);
	_mGuiListBoxCtrl = new GuiListBoxCtrlObject(ref c);
	_mGuiMaterialPreview = new GuiMaterialPreviewObject(ref c);
	_mGuiMenuBar = new GuiMenuBarObject(ref c);
	_mGuiMessageVectorCtrl = new GuiMessageVectorCtrlObject(ref c);
	_mGuiMissionAreaCtrl = new GuiMissionAreaCtrlObject(ref c);
	_mGuiMLTextCtrl = new GuiMLTextCtrlObject(ref c);
	_mGuiObjectView = new GuiObjectViewObject(ref c);
	_mGuiPaneControl = new GuiPaneControlObject(ref c);
	_mGuiProgressBitmapCtrl = new GuiProgressBitmapCtrlObject(ref c);
	_mGuiRolloutCtrl = new GuiRolloutCtrlObject(ref c);
	_mGuiScrollCtrl = new GuiScrollCtrlObject(ref c);
	_mGuiShapeEdPreview = new GuiShapeEdPreviewObject(ref c);
	_mGuiSliderCtrl = new GuiSliderCtrlObject(ref c);
	_mGuiStackControl = new GuiStackControlObject(ref c);
	_mGuiSwatchButtonCtrl = new GuiSwatchButtonCtrlObject(ref c);
	_mGuiTabBookCtrl = new GuiTabBookCtrlObject(ref c);
	_mGuiTableControl = new GuiTableControlObject(ref c);
	_mGuiTabPageCtrl = new GuiTabPageCtrlObject(ref c);
	_mGuiTextCtrl = new GuiTextCtrlObject(ref c);
	_mGuiTextListCtrl = new GuiTextListCtrlObject(ref c);
	_mGuiTheoraCtrl = new GuiTheoraCtrlObject(ref c);
	_mGuiTSCtrl = new GuiTSCtrlObject(ref c);
	_mGuiWindowCtrl = new GuiWindowCtrlObject(ref c);
	_mHTTPObject = new HTTPObjectObject(ref c);
	_mItem = new ItemObject(ref c);
	_mLevelInfo = new LevelInfoObject(ref c);
	_mLightDescription = new LightDescriptionObject(ref c);
	_mLightFlareData = new LightFlareDataObject(ref c);
	_mLightning = new LightningObject(ref c);
	_mMeshRoad = new MeshRoadObject(ref c);
	_mMissionArea = new MissionAreaObject(ref c);
	_mNavMesh = new NavMeshObject(ref c);
	_mNavPath = new NavPathObject(ref c);
	_mNetConnection = new NetConnectionObject(ref c);
	_mNetObject = new NetObjectObject(ref c);
	_mParticleData = new ParticleDataObject(ref c);
	_mParticleEmitterData = new ParticleEmitterDataObject(ref c);
	_mParticleEmitterNode = new ParticleEmitterNodeObject(ref c);
	_mPathCamera = new PathCameraObject(ref c);
	_mPhysicalZone = new PhysicalZoneObject(ref c);
	_mPhysicsForce = new PhysicsForceObject(ref c);
	_mPhysicsShape = new PhysicsShapeObject(ref c);
	_mPlayer = new PlayerObject(ref c);
	_mPortal = new PortalObject(ref c);
	_mPostEffect = new PostEffectObject(ref c);
	_mPrecipitation = new PrecipitationObject(ref c);
	_mProjectile = new ProjectileObject(ref c);
	_mProximityMine = new ProximityMineObject(ref c);
	_mRenderBinManager = new RenderBinManagerObject(ref c);
	_mRenderMeshExample = new RenderMeshExampleObject(ref c);
	_mRenderPassManager = new RenderPassManagerObject(ref c);
	_mRenderPassStateToken = new RenderPassStateTokenObject(ref c);
	_mRigidShape = new RigidShapeObject(ref c);
	_mRiver = new RiverObject(ref c);
	_mScatterSky = new ScatterSkyObject(ref c);
	_mSceneObject = new SceneObjectObject(ref c);
	_mScriptTickObject = new ScriptTickObjectObject(ref c);
	_mSFXController = new SFXControllerObject(ref c);
	_mSFXEmitter = new SFXEmitterObject(ref c);
	_mSFXParameter = new SFXParameterObject(ref c);
	_mSFXProfile = new SFXProfileObject(ref c);
	_mSFXSound = new SFXSoundObject(ref c);
	_mSFXState = new SFXStateObject(ref c);
	_mShaderData = new ShaderDataObject(ref c);
	_mShapeBase = new ShapeBaseObject(ref c);
	_mShapeBaseData = new ShapeBaseDataObject(ref c);
	_mSimpleNetObject = new SimpleNetObjectObject(ref c);
	_mStreamObject = new StreamObjectObject(ref c);
	_mTCPObject = new TCPObjectObject(ref c);
	_mTimeOfDay = new TimeOfDayObject(ref c);
	_mTrigger = new TriggerObject(ref c);
	_mTSAttachable = new TSAttachableObject(ref c);
	_mTSDynamic = new TSDynamicObject(ref c);
	_mTSPathShape = new TSPathShapeObject(ref c);
	_mTSShapeConstructor = new TSShapeConstructorObject(ref c);
	_mTSStatic = new TSStaticObject(ref c);
	_mTurretShape = new TurretShapeObject(ref c);
	_mVolumetricFog = new VolumetricFogObject(ref c);
	_mWalkableShape = new WalkableShapeObject(ref c);
	_mWheeledVehicle = new WheeledVehicleObject(ref c);
	_mWorldEditorSelection = new WorldEditorSelectionObject(ref c);
	_mZipObject = new ZipObjectObject(ref c);
	_mZone = new ZoneObject(ref c);
}
public UtilObject _mUtil;
        /// <summary>
        /// 
        /// </summary>
public UtilObject Util{get { return _mUtil; }}
public AIClientObject _mAIClient;
        /// <summary>
        /// 
        /// </summary>
public AIClientObject AIClient{get { return _mAIClient; }}
public AIConnectionObject _mAIConnection;
        /// <summary>
        /// 
        /// </summary>
public AIConnectionObject AIConnection{get { return _mAIConnection; }}
public AIPlayerObject _mAIPlayer;
        /// <summary>
        /// 
        /// </summary>
public AIPlayerObject AIPlayer{get { return _mAIPlayer; }}
public CompoundUndoActionObject _mCompoundUndoAction;
        /// <summary>
        /// 
        /// </summary>
public CompoundUndoActionObject CompoundUndoAction{get { return _mCompoundUndoAction; }}
public ConsoleLoggerObject _mConsoleLogger;
        /// <summary>
        /// 
        /// </summary>
public ConsoleLoggerObject ConsoleLogger{get { return _mConsoleLogger; }}
public CreatorTreeObject _mCreatorTree;
        /// <summary>
        /// 
        /// </summary>
public CreatorTreeObject CreatorTree{get { return _mCreatorTree; }}
public DbgFileViewObject _mDbgFileView;
        /// <summary>
        /// 
        /// </summary>
public DbgFileViewObject DbgFileView{get { return _mDbgFileView; }}
public EditManagerObject _mEditManager;
        /// <summary>
        /// 
        /// </summary>
public EditManagerObject EditManager{get { return _mEditManager; }}
public EventManagerObject _mEventManager;
        /// <summary>
        /// 
        /// </summary>
public EventManagerObject EventManager{get { return _mEventManager; }}
public FieldBrushObjectObject _mFieldBrushObject;
        /// <summary>
        /// 
        /// </summary>
public FieldBrushObjectObject FieldBrushObject{get { return _mFieldBrushObject; }}
public FileObjectObject _mFileObject;
        /// <summary>
        /// 
        /// </summary>
public FileObjectObject FileObject{get { return _mFileObject; }}
public ForestObject _mForest;
        /// <summary>
        /// 
        /// </summary>
public ForestObject Forest{get { return _mForest; }}
public ForestBrushObject _mForestBrush;
        /// <summary>
        /// 
        /// </summary>
public ForestBrushObject ForestBrush{get { return _mForestBrush; }}
public ForestBrushToolObject _mForestBrushTool;
        /// <summary>
        /// 
        /// </summary>
public ForestBrushToolObject ForestBrushTool{get { return _mForestBrushTool; }}
public ForestEditorCtrlObject _mForestEditorCtrl;
        /// <summary>
        /// 
        /// </summary>
public ForestEditorCtrlObject ForestEditorCtrl{get { return _mForestEditorCtrl; }}
public ForestSelectionToolObject _mForestSelectionTool;
        /// <summary>
        /// 
        /// </summary>
public ForestSelectionToolObject ForestSelectionTool{get { return _mForestSelectionTool; }}
public GuiBitmapCtrlObject _mGuiBitmapCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiBitmapCtrlObject GuiBitmapCtrl{get { return _mGuiBitmapCtrl; }}
public GuiCanvasObject _mGuiCanvas;
        /// <summary>
        /// 
        /// </summary>
public GuiCanvasObject GuiCanvas{get { return _mGuiCanvas; }}
public GuiColorPickerCtrlObject _mGuiColorPickerCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiColorPickerCtrlObject GuiColorPickerCtrl{get { return _mGuiColorPickerCtrl; }}
public GuiControlObject _mGuiControl;
        /// <summary>
        /// 
        /// </summary>
public GuiControlObject GuiControl{get { return _mGuiControl; }}
public GuiControlProfileObject _mGuiControlProfile;
        /// <summary>
        /// 
        /// </summary>
public GuiControlProfileObject GuiControlProfile{get { return _mGuiControlProfile; }}
public GuiConvexEditorCtrlObject _mGuiConvexEditorCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiConvexEditorCtrlObject GuiConvexEditorCtrl{get { return _mGuiConvexEditorCtrl; }}
public GuiDecalEditorCtrlObject _mGuiDecalEditorCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiDecalEditorCtrlObject GuiDecalEditorCtrl{get { return _mGuiDecalEditorCtrl; }}
public GuiEditCtrlObject _mGuiEditCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiEditCtrlObject GuiEditCtrl{get { return _mGuiEditCtrl; }}
public GuiFileTreeCtrlObject _mGuiFileTreeCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiFileTreeCtrlObject GuiFileTreeCtrl{get { return _mGuiFileTreeCtrl; }}
public GuiFilterCtrlObject _mGuiFilterCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiFilterCtrlObject GuiFilterCtrl{get { return _mGuiFilterCtrl; }}
public GuiGradientCtrlObject _mGuiGradientCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiGradientCtrlObject GuiGradientCtrl{get { return _mGuiGradientCtrl; }}
public GuiIdleCamFadeBitmapCtrlObject _mGuiIdleCamFadeBitmapCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiIdleCamFadeBitmapCtrlObject GuiIdleCamFadeBitmapCtrl{get { return _mGuiIdleCamFadeBitmapCtrl; }}
public GuiInspectorObject _mGuiInspector;
        /// <summary>
        /// 
        /// </summary>
public GuiInspectorObject GuiInspector{get { return _mGuiInspector; }}
public GuiInspectorDynamicFieldObject _mGuiInspectorDynamicField;
        /// <summary>
        /// 
        /// </summary>
public GuiInspectorDynamicFieldObject GuiInspectorDynamicField{get { return _mGuiInspectorDynamicField; }}
public GuiInspectorDynamicGroupObject _mGuiInspectorDynamicGroup;
        /// <summary>
        /// 
        /// </summary>
public GuiInspectorDynamicGroupObject GuiInspectorDynamicGroup{get { return _mGuiInspectorDynamicGroup; }}
public GuiInspectorFieldObject _mGuiInspectorField;
        /// <summary>
        /// 
        /// </summary>
public GuiInspectorFieldObject GuiInspectorField{get { return _mGuiInspectorField; }}
public GuiMaterialCtrlObject _mGuiMaterialCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiMaterialCtrlObject GuiMaterialCtrl{get { return _mGuiMaterialCtrl; }}
public GuiMeshRoadEditorCtrlObject _mGuiMeshRoadEditorCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiMeshRoadEditorCtrlObject GuiMeshRoadEditorCtrl{get { return _mGuiMeshRoadEditorCtrl; }}
public GuiMissionAreaEditorCtrlObject _mGuiMissionAreaEditorCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiMissionAreaEditorCtrlObject GuiMissionAreaEditorCtrl{get { return _mGuiMissionAreaEditorCtrl; }}
public GuiNavEditorCtrlObject _mGuiNavEditorCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiNavEditorCtrlObject GuiNavEditorCtrl{get { return _mGuiNavEditorCtrl; }}
public GuiParticleGraphCtrlObject _mGuiParticleGraphCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiParticleGraphCtrlObject GuiParticleGraphCtrl{get { return _mGuiParticleGraphCtrl; }}
public GuiPopUpMenuCtrlObject _mGuiPopUpMenuCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiPopUpMenuCtrlObject GuiPopUpMenuCtrl{get { return _mGuiPopUpMenuCtrl; }}
public GuiPopUpMenuCtrlExObject _mGuiPopUpMenuCtrlEx;
        /// <summary>
        /// 
        /// </summary>
public GuiPopUpMenuCtrlExObject GuiPopUpMenuCtrlEx{get { return _mGuiPopUpMenuCtrlEx; }}
public GuiRiverEditorCtrlObject _mGuiRiverEditorCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiRiverEditorCtrlObject GuiRiverEditorCtrl{get { return _mGuiRiverEditorCtrl; }}
public GuiRoadEditorCtrlObject _mGuiRoadEditorCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiRoadEditorCtrlObject GuiRoadEditorCtrl{get { return _mGuiRoadEditorCtrl; }}
public GuiTerrPreviewCtrlObject _mGuiTerrPreviewCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiTerrPreviewCtrlObject GuiTerrPreviewCtrl{get { return _mGuiTerrPreviewCtrl; }}
public GuiTextEditCtrlObject _mGuiTextEditCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiTextEditCtrlObject GuiTextEditCtrl{get { return _mGuiTextEditCtrl; }}
public GuiTickCtrlObject _mGuiTickCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiTickCtrlObject GuiTickCtrl{get { return _mGuiTickCtrl; }}
public GuiToolboxButtonCtrlObject _mGuiToolboxButtonCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiToolboxButtonCtrlObject GuiToolboxButtonCtrl{get { return _mGuiToolboxButtonCtrl; }}
public GuiTreeViewCtrlObject _mGuiTreeViewCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiTreeViewCtrlObject GuiTreeViewCtrl{get { return _mGuiTreeViewCtrl; }}
public GuiVariableInspectorObject _mGuiVariableInspector;
        /// <summary>
        /// 
        /// </summary>
public GuiVariableInspectorObject GuiVariableInspector{get { return _mGuiVariableInspector; }}
public LangTableObject _mLangTable;
        /// <summary>
        /// 
        /// </summary>
public LangTableObject LangTable{get { return _mLangTable; }}
public LightBaseObject _mLightBase;
        /// <summary>
        /// 
        /// </summary>
public LightBaseObject LightBase{get { return _mLightBase; }}
public MaterialObject _mMaterial;
        /// <summary>
        /// 
        /// </summary>
public MaterialObject Material{get { return _mMaterial; }}
public MECreateUndoActionObject _mMECreateUndoAction;
        /// <summary>
        /// 
        /// </summary>
public MECreateUndoActionObject MECreateUndoAction{get { return _mMECreateUndoAction; }}
public MEDeleteUndoActionObject _mMEDeleteUndoAction;
        /// <summary>
        /// 
        /// </summary>
public MEDeleteUndoActionObject MEDeleteUndoAction{get { return _mMEDeleteUndoAction; }}
public MenuBarObject _mMenuBar;
        /// <summary>
        /// 
        /// </summary>
public MenuBarObject MenuBar{get { return _mMenuBar; }}
public MessageObject _mMessage;
        /// <summary>
        /// 
        /// </summary>
public MessageObject Message{get { return _mMessage; }}
public MessageVectorObject _mMessageVector;
        /// <summary>
        /// 
        /// </summary>
public MessageVectorObject MessageVector{get { return _mMessageVector; }}
public PersistenceManagerObject _mPersistenceManager;
        /// <summary>
        /// 
        /// </summary>
public PersistenceManagerObject PersistenceManager{get { return _mPersistenceManager; }}
public PhysicsDebrisDataObject _mPhysicsDebrisData;
        /// <summary>
        /// 
        /// </summary>
public PhysicsDebrisDataObject PhysicsDebrisData{get { return _mPhysicsDebrisData; }}
public PopupMenuObject _mPopupMenu;
        /// <summary>
        /// 
        /// </summary>
public PopupMenuObject PopupMenu{get { return _mPopupMenu; }}
public ReadXMLObject _mReadXML;
        /// <summary>
        /// 
        /// </summary>
public ReadXMLObject ReadXML{get { return _mReadXML; }}
public SettingsObject _mSettings;
        /// <summary>
        /// 
        /// </summary>
public SettingsObject Settings{get { return _mSettings; }}
public SFXSourceObject _mSFXSource;
        /// <summary>
        /// 
        /// </summary>
public SFXSourceObject SFXSource{get { return _mSFXSource; }}
public SimComponentObject _mSimComponent;
        /// <summary>
        /// 
        /// </summary>
public SimComponentObject SimComponent{get { return _mSimComponent; }}
public SimDataBlockObject _mSimDataBlock;
        /// <summary>
        /// 
        /// </summary>
public SimDataBlockObject SimDataBlock{get { return _mSimDataBlock; }}
public SimObjectObject _mSimObject;
        /// <summary>
        /// 
        /// </summary>
public SimObjectObject SimObject{get { return _mSimObject; }}
public SimPersistSetObject _mSimPersistSet;
        /// <summary>
        /// 
        /// </summary>
public SimPersistSetObject SimPersistSet{get { return _mSimPersistSet; }}
public SimResponseCurveObject _mSimResponseCurve;
        /// <summary>
        /// 
        /// </summary>
public SimResponseCurveObject SimResponseCurve{get { return _mSimResponseCurve; }}
public SimSetObject _mSimSet;
        /// <summary>
        /// 
        /// </summary>
public SimSetObject SimSet{get { return _mSimSet; }}
public SimXMLDocumentObject _mSimXMLDocument;
        /// <summary>
        /// 
        /// </summary>
public SimXMLDocumentObject SimXMLDocument{get { return _mSimXMLDocument; }}
public SkyBoxObject _mSkyBox;
        /// <summary>
        /// 
        /// </summary>
public SkyBoxObject SkyBox{get { return _mSkyBox; }}
public SpawnSphereObject _mSpawnSphere;
        /// <summary>
        /// 
        /// </summary>
public SpawnSphereObject SpawnSphere{get { return _mSpawnSphere; }}
public StaticShapeObject _mStaticShape;
        /// <summary>
        /// 
        /// </summary>
public StaticShapeObject StaticShape{get { return _mStaticShape; }}
public SunObject _mSun;
        /// <summary>
        /// 
        /// </summary>
public SunObject Sun{get { return _mSun; }}
public TerrainBlockObject _mTerrainBlock;
        /// <summary>
        /// 
        /// </summary>
public TerrainBlockObject TerrainBlock{get { return _mTerrainBlock; }}
public TerrainEditorObject _mTerrainEditor;
        /// <summary>
        /// 
        /// </summary>
public TerrainEditorObject TerrainEditor{get { return _mTerrainEditor; }}
public TerrainSmoothActionObject _mTerrainSmoothAction;
        /// <summary>
        /// 
        /// </summary>
public TerrainSmoothActionObject TerrainSmoothAction{get { return _mTerrainSmoothAction; }}
public TerrainSolderEdgesActionObject _mTerrainSolderEdgesAction;
        /// <summary>
        /// 
        /// </summary>
public TerrainSolderEdgesActionObject TerrainSolderEdgesAction{get { return _mTerrainSolderEdgesAction; }}
public TheoraTextureObjectObject _mTheoraTextureObject;
        /// <summary>
        /// 
        /// </summary>
public TheoraTextureObjectObject TheoraTextureObject{get { return _mTheoraTextureObject; }}
public UndoActionObject _mUndoAction;
        /// <summary>
        /// 
        /// </summary>
public UndoActionObject UndoAction{get { return _mUndoAction; }}
public UndoManagerObject _mUndoManager;
        /// <summary>
        /// 
        /// </summary>
public UndoManagerObject UndoManager{get { return _mUndoManager; }}
public WorldEditorObject _mWorldEditor;
        /// <summary>
        /// 
        /// </summary>
public WorldEditorObject WorldEditor{get { return _mWorldEditor; }}
public ActionMapObject _mActionMap;
        /// <summary>
        /// 
        /// </summary>
public ActionMapObject ActionMap{get { return _mActionMap; }}
public AITurretShapeObject _mAITurretShape;
        /// <summary>
        /// 
        /// </summary>
public AITurretShapeObject AITurretShape{get { return _mAITurretShape; }}
public ArrayObjectObject _mArrayObject;
        /// <summary>
        /// 
        /// </summary>
public ArrayObjectObject ArrayObject{get { return _mArrayObject; }}
public CameraObject _mCamera;
        /// <summary>
        /// 
        /// </summary>
public CameraObject Camera{get { return _mCamera; }}
public CloudLayerObject _mCloudLayer;
        /// <summary>
        /// 
        /// </summary>
public CloudLayerObject CloudLayer{get { return _mCloudLayer; }}
public CoverPointObject _mCoverPoint;
        /// <summary>
        /// 
        /// </summary>
public CoverPointObject CoverPoint{get { return _mCoverPoint; }}
public CubemapDataObject _mCubemapData;
        /// <summary>
        /// 
        /// </summary>
public CubemapDataObject CubemapData{get { return _mCubemapData; }}
public DebrisObject _mDebris;
        /// <summary>
        /// 
        /// </summary>
public DebrisObject Debris{get { return _mDebris; }}
public DebugDrawerObject _mDebugDrawer;
        /// <summary>
        /// 
        /// </summary>
public DebugDrawerObject DebugDrawer{get { return _mDebugDrawer; }}
public DecalDataObject _mDecalData;
        /// <summary>
        /// 
        /// </summary>
public DecalDataObject DecalData{get { return _mDecalData; }}
public DecalRoadObject _mDecalRoad;
        /// <summary>
        /// 
        /// </summary>
public DecalRoadObject DecalRoad{get { return _mDecalRoad; }}
public DynamicConsoleMethodComponentObject _mDynamicConsoleMethodComponent;
        /// <summary>
        /// 
        /// </summary>
public DynamicConsoleMethodComponentObject DynamicConsoleMethodComponent{get { return _mDynamicConsoleMethodComponent; }}
public EditTSCtrlObject _mEditTSCtrl;
        /// <summary>
        /// 
        /// </summary>
public EditTSCtrlObject EditTSCtrl{get { return _mEditTSCtrl; }}
public FileDialogObject _mFileDialog;
        /// <summary>
        /// 
        /// </summary>
public FileDialogObject FileDialog{get { return _mFileDialog; }}
public FileStreamObjectObject _mFileStreamObject;
        /// <summary>
        /// 
        /// </summary>
public FileStreamObjectObject FileStreamObject{get { return _mFileStreamObject; }}
public FlyingVehicleObject _mFlyingVehicle;
        /// <summary>
        /// 
        /// </summary>
public FlyingVehicleObject FlyingVehicle{get { return _mFlyingVehicle; }}
public ForestWindEmitterObject _mForestWindEmitter;
        /// <summary>
        /// 
        /// </summary>
public ForestWindEmitterObject ForestWindEmitter{get { return _mForestWindEmitter; }}
public GameBaseObject _mGameBase;
        /// <summary>
        /// 
        /// </summary>
public GameBaseObject GameBase{get { return _mGameBase; }}
public GameConnectionObject _mGameConnection;
        /// <summary>
        /// 
        /// </summary>
public GameConnectionObject GameConnection{get { return _mGameConnection; }}
public GroundPlaneObject _mGroundPlane;
        /// <summary>
        /// 
        /// </summary>
public GroundPlaneObject GroundPlane{get { return _mGroundPlane; }}
public GuiAutoCompleteCtrlObject _mGuiAutoCompleteCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiAutoCompleteCtrlObject GuiAutoCompleteCtrl{get { return _mGuiAutoCompleteCtrl; }}
public GuiAutoScrollCtrlObject _mGuiAutoScrollCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiAutoScrollCtrlObject GuiAutoScrollCtrl{get { return _mGuiAutoScrollCtrl; }}
public GuiBitmapButtonCtrlObject _mGuiBitmapButtonCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiBitmapButtonCtrlObject GuiBitmapButtonCtrl{get { return _mGuiBitmapButtonCtrl; }}
public GuiButtonBaseCtrlObject _mGuiButtonBaseCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiButtonBaseCtrlObject GuiButtonBaseCtrl{get { return _mGuiButtonBaseCtrl; }}
public GuiCheckBoxCtrlObject _mGuiCheckBoxCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiCheckBoxCtrlObject GuiCheckBoxCtrl{get { return _mGuiCheckBoxCtrl; }}
public GuiChunkedBitmapCtrlObject _mGuiChunkedBitmapCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiChunkedBitmapCtrlObject GuiChunkedBitmapCtrl{get { return _mGuiChunkedBitmapCtrl; }}
public GuiClockHudObject _mGuiClockHud;
        /// <summary>
        /// 
        /// </summary>
public GuiClockHudObject GuiClockHud{get { return _mGuiClockHud; }}
public GuiDirectoryFileListCtrlObject _mGuiDirectoryFileListCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiDirectoryFileListCtrlObject GuiDirectoryFileListCtrl{get { return _mGuiDirectoryFileListCtrl; }}
public GuiDragAndDropControlObject _mGuiDragAndDropControl;
        /// <summary>
        /// 
        /// </summary>
public GuiDragAndDropControlObject GuiDragAndDropControl{get { return _mGuiDragAndDropControl; }}
public GuiDynamicCtrlArrayControlObject _mGuiDynamicCtrlArrayControl;
        /// <summary>
        /// 
        /// </summary>
public GuiDynamicCtrlArrayControlObject GuiDynamicCtrlArrayControl{get { return _mGuiDynamicCtrlArrayControl; }}
public GuiFormCtrlObject _mGuiFormCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiFormCtrlObject GuiFormCtrl{get { return _mGuiFormCtrl; }}
public GuiFrameSetCtrlObject _mGuiFrameSetCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiFrameSetCtrlObject GuiFrameSetCtrl{get { return _mGuiFrameSetCtrl; }}
public GuiGameListMenuCtrlObject _mGuiGameListMenuCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiGameListMenuCtrlObject GuiGameListMenuCtrl{get { return _mGuiGameListMenuCtrl; }}
public GuiGameListOptionsCtrlObject _mGuiGameListOptionsCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiGameListOptionsCtrlObject GuiGameListOptionsCtrl{get { return _mGuiGameListOptionsCtrl; }}
public GuiGraphCtrlObject _mGuiGraphCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiGraphCtrlObject GuiGraphCtrl{get { return _mGuiGraphCtrl; }}
public GuiIconButtonCtrlObject _mGuiIconButtonCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiIconButtonCtrlObject GuiIconButtonCtrl{get { return _mGuiIconButtonCtrl; }}
public GuiImageListObject _mGuiImageList;
        /// <summary>
        /// 
        /// </summary>
public GuiImageListObject GuiImageList{get { return _mGuiImageList; }}
public GuiInspectorTypeBitMask32Object _mGuiInspectorTypeBitMask32;
        /// <summary>
        /// 
        /// </summary>
public GuiInspectorTypeBitMask32Object GuiInspectorTypeBitMask32{get { return _mGuiInspectorTypeBitMask32; }}
public GuiInspectorTypeFileNameObject _mGuiInspectorTypeFileName;
        /// <summary>
        /// 
        /// </summary>
public GuiInspectorTypeFileNameObject GuiInspectorTypeFileName{get { return _mGuiInspectorTypeFileName; }}
public GuiListBoxCtrlObject _mGuiListBoxCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiListBoxCtrlObject GuiListBoxCtrl{get { return _mGuiListBoxCtrl; }}
public GuiMaterialPreviewObject _mGuiMaterialPreview;
        /// <summary>
        /// 
        /// </summary>
public GuiMaterialPreviewObject GuiMaterialPreview{get { return _mGuiMaterialPreview; }}
public GuiMenuBarObject _mGuiMenuBar;
        /// <summary>
        /// 
        /// </summary>
public GuiMenuBarObject GuiMenuBar{get { return _mGuiMenuBar; }}
public GuiMessageVectorCtrlObject _mGuiMessageVectorCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiMessageVectorCtrlObject GuiMessageVectorCtrl{get { return _mGuiMessageVectorCtrl; }}
public GuiMissionAreaCtrlObject _mGuiMissionAreaCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiMissionAreaCtrlObject GuiMissionAreaCtrl{get { return _mGuiMissionAreaCtrl; }}
public GuiMLTextCtrlObject _mGuiMLTextCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiMLTextCtrlObject GuiMLTextCtrl{get { return _mGuiMLTextCtrl; }}
public GuiObjectViewObject _mGuiObjectView;
        /// <summary>
        /// 
        /// </summary>
public GuiObjectViewObject GuiObjectView{get { return _mGuiObjectView; }}
public GuiPaneControlObject _mGuiPaneControl;
        /// <summary>
        /// 
        /// </summary>
public GuiPaneControlObject GuiPaneControl{get { return _mGuiPaneControl; }}
public GuiProgressBitmapCtrlObject _mGuiProgressBitmapCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiProgressBitmapCtrlObject GuiProgressBitmapCtrl{get { return _mGuiProgressBitmapCtrl; }}
public GuiRolloutCtrlObject _mGuiRolloutCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiRolloutCtrlObject GuiRolloutCtrl{get { return _mGuiRolloutCtrl; }}
public GuiScrollCtrlObject _mGuiScrollCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiScrollCtrlObject GuiScrollCtrl{get { return _mGuiScrollCtrl; }}
public GuiShapeEdPreviewObject _mGuiShapeEdPreview;
        /// <summary>
        /// 
        /// </summary>
public GuiShapeEdPreviewObject GuiShapeEdPreview{get { return _mGuiShapeEdPreview; }}
public GuiSliderCtrlObject _mGuiSliderCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiSliderCtrlObject GuiSliderCtrl{get { return _mGuiSliderCtrl; }}
public GuiStackControlObject _mGuiStackControl;
        /// <summary>
        /// 
        /// </summary>
public GuiStackControlObject GuiStackControl{get { return _mGuiStackControl; }}
public GuiSwatchButtonCtrlObject _mGuiSwatchButtonCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiSwatchButtonCtrlObject GuiSwatchButtonCtrl{get { return _mGuiSwatchButtonCtrl; }}
public GuiTabBookCtrlObject _mGuiTabBookCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiTabBookCtrlObject GuiTabBookCtrl{get { return _mGuiTabBookCtrl; }}
public GuiTableControlObject _mGuiTableControl;
        /// <summary>
        /// 
        /// </summary>
public GuiTableControlObject GuiTableControl{get { return _mGuiTableControl; }}
public GuiTabPageCtrlObject _mGuiTabPageCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiTabPageCtrlObject GuiTabPageCtrl{get { return _mGuiTabPageCtrl; }}
public GuiTextCtrlObject _mGuiTextCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiTextCtrlObject GuiTextCtrl{get { return _mGuiTextCtrl; }}
public GuiTextListCtrlObject _mGuiTextListCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiTextListCtrlObject GuiTextListCtrl{get { return _mGuiTextListCtrl; }}
public GuiTheoraCtrlObject _mGuiTheoraCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiTheoraCtrlObject GuiTheoraCtrl{get { return _mGuiTheoraCtrl; }}
public GuiTSCtrlObject _mGuiTSCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiTSCtrlObject GuiTSCtrl{get { return _mGuiTSCtrl; }}
public GuiWindowCtrlObject _mGuiWindowCtrl;
        /// <summary>
        /// 
        /// </summary>
public GuiWindowCtrlObject GuiWindowCtrl{get { return _mGuiWindowCtrl; }}
public HTTPObjectObject _mHTTPObject;
        /// <summary>
        /// 
        /// </summary>
public HTTPObjectObject HTTPObject{get { return _mHTTPObject; }}
public ItemObject _mItem;
        /// <summary>
        /// 
        /// </summary>
public ItemObject Item{get { return _mItem; }}
public LevelInfoObject _mLevelInfo;
        /// <summary>
        /// 
        /// </summary>
public LevelInfoObject LevelInfo{get { return _mLevelInfo; }}
public LightDescriptionObject _mLightDescription;
        /// <summary>
        /// 
        /// </summary>
public LightDescriptionObject LightDescription{get { return _mLightDescription; }}
public LightFlareDataObject _mLightFlareData;
        /// <summary>
        /// 
        /// </summary>
public LightFlareDataObject LightFlareData{get { return _mLightFlareData; }}
public LightningObject _mLightning;
        /// <summary>
        /// 
        /// </summary>
public LightningObject Lightning{get { return _mLightning; }}
public MeshRoadObject _mMeshRoad;
        /// <summary>
        /// 
        /// </summary>
public MeshRoadObject MeshRoad{get { return _mMeshRoad; }}
public MissionAreaObject _mMissionArea;
        /// <summary>
        /// 
        /// </summary>
public MissionAreaObject MissionArea{get { return _mMissionArea; }}
public NavMeshObject _mNavMesh;
        /// <summary>
        /// 
        /// </summary>
public NavMeshObject NavMesh{get { return _mNavMesh; }}
public NavPathObject _mNavPath;
        /// <summary>
        /// 
        /// </summary>
public NavPathObject NavPath{get { return _mNavPath; }}
public NetConnectionObject _mNetConnection;
        /// <summary>
        /// 
        /// </summary>
public NetConnectionObject NetConnection{get { return _mNetConnection; }}
public NetObjectObject _mNetObject;
        /// <summary>
        /// 
        /// </summary>
public NetObjectObject NetObject{get { return _mNetObject; }}
public ParticleDataObject _mParticleData;
        /// <summary>
        /// 
        /// </summary>
public ParticleDataObject ParticleData{get { return _mParticleData; }}
public ParticleEmitterDataObject _mParticleEmitterData;
        /// <summary>
        /// 
        /// </summary>
public ParticleEmitterDataObject ParticleEmitterData{get { return _mParticleEmitterData; }}
public ParticleEmitterNodeObject _mParticleEmitterNode;
        /// <summary>
        /// 
        /// </summary>
public ParticleEmitterNodeObject ParticleEmitterNode{get { return _mParticleEmitterNode; }}
public PathCameraObject _mPathCamera;
        /// <summary>
        /// 
        /// </summary>
public PathCameraObject PathCamera{get { return _mPathCamera; }}
public PhysicalZoneObject _mPhysicalZone;
        /// <summary>
        /// 
        /// </summary>
public PhysicalZoneObject PhysicalZone{get { return _mPhysicalZone; }}
public PhysicsForceObject _mPhysicsForce;
        /// <summary>
        /// 
        /// </summary>
public PhysicsForceObject PhysicsForce{get { return _mPhysicsForce; }}
public PhysicsShapeObject _mPhysicsShape;
        /// <summary>
        /// 
        /// </summary>
public PhysicsShapeObject PhysicsShape{get { return _mPhysicsShape; }}
public PlayerObject _mPlayer;
        /// <summary>
        /// 
        /// </summary>
public PlayerObject Player{get { return _mPlayer; }}
public PortalObject _mPortal;
        /// <summary>
        /// 
        /// </summary>
public PortalObject Portal{get { return _mPortal; }}
public PostEffectObject _mPostEffect;
        /// <summary>
        /// 
        /// </summary>
public PostEffectObject PostEffect{get { return _mPostEffect; }}
public PrecipitationObject _mPrecipitation;
        /// <summary>
        /// 
        /// </summary>
public PrecipitationObject Precipitation{get { return _mPrecipitation; }}
public ProjectileObject _mProjectile;
        /// <summary>
        /// 
        /// </summary>
public ProjectileObject Projectile{get { return _mProjectile; }}
public ProximityMineObject _mProximityMine;
        /// <summary>
        /// 
        /// </summary>
public ProximityMineObject ProximityMine{get { return _mProximityMine; }}
public RenderBinManagerObject _mRenderBinManager;
        /// <summary>
        /// 
        /// </summary>
public RenderBinManagerObject RenderBinManager{get { return _mRenderBinManager; }}
public RenderMeshExampleObject _mRenderMeshExample;
        /// <summary>
        /// 
        /// </summary>
public RenderMeshExampleObject RenderMeshExample{get { return _mRenderMeshExample; }}
public RenderPassManagerObject _mRenderPassManager;
        /// <summary>
        /// 
        /// </summary>
public RenderPassManagerObject RenderPassManager{get { return _mRenderPassManager; }}
public RenderPassStateTokenObject _mRenderPassStateToken;
        /// <summary>
        /// 
        /// </summary>
public RenderPassStateTokenObject RenderPassStateToken{get { return _mRenderPassStateToken; }}
public RigidShapeObject _mRigidShape;
        /// <summary>
        /// 
        /// </summary>
public RigidShapeObject RigidShape{get { return _mRigidShape; }}
public RiverObject _mRiver;
        /// <summary>
        /// 
        /// </summary>
public RiverObject River{get { return _mRiver; }}
public ScatterSkyObject _mScatterSky;
        /// <summary>
        /// 
        /// </summary>
public ScatterSkyObject ScatterSky{get { return _mScatterSky; }}
public SceneObjectObject _mSceneObject;
        /// <summary>
        /// 
        /// </summary>
public SceneObjectObject SceneObject{get { return _mSceneObject; }}
public ScriptTickObjectObject _mScriptTickObject;
        /// <summary>
        /// 
        /// </summary>
public ScriptTickObjectObject ScriptTickObject{get { return _mScriptTickObject; }}
public SFXControllerObject _mSFXController;
        /// <summary>
        /// 
        /// </summary>
public SFXControllerObject SFXController{get { return _mSFXController; }}
public SFXEmitterObject _mSFXEmitter;
        /// <summary>
        /// 
        /// </summary>
public SFXEmitterObject SFXEmitter{get { return _mSFXEmitter; }}
public SFXParameterObject _mSFXParameter;
        /// <summary>
        /// 
        /// </summary>
public SFXParameterObject SFXParameter{get { return _mSFXParameter; }}
public SFXProfileObject _mSFXProfile;
        /// <summary>
        /// 
        /// </summary>
public SFXProfileObject SFXProfile{get { return _mSFXProfile; }}
public SFXSoundObject _mSFXSound;
        /// <summary>
        /// 
        /// </summary>
public SFXSoundObject SFXSound{get { return _mSFXSound; }}
public SFXStateObject _mSFXState;
        /// <summary>
        /// 
        /// </summary>
public SFXStateObject SFXState{get { return _mSFXState; }}
public ShaderDataObject _mShaderData;
        /// <summary>
        /// 
        /// </summary>
public ShaderDataObject ShaderData{get { return _mShaderData; }}
public ShapeBaseObject _mShapeBase;
        /// <summary>
        /// 
        /// </summary>
public ShapeBaseObject ShapeBase{get { return _mShapeBase; }}
public ShapeBaseDataObject _mShapeBaseData;
        /// <summary>
        /// 
        /// </summary>
public ShapeBaseDataObject ShapeBaseData{get { return _mShapeBaseData; }}
public SimpleNetObjectObject _mSimpleNetObject;
        /// <summary>
        /// 
        /// </summary>
public SimpleNetObjectObject SimpleNetObject{get { return _mSimpleNetObject; }}
public StreamObjectObject _mStreamObject;
        /// <summary>
        /// 
        /// </summary>
public StreamObjectObject StreamObject{get { return _mStreamObject; }}
public TCPObjectObject _mTCPObject;
        /// <summary>
        /// 
        /// </summary>
public TCPObjectObject TCPObject{get { return _mTCPObject; }}
public TimeOfDayObject _mTimeOfDay;
        /// <summary>
        /// 
        /// </summary>
public TimeOfDayObject TimeOfDay{get { return _mTimeOfDay; }}
public TriggerObject _mTrigger;
        /// <summary>
        /// 
        /// </summary>
public TriggerObject Trigger{get { return _mTrigger; }}
public TSAttachableObject _mTSAttachable;
        /// <summary>
        /// 
        /// </summary>
public TSAttachableObject TSAttachable{get { return _mTSAttachable; }}
public TSDynamicObject _mTSDynamic;
        /// <summary>
        /// 
        /// </summary>
public TSDynamicObject TSDynamic{get { return _mTSDynamic; }}
public TSPathShapeObject _mTSPathShape;
        /// <summary>
        /// 
        /// </summary>
public TSPathShapeObject TSPathShape{get { return _mTSPathShape; }}
public TSShapeConstructorObject _mTSShapeConstructor;
        /// <summary>
        /// 
        /// </summary>
public TSShapeConstructorObject TSShapeConstructor{get { return _mTSShapeConstructor; }}
public TSStaticObject _mTSStatic;
        /// <summary>
        /// 
        /// </summary>
public TSStaticObject TSStatic{get { return _mTSStatic; }}
public TurretShapeObject _mTurretShape;
        /// <summary>
        /// 
        /// </summary>
public TurretShapeObject TurretShape{get { return _mTurretShape; }}
public VolumetricFogObject _mVolumetricFog;
        /// <summary>
        /// 
        /// </summary>
public VolumetricFogObject VolumetricFog{get { return _mVolumetricFog; }}
public WalkableShapeObject _mWalkableShape;
        /// <summary>
        /// 
        /// </summary>
public WalkableShapeObject WalkableShape{get { return _mWalkableShape; }}
public WheeledVehicleObject _mWheeledVehicle;
        /// <summary>
        /// 
        /// </summary>
public WheeledVehicleObject WheeledVehicle{get { return _mWheeledVehicle; }}
public WorldEditorSelectionObject _mWorldEditorSelection;
        /// <summary>
        /// 
        /// </summary>
public WorldEditorSelectionObject WorldEditorSelection{get { return _mWorldEditorSelection; }}
public ZipObjectObject _mZipObject;
        /// <summary>
        /// 
        /// </summary>
public ZipObjectObject ZipObject{get { return _mZipObject; }}
public ZoneObject _mZone;
        /// <summary>
        /// 
        /// </summary>
public ZoneObject Zone{get { return _mZone; }}
   /// <summary>
        /// 
        /// </summary>
 public class UtilObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public UtilObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// (aiConnect, S32 , 2, 20, (...)   @brief Creates a new AIConnection, and passes arguments to its onConnect script callback.   @returns The newly created AIConnection   @see GameConnection for parameter information   @ingroup AI)
/// </summary>
public  int _aiConnect(string a1, string a2= "", string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){


return m_ts.fn__aiConnect(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}
/// <summary>
/// ( buildTaggedString, const char*, 2, 11, (string format, ...)   @brief Build a string using the specified tagged string format.   This function takes an already tagged string (passed in as a tagged string ID) and one    or more additional strings.  If the tagged string contains argument tags that range from    %%1 through %%9, then each additional string will be substituted into the tagged string.     The final (non-tagged) combined string will be returned.  The maximum length of the tagged    string plus any inserted additional strings is 511 characters.   @param format A tagged string ID that contains zero or more argument tags, in the form of    %%1 through %%9.   @param ... A variable number of arguments that are insterted into the tagged string    based on the argument tags within the format string.   @returns An ordinary string that is a combination of the original tagged string with any additional    strings passed in inserted in place of each argument tag.   @tsexample      // Create a tagged string with argument tags      %taggedStringID = addTaggedString(\"Welcome %1 to the game!\");      // Some point later, combine the tagged string with some other string      %string = buildTaggedString(%taggedStringID, %playerName);      echo(%string);	@endtsexample   @see \\ref syntaxDataTypes under Tagged %Strings   @see addTaggedString()   @see getTaggedString()   @ingroup Networking)
/// </summary>
public  string _buildTaggedString(string a1, string a2= "", string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= ""){


return m_ts.fn__buildTaggedString(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10);
}
/// <summary>
/// ( call, const char *, 2, 0, ( string functionName, string args... )    Apply the given arguments to the specified global function and return the result of the call.   @param functionName The name of the function to call.  This function must be in the global namespace, i.e.       you cannot call a function in a namespace through #call.  Use eval() for that.   @return The result of the function call.   @tsexample      function myFunction( %arg )      {        return ( %arg SPC \"World!\" );      }            echo( call( \"myFunction\", \"Hello\" ) ); // Prints \"Hello World!\" to the console.   @endtsexample   @ingroup Scripting )
/// </summary>
public  string _call(string a1, string a2= "", string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){


return m_ts.fn__call(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}
/// <summary>
/// ( commandToClient, void, 3, 22, (NetConnection client, string func, ...)   @brief Send a command from the server to the client   @param client The numeric ID of a client GameConnection   @param func Name of the client function being called   @param ... Various parameters being passed to client command   @tsexample      // Set up the client command.  Needs to be executed on the client, such as      // within scripts/client/client.cs      // Update the Ammo Counter with current ammo, if not any then hide the counter.      function clientCmdSetAmmoAmountHud(%amount)      {         if (!%amount)      	  AmmoAmount.setVisible(false);         else         {      	  AmmoAmount.setVisible(true);      	  AmmoAmount.setText(\"Ammo: \"@%amount);         }      }      // Call it from a server function.  Needs to be executed on the server,       //such as within scripts/server/game.cs      function GameConnection::setAmmoAmountHud(%client, %amount)      {         commandToClient(%client, 'SetAmmoAmountHud', %amount);      }   @endtsexample   @ingroup Networking)
/// </summary>
public  void _commandToClient(string a1, string a2, string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= "", string a20= "", string a21= ""){


m_ts.fn__commandToClient(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21);
}
/// <summary>
/// ( commandToServer, void, 2, 21, (string func, ...)	@brief Send a command to the server.   @param func Name of the server command being called   @param ... Various parameters being passed to server command   @tsexample      // Create a standard function.  Needs to be executed on the client, such       // as within scripts/client/default.bind.cs      function toggleCamera(%val)      {      	// If key was down, call a server command named 'ToggleCamera'      	if (%val)      		commandToServer('ToggleCamera');      }      // Server command being called from above.  Needs to be executed on the       // server, such as within scripts/server/commands.cs      function serverCmdToggleCamera(%client)      {         if (%client.getControlObject() == %client.player)         {      	  %client.camera.setVelocity(\"0 0 0\");      	  %control = %client.camera;         }         else         {      	  %client.player.setVelocity(\"0 0 0\");      	  %control = %client.player;        }         %client.setControlObject(%control);         clientCmdSyncEditorGui();      }   @endtsexample   @ingroup Networking)
/// </summary>
public  void _commandToServer(string a1, string a2= "", string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= "", string a20= ""){


m_ts.fn__commandToServer(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20);
}
/// <summary>
/// ( echo, void, 2, 0, ( string message... )    @brief Logs a message to the console.   Concatenates all given arguments to a single string and prints the string to the console.    A newline is added automatically after the text.   @param message Any number of string arguments.   @ingroup Logging )
/// </summary>
public  void _echo(string a1, string a2= "", string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){


m_ts.fn__echo(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}
/// <summary>
/// ( error, void, 2, 0, ( string message... )    @brief Logs an error message to the console.   Concatenates all given arguments to a single string and prints the string to the console as an error    message (in the in-game console, these will show up using a red font by default).    A newline is added automatically after the text.   @param message Any number of string arguments.   @ingroup Logging )
/// </summary>
public  void _error(string a1, string a2= "", string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){


m_ts.fn__error(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}
/// <summary>
/// ( execPrefs, bool, 2, 4, ( string relativeFileName, bool noCalls=false, bool journalScript=false )				@brief Manually execute a special script file that contains game or editor preferences				@param relativeFileName Name and path to file from project folder				@param noCalls Deprecated				@param journalScript Deprecated				@return True if script was successfully executed				@note Appears to be useless in Torque 3D, should be deprecated				@ingroup Scripting)
/// </summary>
public  bool _execPrefs(string a1, string a2= "", string a3= ""){


return m_ts.fn__execPrefs(a1, a2, a3);
}
/// <summary>
/// (expandFilename, const char*, 2, 2, (string filename)				@brief Grabs the full path of a specified file				@param filename Name of the local file to locate				@return String containing the full filepath on disk				@ingroup FileSystem)
/// </summary>
public  string _expandFilename(string a1){


return m_ts.fn__expandFilename(a1);
}
/// <summary>
/// (expandOldFilename, const char*, 2, 2, (string filename)				@brief Retrofits a filepath that uses old Torque style				@return String containing filepath with new formatting				@ingroup FileSystem)
/// </summary>
public  string _expandOldFilename(string a1){


return m_ts.fn__expandOldFilename(a1);
}
/// <summary>
/// ( mathInit, void, 1, 10, ( ... )                @brief Install the math library with specified extensions.                Possible parameters are:                    - 'DETECT' Autodetect math lib settings.                    - 'C' Enable the C math routines. C routines are always enabled.                    - 'FPU' Enable floating point unit routines.                    - 'MMX' Enable MMX math routines.                    - '3DNOW' Enable 3dNow! math routines.                    - 'SSE' Enable SSE math routines.				@ingroup Math)
/// </summary>
public  void _mathInit(string a1= "", string a2= "", string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= ""){


m_ts.fn__mathInit(a1, a2, a3, a4, a5, a6, a7, a8, a9);
}
/// <summary>
/// (resourceDump, void, 1, 1, ()				@brief List the currently managed resources				Currently used by editors only, internal				@ingroup Editors				@internal)
/// </summary>
public  void _resourceDump(){


m_ts.fn__resourceDump();
}
/// <summary>
/// (schedule, S32, 4, 0, schedule(time, refobject|0, command, arg1...argN>))
/// </summary>
public  int _schedule(string a1, string a2, string a3, string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){


return m_ts.fn__schedule(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}
/// <summary>
/// (TestFunction2Args, const char *, 3, 3, testFunction(arg1, arg2))
/// </summary>
public  string _TestFunction2Args(string a1, string a2){


return m_ts.fn__TestFunction2Args(a1, a2);
}
/// <summary>
/// ( warn, void, 2, 0, ( string message... )    @brief Logs a warning message to the console.   Concatenates all given arguments to a single string and prints the string to the console as a warning    message (in the in-game console, these will show up using a turquoise font by default).    A newline is added automatically after the text.   @param message Any number of string arguments.   @ingroup Logging )
/// </summary>
public  void _warn(string a1, string a2= "", string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){


m_ts.fn__warn(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}
/// <summary>
/// ()            @brief Activates DirectInput.            Also activates any connected joysticks.			@ingroup Input)
/// </summary>
public  void activateDirectInput(){


m_ts.fn_activateDirectInput();
}
/// <summary>
/// @brief Activates an existing package.
///    The activation occurs by updating the namespace linkage of existing functions and methods. 
///    If the package is already activated the function does nothing.
///    @ingroup Packages)
/// 
/// </summary>
public  void activatePackage(string packageName){


m_ts.fn_activatePackage(packageName);
}
/// <summary>
/// @brief Add a string to the bad word filter   The bad word filter is a table containing words which will not be    displayed in chat windows. Instead, a designated replacement string will be displayed.     There are already a number of bad words automatically defined.   @param badWord Exact text of the word to restrict.   @return True if word was successfully added, false if the word or a subset of it already exists in the table   @see filterString()   @tsexample      // In this game, \"Foobar\" is banned      %badWord = \"Foobar\";      // Returns true, word was successfully added      addBadWord(%badWord);      // Returns false, word has already been added      addBadWord(\"Foobar\");   @endtsexample   @ingroup Game)
/// </summary>
public  bool addBadWord(string badWord){


return m_ts.fn_addBadWord(badWord);
}
/// <summary>
/// Adds a global shader macro which will be merged with the script defined    macros on every shader.  The macro will replace the value of an existing    macro of the same name.  For the new macro to take effect all the shaders    in the system need to be reloaded.   @see resetLightManager, removeGlobalShaderMacro   @ingroup Rendering )
/// </summary>
public  void addGlobalShaderMacro(string name, string value = null ){
if (value== null) {value = null;}


m_ts.fn_addGlobalShaderMacro(name, value);
}
/// <summary>
/// (string texName, string matName)   @brief Maps the given texture to the given material.   Generates a console warning before overwriting.   Material maps are used by terrain and interiors for triggering    effects when an object moves onto a terrain    block or interior surface using the associated texture.   @ingroup Materials)
/// </summary>
public  void addMaterialMapping(string texName, string matName){


m_ts.fn_addMaterialMapping(texName, matName);
}
/// <summary>
/// ),   @brief Use the addTaggedString function to tag a new string and add it to the NetStringTable   @param str The string to be tagged and placed in the NetStringTable. Tagging ignores case,    so tagging the same string (excluding case differences) will be ignored as a duplicated tag.   @return Returns a string( containing a numeric value) equivalent to the string ID for the newly tagged string   @see \\ref syntaxDataTypes under Tagged %Strings   @see removeTaggedString()   @see getTaggedString()   @ingroup Networking)	
/// </summary>
public  string addTaggedString(string str = ""){


return m_ts.fn_addTaggedString(str);
}
/// <summary>
/// ), 'playerName'[, 'AIClassType'] );)
/// </summary>
public  int aiAddPlayer(string name, string ns = ""){


return m_ts.fn_aiAddPlayer(name, ns);
}
/// <summary>
/// allowConnections(bool allow)   @brief Sets whether or not the global NetInterface allows connections from remote hosts.   @param allow Set to true to allow remote connections.   @ingroup Networking)
/// </summary>
public  void allowConnections(bool allow){


m_ts.fn_allowConnections(allow);
}
/// <summary>
/// @brief Prints the scripting call stack to the console log.
///    Used to trace functions called from within functions. Can help discover what functions were called 
///    (and not yet exited) before the current point in scripts.
///    @ingroup Debugging)
/// 
/// </summary>
public  void backtrace(){


m_ts.fn_backtrace();
}
/// <summary>
/// CSV), (location, [backend]) -				@brief Takes a string informing the backend where to store 				sample data and optionally a name of the specific logging 				backend to use.  The default is the CSV backend. In most 				cases, the logging store will be a file name.				@tsexample				beginSampling( \"mysamples.csv\" );				@endtsexample				@ingroup Rendering)
/// </summary>
public  void beginSampling(string location, string backend = "CSV"){


m_ts.fn_beginSampling(location, backend);
}
/// <summary>
/// @brief Calculates how much an explosion effects a specific object.   Use this to determine how much damage to apply to objects based on their    distance from the explosion's center point, and whether the explosion is    blocked by other objects.   @param pos Center position of the explosion.   @param id Id of the object of which to check coverage.   @param covMask Mask of object types that may block the explosion.   @return Coverage value from 0 (not affected by the explosion) to 1 (fully affected)   @tsexample   // Get the position of the explosion.   %position = %explosion.getPosition();   // Set a list of TypeMasks (defined in gameFunctioncs.cpp), seperated by the | character.   %TypeMasks = $TypeMasks::StaticObjectType | $TypeMasks::ItemObjectType   // Acquire the damage value from 0.0f - 1.0f.   %coverage = calcExplosionCoverage( %position, %sceneObject, %TypeMasks );   // Apply damage to object    %sceneObject.applyDamage( %coverage * 20 );   @endtsexample   @ingroup FX)
/// </summary>
public  float calcExplosionCoverage(Point3F pos, int id, uint covMask){


return m_ts.fn_calcExplosionCoverage(pos.AsString(), id, covMask);
}
/// <summary>
/// cancel(eventId))
/// </summary>
public  void cancel(int eventId){


m_ts.fn_cancel(eventId);
}
/// <summary>
/// cancelAll(objectId): cancel pending events on the specified object.  Events will be automatically cancelled if object is deleted.)
/// </summary>
public  void cancelAll(string objectId){


m_ts.fn_cancelAll(objectId);
}
/// <summary>
/// cancelServerQuery(...); )
/// </summary>
public  void cancelServerQuery(){


m_ts.fn_cancelServerQuery();
}
/// <summary>
/// Release the unused pooled textures in texture manager freeing up video memory.   @ingroup GFX )
/// </summary>
public  void cleanupTexturePool(){


m_ts.fn_cleanupTexturePool();
}
/// <summary>
/// )
/// </summary>
public  void clearClientPaths(){


m_ts.fn_clearClientPaths();
}
/// <summary>
/// Clears the flagged state on all allocated GFX resources.    See flagCurrentGFXResources for usage details.   @ingroup GFX   @see flagCurrentGFXResources, listGFXResources, describeGFXResources )
/// </summary>
public  void clearGFXResourceFlags(){


m_ts.fn_clearGFXResourceFlags();
}
/// <summary>
/// )
/// </summary>
public  void clearServerPaths(){


m_ts.fn_clearServerPaths();
}
/// <summary>
/// ()    @brief Closes the current network port   @ingroup Networking)
/// </summary>
public  void closeNetPort(){


m_ts.fn_closeNetPort();
}
/// <summary>
/// Replace all escape sequences in @a text with their respective character codes.   This function replaces all escape sequences (\\\, \\\\t, etc) in the given string    with the respective characters they represent.   The primary use of this function is for converting strings from their literal form into    their compiled/translated form, as is normally done by the TorqueScript compiler.   @param text A string.   @return A duplicate of @a text with all escape sequences replaced by their respective character codes.   @tsexample      // Print:      //      //    str      //    ing      //      // to the console.  Note how the backslash in the string must be escaped here      // in order to prevent the TorqueScript compiler from collapsing the escape      // sequence in the resulting string.      echo( collapseEscape( \"str\ing\" ) );   @endtsexample   @see expandEscape   @ingroup Strings )
/// </summary>
public  string collapseEscape(string text){


return m_ts.fn_collapseEscape(text);
}
/// <summary>
/// Compile a file to bytecode.   This function will read the TorqueScript code in the specified file, compile it to internal bytecode, and,    if DSO generation is enabled or @a overrideNoDDSO is true, will store the compiled code in a .dso file    in the current DSO path mirrorring the path of @a fileName.   @param fileName Path to the file to compile to bytecode.   @param overrideNoDSO If true, force generation of DSOs even if the engine is compiled to not       generate write compiled code to DSO files.   @return True if the file was successfully compiled, false if not.   @note The definitions contained in the given file will not be made available and no code will actually       be executed.  Use exec() for that.   @see getDSOPath   @see exec   @ingroup Scripting )
/// </summary>
public  bool compile(string fileName, bool overrideNoDSO = false){


return m_ts.fn_compile(fileName, overrideNoDSO);
}
/// <summary>
/// Exports console definition XML representation )
/// </summary>
public  string consoleExportXML(){


return m_ts.fn_consoleExportXML();
}
/// <summary>
/// @brief See if any objects of the given types are present in box of given extent.   @note Extent parameter is last since only one radius is often needed.  If    one radius is provided, the yRadius and zRadius are assumed to be the same.  Unfortunately,    if you need to use the client container, you'll need to set all of the radius parameters.     Fortunately, this function is mostly used on the server.   @param  mask   Indicates the type of objects we are checking against.   @param  center Center of box.   @param  xRadius Search radius in the x-axis. See note above.   @param  yRadius Search radius in the y-axis. See note above.   @param  zRadius Search radius in the z-axis. See note above.   @param useClientContainer Optionally indicates the search should be within the    client container.   @return true if the box is empty, false if any object is found.   @ingroup Game)
/// </summary>
public  bool containerBoxEmpty(uint mask, Point3F center, float xRadius, float yRadius = -1, float zRadius = -1, bool useClientContainer = false){


return m_ts.fn_containerBoxEmpty(mask, center.AsString(), xRadius, yRadius, zRadius, useClientContainer);
}
/// <summary>
/// (int mask, Point3F point, float x, float y, float z)   @brief Find objects matching the bitmask type within a box centered at point, with extents x, y, z.   @returns The first object found, or an empty string if nothing was found.  Thereafter, you can get more    results using containerFindNext().   @see containerFindNext   @ingroup Game)
/// </summary>
public  string containerFindFirst(uint typeMask, Point3F origin, Point3F size){


return m_ts.fn_containerFindFirst(typeMask, origin.AsString(), size.AsString());
}
/// <summary>
/// ()   @brief Get more results from a previous call to containerFindFirst().   @note You must call containerFindFirst() to begin the search.   @returns The next object found, or an empty string if nothing else was found.   @see containerFindFirst()	@ingroup Game)
/// </summary>
public  string containerFindNext(){


return m_ts.fn_containerFindNext();
}
/// <summary>
/// @brief Cast a ray from start to end, checking for collision against items matching mask.   If pExempt is specified, then it is temporarily excluded from collision checks (For    instance, you might want to exclude the player if said player was firing a weapon.)   @param start An XYZ vector containing the tail position of the ray.   @param end An XYZ vector containing the head position of the ray   @param mask A bitmask corresponding to the type of objects to check for   @param pExempt An optional ID for a single object that ignored for this raycast   @param useClientContainer Optionally indicates the search should be within the    client container.   @returns A string containing either null, if nothing was struck, or these fields:   ul>li>The ID of the object that was struck./li>   li>The x, y, z position that it was struck./li>   li>The x, y, z of the normal of the face that was struck./li>   li>The distance between the start point and the position we hit./li>/ul>    @ingroup Game)
/// </summary>
public  string containerRayCast(Point3F start, Point3F end, uint mask, string pExempt = null , bool useClientContainer = false){
if (pExempt== null) {pExempt = null;}


return m_ts.fn_containerRayCast(start.AsString(), end.AsString(), mask, pExempt, useClientContainer);
}
/// <summary>
/// @brief Get distance of the center of the current item from the center of the    current initContainerRadiusSearch.   @param useClientContainer Optionally indicates the search should be within the    client container.   @return distance from the center of the current object to the center of    the search   @see containerSearchNext   @ingroup Game)
/// </summary>
public  float containerSearchCurrDist(bool useClientContainer = false){


return m_ts.fn_containerSearchCurrDist(useClientContainer);
}
/// <summary>
/// @brief Get the distance of the closest point of the current item from the center    of the current initContainerRadiusSearch.   @param useClientContainer Optionally indicates the search should be within the    client container.   @return distance from the closest point of the current object to the    center of the search   @see containerSearchNext    @ingroup Game)
/// </summary>
public  float containerSearchCurrRadiusDist(bool useClientContainer = false){


return m_ts.fn_containerSearchCurrRadiusDist(useClientContainer);
}
/// <summary>
/// @brief Get next item from a search started with initContainerRadiusSearch() or    initContainerTypeSearch().   @param useClientContainer Optionally indicates the search should be within the    client container.   @return the next object found in the search, or null if no more   @tsexample   // print the names of all nearby ShapeBase derived objects   %position = %obj.getPosition;   %radius = 20;   %mask = $TypeMasks::ShapeBaseObjectType;   initContainerRadiusSearch( %position, %radius, %mask );   while ( (%targetObject = containerSearchNext()) != 0 )   {      echo( \"Found: \" @ %targetObject.getName() );   }   @endtsexample   @see initContainerRadiusSearch()   @see initContainerTypeSearch()   @ingroup Game)
/// </summary>
public  string containerSearchNext(bool useClientContainer = false){


return m_ts.fn_containerSearchNext(useClientContainer);
}
/// <summary>
/// @brief Checks to see if text is a bad word   The text is considered to be a bad word if it has been added to the bad word filter.   @param text Text to scan for bad words   @return True if the text has bad word(s), false if it is clean   @see addBadWord()   @see filterString()   @tsexample      // In this game, \"Foobar\" is banned      %badWord = \"Foobar\";      // Add a banned word to the bad word filter      addBadWord(%badWord);      // Create the base string, can come from anywhere like user chat      %userText = \"Foobar\";      // Create a string of random letters      %replacementChars = \"knqwrtlzs\";      // If the text contains a bad word, filter it before printing      // Otherwise print the original text      if(containsBadWords(%userText))      {      	// Filter the string      	%filteredText = filterString(%userText, %replacementChars);      	// Print filtered text      	echo(%filteredText);      }      else      	echo(%userText);   @endtsexample   @ingroup Game)
/// </summary>
public  bool containsBadWords(string text){


return m_ts.fn_containsBadWords(text);
}
/// <summary>
/// Count the number of bits that are set in the given 32 bit integer.   @param v An integer value.   @return The number of bits that are set in @a v.   @ingroup Utilities )
/// </summary>
public  int countBits(int v){


return m_ts.fn_countBits(v);
}
/// <summary>
/// @brief Create the given directory or the path leading to the given filename.   If @a path ends in a trailing slash, then all components in the given path will be created as directories (if not already in place).  If @a path,    does @b not end in a trailing slash, then the last component of the path is taken to be a file name and only the directory components    of the path will be created.   @param path The path to create.   @note Only present in a Tools build of Torque.   @ingroup FileSystem )
/// </summary>
public  bool createPath(string path){


return m_ts.fn_createPath(path);
}
/// <summary>
/// ()                Forcibly disconnects any attached script debugging client.				@internal Primarily used for Torsion and other debugging tools)
/// </summary>
public  void dbgDisconnect(){


m_ts.fn_dbgDisconnect();
}
/// <summary>
/// ()                Returns true if a script debugging client is connected else return false.				@internal Primarily used for Torsion and other debugging tools)
/// </summary>
public  bool dbgIsConnected(){


return m_ts.fn_dbgIsConnected();
}
/// <summary>
/// ( int port, string password, bool waitForClient )                Open a debug server port on the specified port, requiring the specified password, 				and optionally waiting for the debug client to connect.				@internal Primarily used for Torsion and other debugging tools)
/// </summary>
public  void dbgSetParameters(int port, string password, bool waitForClient = false){


m_ts.fn_dbgSetParameters(port, password, waitForClient);
}
/// <summary>
/// ()            @brief Disables DirectInput.            Also deactivates any connected joysticks.			@ingroup Input )
/// </summary>
public  void deactivateDirectInput(){


m_ts.fn_deactivateDirectInput();
}
/// <summary>
/// @brief Deactivates a previously activated package.
///    The package is deactivated by removing its namespace linkages to any function or method. 
///    If there are any packages above this one in the stack they are deactivated as well. 
///    If the package is not on the stack this function does nothing.
///    @ingroup Packages)
/// 
/// </summary>
public  void deactivatePackage(string packageName){


m_ts.fn_deactivatePackage(packageName);
}
/// <summary>
/// Drops the engine into the native C++ debugger.   This function triggers a debug break and drops the process into the IDE's debugger.  If the process is not    running with a debugger attached it will generate a runtime error on most platforms.   @note This function is not available in shipping builds.   @ingroup Debugging )
/// </summary>
public  void debug(){


m_ts.fn_debug();
}
/// <summary>
/// @brief Dumps all current EngineObject instances to the console.   @note This function is only available in debug builds.   @ingroup Debugging )
/// </summary>
public  void debugDumpAllObjects(){


m_ts.fn_debugDumpAllObjects();
}
/// <summary>
/// Call the given function for each instance of the given class.
///    @param className Name of the class for which to enumerate instances.
///    @param functionName Name of function to call and pass each instance of the given class.
///    @note This function is only available in debug builds and primarily meant as an aid in debugging.
///    @ingroup Console)
/// 
/// </summary>
public  void debugEnumInstances(string className, string functionName){


m_ts.fn_debugEnumInstances(className, functionName);
}
/// <summary>
/// @brief Logs the value of the given variable to the console.   Prints a string of the form \"variableName> = variable value>\" to the console.   @param variableName Name of the local or global variable to print.   @tsexample      %var = 1;      debugv( \"%var\" ); // Prints \"%var = 1\"   @endtsexample   @ingroup Debugging )
/// </summary>
public  void debugv(string variableName){


m_ts.fn_debugv(variableName);
}
/// <summary>
/// Adds a new decal to the decal manager.   @param position World position for the decal.   @param normal Decal normal vector (if the decal was a tire lying flat on a    surface, this is the vector pointing in the direction of the axle).   @param rot Angle (in radians) to rotate this decal around its normal vector.   @param scale Scale factor applied to the decal.   @param decalData DecalData datablock to use for the new decal.   @param isImmortal Whether or not this decal is immortal. If immortal, it    does not expire automatically and must be removed explicitly.   @return Returns the ID of the new Decal object or -1 on failure.   @tsexample   // Specify the decal position   %position = \"1.0 1.0 1.0\";   // Specify the up vector   %normal = \"0.0 0.0 1.0\";   // Add the new decal.   %decalObj = decalManagerAddDecal( %position, %normal, 0.5, 0.35, ScorchBigDecal, false );   @endtsexample   @ingroup Decals )
/// </summary>
public  int decalManagerAddDecal(Point3F position, Point3F normal, float rot, float scale, string decalData, bool isImmortal = false){


return m_ts.fn_decalManagerAddDecal(position.AsString(), normal.AsString(), rot, scale, decalData, isImmortal);
}
/// <summary>
/// Removes all decals currently loaded in the decal manager.   @tsexample   // Tell the decal manager to remove all existing decals.   decalManagerClear();   @endtsexample   @ingroup Decals )
/// </summary>
public  void decalManagerClear(){


m_ts.fn_decalManagerClear();
}
/// <summary>
/// Returns whether the decal manager has unsaved modifications.   @return True if the decal manager has unsaved modifications, false if    everything has been saved.   @tsexample   // Ask the decal manager if it has unsaved modifications.   %hasUnsavedModifications = decalManagerDirty();   @endtsexample   @ingroup Decals )
/// </summary>
public  bool decalManagerDirty(){


return m_ts.fn_decalManagerDirty();
}
/// <summary>
/// Clears existing decals and replaces them with decals loaded from the specified file.   @param fileName Filename to load the decals from.   @return True if the decal manager was able to load the requested file,    false if it could not.   @tsexample   // Set the filename to load the decals from.   %fileName = \"./missionDecals.mis.decals\";   // Inform the decal manager to load the decals from the entered filename.   decalManagerLoad( %fileName );   @endtsexample   @ingroup Decals )
/// </summary>
public  bool decalManagerLoad(string fileName){


return m_ts.fn_decalManagerLoad(fileName);
}
/// <summary>
/// Remove specified decal from the scene.   @param decalID ID of the decal to remove.   @return Returns true if successful, false if decal ID not found.   @tsexample   // Specify a decal ID to be removed   %decalID = 1;   // Tell the decal manager to remove the specified decal ID.   decalManagerRemoveDecal( %decalId )   @endtsexample   @ingroup Decals )
/// </summary>
public  bool decalManagerRemoveDecal(int decalID){


return m_ts.fn_decalManagerRemoveDecal(decalID);
}
/// <summary>
///  ),   Saves the decals for the active mission in the entered filename.   @param decalSaveFile Filename to save the decals to.   @tsexample   // Set the filename to save the decals in. If no filename is set, then the   // decals will default to activeMissionName>.mis.decals   %fileName = \"./missionDecals.mis.decals\";   // Inform the decal manager to save the decals for the active mission.   decalManagerSave( %fileName );   @endtsexample   @ingroup Decals )
/// </summary>
public  void decalManagerSave(string decalSaveFile = ""){


m_ts.fn_decalManagerSave(decalSaveFile);
}
/// <summary>
/// Delete all the datablocks we've downloaded.   This is usually done in preparation of downloading a new set of datablocks,    such as occurs on a mission change, but it's also good post-mission cleanup. )
/// </summary>
public  void deleteDataBlocks(){


m_ts.fn_deleteDataBlocks();
}
/// <summary>
/// @brief Deletes the given @a file.   @param file %Path of the file to delete.   @note Only present in a Tools build of Torque.   @ingroup FileSystem)
/// </summary>
public  bool deleteFile(string file){


return m_ts.fn_deleteFile(file);
}
/// <summary>
/// Undefine all global variables matching the given name @a pattern.   @param pattern A global variable name pattern.  Must begin with '$'.   @tsexample      // Define a global variable in the \"My\" namespace.      $My::Variable = \"value\";      // Undefine all variable in the \"My\" namespace.      deleteVariables( \"$My::*\" );   @endtsexample   @see strIsMatchExpr   @ingroup Scripting )
/// </summary>
public  void deleteVariables(string pattern){


m_ts.fn_deleteVariables(pattern);
}
/// <summary>
/// @brief Dumps a description of GFX resources to a file or the console.   @param resourceTypes A space seperated list of resource types or an empty string for all resources.   @param filePath A file to dump the list to or an empty string to write to the console.   @param unflaggedOnly If true only unflagged resources are dumped. See flagCurrentGFXResources.   @note The resource types can be one or more of the following:     - texture     - texture target     - window target     - vertex buffers     - primitive buffers     - fences     - cubemaps     - shaders     - stateblocks   @ingroup GFX )
/// </summary>
public  void describeGFXResources(string resourceTypes, string filePath, bool unflaggedOnly = false){


m_ts.fn_describeGFXResources(resourceTypes, filePath, unflaggedOnly);
}
/// <summary>
/// Dumps a description of all state blocks.        @param filePath A file to dump the state blocks to or an empty string to write to the console.   @ingroup GFX )
/// </summary>
public  void describeGFXStateBlocks(string filePath){


m_ts.fn_describeGFXStateBlocks(filePath);
}
/// <summary>
/// @brief Returns the string from a tag string.   Should only be used within the context of a function that receives a tagged    string, and is not meant to be used outside of this context.  Use getTaggedString()    to convert a tagged string ID back into a regular string at any time.   @tsexample      // From scripts/client/message.cs      function clientCmdChatMessage(%sender, %voice, %pitch, %msgString, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9, %a10)      {         onChatMessage(detag(%msgString), %voice, %pitch);      }	@endtsexample   @see \\ref syntaxDataTypes under Tagged %Strings   @see getTag()   @see getTaggedString()   @ingroup Networking)
/// </summary>
public  string detag(string str){


return m_ts.fn_detag(str);
}
/// <summary>
/// ()             @brief Disables use of the joystick.             @note DirectInput must be enabled and active to use this function.             @ingroup Input)
/// </summary>
public  void disableJoystick(){


m_ts.fn_disableJoystick();
}
/// <summary>
/// ()            @brief Disables XInput for Xbox 360 controllers.            @ingroup Input)
/// </summary>
public  void disableXInput(){


m_ts.fn_disableXInput();
}
/// <summary>
/// ), (string queueName, string message, string data)				@brief Dispatch a message to a queue				@param queueName Queue to dispatch the message to				@param message Message to dispatch				@param data Data for message				@return True for success, false for failure				@see dispatchMessageObject				@ingroup Messaging)
/// </summary>
public  bool dispatchMessage(string queueName, string message, string data = ""){


return m_ts.fn_dispatchMessage(queueName, message, data);
}
/// <summary>
/// , ), (string queueName, string message)				@brief Dispatch a message object to a queue				@param queueName Queue to dispatch the message to				@param message Message to dispatch				@return true for success, false for failure				@see dispatchMessage				@ingroup Messaging)
/// </summary>
public  bool dispatchMessageObject(string queueName = "", string message = ""){


return m_ts.fn_dispatchMessageObject(queueName, message);
}
/// <summary>
/// art/gui/splash.bmp),   Display a startup splash window suitable for showing while the engine still starts up.   @note This is currently only implemented on Windows.   @return True if the splash window could be successfully initialized.   @ingroup Platform )
/// </summary>
public  bool displaySplashWindow(string path = "art/gui/splash.bmp"){


return m_ts.fn_displaySplashWindow(path);
}
/// <summary>
/// (bool enabled)   @brief Enables logging of the connection protocols   When enabled a lot of network debugging information is sent to the console.   @param enabled True to enable, false to disable   @ingroup Networking)
/// </summary>
public  void DNetSetLogging(bool enabled){


m_ts.fn_DNetSetLogging(enabled);
}
/// <summary>
/// Return the integer character code value corresponding to the first character in the given string.
/// )
/// 
/// </summary>
public  string dnt_testcase_1(string chr){


return m_ts.fn_dnt_testcase_1(chr);
}
/// <summary>
/// Return the integer character code value corresponding to the first character in the given string.
/// )
/// 
/// </summary>
public  Point4F dnt_testcase_10(Point4F chr){


return new Point4F ( m_ts.fn_dnt_testcase_10(chr.AsString()));
}
/// <summary>
/// Return the integer character code value corresponding to the first character in the given string.
/// )
/// 
/// </summary>
public  RectF dnt_testcase_12(RectF chr){


return new RectF ( m_ts.fn_dnt_testcase_12(chr.AsString()));
}
/// <summary>
/// Return the integer character code value corresponding to the first character in the given string.
/// )
/// 
/// </summary>
public  RectI dnt_testcase_13(RectI chr){


return new RectI ( m_ts.fn_dnt_testcase_13(chr.AsString()));
}
/// <summary>
/// Return the integer character code value corresponding to the first character in the given string.
/// )
/// 
/// </summary>
public  RectSpacingI dnt_testcase_14(RectSpacingI chr){


return new RectSpacingI ( m_ts.fn_dnt_testcase_14(chr.AsString()));
}
/// <summary>
/// Return the integer character code value corresponding to the first character in the given string.
/// )
/// 
/// </summary>
public  TransformF dnt_testcase_15(TransformF chr){


return new TransformF ( m_ts.fn_dnt_testcase_15(chr.AsString()));
}
/// <summary>
/// Return the integer character code value corresponding to the first character in the given string.
/// )
/// 
/// </summary>
public  AngAxisF dnt_testcase_2(AngAxisF chr){


return new AngAxisF ( m_ts.fn_dnt_testcase_2(chr.AsString()));
}
/// <summary>
/// Return the integer character code value corresponding to the first character in the given string.
/// )
/// 
/// </summary>
public  Box3F dnt_testcase_3(Box3F chr){


return new Box3F ( m_ts.fn_dnt_testcase_3(chr.AsString()));
}
/// <summary>
/// Return the integer character code value corresponding to the first character in the given string.
/// )
/// 
/// </summary>
public  ColorF dnt_testcase_4(ColorF chr){


return new ColorF ( m_ts.fn_dnt_testcase_4(chr.AsString()));
}
/// <summary>
/// Return the integer character code value corresponding to the first character in the given string.
/// )
/// 
/// </summary>
public  ColorI dnt_testcase_5(ColorI chr){


return new ColorI ( m_ts.fn_dnt_testcase_5(chr.AsString()));
}
/// <summary>
/// Return the integer character code value corresponding to the first character in the given string.
/// )
/// 
/// </summary>
public  EaseF dnt_testcase_6(EaseF chr){


return new EaseF ( m_ts.fn_dnt_testcase_6(chr.AsString()));
}
/// <summary>
/// Return the integer character code value corresponding to the first character in the given string.
/// )
/// 
/// </summary>
public  Point2F dnt_testcase_7(Point2F chr){


return new Point2F ( m_ts.fn_dnt_testcase_7(chr.AsString()));
}
/// <summary>
/// Return the integer character code value corresponding to the first character in the given string.
/// )
/// 
/// </summary>
public  Point2I dnt_testcase_8(Point2I chr){


return new Point2I ( m_ts.fn_dnt_testcase_8(chr.AsString()));
}
/// <summary>
/// Return the integer character code value corresponding to the first character in the given string.
/// )
/// 
/// </summary>
public  Point3F dnt_testcase_9(Point3F chr){


return new Point3F ( m_ts.fn_dnt_testcase_9(chr.AsString()));
}
/// <summary>
/// @brief Dumps all declared console classes to the console.            @param dumpScript Optional parameter specifying whether or not classes defined in script should be dumped.            @param dumpEngine Optional parameter specifying whether or not classes defined in the engine should be dumped.			@ingroup Logging)
/// </summary>
public  void dumpConsoleClasses(bool dumpScript = true, bool dumpEngine = true){


m_ts.fn_dumpConsoleClasses(dumpScript, dumpEngine);
}
/// <summary>
/// @brief Dumps all declared console functions to the console.            @param dumpScript Optional parameter specifying whether or not functions defined in script should be dumped.            @param dumpEngine Optional parameter specitying whether or not functions defined in the engine should be dumped.			@ingroup Logging)
/// </summary>
public  void dumpConsoleFunctions(bool dumpScript = true, bool dumpEngine = true){


m_ts.fn_dumpConsoleFunctions(dumpScript, dumpEngine);
}
/// <summary>
/// Dumps the engine scripting documentation to the specified file overwriting any existing content.                     @param outputFile The relative or absolute output file path and name.                     @return Returns true if successful.                     @ingroup Console)
/// </summary>
public  bool dumpEngineDocs(string outputFile){


return m_ts.fn_dumpEngineDocs(outputFile);
}
/// <summary>
/// Dumps to the console a full description of all cached fonts, along with    info on the codepoints each contains.   @ingroup Font )
/// </summary>
public  void dumpFontCacheStatus(){


m_ts.fn_dumpFontCacheStatus();
}
/// <summary>
/// @brief Dumps a formatted list of currently allocated material instances to the console.   @ingroup Materials)
/// </summary>
public  void dumpMaterialInstances(){


m_ts.fn_dumpMaterialInstances();
}
/// <summary>
/// @brief Dumps network statistics for each class to the console.   The returned i>avg/i>, i>min/i> and i>max/i> values are in bits sent per update.     The i>num/i> value is the total number of events collected.   @note This method only works when TORQUE_NET_STATS is defined in torqueConfig.h.   @ingroup Networking )
/// </summary>
public  void dumpNetStats(){


m_ts.fn_dumpNetStats();
}
/// <summary>
/// @brief Dump the current contents of the networked string table to the console.   The results are returned in three columns.  The first column is the network string ID.     The second column is the string itself.  The third column is the reference count to the    network string.   @note This function is available only in debug builds.   @ingroup Networking )
/// </summary>
public  void dumpNetStringTable(){


m_ts.fn_dumpNetStringTable();
}
/// <summary>
/// Dumps all ProcessObjects in ServerProcessList and ClientProcessList to the console. )
/// </summary>
public  void dumpProcessList(bool allow){


m_ts.fn_dumpProcessList(allow);
}
/// <summary>
/// Creates a 64x64 normal map texture filled with noise. The texture is saved    to randNormTex.png in the location of the game executable.   @ingroup GFX)
/// </summary>
public  void dumpRandomNormalMap(){


m_ts.fn_dumpRandomNormalMap();
}
/// <summary>
/// )
/// 
/// </summary>
public  void dumpSoCount(){


m_ts.fn_dumpSoCount();
}
/// <summary>
/// ()				@brief Dumps information about String memory usage				@ingroup Debugging				@ingroup Strings)
/// </summary>
public  void dumpStringMemStats(){


m_ts.fn_dumpStringMemStats();
}
/// <summary>
/// )
/// </summary>
public  void dumpStringTableSize(){


m_ts.fn_dumpStringTableSize();
}
/// <summary>
/// Dumps a list of all active texture objects to the console.   @note This function is only available in debug builds.   @ingroup GFX )
/// </summary>
public  void dumpTextureObjects(){


m_ts.fn_dumpTextureObjects();
}
/// <summary>
/// Copy the specified old font to a new name. The new copy will not have a    platform font backing it, and so will never have characters added to it.    But this is useful for making copies of fonts to add postprocessing effects    to via exportCachedFont.   @param oldFontName The name of the font face to copy.   @param oldFontSize The size of the font to copy.   @param newFontName The name of the new font face.   @ingroup Font )
/// </summary>
public  void duplicateCachedFont(string oldFontName, int oldFontSize, string newFontName){


m_ts.fn_duplicateCachedFont(oldFontName, oldFontSize, newFontName);
}
/// <summary>
/// ()            @brief Prints information to the console stating if DirectInput and a Joystick are enabled and active.            @ingroup Input)
/// </summary>
public  void echoInputState(){


m_ts.fn_echoInputState();
}
/// <summary>
/// ()             @brief Enables use of the joystick.             @note DirectInput must be enabled and active to use this function.             @ingroup Input)
/// </summary>
public  bool enableJoystick(){


return m_ts.fn_enableJoystick();
}
/// <summary>
/// (pattern, [state]) -				@brief Enable sampling for all keys that match the given name 				pattern. Slashes are treated as separators.				@ingroup Rendering)
/// </summary>
public  void enableSamples(string pattern, bool state = true){


m_ts.fn_enableSamples(pattern, state);
}
/// <summary>
/// enableWinConsole(bool);)
/// </summary>
public  void enableWinConsole(bool flag){


m_ts.fn_enableWinConsole(flag);
}
/// <summary>
/// ()            @brief Enables XInput for Xbox 360 controllers.            @note XInput is enabled by default. Disable to use an Xbox 360             Controller as a joystick device.				@ingroup Input)
/// </summary>
public  bool enableXInput(){


return m_ts.fn_enableXInput();
}
/// <summary>
/// @brief Test whether the given string ends with the given suffix.   @param str The string to test.   @param suffix The potential suffix of @a str.   @param caseSensitive If true, the comparison will be case-sensitive; if false, differences in casing will       not be taken into account.   @return True if the last characters in @a str match the complete contents of @a suffix; false otherwise.   @tsexample   startsWith( \"TEST123\", \"123\" ) // Returns true.   @endtsexample   @see startsWith   @ingroup Strings )
/// </summary>
public  bool endsWith(string str, string suffix, bool caseSensitive = false){


return m_ts.fn_endsWith(str, suffix, caseSensitive);
}
/// <summary>
/// (string shapePath, GuiTreeViewCtrl ctrl) Collect scene information from    a COLLADA file and store it in a GuiTreeView control. This function is    used by the COLLADA import gui to show a preview of the scene contents    prior to import, and is probably not much use for anything else.   @param shapePath COLLADA filename   @param ctrl GuiTreeView control to add elements to   @return true if successful, false otherwise   @ingroup Editors   @internal)
/// </summary>
public  bool enumColladaForImport(string shapePath, string ctrl){


return m_ts.fn_enumColladaForImport(shapePath, ctrl);
}
/// <summary>
///  ),				@brief Returns a list of classes that derive from the named class.            If the named class is omitted this dumps all the classes.            @param className The optional base class name.				@return A tab delimited list of classes.            @ingroup Editors				@internal)
/// </summary>
public  string enumerateConsoleClasses(string className = ""){


return m_ts.fn_enumerateConsoleClasses(className);
}
/// <summary>
/// @brief Provide a list of classes that belong to the given category.				@param category The category name.				@return A tab delimited list of classes.				@ingroup Editors				@internal)
/// </summary>
public  string enumerateConsoleClassesByCategory(string category){


return m_ts.fn_enumerateConsoleClassesByCategory(category);
}
/// <summary>
/// eval(consoleString) )
/// </summary>
public  string eval(string consoleString){


return m_ts.fn_eval(consoleString);
}
/// <summary>
/// @brief Used to exclude/prevent all other instances using the same identifier specified					 @note Not used on OSX, Xbox, or in Win debug builds					 @param appIdentifier Name of the app set up for exclusive use.					 @return False if another app is running that specified the same appIdentifier					 @ingroup Platform					 @ingroup GuiCore)
/// </summary>
public  bool excludeOtherInstance(string appIdentifer){


return m_ts.fn_excludeOtherInstance(appIdentifer);
}
/// <summary>
/// Execute the given script file.   @param fileName Path to the file to execute   @param noCalls Deprecated   @param journalScript Deprecated   @return True if the script was successfully executed, false if not.   @tsexample      // Execute the init.cs script file found in the same directory as the current script file.      exec( \"./init.cs\" );   @endtsexample   @see compile   @see eval   @ingroup Scripting )
/// </summary>
public  bool exec(string fileName, bool noCalls = false, bool journalScript = false){


return m_ts.fn_exec(fileName, noCalls, journalScript);
}
/// <summary>
/// @brief Replace all characters in @a text that need to be escaped for the string to be a valid string literal with their    respective escape sequences.   All characters in @a text that cannot appear in a string literal will be replaced by an escape sequence (\\\, \\\\t, etc).   The primary use of this function is for converting strings suitable for being passed as string literals    to the TorqueScript compiler.   @param text A string   @return A duplicate of the text parameter with all unescaped characters that cannot appear in string literals replaced by their respective    escape sequences.   @tsxample   expandEscape( \"str\" NL \"ing\" ) // Returns \"str\ing\".   @endtsxample   @see collapseEscape   @ingroup Strings)
/// </summary>
public  string expandEscape(string text){


return m_ts.fn_expandEscape(text);
}
/// <summary>
/// , false ),   Write out the definitions of all global variables matching the given name @a pattern.   If @a fileName is not \"\", the variable definitions are written to the specified file.  Otherwise the    definitions will be printed to the console.   The output are valid TorqueScript statements that can be executed to restore the global variable    values.   @param pattern A global variable name pattern.  Must begin with '$'.   @param filename %Path of the file to which to write the definitions or \"\" to write the definitions       to the console.   @param append If true and @a fileName is not \"\", then the definitions are appended to the specified file.       Otherwise existing contents of the file (if any) will be overwritten.   @tsexample      // Write out all preference variables to a prefs.cs file.      export( \"$prefs::*\", \"prefs.cs\" );   @endtsexample   @ingroup Scripting )
/// </summary>
public  void export(string pattern, string filename = "", bool append = false){


m_ts.fn_export(pattern, filename, append);
}
/// <summary>
/// Export specified font to the specified filename as a PNG. The    image can then be processed in Photoshop or another tool and    reimported using importCachedFont. Characters in the font are    exported as one long strip.   @param faceName The name of the font face.   @param fontSize The size of the font in pixels.   @param fileName The file name and path for the output PNG.   @param padding The padding between characters.      @param kerning The kerning between characters.      @ingroup Font )
/// </summary>
public  void exportCachedFont(string faceName, int fontSize, string fileName, int padding, int kerning){


m_ts.fn_exportCachedFont(faceName, fontSize, fileName, padding, kerning);
}
/// <summary>
/// Create a XML document containing a dump of the entire exported engine API.   @return A SimXMLDocument containing a dump of the engine's export information or NULL if the operation failed.   @ingroup Console )
/// </summary>
public  string exportEngineAPIToXML(){


return m_ts.fn_exportEngineAPIToXML();
}
/// <summary>
/// , false ),   Write out the definitions of all global variables matching the given name @a pattern.   If @a fileName is not \"\", the variable definitions are written to the specified file.  Otherwise the    definitions will be printed to the console.   The output are valid TorqueScript statements that can be executed to restore the global variable    values.   @param pattern A global variable name pattern.  Must begin with '$'.   @param filename %Path of the file to which to write the definitions or \"\" to write the definitions       to the console.   @param append If true and @a fileName is not \"\", then the definitions are appended to the specified file.       Otherwise existing contents of the file (if any) will be overwritten.   @tsexample      // Write out all preference variables to a prefs.cs file.      export( \"$prefs::*\", \"prefs.cs\" );   @endtsexample   @ingroup Scripting )
/// </summary>
public  void exportToSettings(string pattern, string filename = "", bool append = false){


m_ts.fn_exportToSettings(pattern, filename, append);
}
/// <summary>
/// @brief Get the base of a file name (removes extension)   @param fileName Name and path of file to check   @return String containing the file name, minus extension   @ingroup FileSystem)
/// </summary>
public  string fileBase(string fileName){


return m_ts.fn_fileBase(fileName);
}
/// <summary>
/// @brief Returns a platform specific formatted string with the creation time for the file.   @param fileName Name and path of file to check   @return Formatted string (OS specific) containing created time, \"9/3/2010 12:33:47 PM\" for example   @ingroup FileSystem)
/// </summary>
public  string fileCreatedTime(string fileName){


return m_ts.fn_fileCreatedTime(fileName);
}
/// <summary>
/// @brief Delete a file from the hard drive	@param path Name and path of the file to delete	@note THERE IS NO RECOVERY FROM THIS. Deleted file is gone for good.	@return True if file was successfully deleted	@ingroup FileSystem)
/// </summary>
public  bool fileDelete(string path){


return m_ts.fn_fileDelete(path);
}
/// <summary>
/// @brief Get the extension of a file	@param fileName Name and path of file	@return String containing the extension, such as \".exe\" or \".cs\"	@ingroup FileSystem)
/// </summary>
public  string fileExt(string fileName){


return m_ts.fn_fileExt(fileName);
}
/// <summary>
/// @brief Returns a platform specific formatted string with the last modified time for the file.	@param fileName Name and path of file to check	@return Formatted string (OS specific) containing modified time, \"9/3/2010 12:33:47 PM\" for example	@ingroup FileSystem)
/// </summary>
public  string fileModifiedTime(string fileName){


return m_ts.fn_fileModifiedTime(fileName);
}
/// <summary>
/// @brief Get the file name of a file (removes extension and path)	@param fileName Name and path of file to check	@return String containing the file name, minus extension and path	@ingroup FileSystem)
/// </summary>
public  string fileName(string fileName){


return m_ts.fn_fileName(fileName);
}
/// <summary>
/// @brief Get the path of a file (removes name and extension)	@param fileName Name and path of file to check	@return String containing the path, minus name and extension	@ingroup FileSystem)
/// </summary>
public  string filePath(string fileName){


return m_ts.fn_filePath(fileName);
}
/// <summary>
/// @brief Determines the size of a file on disk	@param fileName Name and path of the file to check	@return Returns filesize in KB, or -1 if no file	@ingroup FileSystem)
/// </summary>
public  int fileSize(string fileName){


return m_ts.fn_fileSize(fileName);
}
/// <summary>
/// @brief Replaces the characters in a string with designated text   Uses the bad word filter to determine which characters within the string will be replaced.   @param baseString  The original string to filter.   @param replacementChars A string containing letters you wish to swap in the baseString.   @return The new scrambled string    @see addBadWord()   @see containsBadWords()   @tsexample      // Create the base string, can come from anywhere      %baseString = \"Foobar\";      // Create a string of random letters      %replacementChars = \"knqwrtlzs\";      // Filter the string      %newString = filterString(%baseString, %replacementChars);      // Print the new string to console      echo(%newString);   @endtsexample   @ingroup Game)
/// </summary>
public  string filterString(string baseString = null , string replacementChars = null ){
if (baseString== null) {baseString = null;}
if (replacementChars== null) {replacementChars = null;}


return m_ts.fn_filterString(baseString, replacementChars);
}
/// <summary>
/// @brief Returns the first file in the directory system matching the given pattern.   Use the corresponding findNextFile() to step through    the results.  If you're only interested in the number of files returned by the    pattern match, use getFileCount().   This function differs from findFirstFileMultiExpr() in that it supports a single search    pattern being passed in.   @note You cannot run multiple simultaneous file system searches with these functions.  Each    call to findFirstFile() and findFirstFileMultiExpr() initiates a new search and renders    a previous search invalid.   @param pattern The path and file name pattern to match against.   @param recurse If true, the search will exhaustively recurse into subdirectories of the given path and match the given filename pattern.   @return The path of the first file matched by the search or an empty string if no matching file could be found.   @tsexample      // Execute all .cs files in a subdirectory and its subdirectories.      for( %file = findFirstFile( \"subdirectory/*.cs\" ); %file !$= \"\"; %file = findNextFile() )         exec( %file );   @endtsexample   @see findNextFile()   @see getFileCount()   @see findFirstFileMultiExpr()   @ingroup FileSearches )
/// </summary>
public  string findFirstFile(string pattern, bool recurse = true){


return m_ts.fn_findFirstFile(pattern, recurse);
}
/// <summary>
/// @brief Returns the first file in the directory system matching the given patterns.   Use the corresponding findNextFileMultiExpr() to step through    the results.  If you're only interested in the number of files returned by the    pattern match, use getFileCountMultiExpr().   This function differs from findFirstFile() in that it supports multiple search patterns    to be passed in.   @note You cannot run multiple simultaneous file system searches with these functions.  Each    call to findFirstFile() and findFirstFileMultiExpr() initiates a new search and renders    a previous search invalid.	@param pattern The path and file name pattern to match against, such as *.cs.  Separate    multiple patterns with TABs.  For example: \"*.cs\" TAB \"*.dso\"	@param recurse If true, the search will exhaustively recurse into subdirectories 	of the given path and match the given filename patterns.   @return String of the first matching file path, or an empty string if no matching    files were found.   @tsexample      // Find all DTS or Collada models      %filePatterns = \"*.dts\" TAB \"*.dae\";      %fullPath = findFirstFileMultiExpr( %filePatterns );      while ( %fullPath !$= \"\" )      {         echo( %fullPath );         %fullPath = findNextFileMultiExpr( %filePatterns );      }   @endtsexample   @see findNextFileMultiExpr()   @see getFileCountMultiExpr()   @see findFirstFile()	@ingroup FileSearches)
/// </summary>
public  string findFirstFileMultiExpr(string pattern, bool recurse = true){


return m_ts.fn_findFirstFileMultiExpr(pattern, recurse);
}
/// <summary>
///  ),   @brief Returns the next file matching a search begun in findFirstFile().   @param pattern The path and file name pattern to match against.  This is optional    and may be left out as it is not used by the code.  It is here for legacy reasons.   @return The path of the next filename matched by the search or an empty string if no more files match.   @tsexample      // Execute all .cs files in a subdirectory and its subdirectories.      for( %file = findFirstFile( \"subdirectory/*.cs\" ); %file !$= \"\"; %file = findNextFile() )         exec( %file );   @endtsexample   @see findFirstFile()   @ingroup FileSearches )
/// </summary>
public  string findNextFile(string pattern = ""){


return m_ts.fn_findNextFile(pattern);
}
/// <summary>
/// ),   @brief Returns the next file matching a search begun in findFirstFileMultiExpr().	@param pattern The path and file name pattern to match against.  This is optional    and may be left out as it is not used by the code.  It is here for legacy reasons.   @return String of the next matching file path, or an empty string if no matching    files were found.   @tsexample      // Find all DTS or Collada models      %filePatterns = \"*.dts\" TAB \"*.dae\";      %fullPath = findFirstFileMultiExpr( %filePatterns );      while ( %fullPath !$= \"\" )      {         echo( %fullPath );         %fullPath = findNextFileMultiExpr( %filePatterns );      }   @endtsexample   @see findFirstFileMultiExpr()	@ingroup FileSearches)
/// </summary>
public  string findNextFileMultiExpr(string pattern = ""){


return m_ts.fn_findNextFileMultiExpr(pattern);
}
/// <summary>
/// Return the first word in @a text.   @param text A list of words separated by newlines, spaces, and/or tabs.   @return The word at index 0 in @a text or \"\" if @a text is empty.   @note This is equal to    @tsexample_nopar      getWord( text, 0 )   @endtsexample   @see getWord   @ingroup FieldManip )
/// </summary>
public  string firstWord(string text){


return m_ts.fn_firstWord(text);
}
/// <summary>
/// @brief Flags all currently allocated GFX resources.   Used for resource allocation and leak tracking by flagging    current resources then dumping a list of unflagged resources    at some later point in execution.   @ingroup GFX   @see listGFXResources, clearGFXResourceFlags, describeGFXResources )
/// </summary>
public  void flagCurrentGFXResources(){


m_ts.fn_flagCurrentGFXResources();
}
/// <summary>
/// Releases all textures and resurrects the texture manager.   @ingroup GFX )
/// </summary>
public  void flushTextureCache(){


m_ts.fn_flushTextureCache();
}
/// <summary>
/// Returns the count of active DDSs files in memory.   @ingroup Rendering )
/// </summary>
public  int getActiveDDSFiles(){


return m_ts.fn_getActiveDDSFiles();
}
/// <summary>
/// Returns the active light manager name.   @ingroup Lighting )
/// </summary>
public  string getActiveLightManager(){


return m_ts.fn_getActiveLightManager();
}
/// <summary>
/// Get the version of the application build, as a string.             @ingroup Debugging)
/// </summary>
public  int getAppVersionNumber(){


return m_ts.fn_getAppVersionNumber();
}
/// <summary>
/// Get the version of the aplication build, as a human readable string.             @ingroup Debugging)
/// </summary>
public  string getAppVersionString(){


return m_ts.fn_getAppVersionString();
}
/// <summary>
/// Returns the best texture format for storage of HDR data for the active device.   @ingroup GFX )
/// </summary>
public  TypeGFXFormat getBestHDRFormat(){


return (TypeGFXFormat)( m_ts.fn_getBestHDRFormat());
}
/// <summary>
/// Returns image info in the following format: width TAB height TAB bytesPerPixel.    It will return an empty string if the file is not found.   @ingroup Rendering )
/// </summary>
public  string getBitmapInfo(string filename){


return m_ts.fn_getBitmapInfo(filename);
}
/// <summary>
/// Get the center point of an axis-aligned box.   @param b A Box3F, in string format using \"minExtentX minExtentY minExtentZ maxExtentX maxExtentY maxExtentZ\"   @return Center of the box.   @ingroup Math)
/// </summary>
public  Point3F getBoxCenter(Box3F box){


return new Point3F ( m_ts.fn_getBoxCenter(box.AsString()));
}
/// <summary>
/// Get the type of build, \"Debug\" or \"Release\".				@ingroup Debugging)
/// </summary>
public  string getBuildString(){


return m_ts.fn_getBuildString();
}
/// <summary>
/// @brief Returns the category of the given class.				@param className The name of the class.				@ingroup Console)
/// </summary>
public  string getCategoryOfClass(string className){


return m_ts.fn_getCategoryOfClass(className);
}
/// <summary>
/// ()
/// 				@brief Get text from the clipboard.
/// 				@internal)
/// 
/// </summary>
public  string getClipboard(){


return m_ts.fn_getClipboard();
}
/// <summary>
/// Get the time of compilation. 				@ingroup Debugging)
/// </summary>
public  string getCompileTimeString(){


return m_ts.fn_getCompileTimeString();
}
/// <summary>
/// ()				@brief Gets the primary LangTable used by the game				@return ID of the core LangTable				@ingroup Localization)
/// </summary>
public  int getCoreLangTable(){


return m_ts.fn_getCoreLangTable();
}
/// <summary>
/// @brief Returns the current %ActionMap.   @see ActionMap	@ingroup Input)
/// </summary>
public  string getCurrentActionMap(){


return m_ts.fn_getCurrentActionMap();
}
/// <summary>
/// @brief Return the current working directory.   @return The absolute path of the current working directory.   @note Only present in a Tools build of Torque.   @see getWorkingDirectory()   @ingroup FileSystem)
/// </summary>
public  string getCurrentDirectory(){


return m_ts.fn_getCurrentDirectory();
}
/// <summary>
/// @brief Returns the description string for the named class.				@param className The name of the class.				@return The class description in string format.				@ingroup Console)
/// </summary>
public  string getDescriptionOfClass(string className){


return m_ts.fn_getDescriptionOfClass(className);
}
/// <summary>
/// Returns the width, height, and bitdepth of the screen/desktop.@ingroup GFX )
/// </summary>
public  Point3F getDesktopResolution(){


return new Point3F ( m_ts.fn_getDesktopResolution());
}
/// <summary>
/// @brief Gathers a list of directories starting at the given path.	@param path String containing the path of the directory	@param depth Depth of search, as in how many subdirectories to parse through	@return Tab delimited string containing list of directories found during search, \"\" if no files were found	@ingroup FileSystem)
/// </summary>
public  string getDirectoryList(string path, int depth = 0){


return m_ts.fn_getDirectoryList(path, depth);
}
/// <summary>
/// Get the string describing the active GFX device.   @ingroup GFX )
/// </summary>
public  string getDisplayDeviceInformation(){


return m_ts.fn_getDisplayDeviceInformation();
}
/// <summary>
/// Returns a tab-seperated string of the detected devices across all adapters.   @ingroup GFX )
/// </summary>
public  string getDisplayDeviceList(){


return m_ts.fn_getDisplayDeviceList();
}
/// <summary>
/// Get the absolute path to the file in which the compiled code for the given script file will be stored.   @param scriptFileName %Path to the .cs script file.   @return The absolute path to the .dso file for the given script file.   @note The compiler will store newly compiled DSOs in the prefs path but pre-existing DSOs will be loaded       from the current paths.   @see compile   @see getPrefsPath   @ingroup Scripting )
/// </summary>
public  string getDSOPath(string scriptFileName){


return m_ts.fn_getDSOPath(scriptFileName);
}
/// <summary>
/// Get the name of the engine product that this is running from, as a string. 				@ingroup Debugging)
/// </summary>
public  string getEngineName(){


return m_ts.fn_getEngineName();
}
/// <summary>
/// getEventTimeLeft(scheduleId) Get the time left in ms until this event will trigger.)
/// </summary>
public  int getEventTimeLeft(int scheduleId){


return m_ts.fn_getEventTimeLeft(scheduleId);
}
/// <summary>
/// @brief Gets the name of the game's executable	@return String containing this game's executable name	@ingroup FileSystem)
/// </summary>
public  string getExecutableName(){


return m_ts.fn_getExecutableName();
}
/// <summary>
/// Gets the clients far clipping.   )
/// </summary>
public  float getFarClippingDistance(){


return m_ts.fn_getFarClippingDistance();
}
/// <summary>
/// Extract the field at the given @a index in the newline and/or tab separated list in @a text.   Fields in @a text must be separated by newlines and/or tabs.   @param text A list of fields separated by newlines and/or tabs.   @param index The zero-based index of the field to extract.   @return The field at the given index or \"\" if the index is out of range.   @tsexample      getField( \"a b\" TAB \"c d\" TAB \"e f\", 1 ) // Returns \"c d\"   @endtsexample   @see getFields   @see getFieldCount   @see getWord   @see getRecord   @ingroup FieldManip )
/// </summary>
public  string getField(string text, int index){


return m_ts.fn_getField(text, index);
}
/// <summary>
/// Return the number of newline and/or tab separated fields in @a text.   @param text A list of fields separated by newlines and/or tabs.   @return The number of newline and/or tab sepearated elements in @a text.   @tsexample      getFieldCount( \"a b\" TAB \"c d\" TAB \"e f\" ) // Returns 3   @endtsexample   @see getWordCount   @see getRecordCount   @ingroup FieldManip )
/// </summary>
public  int getFieldCount(string text){


return m_ts.fn_getFieldCount(text);
}
/// <summary>
/// Extract a range of fields from the given @a startIndex onwards thru @a endIndex.   Fields in @a text must be separated by newlines and/or tabs.   @param text A list of fields separated by newlines and/or tabs.   @param startIndex The zero-based index of the first field to extract from @a text.   @param endIndex The zero-based index of the last field to extract from @a text.  If this is -1, all fields beginning       with @a startIndex are extracted from @a text.   @return A string containing the specified range of fields from @a text or \"\" if @a startIndex       is out of range or greater than @a endIndex.   @tsexample      getFields( \"a b\" TAB \"c d\" TAB \"e f\", 1 ) // Returns \"c d\" TAB \"e f\"   @endtsexample   @see getField   @see getFieldCount   @see getWords   @see getRecords   @ingroup FieldManip )
/// </summary>
public  string getFields(string text, int startIndex, int endIndex = -1){


return m_ts.fn_getFields(text, startIndex, endIndex);
}
/// <summary>
/// @brief Returns the number of files in the directory tree that match the given patterns   This function differs from getFileCountMultiExpr() in that it supports a single search    pattern being passed in.   If you're interested in a list of files that match the given pattern and not just    the number of files, use findFirstFile() and findNextFile().   @param pattern The path and file name pattern to match against.   @param recurse If true, the search will exhaustively recurse into subdirectories of the given path and match the given filename pattern       counting files in subdirectories.   @return Number of files located using the pattern   @tsexample      // Count the number of .cs files in a subdirectory and its subdirectories.      getFileCount( \"subdirectory/*.cs\" );   @endtsexample   @see findFirstFile()   @see findNextFile()   @see getFileCountMultiExpr()   @ingroup FileSearches )
/// </summary>
public  int getFileCount(string pattern, bool recurse = true){


return m_ts.fn_getFileCount(pattern, recurse);
}
/// <summary>
/// @brief Returns the number of files in the directory tree that match the given patterns   If you're interested in a list of files that match the given patterns and not just    the number of files, use findFirstFileMultiExpr() and findNextFileMultiExpr().	@param pattern The path and file name pattern to match against, such as *.cs.  Separate    multiple patterns with TABs.  For example: \"*.cs\" TAB \"*.dso\"	@param recurse If true, the search will exhaustively recurse into subdirectories 	of the given path and match the given filename pattern.	@return Number of files located using the patterns   @tsexample      // Count all DTS or Collada models      %filePatterns = \"*.dts\" TAB \"*.dae\";      echo( \"Nunmer of shape files:\" SPC getFileCountMultiExpr( %filePatterns ) );   @endtsexample   @see findFirstFileMultiExpr()   @see findNextFileMultiExpr()	@ingroup FileSearches)
/// </summary>
public  int getFileCountMultiExpr(string pattern, bool recurse = true){


return m_ts.fn_getFileCountMultiExpr(pattern, recurse);
}
/// <summary>
/// @brief Provides the CRC checksum of the given file.      @param fileName The path to the file.   @return The calculated CRC checksum of the file, or -1 if the file    could not be found.      @ingroup FileSystem)
/// </summary>
public  int getFileCRC(string fileName){


return m_ts.fn_getFileCRC(fileName);
}
/// <summary>
/// @brief .)
/// </summary>
public  Point4F getFrustumOffset(){


return new Point4F ( m_ts.fn_getFrustumOffset());
}
/// <summary>
/// (string funcName) 	@brief Provides the name of the package the function belongs to	@param funcName String containing name of the function	@return The name of the function's package	@ingroup Packages)
/// </summary>
public  string getFunctionPackage(string funcName){


return m_ts.fn_getFunctionPackage(funcName);
}
/// <summary>
/// getJoystickAxes( instance ))
/// </summary>
public  string getJoystickAxes(uint deviceID){


return m_ts.fn_getJoystickAxes(deviceID);
}
/// <summary>
/// Returns a tab seperated list of light manager names.   @ingroup Lighting )
/// </summary>
public  string getLightManagerNames(){


return m_ts.fn_getLightManagerNames();
}
/// <summary>
/// @brief Get the absolute path to the directory that contains the main.cs script from which the engine was started.   This directory will usually contain all the game assets and, in a user-side game installation, will usually be    read-only.   @return The path to the main game assets.   @ingroup FileSystem)
/// </summary>
public  string getMainDotCsDir(){


return m_ts.fn_getMainDotCsDir();
}
/// <summary>
/// @hide)
/// </summary>
public  string getMapEntry(string texName){


return m_ts.fn_getMapEntry(texName);
}
/// <summary>
/// (string texName)   @brief Returns the name of the material mapped to this texture.   If no materials are found, an empty string is returned.   @param texName Name of the texture   @ingroup Materials)
/// </summary>
public  string getMaterialMapping(string texName){


return m_ts.fn_getMaterialMapping(texName);
}
/// <summary>
/// Calculate the greater of two specified numbers.    @param v1 Input value.    @param v2 Input value.    @returns The greater value of the two specified values.    @ingroup Math )
/// </summary>
public  float getMax(float v1, float v2){


return m_ts.fn_getMax(v1, v2);
}
/// <summary>
/// getMaxFrameAllocation(); )
/// </summary>
public  int getMaxFrameAllocation(){


return m_ts.fn_getMaxFrameAllocation();
}
/// <summary>
/// (string namespace, string method) 	@brief Provides the name of the package the method belongs to	@param namespace Class or namespace, such as Player	@param method Name of the funciton to search for	@return The name of the method's package	@ingroup Packages)
/// </summary>
public  string getMethodPackage(string nameSpace, string method){


return m_ts.fn_getMethodPackage(nameSpace, method);
}
/// <summary>
/// Calculate the lesser of two specified numbers.    @param v1 Input value.    @param v2 Input value.    @returns The lesser value of the two specified values.    @ingroup Math )
/// </summary>
public  float getMin(float v1, float v2){


return m_ts.fn_getMin(v1, v2);
}
/// <summary>
/// Get the MissionArea object, if any.					 @ingroup enviroMisc)
/// </summary>
public  string getMissionAreaServerObject(){


return m_ts.fn_getMissionAreaServerObject();
}
/// <summary>
/// (string path) 				@brief Attempts to extract a mod directory from path. Returns empty string on failure.				@param File path of mod folder				@note This is no longer relevant in Torque 3D (which does not use mod folders), should be deprecated				@internal)
/// </summary>
public  string getModNameFromPath(string path){


return m_ts.fn_getModNameFromPath(path);
}
/// <summary>
/// @brief Get the EventManager object for all NavMesh updates.)
/// 
/// </summary>
public  int getNavMeshEventManager(){


return m_ts.fn_getNavMeshEventManager();
}
/// <summary>
/// @brief Returns a space delimited list of the active packages in stack order.
///    @ingroup Packages)
/// 
/// </summary>
public  string getPackageList(){


return m_ts.fn_getPackageList();
}
/// <summary>
/// Returns the pixel shader version for the active device.   @ingroup GFX )
/// </summary>
public  float getPixelShaderVersion(){


return m_ts.fn_getPixelShaderVersion();
}
/// <summary>
/// ([relativeFileName]) 				@note Appears to be useless in Torque 3D, should be deprecated				@internal)
/// </summary>
public  string getPrefsPath(string relativeFileName){


return m_ts.fn_getPrefsPath(relativeFileName);
}
/// <summary>
/// ( int a, int b )    @brief Returns a random number based on parameters passed in..   If no parameters are passed in, getRandom() will return a float between 0.0 and 1.0. If one    parameter is passed an integer between 0 and the passed in value will be returned. Two parameters will    return an integer between the specified numbers.   @param a If this is the only parameter, a number between 0 and a is returned. Elsewise represents the lower bound.   @param b Upper bound on the random number.  The random number will be = @a b.   @return A pseudo-random integer between @a a and @a b, between 0 and a, or a    float between 0.0 and 1.1 depending on usage.   @note All parameters are optional.   @see setRandomSeed   @ingroup Random )
/// </summary>
public  float getRandom(int a = 1, int b = 0){


return m_ts.fn_getRandom(a, b);
}
/// <summary>
/// Get the current seed used by the random number generator.   @return The current random number generator seed value.   @ingroup Random )
/// </summary>
public  int getRandomSeed(){


return m_ts.fn_getRandomSeed();
}
/// <summary>
/// () 				@brief Return the current real time in milliseconds.                Real time is platform defined; typically time since the computer booted.				@ingroup Platform)
/// </summary>
public  int getRealTime(){


return m_ts.fn_getRealTime();
}
/// <summary>
/// Extract the record at the given @a index in the newline-separated list in @a text.   Records in @a text must be separated by newlines.   @param text A list of records separated by newlines.   @param index The zero-based index of the record to extract.   @return The record at the given index or \"\" if @a index is out of range.   @tsexample      getRecord( \"a b\" NL \"c d\" NL \"e f\", 1 ) // Returns \"c d\"   @endtsexample   @see getRecords   @see getRecordCount   @see getWord   @see getField   @ingroup FieldManip )
/// </summary>
public  string getRecord(string text, int index){


return m_ts.fn_getRecord(text, index);
}
/// <summary>
/// Return the number of newline-separated records in @a text.   @param text A list of records separated by newlines.   @return The number of newline-sepearated elements in @a text.   @tsexample      getRecordCount( \"a b\" NL \"c d\" NL \"e f\" ) // Returns 3   @endtsexample   @see getWordCount   @see getFieldCount   @ingroup FieldManip )
/// </summary>
public  int getRecordCount(string text){


return m_ts.fn_getRecordCount(text);
}
/// <summary>
/// Extract a range of records from the given @a startIndex onwards thru @a endIndex.   Records in @a text must be separated by newlines.   @param text A list of records separated by newlines.   @param startIndex The zero-based index of the first record to extract from @a text.   @param endIndex The zero-based index of the last record to extract from @a text.  If this is -1, all records beginning       with @a startIndex are extracted from @a text.   @return A string containing the specified range of records from @a text or \"\" if @a startIndex       is out of range or greater than @a endIndex.   @tsexample      getRecords( \"a b\" NL \"c d\" NL \"e f\", 1 ) // Returns \"c d\" NL \"e f\"   @endtsexample   @see getRecord   @see getRecordCount   @see getWords   @see getFields   @ingroup FieldManip )
/// </summary>
public  string getRecords(string text, int startIndex, int endIndex = -1){


return m_ts.fn_getRecords(text, startIndex, endIndex);
}
/// <summary>
/// getScheduleDuration(%scheduleId); )
/// </summary>
public  int getScheduleDuration(int scheduleId){


return m_ts.fn_getScheduleDuration(scheduleId);
}
/// <summary>
/// getServerCount(...); )
/// </summary>
public  int getServerCount(){


return m_ts.fn_getServerCount();
}
/// <summary>
/// () 				Return the current sim time in milliseconds.                @brief Sim time is time since the game started.				@ingroup Platform)
/// </summary>
public  int getSimTime(){


return m_ts.fn_getSimTime();
}
/// <summary>
/// @brief Return a substring of @a str starting at @a start and continuing either through to the end of @a str    (if @a numChars is -1) or for @a numChars characters (except if this would exceed the actual source    string length).   @param str The string from which to extract a substring.   @param start The offset at which to start copying out characters.   @param numChars Optional argument to specify the number of characters to copy.  If this is -1, all characters up the end       of the input string are copied.   @return A string that contains the given portion of the input string.   @tsexample   getSubStr( \"foobar\", 1, 2 ) // Returns \"oo\".   @endtsexample   @ingroup Strings )
/// </summary>
public  string getSubStr(string str, int start, int numChars = -1){


return m_ts.fn_getSubStr(str, start, numChars);
}
/// <summary>
/// ( string textTagString )    @brief Extracts the tag from a tagged string   Should only be used within the context of a function that receives a tagged    string, and is not meant to be used outside of this context.   @param textTagString The tagged string to extract.   @returns The tag ID of the string.   @see \\ref syntaxDataTypes under Tagged %Strings   @see detag()   @ingroup Networking)
/// </summary>
public  string getTag(string textTagString){


return m_ts.fn_getTag(textTagString);
}
/// <summary>
/// ),   @brief Use the getTaggedString function to convert a tag to a string.   This is not the same as detag() which can only be used within the context    of a function that receives a tag. This function can be used any time and    anywhere to convert a tag to a string.   @param tag A numeric tag ID.   @returns The string as found in the Net String table.   @see \\ref syntaxDataTypes under Tagged %Strings   @see addTaggedString()   @see removeTaggedString()   @ingroup Networking)	
/// </summary>
public  string getTaggedString(string tag = ""){


return m_ts.fn_getTaggedString(tag);
}
/// <summary>
/// @brief Returns the OS temporary directory, \"C:/Users/Mich/AppData/Local/Temp\" for example				@note This can be useful to adhering to OS standards and practices, 				but not really used in Torque 3D right now.				@note Be very careful when getting into OS level File I/O.				@return String containing path to OS temp directory				@note This is legacy function brought over from TGB, and does not appear 				to have much use. Possibly deprecate?				@ingroup FileSystem				@internal)
/// </summary>
public  string getTemporaryDirectory(){


return m_ts.fn_getTemporaryDirectory();
}
/// <summary>
/// @brief Creates a name and extension for a potential temporary file				This does not create the actual file. It simply creates a random name 				for a file that does not exist.				@note This is legacy function brought over from TGB, and does not appear 				to have much use. Possibly deprecate?				@ingroup FileSystem				@internal)
/// </summary>
public  string getTemporaryFileName(){


return m_ts.fn_getTemporaryFileName();
}
/// <summary>
/// (Point2 pos) - gets the terrain height at the specified position.				@param pos The world space point, minus the z (height) value Can be formatted as either (\"x y\") or (x,y)				@return Returns the terrain height at the given point as an F32 value.				@hide)
/// </summary>
public  float getTerrainHeight(Point2F pos){


return m_ts.fn_getTerrainHeight(pos.AsString());
}
/// <summary>
/// (Point3F pos) - gets the terrain height at the specified position.				@param pos The world space point. Can be formatted as either (\"x y z\") or (x,y,z)				@note This function is useful if you simply want to grab the terrain height underneath an object.				@return Returns the terrain height at the given point as an F32 value.				@hide)
/// </summary>
public  float getTerrainHeightBelowPosition(Point3F pos){


return m_ts.fn_getTerrainHeightBelowPosition(pos.AsString());
}
/// <summary>
/// (Point3F x/y/z) Gets the terrain block that is located under the given world point.                                                      @param x/y/z The world coordinates (floating point values) you wish to query at.                                                        These can be formatted as either a string (\"x y z\") or separately as (x, y, z)                                                      @return Returns the ID of the requested terrain block (0 if not found).													  @hide)
/// </summary>
public  int getTerrainUnderWorldPoint(Point3F position){


return m_ts.fn_getTerrainUnderWorldPoint(position.AsString());
}
/// <summary>
/// Returns a list of texture profiles in the format: ProfileName TextureCount TextureMB   @ingroup GFX )
/// </summary>
public  string getTextureProfileStats(){


return m_ts.fn_getTextureProfileStats();
}
/// <summary>
/// getTimeSinceStart(%scheduleId); )
/// </summary>
public  int getTimeSinceStart(int scheduleId){


return m_ts.fn_getTimeSinceStart(scheduleId);
}
/// <summary>
/// Get the numeric suffix of the given input string.   @param str The string from which to read out the numeric suffix.   @return The numeric value of the number suffix of @a str or -1 if @a str has no such suffix.   @tsexample   getTrailingNumber( \"test123\" ) // Returns '123'.   @endtsexample   @see stripTrailingNumber   @ingroup Strings )
/// </summary>
public  int getTrailingNumber(string str){


return m_ts.fn_getTrailingNumber(str);
}
/// <summary>
/// ( String baseName, SimSet set, bool searchChildren )   @brief Returns a unique unused internal name within the SimSet/Group based on a given base name.   @note Currently only used by editors   @ingroup Editors   @internal)
/// </summary>
public  string getUniqueInternalName(string baseName, string setString, bool searchChildren){


return m_ts.fn_getUniqueInternalName(baseName, setString, searchChildren);
}
/// <summary>
/// ( String baseName )	@brief Returns a unique unused SimObject name based on a given base name.	@baseName Name to conver to a unique string if another instance exists	@note Currently only used by editors	@ingroup Editors	@internal)
/// </summary>
public  string getUniqueName(string baseName){


return m_ts.fn_getUniqueName(baseName);
}
/// <summary>
/// getUserDataDirectory())
/// </summary>
public  string getUserDataDirectory(){


return m_ts.fn_getUserDataDirectory();
}
/// <summary>
/// getUserHomeDirectory())
/// </summary>
public  string getUserHomeDirectory(){


return m_ts.fn_getUserHomeDirectory();
}
/// <summary>
/// (string varName)    @brief Returns the value of the named variable or an empty string if not found.   @varName Name of the variable to search for   @return Value contained by varName, \"\" if the variable does not exist   @ingroup Scripting)
/// </summary>
public  string getVariable(string varName){


return m_ts.fn_getVariable(varName);
}
/// <summary>
/// Get the version of the engine build, as a string. 				@ingroup Debugging)
/// </summary>
public  int getVersionNumber(){


return m_ts.fn_getVersionNumber();
}
/// <summary>
/// Get the version of the engine build, as a human readable string. 				@ingroup Debugging)
/// </summary>
public  string getVersionString(){


return m_ts.fn_getVersionString();
}
/// <summary>
/// Test whether Torque is running in web-deployment mode.   In this mode, Torque will usually run within a browser and certain restrictions apply (e.g. Torque will not    be able to enter fullscreen exclusive mode).   @return True if Torque is running in web-deployment mode.   @ingroup Platform )
/// </summary>
public  bool getWebDeployment(){


return m_ts.fn_getWebDeployment();
}
/// <summary>
/// Extract the word at the given @a index in the whitespace-separated list in @a text.   Words in @a text must be separated by newlines, spaces, and/or tabs.   @param text A whitespace-separated list of words.   @param index The zero-based index of the word to extract.   @return The word at the given index or \"\" if the index is out of range.   @tsexample      getWord( \"a b c\", 1 ) // Returns \"b\"   @endtsexample   @see getWords   @see getWordCount   @see getField   @see getRecord   @ingroup FieldManip )
/// </summary>
public  string getWord(string text, int index){


return m_ts.fn_getWord(text, index);
}
/// <summary>
/// Return the number of whitespace-separated words in @a text.   Words in @a text must be separated by newlines, spaces, and/or tabs.   @param text A whitespace-separated list of words.   @return The number of whitespace-separated words in @a text.   @tsexample      getWordCount( \"a b c d e\" ) // Returns 5   @endtsexample   @see getFieldCount   @see getRecordCount   @ingroup FieldManip )
/// </summary>
public  int getWordCount(string text){


return m_ts.fn_getWordCount(text);
}
/// <summary>
/// Extract a range of words from the given @a startIndex onwards thru @a endIndex.   Words in @a text must be separated by newlines, spaces, and/or tabs.   @param text A whitespace-separated list of words.   @param startIndex The zero-based index of the first word to extract from @a text.   @param endIndex The zero-based index of the last word to extract from @a text.  If this is -1, all words beginning       with @a startIndex are extracted from @a text.   @return A string containing the specified range of words from @a text or \"\" if @a startIndex       is out of range or greater than @a endIndex.   @tsexample      getWords( \"a b c d\", 1, 2, ) // Returns \"b c\"   @endtsexample   @see getWord   @see getWordCount   @see getFields   @see getRecords   @ingroup FieldManip )
/// </summary>
public  string getWords(string text, int startIndex, int endIndex = -1){


return m_ts.fn_getWords(text, startIndex, endIndex);
}
/// <summary>
/// @brief Reports the current directory	@return String containing full file path of working directory	@ingroup FileSystem)
/// </summary>
public  string getWorkingDirectory(){


return m_ts.fn_getWorkingDirectory();
}
/// <summary>
/// ( int controllerID, string property, bool currentD )				@brief Queries the current state of a connected Xbox 360 controller.            XInput Properties:             - XI_THUMBLX, XI_THUMBLY - X and Y axes of the left thumbstick.              - XI_THUMBRX, XI_THUMBRY - X and Y axes of the right thumbstick.              - XI_LEFT_TRIGGER, XI_RIGHT_TRIGGER - Left and Right triggers.              - SI_UPOV, SI_DPOV, SI_LPOV, SI_RPOV - Up, Down, Left, and Right on the directional pad.             - XI_START, XI_BACK - The Start and Back buttons.             - XI_LEFT_THUMB, XI_RIGHT_THUMB - Clicking in the left and right thumbstick.             - XI_LEFT_SHOULDER, XI_RIGHT_SHOULDER - Left and Right bumpers.             - XI_A, XI_B , XI_X, XI_Y - The A, B, X, and Y buttons.            @param controllerID Zero-based index of the controller to return information about.            @param property Name of input action being queried, such as \"XI_THUMBLX\".            @param current True checks current device in action.            @return Button queried - 1 if the button is pressed, 0 if it's not.            @return Thumbstick queried - Int representing displacement from rest position.            @return %Trigger queried - Int from 0 to 255 representing how far the trigger is displaced.            @ingroup Input)
/// </summary>
public  int getXInputState(int controllerID, string properties, bool current = false){


return m_ts.fn_getXInputState(controllerID, properties, current);
}
/// <summary>
/// Open the given URL or file in the user's web browser.   @param address The address to open.  If this is not prefixed by a protocol specifier (\"...://\"), then       the function checks whether the address refers to a file or directory and if so, prepends \"file://\"       to @a adress; if the file check fails, \"http://\" is prepended to @a address.   @tsexample      gotoWebPage( \"http://www.garagegames.com\" );   @endtsexample   @ingroup Platform )
/// </summary>
public  void gotoWebPage(string address){


m_ts.fn_gotoWebPage(address);
}
/// <summary>
/// Import an image strip from exportCachedFont. Call with the    same parameters you called exportCachedFont.   @param faceName The name of the font face.   @param fontSize The size of the font in pixels.   @param fileName The file name and path for the input PNG.   @param padding The padding between characters.      @param kerning The kerning between characters.      @ingroup Font )
/// </summary>
public  void importCachedFont(string faceName, int fontSize, string fileName, int padding, int kerning){


m_ts.fn_importCachedFont(faceName, fontSize, fileName, padding, kerning);
}
/// <summary>
/// @brief Start a search for items at the given position and within the given radius, filtering by mask.   @param pos Center position for the search   @param radius Search radius   @param mask Bitmask of object types to include in the search   @param useClientContainer Optionally indicates the search should be within the    client container.   @see containerSearchNext    @ingroup Game)
/// </summary>
public  void initContainerRadiusSearch(Point3F pos, float radius, uint mask, bool useClientContainer = false){


m_ts.fn_initContainerRadiusSearch(pos.AsString(), radius, mask, useClientContainer);
}
/// <summary>
/// @brief Start a search for all items of the types specified by the bitset mask.   @param mask Bitmask of object types to include in the search   @param useClientContainer Optionally indicates the search should be within the    client container.   @see containerSearchNext    @ingroup Game)
/// </summary>
public  void initContainerTypeSearch(uint mask, bool useClientContainer = false){


m_ts.fn_initContainerTypeSearch(mask, useClientContainer);
}
/// <summary>
/// ()				@brief Initializes variables that track device and vendor information/IDs				@ingroup Rendering)
/// </summary>
public  void initDisplayDeviceInfo(){


m_ts.fn_initDisplayDeviceInfo();
}
/// <summary>
/// Test whether the character at the given position is an alpha-numeric character.   Alpha-numeric characters are characters that are either alphabetic (a-z, A-Z) or numbers (0-9).   @param str The string to test.   @param index The index of a character in @a str.   @return True if the character at the given index in @a str is an alpha-numeric character; false otherwise.   @see isspace   @ingroup Strings )
/// </summary>
public  bool isalnum(string str, int index){


return m_ts.fn_isalnum(str, index);
}
/// <summary>
/// @brief Returns true if the passed identifier is the name of a declared class.				@ingroup Console)
/// </summary>
public  bool isClass(string identifier){


return m_ts.fn_isClass(identifier);
}
/// <summary>
/// ()    Returns true if the calling script is a tools script.   @hide)
/// </summary>
public  bool isCurrentScriptToolScript(){


return m_ts.fn_isCurrentScriptToolScript();
}
/// <summary>
/// Test whether the engine has been compiled with TORQUE_DEBUG, i.e. if it includes debugging functionality.   @return True if this is a debug build; false otherwise.   @ingroup Platform )
/// </summary>
public  bool isDebugBuild(){


return m_ts.fn_isDebugBuild();
}
/// <summary>
/// ) , (string varName) 	@brief Determines if a variable exists and contains a value	@param varName Name of the variable to search for	@return True if the variable was defined in script, false if not   @tsexample      isDefined( \"$myVar\" );   @endtsexample	@ingroup Scripting)
/// </summary>
public  bool isDefined(string varName, string varValue = ""){


return m_ts.fn_isDefined(varName, varValue);
}
/// <summary>
/// )
/// </summary>
public  bool isDemo(){


return m_ts.fn_isDemo();
}
/// <summary>
/// @brief Determines if a specified directory exists or not	@param directory String containing path in the form of \"foo/bar\"   @return Returns true if the directory was found.	@note Do not include a trailing slash '/'.	@ingroup FileSystem)
/// </summary>
public  bool IsDirectory(string directory){


return m_ts.fn_IsDirectory(directory);
}
/// <summary>
/// isEventPending(%scheduleId);)
/// </summary>
public  bool isEventPending(int scheduleId){


return m_ts.fn_isEventPending(scheduleId);
}
/// <summary>
/// @brief Determines if the specified file exists or not      @param fileName The path to the file.   @return Returns true if the file was found.      @ingroup FileSystem)
/// </summary>
public  bool isFile(string fileName){


return m_ts.fn_isFile(fileName);
}
/// <summary>
/// (string funcName) 	@brief Determines if a function exists or not	@param funcName String containing name of the function	@return True if the function exists, false if not	@ingroup Scripting)
/// </summary>
public  bool isFunction(string funcName){


return m_ts.fn_isFunction(funcName);
}
/// <summary>
/// isJoystickDetected())
/// </summary>
public  bool isJoystickDetected(){


return m_ts.fn_isJoystickDetected();
}
/// <summary>
/// ()				@brief Queries input manager to see if a joystick is enabled				@return 1 if a joystick exists and is enabled, 0 if it's not.				@ingroup Input)
/// </summary>
public  bool isJoystickEnabled(){


return m_ts.fn_isJoystickEnabled();
}
/// <summary>
/// isKoreanBuild())
/// </summary>
public  bool isKoreanBuild(){


return m_ts.fn_isKoreanBuild();
}
/// <summary>
/// @brief Returns true if the class is derived from the super class.   If either class doesn't exist this returns false.   @param className The class name.   @param superClassName The super class to look for.   @ingroup Console)
/// </summary>
public  bool isMemberOfClass(string className, string superClassName){


return m_ts.fn_isMemberOfClass(className, superClassName);
}
/// <summary>
/// (string namespace, string method) 	@brief Determines if a class/namespace method exists	@param namespace Class or namespace, such as Player	@param method Name of the function to search for	@return True if the method exists, false if not	@ingroup Scripting)
/// </summary>
public  bool isMethod(string nameSpace, string method){


return m_ts.fn_isMethod(nameSpace, method);
}
/// <summary>
/// isObject(object))
/// </summary>
public  bool isObject(string objectName){


return m_ts.fn_isObject(objectName);
}
/// <summary>
/// @brief Returns true if the identifier is the name of a declared package.
///    @ingroup Packages)
/// 
/// </summary>
public  bool isPackage(string identifier){


return m_ts.fn_isPackage(identifier);
}
/// <summary>
/// (string queueName)				@brief Determines if a dispatcher queue exists				@param queueName String containing the name of queue				@ingroup Messaging)
/// </summary>
public  bool isQueueRegistered(string queueName){


return m_ts.fn_isQueueRegistered(queueName);
}
/// <summary>
/// Test whether the engine has been compiled with TORQUE_SHIPPING, i.e. in a form meant for final release.   @return True if this is a shipping build; false otherwise.   @ingroup Platform )
/// </summary>
public  bool isShippingBuild(){


return m_ts.fn_isShippingBuild();
}
/// <summary>
/// Test whether the character at the given position is a whitespace character.   Characters such as tab, space, or newline are considered whitespace.   @param str The string to test.   @param index The index of a character in @a str.   @return True if the character at the given index in @a str is a whitespace character; false otherwise.   @see isalnum   @ingroup Strings )
/// </summary>
public  bool isspace(string str, int index){


return m_ts.fn_isspace(str, index);
}
/// <summary>
/// Test whether the engine has been compiled with TORQUE_TOOLS, i.e. if it includes tool-related functionality.   @return True if this is a tool build; false otherwise.   @ingroup Platform )
/// </summary>
public  bool isToolBuild(){


return m_ts.fn_isToolBuild();
}
/// <summary>
/// ( string name )				@brief Return true if the given name makes for a valid object name.				@param name Name of object				@return True if name is allowed, false if denied (usually because it starts with a number, _, or invalid character				@ingroup Console)
/// </summary>
public  bool isValidObjectName(string name){


return m_ts.fn_isValidObjectName(name);
}
/// <summary>
/// )
/// </summary>
public  bool isWebDemo(){


return m_ts.fn_isWebDemo();
}
/// <summary>
/// @brief Determines if a file name can be written to using File I/O	@param fileName Name and path of file to check	@return Returns true if the file can be written to.	@ingroup FileSystem)
/// </summary>
public  bool isWriteableFileName(string fileName){


return m_ts.fn_isWriteableFileName(fileName);
}
/// <summary>
/// ( int controllerID )				@brief Checks to see if an Xbox 360 controller is connected				@param controllerID Zero-based index of the controller to check.            @return 1 if the controller is connected, 0 if it isn't, and 205 if XInput             hasn't been initialized.				@ingroup Input)
/// </summary>
public  bool isXInputConnected(int controllerID){


return m_ts.fn_isXInputConnected(controllerID);
}
/// <summary>
/// Will generate static lighting for the scene if supported by the active light manager.   If mode is \"forceAlways\", the lightmaps will be regenerated regardless of whether    lighting cache files can be written to. If mode is \"forceWritable\", then the lightmaps    will be regenerated only if the lighting cache files can be written.   @param completeCallbackFn The name of the function to execute when the lighting is complete.   @param mode One of \"forceAlways\",  \"forceWritable\" or \"loadOnly\".   @return Returns true if the scene lighting process was started.   @ingroup Lighting )
/// </summary>
public  bool lightScene(string completeCallbackFn = null , string mode = null ){
if (completeCallbackFn== null) {completeCallbackFn = null;}
if (mode== null) {mode = null;}


return m_ts.fn_lightScene(completeCallbackFn, mode);
}
/// <summary>
/// Returns a list of the unflagged GFX resources. See flagCurrentGFXResources for usage details.   @ingroup GFX   @see flagCurrentGFXResources, clearGFXResourceFlags, describeGFXResources )
/// </summary>
public  void listGFXResources(bool unflaggedOnly = false){


m_ts.fn_listGFXResources(unflaggedOnly);
}
/// <summary>
/// , ),    (string filename, SimGroup parentGroup=MissionGroup, SimObject baseObject=-1)   Load all light instances from a COLLADA (.dae) file and add to the scene.   @param filename COLLADA filename to load lights from   @param parentGroup (optional) name of an existing simgroup to add the new    lights to (defaults to MissionGroup)   @param baseObject (optional) name of an object to use as the origin (useful    if you are loading the lights for a collada scene and have moved or rotated    the geometry)   @return true if successful, false otherwise   @tsexample   // load the lights in room.dae   loadColladaLights( \"art/shapes/collada/room.dae\" );   // load the lights in room.dae and add them to the RoomLights group   loadColladaLights( \"art/shapes/collada/room.dae\", \"RoomLights\" );   // load the lights in room.dae and use the transform of the \"Room\"   object as the origin   loadColladaLights( \"art/shapes/collada/room.dae\", \"\", \"Room\" );   @endtsexample   @note Currently for editor use only   @ingroup Editors   @internal)
/// </summary>
public  bool loadColladaLights(string filename, string parentGroup = "", string baseObject = ""){


return m_ts.fn_loadColladaLights(filename, parentGroup, baseObject);
}
/// <summary>
/// @brief Loads a serialized object from a file.				@param Name and path to text file containing the object				@ingroup Console)
/// </summary>
public  string loadObject(string filename){


return m_ts.fn_loadObject(filename);
}
/// <summary>
/// (bool isLocked)             @brief Lock or unlock the mouse to the window.            When true, prevents the mouse from leaving the bounds of the game window.            @ingroup Input)
/// </summary>
public  void lockMouse(bool isLocked){


m_ts.fn_lockMouse(isLocked);
}
/// <summary>
/// @brief Logs a message to the console.
///    @param message The message text.
///    @note By default, messages will appear white in the console.
///    @ingroup Logging)
/// 
/// </summary>
public  void log(string message){


m_ts.fn_log(message);
}
/// <summary>
/// @brief Logs an error message to the console.
///    @param message The message text.
///    @note By default, errors will appear red in the console.
///    @ingroup Logging)
/// 
/// </summary>
public  void logError(string message){


m_ts.fn_logError(message);
}
/// <summary>
/// @brief Logs a warning message to the console.
///    @param message The message text.
///    @note By default, warnings will appear turquoise in the console.
///    @ingroup Logging)
/// 
/// </summary>
public  void logWarning(string message){


m_ts.fn_logWarning(message);
}
/// <summary>
/// Remove leading whitespace from the string.   @param str A string.   @return A string that is the same as @a str but with any leading (i.e. leftmost) whitespace removed.   @tsexample   ltrim( \"   string  \" ); // Returns \"string  \".   @endtsexample   @see rtrim   @see trim   @ingroup Strings )
/// </summary>
public  string ltrim(string str){


return m_ts.fn_ltrim(str);
}
/// <summary>
/// Return the value of 2*PI (full-circle in radians).    @returns The value of 2*PI.    @ingroup Math )
/// </summary>
public  float m2Pi(){


return m_ts.fn_m2Pi();
}
/// <summary>
/// Calculate absolute value of specified value.    @param v Input Value.    @returns Absolute value of specified value.    @ingroup Math )
/// </summary>
public  float mAbs(float v){


return m_ts.fn_mAbs(v);
}
/// <summary>
/// Calculate the arc-cosine of v.    @param v Input Value (in radians).    @returns The arc-cosine of the input value.    @ingroup Math )
/// </summary>
public  float mAcos(float v){


return m_ts.fn_mAcos(v);
}
/// <summary>
/// ),	@brief Converts a relative file path to a full path	For example, \"./console.log\" becomes \"C:/Torque/t3d/examples/FPS Example/game/console.log\"	@param path Name of file or path to check   @param cwd Optional current working directory from which to build the full path.	@return String containing non-relative directory of path	@ingroup FileSystem)
/// </summary>
public  string makeFullPath(string path, string cwd = ""){


return m_ts.fn_makeFullPath(path, cwd);
}
/// <summary>
/// ),	@brief Turns a full or local path to a relative one   For example, \"./game/art\" becomes \"game/art\"   @param path Full path (may include a file) to convert   @param to Optional base path used for the conversion.  If not supplied the current    working directory is used.	@returns String containing relative path	@ingroup FileSystem)
/// </summary>
public  string makeRelativePath(string path, string to = ""){


return m_ts.fn_makeRelativePath(path, to);
}
/// <summary>
/// Calculate the arc-sine of v.    @param v Input Value (in radians).    @returns The arc-sine of the input value.    @ingroup Math )
/// </summary>
public  float mAsin(float v){


return m_ts.fn_mAsin(v);
}
/// <summary>
/// Calculate the arc-tangent (slope) of a line defined by rise and run.    @param rise of line.    @param run of line.    @returns The arc-tangent (slope) of a line defined by rise and run.    @ingroup Math )
/// </summary>
public  float mAtan(float rise, float run){


return m_ts.fn_mAtan(rise, run);
}
/// <summary>
/// Create a transform from the given translation and orientation.   @param position The translation vector for the transform.   @param orientation The axis and rotation that orients the transform.   @return A transform based on the given position and orientation.   @ingroup Matrices )
/// </summary>
public  TransformF MatrixCreate(Point3F position, AngAxisF orientation){


return new TransformF ( m_ts.fn_MatrixCreate(position.AsString(), orientation.AsString()));
}
/// <summary>
/// @Create a matrix from the given rotations.   @param Vector3F X, Y, and Z rotation in *radians*.   @return A transform based on the given orientation.   @ingroup Matrices )
/// </summary>
public  TransformF MatrixCreateFromEuler(Point3F angles){


return new TransformF ( m_ts.fn_MatrixCreateFromEuler(angles.AsString()));
}
/// <summary>
/// @brief Multiply the given point by the given transform assuming that w=1.   This function will multiply the given vector such that translation with take effect.   @param transform A transform.   @param point A vector.   @return The transformed vector.   @ingroup Matrices)
/// </summary>
public  Point3F MatrixMulPoint(TransformF transform, Point3F point){


return new Point3F ( m_ts.fn_MatrixMulPoint(transform.AsString(), point.AsString()));
}
/// <summary>
/// @brief Multiply the two matrices.   @param left First transform.   @param right Right transform.   @return Concatenation of the two transforms.   @ingroup Matrices )
/// </summary>
public  TransformF MatrixMultiply(TransformF left, TransformF right){


return new TransformF ( m_ts.fn_MatrixMultiply(left.AsString(), right.AsString()));
}
/// <summary>
/// @brief Multiply the vector by the transform assuming that w=0.   This function will multiply the given vector by the given transform such that translation will    not affect the vector.   @param transform A transform.   @param vector A vector.   @return The transformed vector.   @ingroup Matrices)
/// </summary>
public  Point3F MatrixMulVector(TransformF transform, Point3F vector){


return new Point3F ( m_ts.fn_MatrixMulVector(transform.AsString(), vector.AsString()));
}
/// <summary>
/// Round v up to the nearest integer.    @param v Number to convert to integer.    @returns Number converted to integer.    @ingroup Math )
/// </summary>
public  int mCeil(float v){


return m_ts.fn_mCeil(v);
}
/// <summary>
/// Clamp the specified value between two bounds.    @param v Input value.    @param min Minimum Bound.    @param max Maximum Bound.    @returns The specified value clamped to the specified bounds.    @ingroup Math )
/// </summary>
public  float mClamp(float v, float min, float max){


return m_ts.fn_mClamp(v, min, max);
}
/// <summary>
/// Calculate the cosine of v.    @param v Input Value (in radians).    @returns The cosine of the input value.    @ingroup Math )
/// </summary>
public  float mCos(float v){


return m_ts.fn_mCos(v);
}
/// <summary>
/// Convert specified degrees into radians.    @param degrees Input Value (in degrees).    @returns The specified degrees value converted to radians.    @ingroup Math )
/// </summary>
public  float mDegToRad(float degrees){


return m_ts.fn_mDegToRad(degrees);
}
/// <summary>
/// Display a modal message box using the platform's native message box implementation.   @param title The title to display on the message box window.   @param message The text message to display in the box.   @param buttons Which buttons to put on the message box.   @param icons Which icon to show next to the message.   @return One of $MROK, $MRCancel, $MRRetry, and $MRDontSave identifying the button that the user pressed.   @tsexample      messageBox( \"Error\", \"\" );    @endtsexample   @ingroup Platform )
/// </summary>
public  int messageBox(string title, string message, TypeMBButtons buttons = null , TypeMBIcons icons = null ){
if (buttons== null) {buttons = 1;}
if (icons== null) {icons = 1;}


return m_ts.fn_messageBox(title, message, (int)buttons , (int)icons );
}
/// <summary>
/// Formats the specified number to the given number of decimal places.    @param v Number to format.    @param precision Number of decimal places to format to (1-9).    @returns Number formatted to the specified number of decimal places.    @ingroup Math )
/// </summary>
public  string mFloatLength(float v, uint precision){


return m_ts.fn_mFloatLength(v, precision);
}
/// <summary>
/// Round v down to the nearest integer.    @param v Number to convert to integer.    @returns Number converted to integer.    @ingroup Math )
/// </summary>
public  int mFloor(float v){


return m_ts.fn_mFloor(v);
}
/// <summary>
/// Calculate the remainder of v/d.    @param v Input Value.    @param d Divisor Value.    @returns The remainder of v/d.    @ingroup Math )
/// </summary>
public  float mFMod(float v, float d){


return m_ts.fn_mFMod(v, d);
}
/// <summary>
/// Returns whether the value is an exact power of two.    @param v Input value.    @returns Whether the specified value is an exact power of two.    @ingroup Math )
/// </summary>
public  bool mIsPow2(int v){


return m_ts.fn_mIsPow2(v);
}
/// <summary>
/// Calculate linearly interpolated value between two specified numbers using specified normalized time.    @param v1 Interpolate From Input value.    @param v2 Interpolate To Input value.    @param time Normalized time used to interpolate values (0-1).    @returns The interpolated value between the two specified values at normalized time t.    @ingroup Math )
/// </summary>
public  float mLerp(float v1, float v2, float time){


return m_ts.fn_mLerp(v1, v2, time);
}
/// <summary>
/// Calculate the natural logarithm of v.    @param v Input Value.    @returns The natural logarithm of the input value.    @ingroup Math )
/// </summary>
public  float mLog(float v){


return m_ts.fn_mLog(v);
}
/// <summary>
/// Return the value of PI (half-circle in radians).    @returns The value of PI.    @ingroup Math )
/// </summary>
public  float mPi(){


return m_ts.fn_mPi();
}
/// <summary>
/// Calculate b raised to the p-th power.    @param v Input Value.    @param p Power to raise value by.    @returns v raised to the p-th power.    @ingroup Math )
/// </summary>
public  float mPow(float v, float p){


return m_ts.fn_mPow(v, p);
}
/// <summary>
/// Convert specified radians into degrees.    @param radians Input Value (in radians).    @returns The specified radians value converted to degrees.    @ingroup Math )
/// </summary>
public  float mRadToDeg(float radians){


return m_ts.fn_mRadToDeg(radians);
}
/// <summary>
/// Round v to the nth decimal place or the nearest whole number by default.      @param v Value to roundn      @param n Number of decimal places to round to, 0 by defaultn      @return The rounded value as a S32.      @ingroup Math )  
/// </summary>
public  float mRound(float v, int n = 0){


return m_ts.fn_mRound(v, n);
}
/// <summary>
/// Clamp the specified value between 0 and 1 (inclusive).    @param v Input value.    @returns The specified value clamped between 0 and 1 (inclusive).    @ingroup Math )
/// </summary>
public  float mSaturate(float v){


return m_ts.fn_mSaturate(v);
}
/// <summary>
/// Calculate the sine of v.    @param v Input Value (in radians).    @returns The sine of the input value.    @ingroup Math )
/// </summary>
public  float mSin(float v){


return m_ts.fn_mSin(v);
}
/// <summary>
/// Solve a cubic equation (3rd degree polynomial) of form a*x^3 + b*x^2 + c*x + d = 0.    @param a First Coefficient.    @param b Second Coefficient.    @param c Third Coefficient.    @param d Fourth Coefficient.    @returns A 4-tuple, containing: (sol x0 x1 x2). (sol) is the number of solutions    (being 0, 1, 2 or 3), and (x0), (x1) and (x2) are the solutions, if any.    @ingroup Math )
/// </summary>
public  string mSolveCubic(float a, float b, float c, float d){


return m_ts.fn_mSolveCubic(a, b, c, d);
}
/// <summary>
/// Solve a quadratic equation (2nd degree polynomial) of form a*x^2 + b*x + c = 0.    @param a First Coefficient.    @param b Second Coefficient.    @param c Third Coefficient.    @returns A triple, containing: (sol x0 x1). (sol) is the number of solutions    (being 0, 1, or 2), and (x0) and (x1) are the solutions, if any.    @ingroup Math )
/// </summary>
public  string mSolveQuadratic(float a, float b, float c){


return m_ts.fn_mSolveQuadratic(a, b, c);
}
/// <summary>
/// Solve a quartic equation (4th degree polynomial) of form a*x^4 + b*x^3 + c*x^2 + d*x + e = 0.    @param a First Coefficient.    @param b Second Coefficient.    @param c Third Coefficient.    @param d Fourth Coefficient.    @param e Fifth Coefficient.    @returns A 5-tuple, containing: (sol x0 x1 x2 c3). (sol) is the number of solutions    (being 0, 1, 2, 3 or 4), and (x0), (x1), (x2) and (x3) are the solutions, if any.    @ingroup Math )
/// </summary>
public  string mSolveQuartic(float a, float b, float c, float d, float e){


return m_ts.fn_mSolveQuartic(a, b, c, d, e);
}
/// <summary>
/// Calculate the square-root of v.    @param v Input Value.    @returns The square-root of the input value.    @ingroup Math )
/// </summary>
public  float mSqrt(float v){


return m_ts.fn_mSqrt(v);
}
/// <summary>
/// Calculate the tangent of v.    @param v Input Value (in radians).    @returns The tangent of the input value.    @ingroup Math )
/// </summary>
public  float mTan(float v){


return m_ts.fn_mTan(v);
}
/// <summary>
/// nameToID(object))
/// </summary>
public  int nameToID(string objectName){


return m_ts.fn_nameToID(objectName);
}
/// <summary>
/// ( string str, string token, string delimiters )    Tokenize a string using a set of delimiting characters.   This function first skips all leading charaters in @a str that are contained in @a delimiters.    From that position, it then scans for the next character in @a str that is contained in @a delimiters and stores all characters    from the starting position up to the first delimiter in a variable in the current scope called @a token.  Finally, it    skips all characters in @a delimiters after the token and then returns the remaining string contents in @a str.   To scan out all tokens in a string, call this function repeatedly by passing the result it returns each time as the new @a str    until the function returns \"\".   @param str A string.   @param token The name of the variable in which to store the current token.  This variable is set in the       scope in which nextToken is called.   @param delimiters A string of characters.  Each character is considered a delimiter.   @return The remainder of @a str after the token has been parsed out or \"\" if no more tokens were found in @a str.   @tsexample      // Prints:      // a      // b      // c      %str = \"a   b c\";      while ( %str !$= \"\" )      {         // First time, stores \"a\" in the variable %token and sets %str to \"b c\".         %str = nextToken( %str, \"token\", \" \" );         echo( %token );      }   @endtsexample   @ingroup Strings )
/// </summary>
public  string nextToken(string str, string token, string delim){


return m_ts.fn_nextToken(str, token, delim);
}
/// <summary>
/// @brief Open the given @a file through the system.  This will usually open the file in its    associated application.   @param file %Path of the file to open.   @note Only present in a Tools build of Torque.   @ingroup FileSystem)
/// </summary>
public  void openFile(string file){


m_ts.fn_openFile(file);
}
/// <summary>
/// @brief Open the given folder in the system's file manager.   @param path full path to a directory.   @note Only present in a Tools build of Torque.   @ingroup FileSystem)
/// </summary>
public  void openFolder(string path){


m_ts.fn_openFolder(path);
}
/// <summary>
/// @brief Combines two separate strings containing a file path and file name together into a single string	@param path String containing file path	@param file String containing file name	@return String containing concatenated file name and path	@ingroup FileSystem)
/// </summary>
public  string pathConcat(string path, string file){


return m_ts.fn_pathConcat(path, file);
}
/// <summary>
/// @brief Copy a file to a new location.   @param fromFile %Path of the file to copy.   @param toFile %Path where to copy @a fromFile to.   @param noOverwrite If true, then @a fromFile will not overwrite a file that may already exist at @a toFile.   @return True if the file was successfully copied, false otherwise.   @note Only present in a Tools build of Torque.   @ingroup FileSystem)
/// </summary>
public  bool pathCopy(string fromFile, string toFile, bool noOverwrite = true){


return m_ts.fn_pathCopy(fromFile, toFile, noOverwrite);
}
/// <summary>
/// @brief Load all Path information from the mission.   This function is usually called from the loadMissionStage2() server-side function    after the mission file has loaded.  Internally it places all Paths into the server's    PathManager.  From this point the Paths are ready for transmission to the clients.   @tsexample      // Inform the engine to load all Path information from the mission.      pathOnMissionLoadDone();   @endtsexample   @see NetConnection::transmitPaths()   @see NetConnection::clearPaths()   @see Path   @ingroup Networking)
/// </summary>
public  void pathOnMissionLoadDone(){


m_ts.fn_pathOnMissionLoadDone();
}
/// <summary>
/// physicsDebugDraw( bool enable ))
/// </summary>
public  void physicsDebugDraw(bool enable){


m_ts.fn_physicsDebugDraw(enable);
}
/// <summary>
/// physicsDestroy())
/// </summary>
public  void physicsDestroy(){


m_ts.fn_physicsDestroy();
}
/// <summary>
/// physicsDestroyWorld( String worldName ))
/// </summary>
public  void physicsDestroyWorld(string worldName){


m_ts.fn_physicsDestroyWorld(worldName);
}
/// <summary>
/// physicsGetTimeScale())
/// </summary>
public  float physicsGetTimeScale(){


return m_ts.fn_physicsGetTimeScale();
}
/// <summary>
/// ), physicsInit( [string library] ))
/// </summary>
public  bool physicsInit(string library = ""){


return m_ts.fn_physicsInit(library);
}
/// <summary>
/// physicsInitWorld( String worldName ))
/// </summary>
public  bool physicsInitWorld(string worldName){


return m_ts.fn_physicsInitWorld(worldName);
}
/// <summary>
/// physicsPluginPresent()   @brief Returns true if a physics plugin exists and is initialized.   @ingroup Physics )
/// </summary>
public  bool physicsPluginPresent(){


return m_ts.fn_physicsPluginPresent();
}
/// <summary>
/// physicsRestoreState())
/// </summary>
public  void physicsRestoreState(){


m_ts.fn_physicsRestoreState();
}
/// <summary>
/// physicsSetTimeScale( F32 scale ))
/// </summary>
public  void physicsSetTimeScale(float scale){


m_ts.fn_physicsSetTimeScale(scale);
}
/// <summary>
/// physicsStopSimulation( String worldName ))
/// </summary>
public  bool physicsSimulationEnabled(){


return m_ts.fn_physicsSimulationEnabled();
}
/// <summary>
/// physicsStartSimulation( String worldName ))
/// </summary>
public  void physicsStartSimulation(string worldName){


m_ts.fn_physicsStartSimulation(worldName);
}
/// <summary>
/// physicsStopSimulation( String worldName ))
/// </summary>
public  void physicsStopSimulation(string worldName){


m_ts.fn_physicsStopSimulation(worldName);
}
/// <summary>
/// physicsStoreState())
/// </summary>
public  void physicsStoreState(){


m_ts.fn_physicsStoreState();
}
/// <summary>
/// (string filename)                 @brief Begin playback of a journal from a specified field.				@param filename Name and path of file journal file				@ingroup Platform)
/// </summary>
public  void playJournal(string filename){


m_ts.fn_playJournal(filename);
}
/// <summary>
/// THEORA, 30.0f, Point2I::Zero ),   Load a journal file and capture it video.   @ingroup Rendering )
/// </summary>
public  void playJournalToVideo(string journalFile, string videoFile = null , string encoder = "THEORA", float framerate = 30.0f, Point2I resolution = null ){
if (videoFile== null) {videoFile = null;}
if (resolution== null) {resolution = new Point2I(0,0);}


m_ts.fn_playJournalToVideo(journalFile, videoFile, encoder, framerate, resolution.AsString());
}
/// <summary>
/// () 				@brief Pop and restore the last setting of $instantGroup off the stack.				@note Currently only used for editors				@ingroup Editors				@internal)
/// </summary>
public  void popInstantGroup(){


m_ts.fn_popInstantGroup();
}
/// <summary>
/// Populate the font cache for all fonts with Unicode code points in the specified range.   @param rangeStart The start Unicode point.   @param rangeEnd The end Unicode point.   @note We only support BMP-0, so code points range from 0 to 65535.   @ingroup Font )
/// </summary>
public  void populateAllFontCacheRange(uint rangeStart, uint rangeEnd){


m_ts.fn_populateAllFontCacheRange(rangeStart, rangeEnd);
}
/// <summary>
/// Populate the font cache for all fonts with characters from the specified string.   @ingroup Font )
/// </summary>
public  void populateAllFontCacheString(string stringx){


m_ts.fn_populateAllFontCacheString(stringx);
}
/// <summary>
/// Populate the font cache for the specified font with Unicode code points in the specified range.   @param faceName The name of the font face.   @param fontSize The size of the font in pixels.   @param rangeStart The start Unicode point.   @param rangeEnd The end Unicode point.   @note We only support BMP-0, so code points range from 0 to 65535.   @ingroup Font )
/// </summary>
public  void populateFontCacheRange(string faceName, int fontSize, uint rangeStart, uint rangeEnd){


m_ts.fn_populateFontCacheRange(faceName, fontSize, rangeStart, rangeEnd);
}
/// <summary>
/// Populate the font cache for the specified font with characters from the specified string.    @param faceName The name of the font face.    @param fontSize The size of the font in pixels.    @param string The string to populate.    @ingroup Font )
/// </summary>
public  void populateFontCacheString(string faceName, int fontSize, string stringx){


m_ts.fn_populateFontCacheString(faceName, fontSize, stringx);
}
/// <summary>
/// Preload all datablocks in client mode.   (Server parameter is set to false).  This will take some time to complete.)
/// </summary>
public  void preloadClientDataBlocks(){


m_ts.fn_preloadClientDataBlocks();
}
/// <summary>
/// @brief Dumps current profiling stats to the console window.				@note Markers disabled with profilerMarkerEnable() will be skipped over. 				If the profiler is currently running, it will be disabled.				@ingroup Debugging)
/// </summary>
public  void profilerDump(){


m_ts.fn_profilerDump();
}
/// <summary>
/// @brief Dumps current profiling stats to a file.				@note If the profiler is currently running, it will be disabled.				@param fileName Name and path of file to save profiling stats to. Must use forward slashes (/). 				Will attempt to create the file if it does not already exist.				@tsexample				profilerDumpToFile( \"C:/Torque/log1.txt\" );				@endtsexample				@ingroup Debugging )
/// </summary>
public  void profilerDumpToFile(string fileName){


m_ts.fn_profilerDumpToFile(fileName);
}
/// <summary>
/// @brief Enables or disables the profiler.				Data is only gathered while the profiler is enabled.				@note Profiler is not available in shipping builds.				T3D has predefined profiling areas surrounded by markers, 				but you may need to define additional markers (in C++) around areas you wish to profile,				 by using the PROFILE_START( markerName ); and PROFILE_END(); macros.				@ingroup Debugging )
/// </summary>
public  void profilerEnable(bool enable){


m_ts.fn_profilerEnable(enable);
}
/// <summary>
/// @brief Enable or disable a specific profile.   @param enable     Optional paramater to enable or disable the profile.   @param markerName Name of a specific marker to enable or disable.   @note Calling this function will first call profilerReset(), clearing all data from profiler.    All profile markers are enabled by default.   @ingroup Debugging)
/// </summary>
public  void profilerMarkerEnable(string markerName, bool enable = true){


m_ts.fn_profilerMarkerEnable(markerName, enable);
}
/// <summary>
/// @brief Resets the profiler, clearing it of all its data.				If the profiler is currently running, it will first be disabled. 				All markers will retain their current enabled/disabled status.				@ingroup Debugging )
/// </summary>
public  void profilerReset(){


m_ts.fn_profilerReset();
}
/// <summary>
/// ) , ([group]) 				@brief Pushes the current $instantGroup on a stack 				and sets it to the given value (or clears it).				@note Currently only used for editors				@ingroup Editors				@internal)
/// </summary>
public  void pushInstantGroup(string group = ""){


m_ts.fn_pushInstantGroup(group);
}
/// <summary>
/// queryAllServers(...); )
/// </summary>
public  void queryAllServers(uint lanPort, uint flags, string gameType, string missionType, uint minPlayers, uint maxPlayers, uint maxBots, uint regionMask, uint maxPing, uint minCPU, uint filterFlags){


m_ts.fn_queryAllServers(lanPort, flags, gameType, missionType, minPlayers, maxPlayers, maxBots, regionMask, maxPing, minCPU, filterFlags);
}
/// <summary>
/// queryLanServers(...); )
/// </summary>
public  void queryLanServers(uint lanPort, uint flags, string gameType, string missionType, uint minPlayers, uint maxPlayers, uint maxBots, uint regionMask, uint maxPing, uint minCPU, uint filterFlags){


m_ts.fn_queryLanServers(lanPort, flags, gameType, missionType, minPlayers, maxPlayers, maxBots, regionMask, maxPing, minCPU, filterFlags);
}
/// <summary>
/// queryMasterServer(...); )
/// </summary>
public  void queryMasterServer(uint lanPort, uint flags, string gameType, string missionType, uint minPlayers, uint maxPlayers, uint maxBots, uint regionMask, uint maxPing, uint minCPU, uint filterFlags){


m_ts.fn_queryMasterServer(lanPort, flags, gameType, missionType, minPlayers, maxPlayers, maxBots, regionMask, maxPing, minCPU, filterFlags);
}
/// <summary>
/// querySingleServer(...); )
/// </summary>
public  void querySingleServer(string addrText, byte flags = 0){


m_ts.fn_querySingleServer(addrText, flags);
}
public  void realQuit(){


m_ts.fn_realQuit();
}
/// <summary>
/// Close the current Redbook device.				@brief Deprecated				@internal)
/// </summary>
public  bool redbookClose(){


return m_ts.fn_redbookClose();
}
/// <summary>
/// get the number of redbook devices.				@brief Deprecated				@internal)
/// </summary>
public  int redbookGetDeviceCount(){


return m_ts.fn_redbookGetDeviceCount();
}
/// <summary>
/// (int index) Get name of specified Redbook device.				@brief Deprecated				@internal)
/// </summary>
public  string redbookGetDeviceName(int index){


return m_ts.fn_redbookGetDeviceName(index);
}
/// <summary>
/// Get a string explaining the last redbook error.				@brief Deprecated				@internal)
/// </summary>
public  string redbookGetLastError(){


return m_ts.fn_redbookGetLastError();
}
/// <summary>
/// Return the number of tracks.				@brief Deprecated				@internal)
/// </summary>
public  int redbookGetTrackCount(){


return m_ts.fn_redbookGetTrackCount();
}
/// <summary>
/// Get the volume.				@brief Deprecated				@internal)
/// </summary>
public  float redbookGetVolume(){


return m_ts.fn_redbookGetVolume();
}
/// <summary>
/// ), (string device=NULL)				@brief Deprecated				@internal)
/// </summary>
public  bool redbookOpen(string device = ""){


return m_ts.fn_redbookOpen(device);
}
/// <summary>
/// (int track) Play the selected track.				@brief Deprecated				@internal)
/// </summary>
public  bool redbookPlay(int track){


return m_ts.fn_redbookPlay(track);
}
/// <summary>
/// (float volume) Set playback volume.				@brief Deprecated				@internal)
/// </summary>
public  bool redbookSetVolume(float volume){


return m_ts.fn_redbookSetVolume(volume);
}
/// <summary>
/// Stop playing.				@brief Deprecated				@internal)
/// </summary>
public  bool redbookStop(){


return m_ts.fn_redbookStop();
}
/// <summary>
/// (string queueName, string listener)				@brief Registers an event message				@param queueName String containing the name of queue to attach listener to				@param listener Name of event messenger				@ingroup Messaging)
/// </summary>
public  bool registerMessageListener(string queueName, string listenerName){


return m_ts.fn_registerMessageListener(queueName, listenerName);
}
/// <summary>
/// (string queueName)				@brief Registeres a dispatcher queue				@param queueName String containing the name of queue				@ingroup Messaging)
/// </summary>
public  void registerMessageQueue(string queueName){


m_ts.fn_registerMessageQueue(queueName);
}
/// <summary>
/// @brief Flushes all procedural shaders and re-initializes all active material instances.    @ingroup Materials)
/// </summary>
public  void reInitMaterials(){


m_ts.fn_reInitMaterials();
}
/// <summary>
/// Force the resource at specified input path to be reloaded   @param path Path to the resource to be reloaded   @tsexample   reloadResource( \"art/shapes/box.dts\" );   @endtsexample   @note Currently used by editors only   @ingroup Editors   @internal)
/// </summary>
public  void reloadResource(string path){


m_ts.fn_reloadResource(path);
}
/// <summary>
/// Reload all the textures from disk.   @ingroup GFX )
/// </summary>
public  void reloadTextures(){


m_ts.fn_reloadTextures();
}
/// <summary>
/// Remove the field in @a text at the given @a index.   Fields in @a text must be separated by newlines and/or tabs.   @param text A list of fields separated by newlines and/or tabs.   @param index The zero-based index of the field in @a text.   @return A new string with the field at the given index removed or the original string if @a index is       out of range.   @tsexample      removeField( \"a b\" TAB \"c d\" TAB \"e f\", 1 ) // Returns \"a b\" TAB \"e f\"   @endtsexample   @see removeWord   @see removeRecord   @ingroup FieldManip )
/// </summary>
public  string removeField(string text, int index){


return m_ts.fn_removeField(text, index);
}
/// <summary>
/// Removes an existing global macro by name.   @see addGlobalShaderMacro   @ingroup Rendering )
/// </summary>
public  void removeGlobalShaderMacro(string name){


m_ts.fn_removeGlobalShaderMacro(name);
}
/// <summary>
/// Remove the record in @a text at the given @a index.   Records in @a text must be separated by newlines.   @param text A list of records separated by newlines.   @param index The zero-based index of the record in @a text.   @return A new string with the record at the given @a index removed or the original string if @a index is       out of range.   @tsexample      removeRecord( \"a b\" NL \"c d\" NL \"e f\", 1 ) // Returns \"a b\" NL \"e f\"   @endtsexample   @see removeWord   @see removeField   @ingroup FieldManip )
/// </summary>
public  string removeRecord(string text, int index){


return m_ts.fn_removeRecord(text, index);
}
/// <summary>
/// @brief Remove a tagged string from the Net String Table   @param tag The tag associated with the string   @see \\ref syntaxDataTypes under Tagged %Strings   @see addTaggedString()   @see getTaggedString()   @ingroup Networking)	
/// </summary>
public  void removeTaggedString(int tag = -1){


m_ts.fn_removeTaggedString(tag);
}
/// <summary>
/// Remove the word in @a text at the given @a index.   Words in @a text must be separated by newlines, spaces, and/or tabs.   @param text A whitespace-separated list of words.   @param index The zero-based index of the word in @a text.   @return A new string with the word at the given index removed or the original string if @a index is       out of range.   @tsexample      removeWord( \"a b c d\", 2 ) // Returns \"a b d\"   @endtsexample   @see removeField   @see removeRecord   @ingroup FieldManip )
/// </summary>
public  string removeWord(string text, int index){


return m_ts.fn_removeWord(text, index);
}
/// <summary>
/// @brief Renames the given @a file.   @param from %Path of the file to rename from.   @param frome %Path of the file to rename to.   @note Only present in a Tools build of Torque.   @ingroup FileSystem)
/// </summary>
public  bool renameFile(string from, string to){


return m_ts.fn_renameFile(from, to);
}
/// <summary>
/// ()   @brief Reset FPS stats (fps::)   @ingroup Game)
/// </summary>
public  void resetFPSTracker(){


m_ts.fn_resetFPSTracker();
}
/// <summary>
/// @brief Deactivates and then activates the currently active light manager.   This causes most shaders to be regenerated and is often used when global    rendering changes have occured.   @ingroup Lighting )
/// </summary>
public  void resetLightManager(){


m_ts.fn_resetLightManager();
}
/// <summary>
/// ()            @brief Rebuilds the XInput section of the InputManager            Requests a full refresh of events for all controllers. Useful when called at the beginning             of game code after actionMaps are set up to hook up all appropriate events.            @ingroup Input)
/// </summary>
public  void resetXInput(){


m_ts.fn_resetXInput();
}
/// <summary>
/// Return all but the first word in @a text.   @param text A list of words separated by newlines, spaces, and/or tabs.   @return @a text with the first word removed.   @note This is equal to    @tsexample_nopar      getWords( text, 1 )   @endtsexample   @see getWords   @ingroup FieldManip )
/// </summary>
public  string restWords(string text){


return m_ts.fn_restWords(text);
}
/// <summary>
/// Remove trailing whitespace from the string.   @param str A string.   @return A string that is the same as @a str but with any trailing (i.e. rightmost) whitespace removed.   @tsexample   rtrim( \"   string  \" ); // Returns \"   string\".   @endtsexample   @see ltrim   @see trim   @ingroup Strings )
/// </summary>
public  string rtrim(string str){


return m_ts.fn_rtrim(str);
}
/// <summary>
/// (string device, float xRumble, float yRumble)      @brief Activates the vibration motors in the specified controller.      The controller will constantly at it's xRumble and yRumble intensities until       changed or told to stop.      Valid inputs for xRumble/yRumble are [0 - 1].      @param device Name of the device to rumble.      @param xRumble Intensity to apply to the left motor.      @param yRumble Intensity to apply to the right motor.      @note in an Xbox 360 controller, the left motor is low-frequency,       while the right motor is high-frequency.      @ingroup Input)
/// </summary>
public  void rumble(string device, float xRumble, float yRumble){


m_ts.fn_rumble(device, xRumble, yRumble);
}
/// <summary>
/// (string filename)                 Save the journal to the specified file.				@ingroup Platform)
/// </summary>
public  void saveJournal(string filename){


m_ts.fn_saveJournal(filename);
}
/// <summary>
/// @brief Serialize the object to a file.				@param object The object to serialize.				@param filename The file name and path.				@ingroup Console)
/// </summary>
public  bool saveObject(string objectx, string filename){


return m_ts.fn_saveObject(objectx, filename);
}
/// <summary>
/// Dump the current zoning states of all zone spaces in the scene to the console.   @param updateFirst If true, zoning states are brought up to date first; if false, the zoning states    are dumped as is.   @note Only valid on the client.   @ingroup Game )
/// </summary>
public  void sceneDumpZoneStates(bool updateFirst = true){


m_ts.fn_sceneDumpZoneStates(updateFirst);
}
/// <summary>
/// Return the SceneObject that contains the given zone.   @param zoneId ID of zone.   @return A SceneObject or NULL if the given @a zoneId is invalid.   @note Only valid on the client.   @ingroup Game )
/// </summary>
public  string sceneGetZoneOwner(uint zoneId = 1){


return m_ts.fn_sceneGetZoneOwner(zoneId);
}
/// <summary>
/// Takes a screenshot with optional tiling to produce huge screenshots.   @param file The output image file path.   @param format Either JPEG or PNG.   @param tileCount If greater than 1 will tile the current screen size to take a large format screenshot.   @param tileOverlap The amount of horizontal and vertical overlap between the tiles used to remove tile edge artifacts from post effects.   @ingroup GFX )
/// </summary>
public  void screenShot(string file, string format, uint tileCount = 1, float tileOverlap = 0){


m_ts.fn_screenShot(file, format, tileCount, tileOverlap);
}
/// <summary>
/// @brief Open the given folder in the system's file manager.   @param path full path to a directory.   @note Only present in a Tools build of Torque.   @ingroup FileSystem)
/// </summary>
public  void selectFile(string path){


m_ts.fn_selectFile(path);
}
/// <summary>
/// (string text)
///                @brief Set the system clipboard.
/// 			   @internal)
/// 
/// </summary>
public  bool setClipboard(string text){


return m_ts.fn_setClipboard(text);
}
/// <summary>
/// (string LangTable)				@brief Sets the primary LangTable used by the game				@param LangTable ID of the core LangTable				@ingroup Localization)
/// </summary>
public  void setCoreLangTable(string lgTable){


m_ts.fn_setCoreLangTable(lgTable);
}
/// <summary>
/// @brief Set the current working directory.   @param path The absolute or relative (to the current working directory) path of the directory which should be made the new       working directory.   @return True if the working directory was successfully changed to @a path, false otherwise.   @note Only present in a Tools build of Torque.   @ingroup FileSystem)
/// </summary>
public  bool setCurrentDirectory(string path){


return m_ts.fn_setCurrentDirectory(path);
}
/// <summary>
/// @brief Set the default FOV for a camera.            @param defaultFOV The default field of view in degrees				@ingroup CameraSystem)
/// </summary>
public  void setDefaultFov(float defaultFOV){


m_ts.fn_setDefaultFov(defaultFOV);
}
/// <summary>
/// Sets the clients far clipping.   )
/// </summary>
public  void setFarClippingDistance(float dist){


m_ts.fn_setFarClippingDistance(dist);
}
/// <summary>
/// Replace the field in @a text at the given @a index with @a replacement.   Fields in @a text must be separated by newlines and/or tabs.   @param text A list of fields separated by newlines and/or tabs.   @param index The zero-based index of the field to replace.   @param replacement The string with which to replace the field.   @return A new string with the field at the given @a index replaced by @a replacement or the original       string if @a index is out of range.   @tsexample      setField( \"a b\" TAB \"c d\" TAB \"e f\", 1, \"g h\" ) // Returns \"a b\" TAB \"g h\" TAB \"e f\"   @endtsexample   @see getField   @see setWord   @see setRecord   @ingroup FieldManip )
/// </summary>
public  string setField(string text, int index, string replacement){


return m_ts.fn_setField(text, index, replacement);
}
/// <summary>
/// @brief Resizes the rendertargets of the Volumetric Fog object.
/// 	If there are fogobjects in the scene then the function is postponed until
/// 	all fogobjects are deleted.
/// 	@params new_quality new quality for the rendertargets 1 = full size, 2 = halfsize, 3 = 1/3, 4 = 1/4 ...)
/// 
/// </summary>
public  int SetFogVolumeQuality(uint new_quality){


return m_ts.fn_SetFogVolumeQuality(new_quality);
}
/// <summary>
/// @brief Set the FOV of the camera.            @param FOV The camera's new FOV in degrees				@ingroup CameraSystem)
/// </summary>
public  void setFov(float FOV){


m_ts.fn_setFov(FOV);
}
/// <summary>
/// @brief .)
/// </summary>
public  void setFrustumOffset(Point4F offset){


m_ts.fn_setFrustumOffset(offset.AsString());
}
/// <summary>
/// Finds and activates the named light manager.   @return Returns true if the light manager is found and activated.   @ingroup Lighting )
/// </summary>
public  bool setLightManager(string name){


return m_ts.fn_setLightManager(name);
}
/// <summary>
/// @brief Determines how log files are written.	Sets the operational mode of the console logging system.   @param mode Parameter specifying the logging mode.  This can be:      - 1: Open and close the console log file for each seperate string of output.  This will ensure that all          parts get written out to disk and that no parts remain in intermediate buffers even if the process crashes.      - 2: Keep the log file open and write to it continuously.  This will make the system operate faster but          if the process crashes, parts of the output may not have been written to disk yet and will be missing from          the log.               Additionally, when changing the log mode and thus opening a new log file, either of the two mode values may be       combined by binary OR with 0x4 to cause the logging system to flush all console log messages that had already been       issued to the console system into the newly created log file.	@note Xbox 360 does not support logging to a file. Use Platform::OutputDebugStr in C++ instead.	@ingroup Logging )
/// </summary>
public  void setLogMode(int mode){


m_ts.fn_setLogMode(mode);
}
/// <summary>
/// (int port, bool bind=true)    @brief Set the network port for the game to use.   @param port The port to use.   @param bind True if bind() should be called on the port.   @returns True if the port was successfully opened.   This will trigger a windows firewall prompt.     If you don't have firewall tunneling tech you can set this to false to avoid the prompt.   @ingroup Networking)
/// </summary>
public  bool setNetPort(int port, bool bind = true){


return m_ts.fn_setNetPort(port, bind);
}
/// <summary>
/// @brief Sets the pixel shader version for the active device.   This can be used to force a lower pixel shader version than is supported by    the device for testing or performance optimization.   @param version The floating point shader version number.   @note This will only affect shaders/materials created after the call    and should be used before the game begins.   @see $pref::Video::forcedPixVersion   @ingroup GFX )
/// </summary>
public  void setPixelShaderVersion(float version){


m_ts.fn_setPixelShaderVersion(version);
}
/// <summary>
/// Set the current seed for the random number generator.   Based on this seed, a repeatable sequence of numbers will be produced by getRandom().   @param seed The seed with which to initialize the randon number generator with.  The same seed will always leed to      the same sequence of pseudo-random numbers.      If -1, the current timestamp will be used as the seed which is a good basis for randomization.   @ingroup Random )
/// </summary>
public  void setRandomSeed(int seed = -1){


m_ts.fn_setRandomSeed(seed);
}
/// <summary>
/// Replace the record in @a text at the given @a index with @a replacement.   Records in @a text must be separated by newlines.   @param text A list of records separated by newlines.   @param index The zero-based index of the record to replace.   @param replacement The string with which to replace the record.   @return A new string with the record at the given @a index replaced by @a replacement or the original       string if @a index is out of range.   @tsexample      setRecord( \"a b\" NL \"c d\" NL \"e f\", 1, \"g h\" ) // Returns \"a b\" NL \"g h\" NL \"e f\"   @endtsexample   @see getRecord   @see setWord   @see setField   @ingroup FieldManip )
/// </summary>
public  string setRecord(string text, int index, string replacement){


return m_ts.fn_setRecord(text, index, replacement);
}
/// <summary>
/// Set the reflection texture format.   @ingroup GFX )
/// </summary>
public  void setReflectFormat(TypeGFXFormat format){


m_ts.fn_setReflectFormat((int)format );
}
/// <summary>
/// setServerInfo(...); )
/// </summary>
public  bool setServerInfo(uint index){


return m_ts.fn_setServerInfo(index);
}
/// <summary>
/// ), string sShadowSystemName)
/// </summary>
public  bool setShadowManager(string sShadowSystemName = ""){


return m_ts.fn_setShadowManager(sShadowSystemName);
}
/// <summary>
/// ), )
/// </summary>
public  string setShadowVizLight(string name = ""){


return m_ts.fn_setShadowVizLight(name);
}
/// <summary>
/// (string varName, string value)    @brief Sets the value of the named variable.   @param varName Name of the variable to locate   @param value New value of the variable   @return True if variable was successfully found and set   @ingroup Scripting)
/// </summary>
public  void setVariable(string varName, string value){


m_ts.fn_setVariable(varName, value);
}
/// <summary>
/// Replace the word in @a text at the given @a index with @a replacement.   Words in @a text must be separated by newlines, spaces, and/or tabs.   @param text A whitespace-separated list of words.   @param index The zero-based index of the word to replace.   @param replacement The string with which to replace the word.   @return A new string with the word at the given @a index replaced by @a replacement or the original       string if @a index is out of range.   @tsexample      setWord( \"a b c d\", 2, \"f\" ) // Returns \"a b f d\"   @endtsexample   @see getWord   @see setField   @see setRecord   @ingroup FieldManip )
/// </summary>
public  string setWord(string text, int index, string replacement){


return m_ts.fn_setWord(text, index, replacement);
}
/// <summary>
/// @brief Set the zoom speed of the camera.            This affects how quickly the camera changes from one field of view             to another.            @param speed The camera's zoom speed in ms per 90deg FOV change				@ingroup CameraSystem)
/// </summary>
public  void setZoomSpeed(int speed){


m_ts.fn_setZoomSpeed(speed);
}
/// <summary>
/// Try to create a new sound device using the given properties.   If a sound device is currently initialized, it will be uninitialized first.  However, be aware that in this case,    if this function fails, it will not restore the previously active device but rather leave the sound system in an    uninitialized state.   Sounds that are already playing while the new device is created will be temporarily transitioned to virtualized    playback and then resume normal playback once the device has been created.   In the core scripts, sound is automatically set up during startup in the sfxStartup() function.   @param provider The name of the device provider as returned by sfxGetAvailableDevices().   @param device The name of the device as returned by sfxGetAvailableDevices().   @param useHardware Whether to enabled hardware mixing on the device or not.  Only relevant if supported by the given device.   @param maxBuffers The maximum number of concurrent voices for this device to use or -1 for the device to pick its own reasonable default.   @return True if the initialization was successful, false if not.   @note This function must be called before any of the sound playback functions can be used.   @see sfxGetAvailableDevices   @see sfxGetDeviceInfo   @see sfxDeleteDevice   @ref SFX_devices   @ingroup SFX )
/// </summary>
public  bool sfxCreateDevice(string provider, string device, bool useHardware, int maxBuffers){


return m_ts.fn_sfxCreateDevice(provider, device, useHardware, maxBuffers);
}
/// <summary>
/// , , , ),                     ( SFXTrack track | ( SFXDescription description, string filename ) [, float x, float y, float z ] )                      Creates a new paused sound source using a profile or a description                      and filename.  The return value is the source which must be                      released by delete().                     @hide )
/// </summary>
public  int sfxCreateSource(string SFXType, string filename = "", string x = "", string y = "", string z = ""){


return m_ts.fn_sfxCreateSource(SFXType, filename, x, y, z);
}
/// <summary>
/// Delete the currently active sound device and release all its resources.   SFXSources that are still playing will be transitioned to virtualized playback mode.    When creating a new device, they will automatically transition back to normal playback.   In the core scripts, this is done automatically for you during shutdown in the sfxShutdown() function.   @see sfxCreateDevice   @ref SFX_devices   @ingroup SFX )
/// </summary>
public  void sfxDeleteDevice(){


m_ts.fn_sfxDeleteDevice();
}
/// <summary>
/// Mark the given @a source for deletion as soon as it moves into stopped state.   This function will retroactively turn the given @a source into a play-once source (see @ref SFXSource_playonce).   @param source A sound source.   @ingroup SFX )
/// </summary>
public  void sfxDeleteWhenStopped(string source){


m_ts.fn_sfxDeleteWhenStopped(source);
}
/// <summary>
/// Dump information about all current SFXSource instances to the console.   The dump includes information about the playback status for each source, volume levels, virtualization, etc.   @param includeGroups If true, direct instances of SFXSources (which represent logical sound groups) will be included.       Otherwise only instances of subclasses of SFXSources are included in the dump.   @see SFXSource   @see sfxDumpSourcesToString   @ingroup SFX )
/// </summary>
public  void sfxDumpSources(bool includeGroups = false){


m_ts.fn_sfxDumpSources(includeGroups);
}
/// <summary>
/// Dump information about all current SFXSource instances to a string.   The dump includes information about the playback status for each source, volume levels, virtualization, etc.   @param includeGroups If true, direct instances of SFXSources (which represent logical sound groups) will be included.       Otherwise only instances of subclasses of SFXSources are included in the dump.   @return A string containing a dump of information about all currently instantiated SFXSources.   @see SFXSource   @see sfxDumpSources   @ingroup SFX )
/// </summary>
public  string sfxDumpSourcesToString(bool includeGroups = false){


return m_ts.fn_sfxDumpSourcesToString(includeGroups);
}
/// <summary>
/// Return a newline-separated list of all active states.   @return A list of the form   @verbatim      stateName1 NL stateName2 NL stateName3 ...   @endverbatim   where each element is the name of an active state object.   @tsexample      // Disable all active states.      foreach$( %state in sfxGetActiveStates() )         %state.disable();   @endtsexample   @ingroup SFX )
/// </summary>
public  string sfxGetActiveStates(){


return m_ts.fn_sfxGetActiveStates();
}
/// <summary>
/// Get a list of all available sound devices.   The return value will be a newline-separated list of entries where each line describes one available sound    device.  Each such line will have the following format:   @verbatim      provider TAB device TAB hasHardware TAB numMaxBuffers   @endverbatim   - provider: The name of the device provider (e.g. \"FMOD\").   - device: The name of the device as returned by the device layer.   - hasHardware: Whether the device supports hardware mixing or not.   - numMaxBuffers: The maximum number of concurrent voices supported by the device's mixer.  If this limit       limit is exceeded, i.e. if there are more active sounds playing at any one time, then voice virtualization       will start culling voices and put them into virtualized playback mode.  Voice virtualization may or may not       be provided by the device itself; if not provided by the device, it will be provided by Torque's sound system.   @return A newline-separated list of information about all available sound devices.   @see sfxCreateDevice   @see sfxGetDeviceInfo   @see $SFX::DEVICE_INFO_PROVIDER   @see $SFX::DEVICE_INFO_NAME   @see $SFX::DEVICE_INFO_USEHARDWARE   @see $SFX::DEVICE_INFO_MAXBUFFERS   @ref SFX_devices   @ingroup SFX )
/// </summary>
public  string sfxGetAvailableDevices(){


return m_ts.fn_sfxGetAvailableDevices();
}
/// <summary>
/// Return information about the currently active sound device.   The return value is a tab-delimited string of the following format:   @verbatim      provider TAB device TAB hasHardware TAB numMaxBuffers TAB caps   @endverbatim   - provider: The name of the device provider (e.g. \"FMOD\").   - device: The name of the device as returned by the device layer.   - hasHardware: Whether the device supports hardware mixing or not.   - numMaxBuffers: The maximum number of concurrent voices supported by the device's mixer.  If this limit       limit is exceeded, i.e. if there are more active sounds playing at any one time, then voice virtualization       will start culling voices and put them into virtualized playback mode.  Voice virtualization may or may not       be provided by the device itself; if not provided by the device, it will be provided by Torque's sound system.   - caps: A bitfield of capability flags.   @return A tab-separated list of properties of the currently active sound device or the empty string if no sound device has been initialized.   @see sfxCreateDevice   @see sfxGetAvailableDevices   @see $SFX::DEVICE_INFO_PROVIDER   @see $SFX::DEVICE_INFO_NAME   @see $SFX::DEVICE_INFO_USEHARDWARE   @see $SFX::DEVICE_INFO_MAXBUFFERS   @see $SFX::DEVICE_INFO_CAPS   @see $SFX::DEVICE_CAPS_REVERB   @see $SFX::DEVICE_CAPS_VOICEMANAGEMENT   @see $SFX::DEVICE_CAPS_OCCLUSION   @see $SFX::DEVICE_CAPS_DSPEFFECTS   @see $SFX::DEVICE_CAPS_MULTILISTENER   @see $SFX::DEVICE_CAPS_FMODDESIGNER   @ref SFX_devices   @ingroup SFX )
/// </summary>
public  string sfxGetDeviceInfo(){


return m_ts.fn_sfxGetDeviceInfo();
}
/// <summary>
/// Get the falloff curve type currently being applied to 3D sounds.   @return The current distance model type.   @ref SFXSource_volume   @ref SFX_3d   @ingroup SFX )
/// </summary>
public  TypeSFXDistanceModel sfxGetDistanceModel(){


return (TypeSFXDistanceModel)( m_ts.fn_sfxGetDistanceModel());
}
/// <summary>
/// Get the current global doppler effect setting.   @return The current global doppler effect scale factor (>=0).   @see sfxSetDopplerFactor   @ref SFXSource_doppler   @ingroup SFX )
/// </summary>
public  float sfxGetDopplerFactor(){


return m_ts.fn_sfxGetDopplerFactor();
}
/// <summary>
/// Get the current global scale factor applied to volume attenuation of 3D sounds in the logarithmic model.   @return The current scale factor for logarithmic 3D sound falloff curves.   @see sfxGetDistanceModel   @see SFXDistanceModel   @ref SFXSource_volume   @ref SFX_3d   @ingroup SFX )
/// </summary>
public  float sfxGetRolloffFactor(){


return m_ts.fn_sfxGetRolloffFactor();
}
/// <summary>
/// , , ),   Start playing the given source or create a new source for the given track and play it.   @hide )
/// </summary>
public  int sfxPlay(string trackName, string pointOrX = "", string y = "", string z = ""){


return m_ts.fn_sfxPlay(trackName, pointOrX, y, z);
}
/// <summary>
/// , , , -1.0f),   SFXSource sfxPlayOnce( ( SFXTrack track | SFXDescription description, string filename ) [, float x, float y, float z, float fadeInTime=-1 ] )    Create a new play-once source for the given profile or description+filename and start playback of the source.   @hide )
/// </summary>
public  int sfxPlayOnce(string SFXType, string filename, string x = "", string y = "", string z = "", float fadeInTime = -1.0f){


return m_ts.fn_sfxPlayOnce(SFXType, filename, x, y, z, fadeInTime);
}
/// <summary>
/// Set the falloff curve type to use for distance-based volume attenuation of 3D sounds.   @param model The distance model to use for 3D sound.   @note This setting takes effect globally and is applied to all 3D sounds.   @ingroup SFX )
/// </summary>
public  void sfxSetDistanceModel(TypeSFXDistanceModel model){


m_ts.fn_sfxSetDistanceModel((int)model );
}
/// <summary>
/// Set the global doppler effect scale factor.   @param value The new doppler shift scale factor.   @pre @a value must be >= 0.   @see sfxGetDopplerFactor   @ref SFXSource_doppler   @ingroup SFX )
/// </summary>
public  void sfxSetDopplerFactor(float value){


m_ts.fn_sfxSetDopplerFactor(value);
}
/// <summary>
/// Set the global scale factor to apply to volume attenuation of 3D sounds in the logarithmic model.   @param value The new scale factor for logarithmic 3D sound falloff curves.   @pre @a value must be > 0.   @note This function has no effect if the currently distance model is set to SFXDistanceModel::Linear.   @see sfxGetDistanceModel   @see SFXDistanceModel   @ref SFXSource_volume   @ref SFX_3d   @ingroup SFX )
/// </summary>
public  void sfxSetRolloffFactor(float value){


m_ts.fn_sfxSetRolloffFactor(value);
}
/// <summary>
/// Stop playback of the given @a source.   This is equivalent to calling SFXSource::stop().   @param source The source to put into stopped state.   @ingroup SFX )
/// </summary>
public  void sfxStop(string source){


m_ts.fn_sfxStop(source);
}
/// <summary>
/// Stop playback of the given @a source (if it is not already stopped) and delete the @a source.   The advantage of this function over directly calling delete() is that it will correctly    handle volume fades that may be configured on the source.  Whereas calling delete() would immediately    stop playback and delete the source, this functionality will wait for the fade-out to play and only then    stop the source and delete it.   @param source A sound source.   @ref SFXSource_fades   @ingroup SFX )
/// </summary>
public  void sfxStopAndDelete(string source){


m_ts.fn_sfxStopAndDelete(source);
}
/// <summary>
/// , ), (string executable, string args, string directory)				@brief Launches an outside executable or batch file				@param executable Name of the executable or batch file				@param args Optional list of arguments, in string format, to pass to the executable				@param directory Optional string containing path to output or shell				@ingroup Platform)
/// </summary>
public  bool shellExecute(string executable, string args = "", string directory = ""){


return m_ts.fn_shellExecute(executable, args, directory);
}
/// <summary>
/// @brief Determines the memory consumption of a class or object.				@param objectOrClass The object or class being measured.				@return Returns the total size of an object in bytes.				@ingroup Debugging)
/// </summary>
public  int sizeofx(string objectOrClass){


return m_ts.fn_sizeof(objectOrClass);
}
/// <summary>
/// @brief Prevents mouse movement from being processed					 In the source, whenever a mouse move event occurs 					 GameTSCtrl::onMouseMove() is called. Whenever snapToggle() 					 is called, it will flag a variable that can prevent this 					 from happening: gSnapLine. This variable is not exposed to 					 script, so you need to call this function to trigger it.					 @tsexample					 // Snapping is off by default, so we will toggle					 // it on first:					 PlayGui.snapToggle();					 // Mouse movement should be disabled					 // Let's turn it back on					 PlayGui.snapToggle();					 @endtsexample					 @ingroup GuiGame)
/// </summary>
public  void snapToggle(){


m_ts.fn_snapToggle();
}
/// <summary>
/// ,,,,) ,spawnObject(class [, dataBlock, name, properties, script,modelName])				@hide)
/// </summary>
public  int spawnObject(string spawnClass, string spawnDataBlock = "", string spawnName = "", string spawnProperties = "", string spawnScript = "", string modelName = ""){


return m_ts.fn_spawnObject(spawnClass, spawnDataBlock, spawnName, spawnProperties, spawnScript, modelName);
}
/// <summary>
/// Activates the shape replicator.													@tsexample														// Call the function														StartClientReplication()													@endtsexample													@ingroup Foliage					)
/// </summary>
public  void StartClientReplication(){


m_ts.fn_StartClientReplication();
}
/// <summary>
/// @brief Start watching resources for file changes   Typically this is called during initializeCore().   @see stopFileChangeNotifications()	@ingroup FileSystem)
/// </summary>
public  void startFileChangeNotifications(){


m_ts.fn_startFileChangeNotifications();
}
/// <summary>
/// Activates the foliage replicator.													@tsexample														// Call the function														StartFoliageReplication();													@endtsexample													@ingroup Foliage)
/// </summary>
public  void StartFoliageReplication(){


m_ts.fn_StartFoliageReplication();
}
/// <summary>
/// startHeartbeat(...); )
/// </summary>
public  void startHeartbeat(){


m_ts.fn_startHeartbeat();
}
/// <summary>
/// startPrecisionTimer() - Create and start a high resolution platform timer. Returns the timer id. )
/// </summary>
public  int startPrecisionTimer(){


return m_ts.fn_startPrecisionTimer();
}
/// <summary>
/// Test whether the given string begins with the given prefix.   @param str The string to test.   @param prefix The potential prefix of @a str.   @param caseSensitive If true, the comparison will be case-sensitive; if false, differences in casing will       not be taken into account.   @return True if the first characters in @a str match the complete contents of @a prefix; false otherwise.   @tsexample   startsWith( \"TEST123\", \"test\" ) // Returns true.   @endtsexample   @see endsWith   @ingroup Strings )
/// </summary>
public  bool startsWith(string str, string prefix, bool caseSensitive = false){


return m_ts.fn_startsWith(str, prefix, caseSensitive);
}
/// <summary>
/// THEORA, 30.0f, Point2I::Zero ),   Begins a video capture session.   @see stopVideoCapture   @ingroup Rendering )
/// </summary>
public  void startVideoCapture(string canvas, string filename, string encoder = "THEORA", float framerate = 30.0f, Point2I resolution = null ){
if (resolution== null) {resolution = new Point2I(0,0);}


m_ts.fn_startVideoCapture(canvas, filename, encoder, framerate, resolution.AsString());
}
/// <summary>
/// @brief Stop watching resources for file changes   Typically this is called during shutdownCore().   @see startFileChangeNotifications()	@ingroup FileSystem)
/// </summary>
public  void stopFileChangeNotifications(){


m_ts.fn_stopFileChangeNotifications();
}
/// <summary>
/// stopHeartbeat(...); )
/// </summary>
public  void stopHeartbeat(){


m_ts.fn_stopHeartbeat();
}
/// <summary>
/// stopPrecisionTimer( S32 id ) - Stop and destroy timer with the passed id.  Returns the elapsed milliseconds. )
/// </summary>
public  int stopPrecisionTimer(int id){


return m_ts.fn_stopPrecisionTimer(id);
}
/// <summary>
/// ()				@brief Stops the rendering sampler				@ingroup Rendering)
/// </summary>
public  void stopSampling(){


m_ts.fn_stopSampling();
}
/// <summary>
/// stopServerQuery(...); )
/// </summary>
public  void stopServerQuery(){


m_ts.fn_stopServerQuery();
}
/// <summary>
/// Stops the video capture session.   @see startVideoCapture      @ingroup Rendering )
/// </summary>
public  void stopVideoCapture(){


m_ts.fn_stopVideoCapture();
}
/// <summary>
/// Return the integer character code value corresponding to the first character in the given string.   @param chr a (one-character) string.   @return the UTF32 code value for the first character in the given string.   @ingroup Strings )
/// </summary>
public  int strasc(string chr){


return m_ts.fn_strasc(chr);
}
/// <summary>
/// Find the first occurrence of the given character in @a str.   @param str The string to search.   @param chr The character to search for.  Only the first character from the string is taken.   @return The remainder of the input string starting with the given character or the empty string if the character could not be found.   @see strrchr   @ingroup Strings )
/// </summary>
public  string strchr(string str, string chr){


return m_ts.fn_strchr(str, chr);
}
/// <summary>
/// Find the first occurrence of the given character in the given string.   @param str The string to search.   @param chr The character to look for.  Only the first character of this string will be searched for.   @param start The index into @a str at which to start searching for the given character.   @return The index of the first occurrence of @a chr in @a str or -1 if @a str does not contain the given character.   @tsexample   strchrpos( \"test\", \"s\" ) // Returns 2.   @endtsexample   @ingroup Strings )
/// </summary>
public  int strchrpos(string str, string chr, int start = 0){


return m_ts.fn_strchrpos(str, chr, start);
}
/// <summary>
/// Compares two strings using case-b>sensitive/b> comparison.   @param str1 The first string.   @param str2 The second string.   @return 0 if both strings are equal, a value 0 if the first character different in str1 has a smaller character code       value than the character at the same position in str2, and a value >1 otherwise.   @tsexample   if( strcmp( %var, \"foobar\" ) == 0 )      echo( \"%var is equal to 'foobar'\" );   @endtsexample   @see stricmp   @see strnatcmp   @ingroup Strings )
/// </summary>
public  int strcmp(string str1, string str2){


return m_ts.fn_strcmp(str1, str2);
}
/// <summary>
/// Format the given value as a string using printf-style formatting.   @param format A printf-style format string.   @param value The value argument matching the given format string.   @tsexample   // Convert the given integer value to a string in a hex notation.   %hex = strformat( \"%x\", %value );   @endtsexample   @ingroup Strings   @see http://en.wikipedia.org/wiki/Printf )
/// </summary>
public  string strformat(string format, string value){


return m_ts.fn_strformat(format, value);
}
/// <summary>
/// Compares two strings using case-b>insensitive/b> comparison.   @param str1 The first string.   @param str2 The second string.   @return 0 if both strings are equal, a value 0 if the first character different in str1 has a smaller character code       value than the character at the same position in str2, and a value >0 otherwise.   @tsexample   if( stricmp( \"FOObar\", \"foobar\" ) == 0 )      echo( \"this is always true\" );   @endtsexample   @see strcmp   @see strinatcmp   @ingroup Strings )
/// </summary>
public  int stricmp(string str1, string str2){


return m_ts.fn_stricmp(str1, str2);
}
/// <summary>
/// Compares two strings using \"natural order\" case-b>insensitive/b> comparison.   Natural order means that rather than solely comparing single character code values, strings are ordered in a    natural way.  For example, the string \"hello10\" is considered greater than the string \"hello2\" even though    the first numeric character in \"hello10\" actually has a smaller character value than the corresponding character    in \"hello2\".  However, since 10 is greater than 2, strnatcmp will put \"hello10\" after \"hello2\".   @param str1 The first string.   @param str2 The second string.   @return 0 if the strings are equal, a value >0 if @a str1 comes after @a str2 in a natural order, and a value       0 if @a str1 comes before @a str2 in a natural order.   @tsexample   // Bubble sort 10 elements of %array using natural order   do   {      %swapped = false;      for( %i = 0; %i  10 - 1; %i ++ )         if( strnatcmp( %array[ %i ], %array[ %i + 1 ] ) > 0 )         {            %temp = %array[ %i ];            %array[ %i ] = %array[ %i + 1 ];            %array[ %i + 1 ] = %temp;            %swapped = true;         }   }   while( %swapped );   @endtsexample   @see stricmp   @see strnatcmp   @ingroup Strings )
/// </summary>
public  int strinatcmp(string str1, string str2){


return m_ts.fn_strinatcmp(str1, str2);
}
/// <summary>
/// Remove all occurrences of characters contained in @a chars from @a str.   @param str The string to filter characters out from.   @param chars A string of characters to filter out from @a str.   @return A version of @a str with all occurrences of characters contained in @a chars filtered out.   @tsexample   stripChars( \"teststring\", \"se\" ); // Returns \"tttring\".   @endtsexample   @ingroup Strings )
/// </summary>
public  string stripChars(string str, string chars){


return m_ts.fn_stripChars(str, chars);
}
/// <summary>
/// @brief Strip TorqueML control characters from the specified string, returning a 'clean' version.					 @param inString String to strip TorqueML control characters from.					 @tsexample					 // Define the string to strip TorqueML control characters from					 %string = \"font:Arial:24>How Now color:c43c12>Brown color:000000>Cow\";					 // Request the stripped version of the string					 %strippedString = StripMLControlChars(%string);					 @endtsexample					 @return Version of the inputted string with all TorqueML characters removed.					 @see References					 @ingroup GuiCore)
/// </summary>
public  string StripMLControlChars(string inString){


return m_ts.fn_StripMLControlChars(inString);
}
/// <summary>
/// Strip a numeric suffix from the given string.   @param str The string from which to strip its numeric suffix.   @return The string @a str without its number suffix or the original string @a str if it has no such suffix.   @tsexample   stripTrailingNumber( \"test123\" ) // Returns \"test\".   @endtsexample   @see getTrailingNumber   @ingroup Strings )
/// </summary>
public  string stripTrailingNumber(string str){


return m_ts.fn_stripTrailingNumber(str);
}
/// <summary>
/// Match a pattern against a string.   @param pattern The wildcard pattern to match against.  The pattern can include characters, '*' to match       any number of characters and '?' to match a single character.   @param str The string which should be matched against @a pattern.   @param caseSensitive If true, characters in the pattern are matched in case-sensitive fashion against       this string.  If false, differences in casing are ignored.   @return True if @a str matches the given @a pattern.   @tsexample   strIsMatchExpr( \"f?o*R\", \"foobar\" ) // Returns true.   @endtsexample   @see strIsMatchMultipleExpr   @ingroup Strings )
/// </summary>
public  bool strIsMatchExpr(string pattern, string str, bool caseSensitive = false){


return m_ts.fn_strIsMatchExpr(pattern, str, caseSensitive);
}
/// <summary>
/// Match a multiple patterns against a single string.   @param patterns A tab-separated list of patterns.  Each pattern can include charaters, '*' to match       any number of characters and '?' to match a single character.  Each of the patterns is tried in turn.   @param str The string which should be matched against @a patterns.   @param caseSensitive If true, characters in the pattern are matched in case-sensitive fashion against       this string.  If false, differences in casing are ignored.   @return True if @a str matches any of the given @a patterns.   @tsexample   strIsMatchMultipleExpr( \"*.cs *.gui *.mis\", \"mymission.mis\" ) // Returns true.   @endtsexample   @see strIsMatchExpr   @ingroup Strings )
/// </summary>
public  bool strIsMatchMultipleExpr(string patterns, string str, bool caseSensitive = false){


return m_ts.fn_strIsMatchMultipleExpr(patterns, str, caseSensitive);
}
/// <summary>
/// Get the length of the given string in bytes.   @note This does b>not/b> return a true character count for strings with multi-byte characters!   @param str A string.   @return The length of the given string in bytes.   @ingroup Strings )
/// </summary>
public  int strlen(string str){


return m_ts.fn_strlen(str);
}
/// <summary>
/// Return an all lower-case version of the given string.   @param str A string.   @return A version of @a str with all characters converted to lower-case.   @tsexample   strlwr( \"TesT1\" ) // Returns \"test1\"   @endtsexample   @see strupr   @ingroup Strings )
/// </summary>
public  string strlwr(string str){


return m_ts.fn_strlwr(str);
}
/// <summary>
/// Compares two strings using \"natural order\" case-b>sensitive/b> comparison.   Natural order means that rather than solely comparing single character code values, strings are ordered in a    natural way.  For example, the string \"hello10\" is considered greater than the string \"hello2\" even though    the first numeric character in \"hello10\" actually has a smaller character value than the corresponding character    in \"hello2\".  However, since 10 is greater than 2, strnatcmp will put \"hello10\" after \"hello2\".   @param str1 The first string.   @param str2 The second string.   @return 0 if the strings are equal, a value >0 if @a str1 comes after @a str2 in a natural order, and a value       0 if @a str1 comes before @a str2 in a natural order.   @tsexample   // Bubble sort 10 elements of %array using natural order   do   {      %swapped = false;      for( %i = 0; %i  10 - 1; %i ++ )         if( strnatcmp( %array[ %i ], %array[ %i + 1 ] ) > 0 )         {            %temp = %array[ %i ];            %array[ %i ] = %array[ %i + 1 ];            %array[ %i + 1 ] = %temp;            %swapped = true;         }   }   while( %swapped );   @endtsexample   @see strcmp   @see strinatcmp   @ingroup Strings )
/// </summary>
public  int strnatcmp(string str1, string str2){


return m_ts.fn_strnatcmp(str1, str2);
}
/// <summary>
/// Find the start of @a needle in @a haystack searching from left to right beginning at the given offset.   @param haystack The string to search.   @param needle The string to search for.   @return The index at which the first occurrence of @a needle was found in @a haystack or -1 if no match was found.   @tsexample   strpos( \"b ab\", \"b\", 1 ) // Returns 3.   @endtsexample   @ingroup Strings )
/// </summary>
public  int strpos(string haystack, string needle, int offset = 0){


return m_ts.fn_strpos(haystack, needle, offset);
}
/// <summary>
/// Find the last occurrence of the given character in @a str.   @param str The string to search.   @param chr The character to search for.  Only the first character from the string is taken.   @return The remainder of the input string starting with the given character or the empty string if the character could not be found.   @see strchr   @ingroup Strings )
/// </summary>
public  string strrchr(string str, string chr){


return m_ts.fn_strrchr(str, chr);
}
/// <summary>
/// Find the last occurrence of the given character in the given string.   @param str The string to search.   @param chr The character to look for.  Only the first character of this string will be searched for.   @param start The index into @a str at which to start searching for the given character.   @return The index of the last occurrence of @a chr in @a str or -1 if @a str does not contain the given character.   @tsexample   strrchrpos( \"test\", \"t\" ) // Returns 3.   @endtsexample   @ingroup Strings )
/// </summary>
public  int strrchrpos(string str, string chr, int start = 0){


return m_ts.fn_strrchrpos(str, chr, start);
}
/// <summary>
///  ),   Return a string that repeats @a str @a numTimes number of times delimiting each occurrence with @a delimiter.   @param str The string to repeat multiple times.   @param numTimes The number of times to repeat @a str in the result string.   @param delimiter The string to put between each repetition of @a str.   @return A string containing @a str repeated @a numTimes times.   @tsexample   strrepeat( \"a\", 5, \"b\" ) // Returns \"ababababa\".   @endtsexample   @ingroup Strings )
/// </summary>
public  string strrepeat(string str, int numTimes, string delimiter = ""){


return m_ts.fn_strrepeat(str, numTimes, delimiter);
}
/// <summary>
/// Replace all occurrences of @a from in @a source with @a to.   @param source The string in which to replace the occurrences of @a from.   @param from The string to replace in @a source.   @param to The string with which to replace occurrences of @from.   @return A string with all occurrences of @a from in @a source replaced by @a to.   @tsexample   strreplace( \"aabbccbb\", \"bb\", \"ee\" ) // Returns \"aaeeccee\".   @endtsexample   @ingroup Strings )
/// </summary>
public  string strreplace(string source, string from, string to){


return m_ts.fn_strreplace(source, from, to);
}
/// <summary>
/// Find the start of @a substring in the given @a string searching from left to right.   @param string The string to search.   @param substring The string to search for.   @return The index into @a string at which the first occurrence of @a substring was found or -1 if @a substring could not be found.   @tsexample   strstr( \"abcd\", \"c\" ) // Returns 2.   @endtsexample   @ingroup Strings )
/// </summary>
public  int strstr(string stringx, string substring){


return m_ts.fn_strstr(stringx, substring);
}
/// <summary>
/// strToPlayerName(string); )
/// </summary>
public  string strToPlayerName(string ptr){


return m_ts.fn_strToPlayerName(ptr);
}
/// <summary>
/// Return an all upper-case version of the given string.   @param str A string.   @return A version of @a str with all characters converted to upper-case.   @tsexample   strupr( \"TesT1\" ) // Returns \"TEST1\"   @endtsexample   @see strlwr   @ingroup Strings )
/// </summary>
public  string strupr(string str){


return m_ts.fn_strupr(str);
}
/// <summary>
/// @brief Initializes and open the telnet console.                @param port        Port to listen on for console connections (0 will shut down listening).                @param consolePass Password for read/write access to console.                @param listenPass  Password for read access to console.                @param remoteEcho  [optional] Enable echoing back to the client, off by default.				@ingroup Debugging)
/// </summary>
public  void telnetSetParameters(int port, string consolePass, string listenPass, bool remoteEcho = false){


m_ts.fn_telnetSetParameters(port, consolePass, listenPass, remoteEcho);
}
/// <summary>
/// testBridge(arg1, arg2, arg3))
/// </summary>
public  string testJavaScriptBridge(string arg1, string arg2, string arg3){


return m_ts.fn_testJavaScriptBridge(arg1, arg2, arg3);
}
/// <summary>
/// Enable or disable tracing in the script code VM.   When enabled, the script code runtime will trace the invocation and returns    from all functions that are called and log them to the console. This is helpful in    observing the flow of the script program.   @param enable New setting for script trace execution, on by default.   @ingroup Debugging )
/// </summary>
public  void trace(bool enable = true){


m_ts.fn_trace(enable);
}
/// <summary>
/// Remove leading and trailing whitespace from the string.   @param str A string.   @return A string that is the same as @a str but with any leading (i.e. leftmost) and trailing (i.e. rightmost) whitespace removed.   @tsexample   trim( \"   string  \" ); // Returns \"string\".   @endtsexample   @ingroup Strings )
/// </summary>
public  string trim(string str){


return m_ts.fn_trim(str);
}
/// <summary>
/// tsUpdateImposterImages( bool forceupdate ))
/// </summary>
public  void tsUpdateImposterImages(bool forceUpdate = false){


m_ts.fn_tsUpdateImposterImages(forceUpdate);
}
/// <summary>
/// , false), ([searchString[, bool skipInteractive]])				@brief Run unit tests, or just the tests that prefix match against the searchString.				@ingroup Console)
/// </summary>
public  void unitTest_runTests(string searchString = "", bool skip = false){


m_ts.fn_unitTest_runTests(searchString, skip);
}
/// <summary>
/// (string queueName, string listener)				@brief Unregisters an event message				@param queueName String containing the name of queue				@param listener Name of event messenger				@ingroup Messaging)
/// </summary>
public  void unregisterMessageListener(string queueName, string listenerName){


m_ts.fn_unregisterMessageListener(queueName, listenerName);
}
/// <summary>
/// (string queueName)				@brief Unregisters a dispatcher queue				@param queueName String containing the name of queue				@ingroup Messaging)
/// </summary>
public  void unregisterMessageQueue(string queueName){


m_ts.fn_unregisterMessageQueue(queueName);
}
/// <summary>
/// Add two vectors.   @param a The first vector.   @param b The second vector.   @return The vector @a a + @a b.   @tsexample      //-----------------------------------------------------------------------------      //      // VectorAdd( %a, %b );      //      // The sum of vector a, (ax, ay, az), and vector b, (bx, by, bz) is:      //      //     a + b = ( ax + bx, ay + by, az + bz )      //      //-----------------------------------------------------------------------------      %a = \"1 0 0\";      %b = \"0 1 0\";      // %r = \"( 1 + 0, 0 + 1, 0 + 0 )\";      // %r = \"1 1 0\";      %r = VectorAdd( %a, %b );   @endtsexample   @ingroup Vectors)
/// </summary>
public  Point3F VectorAdd(Point3F a, Point3F b){


return new Point3F ( m_ts.fn_VectorAdd(a.AsString(), b.AsString()));
}
/// <summary>
/// Calculcate the cross product of two vectors.   @param a The first vector.   @param b The second vector.   @return The cross product @a x @a b.   @tsexample	//-----------------------------------------------------------------------------	//	// VectorCross( %a, %b );	//	// The cross product of vector a, (ax, ay, az), and vector b, (bx, by, bz), is	//	//     a x b = ( ( ay * bz ) - ( az * by ), ( az * bx ) - ( ax * bz ), ( ax * by ) - ( ay * bx ) )	//	//-----------------------------------------------------------------------------	%a = \"1 1 0\";	%b = \"2 0 1\";	// %r = \"( ( 1 * 1 ) - ( 0 * 0 ), ( 0 * 2 ) - ( 1 * 1 ), ( 1 * 0 ) - ( 1 * 2 ) )\";	// %r = \"1 -1 -2\";	%r = VectorCross( %a, %b );   @endtsexample	   @ingroup Vectors )
/// </summary>
public  Point3F VectorCross(Point3F a, Point3F b){


return new Point3F ( m_ts.fn_VectorCross(a.AsString(), b.AsString()));
}
/// <summary>
/// Compute the distance between two vectors.   @param a The first vector.   @param b The second vector.   @return The length( @a b - @a a ).   @tsexample	//-----------------------------------------------------------------------------	//	// VectorDist( %a, %b );	//	// The distance between vector a, (ax, ay, az), and vector b, (bx, by, bz), is	//	//     a -> b = ||( b - a )||	//            = ||( bx - ax, by - ay, bz - az )||	//            = mSqrt( ( bx - ax ) * ( bx - ax ) + ( by - ay ) * ( by - ay ) + ( bz - az ) * ( bz - az ) )	//	//-----------------------------------------------------------------------------	%a = \"1 1 0\";	%b = \"2 0 1\";	// %r = mSqrt( ( 2 - 1 ) * ( 2 - 1) + ( 0 - 1 ) * ( 0 - 1 ) + ( 1 - 0 ) * ( 1 - 0 ) );	// %r = mSqrt( 3 );	%r = VectorDist( %a, %b );   @endtsexample   @ingroup Vectors )
/// </summary>
public  float VectorDist(Point3F a, Point3F b){


return m_ts.fn_VectorDist(a.AsString(), b.AsString());
}
/// <summary>
/// Compute the dot product of two vectors.   @param a The first vector.   @param b The second vector.   @return The dot product @a a * @a b.   @tsexample	//-----------------------------------------------------------------------------	//	// VectorDot( %a, %b );	//	// The dot product between vector a, (ax, ay, az), and vector b, (bx, by, bz), is:	//	//     a . b = ( ax * bx + ay * by + az * bz )	//	//-----------------------------------------------------------------------------	%a = \"1 1 0\";	%b = \"2 0 1\";	// %r = \"( 1 * 2 + 1 * 0 + 0 * 1 )\";	// %r = 2;	%r = VectorDot( %a, %b );   @endtsexample   @ingroup Vectors )
/// </summary>
public  float VectorDot(Point3F a, Point3F b){


return m_ts.fn_VectorDot(a.AsString(), b.AsString());
}
/// <summary>
/// Calculate the magnitude of the given vector.   @param v A vector.   @return The length of vector @a v.   @tsexample	//-----------------------------------------------------------------------------	//	// VectorLen( %a );	//	// The length or magnitude of  vector a, (ax, ay, az), is:	//	//     ||a|| = Sqrt( ax * ax + ay * ay + az * az )	//	//-----------------------------------------------------------------------------	%a = \"1 1 0\";	// %r = mSqrt( 1 * 1 + 1 * 1 + 0 * 0 );	// %r = mSqrt( 2 );	// %r = 1.414;	%r = VectorLen( %a );   @endtsexample   @ingroup Vectors )
/// </summary>
public  float VectorLen(Point3F v){


return m_ts.fn_VectorLen(v.AsString());
}
/// <summary>
/// Linearly interpolate between two vectors by @a t.   @param a Vector to start interpolation from.   @param b Vector to interpolate to.   @param t Interpolation factor (0-1).  At zero, @a a is returned and at one, @a b is returned.  In between, an interpolated vector       between @a a and @a b is returned.   @return An interpolated vector between @a a and @a b.   @tsexample	//-----------------------------------------------------------------------------	//	// VectorLerp( %a, %b );	//	// The point between vector a, (ax, ay, az), and vector b, (bx, by, bz), which is	// weighted by the interpolation factor, t, is	//	//     r = a + t * ( b - a )	//       = ( ax + t * ( bx - ax ), ay + t * ( by - ay ), az + t * ( bz - az ) )	//	//-----------------------------------------------------------------------------	%a = \"1 1 0\";	%b = \"2 0 1\";	%v = \"0.25\";	// %r = \"( 1 + 0.25 * ( 2 - 1 ), 1 + 0.25 * ( 0 - 1 ), 0 + 0.25 * ( 1 - 0 ) )\";	// %r = \"1.25 0.75 0.25\";	%r = VectorLerp( %a, %b );   @endtsexample   @ingroup Vectors )
/// </summary>
public  Point3F VectorLerp(Point3F a, Point3F b, float t){


return new Point3F ( m_ts.fn_VectorLerp(a.AsString(), b.AsString(), t));
}
/// <summary>
/// Brings a vector into its unit form, i.e. such that it has the magnitute 1.   @param v The vector to normalize.   @return The vector @a v scaled to length 1.   @tsexample	//-----------------------------------------------------------------------------	//	// VectorNormalize( %a );	//	// The normalized vector a, (ax, ay, az), is:	//	//     a^ = a / ||a||	//        = ( ax / ||a||, ay / ||a||, az / ||a|| )	//	//-----------------------------------------------------------------------------	%a = \"1 1 0\";	%l = 1.414;	// %r = \"( 1 / 1.141, 1 / 1.141, 0 / 1.141 )\";	// %r = \"0.707 0.707 0\";	%r = VectorNormalize( %a );   @endtsexample   @ingroup Vectors )
/// </summary>
public  Point3F VectorNormalize(Point3F v){


return new Point3F ( m_ts.fn_VectorNormalize(v.AsString()));
}
/// <summary>
/// Create an orthogonal basis from the given vector.   @param aaf The vector to create the orthogonal basis from.   @return A matrix representing the orthogonal basis.   @ingroup Vectors )
/// </summary>
public  MatrixF VectorOrthoBasis(AngAxisF aa){


return new MatrixF ( m_ts.fn_VectorOrthoBasis(aa.AsString()));
}
/// <summary>
/// (Vector3F, float) rotate a vector in 2d)
/// </summary>
public  string VectorRot(Point3F v, float angle){


return m_ts.fn_VectorRot(v.AsString(), angle);
}
/// <summary>
/// Scales a vector by a scalar.   @param a The vector to scale.   @param scalar The scale factor.   @return The vector @a a * @a scalar.   @tsexample	//-----------------------------------------------------------------------------	//	// VectorScale( %a, %v );	//	// Scaling vector a, (ax, ay, az), but the scalar, v, is:	//	//     a * v = ( ax * v, ay * v, az * v )	//	//-----------------------------------------------------------------------------	%a = \"1 1 0\";	%v = \"2\";	// %r = \"( 1 * 2, 1 * 2, 0 * 2 )\";	// %r = \"2 2 0\";	%r = VectorScale( %a, %v );   @endtsexample   @ingroup Vectors )
/// </summary>
public  Point3F VectorScale(Point3F a, float scalar){


return new Point3F ( m_ts.fn_VectorScale(a.AsString(), scalar));
}
/// <summary>
/// Subtract two vectors.   @param a The first vector.   @param b The second vector.   @return The vector @a a - @a b.   @tsexample	//-----------------------------------------------------------------------------	//	// VectorSub( %a, %b );	//	// The difference of vector a, (ax, ay, az), and vector b, (bx, by, bz) is:	//	//     a - b = ( ax - bx, ay - by, az - bz )	//	//-----------------------------------------------------------------------------	%a = \"1 0 0\";	%b = \"0 1 0\";	// %r = \"( 1 - 0, 0 - 1, 0 - 0 )\";	// %r = \"1 -1 0\";	%r = VectorSub( %a, %b );   @endtsexample   @ingroup Vectors )
/// </summary>
public  Point3F VectorSub(Point3F a, Point3F b){


return new Point3F ( m_ts.fn_VectorSub(a.AsString(), b.AsString()));
}
/// <summary>
/// @brief Update all NavMesh tiles that intersect the given object's world box.)
/// 
/// </summary>
public  void WalkaboutUpdateAll(int objid = 0, bool remove = false){


m_ts.fn_WalkaboutUpdateAll(objid, remove);
}
/// <summary>
/// @brief Update all tiles in a given NavMesh that intersect the given object's world box.)
/// 
/// </summary>
public  void WalkaboutUpdateMesh(int meshid = 0, int objid = 0, bool remove = false){


m_ts.fn_WalkaboutUpdateMesh(meshid, objid, remove);
}
/// <summary>
/// Force all cached fonts to serialize themselves to the cache.   @ingroup Font )
/// </summary>
public  void writeFontCache(){


m_ts.fn_writeFontCache();
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ActionMapObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ActionMapObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( ActionMap, bind, bool, 5, 10, actionMap.bind( device, action, [modifier spec, mod...], command ) 			  @hide)
/// </summary>
public  bool bind(string actionmap, string a2, string a3, string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= ""){


return m_ts.fnActionMap_bind(actionmap, a2, a3, a4, a5, a6, a7, a8, a9);
}
/// <summary>
///  ),    @brief Associates a make command and optional break command to a specified input device action.    Must include parenthesis and semicolon in the make and break command strings.    @param device The device to bind to. Can be a keyboard, mouse, joystick or gamepad.    @param action The device action to bind to. The action is dependant upon the device. Specify a key for keyboards.    @param makeCmd The command to execute when the device/action is made.    @param breakCmd [optional] The command to execute when the device or action is unmade.    @return True the bind was successful, false if the device was unknown or description failed.	@tsexample	// Print to the console when the spacebar is pressed	function onSpaceDown()	{	   echo(\"Space bar down!\");	}	// Print to the console when the spacebar is released	function onSpaceUp()	{	   echo(\"Space bar up!\");	}   // Bind the commands onSpaceDown() and onSpaceUp() to spacebar events	moveMap.bindCmd(keyboard, \"space\", \"onSpaceDown();\", \"onSpaceUp();\");	@endtsexample)
/// </summary>
public  bool bindCmd(string actionmap, string device, string action, string makeCmd, string breakCmd = ""){


return m_ts.fnActionMap_bindCmd(actionmap, device, action, makeCmd, breakCmd);
}
/// <summary>
/// ( ActionMap, bindObj, bool, 6, 11, (device, action, [modifier spec, mod...], command, object)			  @hide)
/// </summary>
public  bool bindObj(string actionmap, string a2, string a3, string a4, string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= ""){


return m_ts.fnActionMap_bindObj(actionmap, a2, a3, a4, a5, a6, a7, a8, a9, a10);
}
/// <summary>
/// @brief Gets the ActionMap binding for the specified command.   Use getField() on the return value to get the device and action of the binding.   @param command The function to search bindings for.   @return The binding against the specified command. Returns an empty string(\"\")    if a binding wasn't found.	@tsexample	// Find what the function \"jump()\" is bound to in moveMap	%bind = moveMap.getBinding( \"jump\" );	if ( %bind !$= \"\" )	{	// Find out what device is used in the binding		%device = getField( %bind, 0 );	// Find out what action (such as a key) is used in the binding		%action = getField( %bind, 1 );	}	@endtsexample   @see getField)
/// </summary>
public  string getBinding(string actionmap, string command){


return m_ts.fnActionMap_getBinding(actionmap, command);
}
/// <summary>
/// @brief Gets ActionMap command for the device and action.   @param device The device that was bound. Can be a keyboard, mouse, joystick or a gamepad.   @param action The device action that was bound.  The action is dependant upon the device. Specify a key for keyboards.   @return The command against the specified device and action.	@tsexample	// Find what function is bound to a device\'s action	// In this example, \"jump()\" was assigned to the space key in another script	%command = moveMap.getCommand(\"keyboard\", \"space\");	// Should print \"jump\" in the console	echo(%command)	@endtsexample)
/// </summary>
public  string getCommand(string actionmap, string device, string action){


return m_ts.fnActionMap_getCommand(actionmap, device, action);
}
/// <summary>
/// @brief Gets the Dead zone for the specified device and action.   @param device The device that was bound.  Can be a keyboard, mouse, joystick or a gamepad.   @param action The device action that was bound. The action is dependant upon the device. Specify a key for keyboards.   @return The dead zone for the specified device and action. Returns \"0 0\" if there is no dead zone     or an empty string(\"\") if the mapping was not found.	@tsexample	%deadZone = moveMap.getDeadZone( \"gamepad\", \"thumbrx\");	@endtsexample)
/// </summary>
public  string getDeadZone(string actionmap, string device, string action){


return m_ts.fnActionMap_getDeadZone(actionmap, device, action);
}
/// <summary>
/// @brief Get any scaling on the specified device and action.   @param device The device that was bound. Can be keyboard, mouse, joystick or gamepad.   @param action The device action that was bound. The action is dependant upon the device. Specify a key for keyboards.   @return Any scaling applied to the specified device and action.	@tsexample	%scale = %moveMap.getScale( \"gamepad\", \"thumbrx\");	@endtsexample)
/// </summary>
public  float getScale(string actionmap, string device, string action){


return m_ts.fnActionMap_getScale(actionmap, device, action);
}
/// <summary>
/// @brief Determines if the specified device and action is inverted.   Should only be used for scrolling devices or gamepad/joystick axes.   @param device The device that was bound. Can be a keyboard, mouse, joystick or a gamepad.   @param action The device action that was bound.  The action is dependant upon the device. Specify a key for keyboards.   @return True if the specified device and action is inverted.	@tsexample   %if ( moveMap.isInverted( \"mouse\", \"xaxis\"))      echo(\"Mouse's xAxis is inverted\");	@endtsexample)
/// </summary>
public  bool isInverted(string actionmap, string device, string action){


return m_ts.fnActionMap_isInverted(actionmap, device, action);
}
/// <summary>
/// @brief Pop the ActionMap off the %ActionMap stack.   Deactivates an %ActionMap and removes it from the @ActionMap stack.	@tsexample	// Deactivate moveMap	moveMap.pop();	@endtsexample   @see ActionMap)
/// </summary>
public  void pop(string actionmap){


m_ts.fnActionMap_pop(actionmap);
}
/// <summary>
/// @brief Push the ActionMap onto the %ActionMap stack.   Activates an ActionMap and placees it at the top of the ActionMap stack.	@tsexample	// Make moveMap the active action map	moveMap.push();	@endtsexample   @see ActionMap)
/// </summary>
public  void push(string actionmap){


m_ts.fnActionMap_push(actionmap);
}
/// <summary>
/// @brief Saves the ActionMap to a file or dumps it to the console.   @param fileName The file path to save the ActionMap to. If a filename is not specified     the ActionMap will be dumped to the console.   @param append Whether to write the ActionMap at the end of the file or overwrite it.	@tsexample	// Write out the actionmap into the config.cs file   moveMap.save( \"scripts/client/config.cs\" );	@endtsexample)
/// </summary>
public  void save(string actionmap, string fileName = null , bool append = false){
if (fileName== null) {fileName = null;}


m_ts.fnActionMap_save(actionmap, fileName, append);
}
/// <summary>
/// @brief Removes the binding on an input device and action.   @param device The device to unbind from. Can be a keyboard, mouse, joystick or a gamepad.   @param action The device action to unbind from. The action is dependant upon the device. Specify a key for keyboards.   @return True if the unbind was successful, false if the device was unknown or description failed.	@tsexample	moveMap.unbind(\"keyboard\", \"space\");	@endtsexample)
/// </summary>
public  bool unbind(string actionmap, string device, string action){


return m_ts.fnActionMap_unbind(actionmap, device, action);
}
/// <summary>
/// @brief Remove any object-binding on an input device and action.   @param device The device to bind to.  Can be keyboard, mouse, joystick or gamepad.   @param action The device action to unbind from. The action is dependant upon the device. Specify a key for keyboards.   @param obj The object to perform unbind against.   @return True if the unbind was successful, false if the device was unknown or description failed.	@tsexample   moveMap.unbindObj(\"keyboard\", \"numpad1\", \"rangeChange\", %player);   @endtsexample)
/// </summary>
public  bool unbindObj(string actionmap, string device, string action, string obj){


return m_ts.fnActionMap_unbindObj(actionmap, device, action, obj);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class AIClientObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public AIClientObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ai.getAimLocation(); ) 
/// </summary>
public  string AIClient_getAimLocation(string aiclient){


return m_ts.fn_AIClient_getAimLocation(aiclient);
}
/// <summary>
/// ai.getLocation(); ) 
/// </summary>
public  string AIClient_getLocation(string aiclient){


return m_ts.fn_AIClient_getLocation(aiclient);
}
/// <summary>
/// ai.getMoveDestination(); ) 
/// </summary>
public  string AIClient_getMoveDestination(string aiclient){


return m_ts.fn_AIClient_getMoveDestination(aiclient);
}
/// <summary>
/// ai.getTargetObject(); ) 
/// </summary>
public  int AIClient_getTargetObject(string aiclient){


return m_ts.fn_AIClient_getTargetObject(aiclient);
}
/// <summary>
/// ai.missionCycleCleanup(); ) 
/// </summary>
public  void AIClient_missionCycleCleanup(string aiclient){


m_ts.fn_AIClient_missionCycleCleanup(aiclient);
}
/// <summary>
/// ai.move(); ) 
/// </summary>
public  void AIClient_move(string aiclient){


m_ts.fn_AIClient_move(aiclient);
}
/// <summary>
/// ai.moveForward(); ) 
/// </summary>
public  void AIClient_moveForward(string aiclient){


m_ts.fn_AIClient_moveForward(aiclient);
}
/// <summary>
/// ai.setAimLocation( x y z ); ) 
/// </summary>
public  void AIClient_setAimLocation(string aiclient, Point3F v){


m_ts.fn_AIClient_setAimLocation(aiclient, v.AsString());
}
/// <summary>
/// ai.setMoveDestination( x y z ); )
/// </summary>
public  void AIClient_setMoveDestination(string aiclient, Point3F v){


m_ts.fn_AIClient_setMoveDestination(aiclient, v.AsString());
}
/// <summary>
/// ai.setMoveSpeed( float ); ) 
/// </summary>
public  void AIClient_setMoveSpeed(string aiclient, float speed){


m_ts.fn_AIClient_setMoveSpeed(aiclient, speed);
}
/// <summary>
/// ai.setTargetObject( obj ); ) 
/// </summary>
public  void AIClient_setTargetObject(string aiclient, string objName){


m_ts.fn_AIClient_setTargetObject(aiclient, objName);
}
/// <summary>
/// ai.stop(); ) 
/// </summary>
public  void AIClient_stop(string aiclient){


m_ts.fn_AIClient_stop(aiclient);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class AIConnectionObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public AIConnectionObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// )
/// </summary>
public  string AIConnection_getAddress(string aiconnection){


return m_ts.fn_AIConnection_getAddress(aiconnection);
}
/// <summary>
/// getFreeLook()              Is freelook on for the current move?)
/// </summary>
public  bool AIConnection_getFreeLook(string aiconnection){


return m_ts.fn_AIConnection_getFreeLook(aiconnection);
}
/// <summary>
/// (string field)              Get the given field of a move.              @param field One of {'x','y','z','yaw','pitch','roll'}              @returns The requested field on the current move.)
/// </summary>
public  float AIConnection_getMove(string aiconnection, string field){


return m_ts.fn_AIConnection_getMove(aiconnection, field);
}
/// <summary>
/// (int trigger)              Is the given trigger set?)
/// </summary>
public  bool AIConnection_getTrigger(string aiconnection, int idx){


return m_ts.fn_AIConnection_getTrigger(aiconnection, idx);
}
/// <summary>
/// (bool isFreeLook)              Enable/disable freelook on the current move.)
/// </summary>
public  void AIConnection_setFreeLook(string aiconnection, bool isFreeLook){


m_ts.fn_AIConnection_setFreeLook(aiconnection, isFreeLook);
}
/// <summary>
/// (string field, float value)              Set a field on the current move.              @param   field One of {'x','y','z','yaw','pitch','roll'}              @param   value Value to set field to.)
/// </summary>
public  void AIConnection_setMove(string aiconnection, string field, float value){


m_ts.fn_AIConnection_setMove(aiconnection, field, value);
}
/// <summary>
/// (int trigger, bool set)              Set a trigger.)
/// </summary>
public  void AIConnection_setTrigger(string aiconnection, int idx, bool set){


m_ts.fn_AIConnection_setTrigger(aiconnection, idx, set);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class AIPlayerObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public AIPlayerObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( GameBase obj, [Point3F offset] )              Sets the bot's target object. Optionally set an offset from target location.			  @hide)
/// </summary>
public  void AIPlayer_setAimObject(string aiplayer, string objName, Point3F offset = null ){
if (offset== null) {offset = new Point3F(0.0f, 0.0f, 0.0f);}


m_ts.fn_AIPlayer_setAimObject(aiplayer, objName, offset.AsString());
}
/// <summary>
/// )	
/// </summary>
public  void AISearchSimSet(string aiplayer, float fOV, float farDist, string ObjToSearch, string result){


m_ts.fnAIPlayer_AISearchSimSet(aiplayer, fOV, farDist, ObjToSearch, result);
}
/// <summary>
/// @brief Use this to stop aiming at an object or a point.      @see setAimLocation()   @see setAimObject())
/// </summary>
public  void clearAim(string aiplayer){


m_ts.fnAIPlayer_clearAim(aiplayer);
}
/// <summary>
/// @brief Tells the AI to find cover nearby.
/// 
///    @param from   Location to find cover from (i.e., enemy position).
///    @param radius Distance to search for cover.
///    @return Cover point ID if cover was found, -1 otherwise.)
/// 
/// </summary>
public  int findCover(string aiplayer, Point3F from, float radius){


return m_ts.fnAIPlayer_findCover(aiplayer, from.AsString(), radius);
}
/// <summary>
/// @brief Get the NavMesh object this AIPlayer is currently using.
/// 
///    @return The ID of the NavPath object this character is using for 
///    pathfinding. This is determined by the character's location, 
///    navigation type and other factors. Returns -1 if no NavMesh is 
///    found.)
/// 
/// </summary>
public  int findNavMesh(string aiplayer){


return m_ts.fnAIPlayer_findNavMesh(aiplayer);
}
/// <summary>
/// @brief Tell the AIPlayer to follow a path.
/// 
///    @param obj ID of a NavPath object for the character to follow.)
/// 
/// </summary>
public  void followNavPath(string aiplayer, uint obj){


m_ts.fnAIPlayer_followNavPath(aiplayer, obj);
}
/// <summary>
/// @brief Tell the AIPlayer to follow another object.
/// 
///    @param obj ID of the object to follow.
///    @param radius Maximum distance we let the target escape to.)
/// 
/// </summary>
public  void followObject(string aiplayer, uint obj, float radius){


m_ts.fnAIPlayer_followObject(aiplayer, obj, radius);
}
/// <summary>
/// @brief Returns the point the AIPlayer is aiming at.   This will reflect the position set by setAimLocation(),    or the position of the object that the bot is now aiming at.     If the bot is not aiming at anything, this value will    change to whatever point the bot's current line-of-sight intercepts.   @return World space coordinates of the object AI is aiming at. Formatted as \"X Y Z\".      @see setAimLocation()   @see setAimObject())
/// </summary>
public  Point3F getAimLocation(string aiplayer){


return new Point3F ( m_ts.fnAIPlayer_getAimLocation(aiplayer));
}
/// <summary>
/// @brief Gets the object the AIPlayer is targeting.   @return Returns -1 if no object is being aimed at,    or the SimObjectID of the object the AIPlayer is aiming at.      @see setAimObject())
/// </summary>
public  int getAimObject(string aiplayer){


return m_ts.fnAIPlayer_getAimObject(aiplayer);
}
/// <summary>
/// @brief Get the AIPlayer's current destination.   @return Returns a point containing the \"x y z\" position    of the AIPlayer's current move destination. If no move destination    has yet been set, this returns \"0 0 0\".      @see setMoveDestination())
/// </summary>
public  Point3F getMoveDestination(string aiplayer){


return new Point3F ( m_ts.fnAIPlayer_getMoveDestination(aiplayer));
}
/// <summary>
/// @brief Gets the move speed of an AI object.   @return A speed multiplier between 0.0 and 1.0.   @see setMoveSpeed())
/// </summary>
public  float getMoveSpeed(string aiplayer){


return m_ts.fnAIPlayer_getMoveSpeed(aiplayer);
}
/// <summary>
/// @brief Return the NavMesh this AIPlayer is using to navigate.)
/// 
/// </summary>
public  int getNavMesh(string aiplayer){


return m_ts.fnAIPlayer_getNavMesh(aiplayer);
}
/// <summary>
/// @brief Return the size of NavMesh this character uses for pathfinding.)
/// 
/// </summary>
public  string getNavSize(string aiplayer){


return m_ts.fnAIPlayer_getNavSize(aiplayer);
}
/// <summary>
/// @brief Get the AIPlayer's current pathfinding destination.
/// 
///    @return Returns a point containing the \"x y z\" position 
///    of the AIPlayer's current path destination. If no path destination 
///    has yet been set, this returns \"0 0 0\".
/// 
///    @see setPathDestination())
/// 
/// </summary>
public  Point3F getPathDestination(string aiplayer){


return new Point3F ( m_ts.fnAIPlayer_getPathDestination(aiplayer));
}
/// <summary>
/// @brief Tells the AI to re-plan its path. Does nothing if the character 
///    has no path, or if it is following a mission path.)
/// 
/// </summary>
public  void repath(string aiplayer){


m_ts.fnAIPlayer_repath(aiplayer);
}
/// <summary>
/// @brief Tells the AIPlayer to aim at the location provided.   @param target An \"x y z\" position in the game world to target.      @see getAimLocation())
/// </summary>
public  void setAimLocation(string aiplayer, Point3F target){


m_ts.fnAIPlayer_setAimLocation(aiplayer, target.AsString());
}
/// <summary>
/// @brief Tells the AI to move to the location provided   @param goal Coordinates in world space representing location to move to.   @param slowDown A boolean value. If set to true, the bot will slow down    when it gets within 5-meters of its move destination. If false, the bot    will stop abruptly when it reaches the move destination. By default, this is true.   @note Upon reaching a move destination, the bot will clear its move destination and    calls to getMoveDestination will return \"0 0 0\".      @see getMoveDestination())
/// </summary>
public  void setMoveDestination(string aiplayer, Point3F goal, bool slowDown = true){


m_ts.fnAIPlayer_setMoveDestination(aiplayer, goal.AsString(), slowDown);
}
/// <summary>
/// @brief Sets the move speed for an AI object.   @param speed A speed multiplier between 0.0 and 1.0.     This is multiplied by the AIPlayer's base movement rates (as defined in    its PlayerData datablock)      @see getMoveDestination())
/// </summary>
public  void setMoveSpeed(string aiplayer, float speed){


m_ts.fnAIPlayer_setMoveSpeed(aiplayer, speed);
}
/// <summary>
/// @brief Set the size of NavMesh this character uses. One of \"Small\", \"Regular\" or \"Large\".)
/// 
/// </summary>
public  void setNavSize(string aiplayer, string size){


m_ts.fnAIPlayer_setNavSize(aiplayer, size);
}
/// <summary>
/// @brief Tells the AI to find a path to the location provided
/// 
///    @param goal Coordinates in world space representing location to move to.
///    @return True if a path was found.
/// 
///    @see getPathDestination()
///    @see setMoveDestination())
/// 
/// </summary>
public  bool setPathDestination(string aiplayer, Point3F goal){


return m_ts.fnAIPlayer_setPathDestination(aiplayer, goal.AsString());
}
/// <summary>
/// @brief Tells the AIPlayer to stop moving.)
/// </summary>
public  void stop(string aiplayer){


m_ts.fnAIPlayer_stop(aiplayer);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class AITurretShapeObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public AITurretShapeObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Activate a turret from a deactive state.)
/// </summary>
public  void activateTurret(string aiturretshape){


m_ts.fnAITurretShape_activateTurret(aiturretshape);
}
/// <summary>
/// @brief Adds object to the turret's ignore list.   All objects in this list will be ignored by the turret's targeting.   @param obj The ShapeBase object to ignore.)
/// </summary>
public  void addToIgnoreList(string aiturretshape, string obj){


m_ts.fnAITurretShape_addToIgnoreList(aiturretshape, obj);
}
/// <summary>
/// @brief Deactivate a turret from an active state.)
/// </summary>
public  void deactivateTurret(string aiturretshape){


m_ts.fnAITurretShape_deactivateTurret(aiturretshape);
}
/// <summary>
/// @brief Get the turret's current target.   @returns The object that is the target's current target, or 0 if no target.)
/// </summary>
public  string getTarget(string aiturretshape){


return m_ts.fnAITurretShape_getTarget(aiturretshape);
}
/// <summary>
/// @brief Get the turret's defined projectile velocity that helps with target leading.   @returns The defined weapon projectile speed, or 0 if leading is disabled.)
/// </summary>
public  float getWeaponLeadVelocity(string aiturretshape){


return m_ts.fnAITurretShape_getWeaponLeadVelocity(aiturretshape);
}
/// <summary>
/// @brief Indicates if the turret has a target.   @returns True if the turret has a target.)
/// </summary>
public  bool hasTarget(string aiturretshape){


return m_ts.fnAITurretShape_hasTarget(aiturretshape);
}
/// <summary>
/// @brief Recenter the turret's weapon.)
/// </summary>
public  void recenterTurret(string aiturretshape){


m_ts.fnAITurretShape_recenterTurret(aiturretshape);
}
/// <summary>
/// @brief Removes object from the turret's ignore list.   All objects in this list will be ignored by the turret's targeting.   @param obj The ShapeBase object to once again allow for targeting.)
/// </summary>
public  void removeFromIgnoreList(string aiturretshape, string obj){


m_ts.fnAITurretShape_removeFromIgnoreList(aiturretshape, obj);
}
/// <summary>
/// @brief Resets the turret's target tracking.   Only resets the internal target tracking.  Does not modify the turret's facing.)
/// </summary>
public  void resetTarget(string aiturretshape){


m_ts.fnAITurretShape_resetTarget(aiturretshape);
}
/// <summary>
/// @brief Set the firing state of the turret's guns.   @param fire Set to true to activate all guns.  False to deactivate them.)
/// </summary>
public  void setAllGunsFiring(string aiturretshape, bool fire){


m_ts.fnAITurretShape_setAllGunsFiring(aiturretshape, fire);
}
/// <summary>
/// @brief Set the firing state of the given gun slot.   @param slot The gun to modify.  Valid range is 0-3 that corresponds to the weapon mount point.   @param fire Set to true to activate the gun.  False to deactivate it.)
/// </summary>
public  void setGunSlotFiring(string aiturretshape, int slot, bool fire){


m_ts.fnAITurretShape_setGunSlotFiring(aiturretshape, slot, fire);
}
/// <summary>
/// @brief Set the turret's current state.   Normally the turret's state comes from updating the state machine but this method    allows you to override this and jump to the requested state immediately.   @param newState The name of the new state.   @param force Is true then force the full processing of the new state even if it is the    same as the current state.  If false then only the time out value is reset and the state's    script method is called, if any.)
/// </summary>
public  void setTurretState(string aiturretshape, string newState, bool force = false){


m_ts.fnAITurretShape_setTurretState(aiturretshape, newState, force);
}
/// <summary>
/// @brief Set the turret's projectile velocity to help lead the target.   This value normally comes from AITurretShapeData::weaponLeadVelocity but this method    allows you to override the datablock value.  This can be useful if the turret changes    ammunition, uses a different weapon than the default, is damaged, etc.   @note Setting this to 0 will disable target leading.)
/// </summary>
public  void setWeaponLeadVelocity(string aiturretshape, float velocity){


m_ts.fnAITurretShape_setWeaponLeadVelocity(aiturretshape, velocity);
}
/// <summary>
/// @brief Begin scanning for a target.)
/// </summary>
public  void startScanForTargets(string aiturretshape){


m_ts.fnAITurretShape_startScanForTargets(aiturretshape);
}
/// <summary>
/// @brief Have the turret track the current target.)
/// </summary>
public  void startTrackingTarget(string aiturretshape){


m_ts.fnAITurretShape_startTrackingTarget(aiturretshape);
}
/// <summary>
/// @brief Stop scanning for targets.   @note Only impacts the scanning for new targets.  Does not effect a turret's current    target lock.)
/// </summary>
public  void stopScanForTargets(string aiturretshape){


m_ts.fnAITurretShape_stopScanForTargets(aiturretshape);
}
/// <summary>
/// @brief Stop the turret from tracking the current target.)
/// </summary>
public  void stopTrackingTarget(string aiturretshape){


m_ts.fnAITurretShape_stopTrackingTarget(aiturretshape);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ArrayObjectObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ArrayObjectObject(ref Omni ts){m_ts = ts;}
/// <summary>
///  ),   Adds a new element to the end of an array (same as push_back()).   @param key Key for the new element   @param value Value for the new element )
/// </summary>
public  void add(string arrayobject, string key, string value = ""){


m_ts.fnArrayObject_add(arrayobject, key, value);
}
/// <summary>
/// Appends the target array to the array object.   @param target ArrayObject to append to the end of this array )
/// </summary>
public  bool append(string arrayobject, string target){


return m_ts.fnArrayObject_append(arrayobject, target);
}
/// <summary>
/// Get the number of elements in the array. )
/// </summary>
public  int count(string arrayobject){


return m_ts.fnArrayObject_count(arrayobject);
}
/// <summary>
/// Get the number of times a particular key is found in the array.   @param key Key value to count )
/// </summary>
public  int countKey(string arrayobject, string key){


return m_ts.fnArrayObject_countKey(arrayobject, key);
}
/// <summary>
/// Get the number of times a particular value is found in the array.   @param value Array element value to count )
/// </summary>
public  int countValue(string arrayobject, string value){


return m_ts.fnArrayObject_countValue(arrayobject, value);
}
/// <summary>
/// Removes elements with matching keys from array.   @param target ArrayObject containing keys to remove from this array )
/// </summary>
public  bool crop(string arrayobject, string target){


return m_ts.fnArrayObject_crop(arrayobject, target);
}
/// <summary>
/// Alters array into an exact duplicate of the target array.   @param target ArrayObject to duplicate )
/// </summary>
public  bool duplicate(string arrayobject, string target){


return m_ts.fnArrayObject_duplicate(arrayobject, target);
}
/// <summary>
/// Echos the array contents to the console )
/// </summary>
public  void echo(string arrayobject){


m_ts.fnArrayObject_echo(arrayobject);
}
/// <summary>
/// Emptys all elements from an array )
/// </summary>
public  void empty(string arrayobject){


m_ts.fnArrayObject_empty(arrayobject);
}
/// <summary>
/// Removes an element at a specific position from the array.   @param index 0-based index of the element to remove )
/// </summary>
public  void erase(string arrayobject, int index){


m_ts.fnArrayObject_erase(arrayobject, index);
}
/// <summary>
/// Gets the current pointer index )
/// </summary>
public  int getCurrent(string arrayobject){


return m_ts.fnArrayObject_getCurrent(arrayobject);
}
/// <summary>
/// Search the array from the current position for the key    @param value Array key to search for   @return Index of the first element found, or -1 if none )
/// </summary>
public  int getIndexFromKey(string arrayobject, string key){


return m_ts.fnArrayObject_getIndexFromKey(arrayobject, key);
}
/// <summary>
/// Search the array from the current position for the element    @param value Array value to search for   @return Index of the first element found, or -1 if none )
/// </summary>
public  int getIndexFromValue(string arrayobject, string value){


return m_ts.fnArrayObject_getIndexFromValue(arrayobject, value);
}
/// <summary>
/// Get the key of the array element at the submitted index.   @param index 0-based index of the array element to get   @return The key associated with the array element at the    specified index, or \"\" if the index is out of range )
/// </summary>
public  string getKey(string arrayobject, int index){


return m_ts.fnArrayObject_getKey(arrayobject, index);
}
/// <summary>
/// Get the value of the array element at the submitted index.   @param index 0-based index of the array element to get   @return The value of the array element at the specified index,    or \"\" if the index is out of range )
/// </summary>
public  string getValue(string arrayobject, int index){


return m_ts.fnArrayObject_getValue(arrayobject, index);
}
/// <summary>
/// Adds a new element to a specified position in the array.   - @a index = 0 will insert an element at the start of the array (same as push_front())   - @a index = %array.count() will insert an element at the end of the array (same as push_back())   @param key Key for the new element   @param value Value for the new element   @param index 0-based index at which to insert the new element )
/// </summary>
public  void insert(string arrayobject, string key, string value, int index){


m_ts.fnArrayObject_insert(arrayobject, key, value, index);
}
/// <summary>
/// Moves array pointer to start of array   @return Returns the new array pointer )
/// </summary>
public  int moveFirst(string arrayobject){


return m_ts.fnArrayObject_moveFirst(arrayobject);
}
/// <summary>
/// Moves array pointer to end of array   @return Returns the new array pointer )
/// </summary>
public  int moveLast(string arrayobject){


return m_ts.fnArrayObject_moveLast(arrayobject);
}
/// <summary>
/// Moves array pointer to next position   @return Returns the new array pointer, or -1 if already at the end )
/// </summary>
public  int moveNext(string arrayobject){


return m_ts.fnArrayObject_moveNext(arrayobject);
}
/// <summary>
/// Moves array pointer to prev position   @return Returns the new array pointer, or -1 if already at the start )
/// </summary>
public  int movePrev(string arrayobject){


return m_ts.fnArrayObject_movePrev(arrayobject);
}
/// <summary>
/// Removes the last element from the array )
/// </summary>
public  void pop_back(string arrayobject){


m_ts.fnArrayObject_pop_back(arrayobject);
}
/// <summary>
/// Removes the first element from the array )
/// </summary>
public  void pop_front(string arrayobject){


m_ts.fnArrayObject_pop_front(arrayobject);
}
/// <summary>
///  ),   Adds a new element to the end of an array.   @param key Key for the new element   @param value Value for the new element )
/// </summary>
public  void push_back(string arrayobject, string key, string value = ""){


m_ts.fnArrayObject_push_back(arrayobject, key, value);
}
/// <summary>
///  ),   Adds a new element to the front of an array )
/// </summary>
public  void push_front(string arrayobject, string key, string value = ""){


m_ts.fnArrayObject_push_front(arrayobject, key, value);
}
/// <summary>
/// Sets the current pointer index.   @param index New 0-based pointer index )
/// </summary>
public  void setCurrent(string arrayobject, int index){


m_ts.fnArrayObject_setCurrent(arrayobject, index);
}
/// <summary>
/// Set the key at the given index.   @param key New key value   @param index 0-based index of the array element to update )
/// </summary>
public  void setKey(string arrayobject, string key, int index){


m_ts.fnArrayObject_setKey(arrayobject, key, index);
}
/// <summary>
/// Set the value at the given index.   @param value New array element value   @param index 0-based index of the array element to update )
/// </summary>
public  void setValue(string arrayobject, string value, int index){


m_ts.fnArrayObject_setValue(arrayobject, value, index);
}
/// <summary>
/// Alpha sorts the array by value   @param ascending [optional] True for ascending sort, false for descending sort )
/// </summary>
public  void sort(string arrayobject, bool ascending = false){


m_ts.fnArrayObject_sort(arrayobject, ascending);
}
/// <summary>
/// Alpha sorts the array by value in ascending order )
/// </summary>
public  void sorta(string arrayobject){


m_ts.fnArrayObject_sorta(arrayobject);
}
/// <summary>
/// Alpha sorts the array by value in descending order )
/// </summary>
public  void sortd(string arrayobject){


m_ts.fnArrayObject_sortd(arrayobject);
}
/// <summary>
/// Sorts the array by value in ascending order using the given callback function.   @param functionName Name of a function that takes two arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal.   @tsexample   function mySortCallback(%a, %b)   {      return strcmp( %a.name, %b.name );   }   %array.sortf( \"mySortCallback\" );   @endtsexample )
/// </summary>
public  void sortf(string arrayobject, string functionName){


m_ts.fnArrayObject_sortf(arrayobject, functionName);
}
/// <summary>
/// Sorts the array by value in descending order using the given callback function.   @param functionName Name of a function that takes two arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal.   @see sortf )
/// </summary>
public  void sortfd(string arrayobject, string functionName){


m_ts.fnArrayObject_sortfd(arrayobject, functionName);
}
/// <summary>
/// Sorts the array by key in ascending order using the given callback function.   @param functionName Name of a function that takes two arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal.   @see sortf )
/// </summary>
public  void sortfk(string arrayobject, string functionName){


m_ts.fnArrayObject_sortfk(arrayobject, functionName);
}
/// <summary>
/// Sorts the array by key in descending order using the given callback function.   @param functionName Name of a function that takes two arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal.   @see sortf )
/// </summary>
public  void sortfkd(string arrayobject, string functionName){


m_ts.fnArrayObject_sortfkd(arrayobject, functionName);
}
/// <summary>
/// Alpha sorts the array by key   @param ascending [optional] True for ascending sort, false for descending sort )
/// </summary>
public  void sortk(string arrayobject, bool ascending = false){


m_ts.fnArrayObject_sortk(arrayobject, ascending);
}
/// <summary>
/// Alpha sorts the array by key in ascending order )
/// </summary>
public  void sortka(string arrayobject){


m_ts.fnArrayObject_sortka(arrayobject);
}
/// <summary>
/// Alpha sorts the array by key in descending order )
/// </summary>
public  void sortkd(string arrayobject){


m_ts.fnArrayObject_sortkd(arrayobject);
}
/// <summary>
/// Numerically sorts the array by value   @param ascending [optional] True for ascending sort, false for descending sort )
/// </summary>
public  void sortn(string arrayobject, bool ascending = false){


m_ts.fnArrayObject_sortn(arrayobject, ascending);
}
/// <summary>
/// Numerically sorts the array by value in ascending order ) 
/// </summary>
public  void sortna(string arrayobject){


m_ts.fnArrayObject_sortna(arrayobject);
}
/// <summary>
/// Numerically sorts the array by value in descending order )
/// </summary>
public  void sortnd(string arrayobject){


m_ts.fnArrayObject_sortnd(arrayobject);
}
/// <summary>
/// Numerically sorts the array by key   @param ascending [optional] True for ascending sort, false for descending sort )
/// </summary>
public  void sortnk(string arrayobject, bool ascending = false){


m_ts.fnArrayObject_sortnk(arrayobject, ascending);
}
/// <summary>
/// Numerical sorts the array by key in ascending order )
/// </summary>
public  void sortnka(string arrayobject){


m_ts.fnArrayObject_sortnka(arrayobject);
}
/// <summary>
/// Numerical sorts the array by key in descending order )
/// </summary>
public  void sortnkd(string arrayobject){


m_ts.fnArrayObject_sortnkd(arrayobject);
}
/// <summary>
/// Removes any elements that have duplicated keys (leaving the first instance) )
/// </summary>
public  void uniqueKey(string arrayobject){


m_ts.fnArrayObject_uniqueKey(arrayobject);
}
/// <summary>
/// Removes any elements that have duplicated values (leaving the first instance) )
/// </summary>
public  void uniqueValue(string arrayobject){


m_ts.fnArrayObject_uniqueValue(arrayobject);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class CameraObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public CameraObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Move the camera to fully view the given radius.                   @note For this operation to take affect a valid edit orbit point must first be specified.  See Camera::setEditOrbitPoint().                   @param radius The radius to view.)
/// </summary>
public  void autoFitRadius(string camera, float radius){


m_ts.fnCamera_autoFitRadius(camera, radius);
}
/// <summary>
/// Get the angular velocity for a Newton mode camera.                   @returns The angular velocity in the form of \"x y z\".                   @note Only returns useful results when Camera::newtonRotation is set to true.)
/// </summary>
public  Point3F getAngularVelocity(string camera){


return new Point3F ( m_ts.fnCamera_getAngularVelocity(camera));
}
/// <summary>
/// Returns the current camera control mode.                   @see CameraMotionMode)
/// </summary>
public  TypeCameraMotionMode getMode(string camera){


return (TypeCameraMotionMode)( m_ts.fnCamera_getMode(camera));
}
/// <summary>
/// Get the camera's offset from its orbit or tracking point.                   The offset is added to the camera's position when set to CameraMode::OrbitObject.                   @returns The offset in the form of \"x y z\".)
/// </summary>
public  Point3F getOffset(string camera){


return new Point3F ( m_ts.fnCamera_getOffset(camera));
}
/// <summary>
/// Get the camera's position in the world.                   @returns The position in the form of \"x y z\".)
/// </summary>
public  Point3F getPosition(string camera){


return new Point3F ( m_ts.fnCamera_getPosition(camera));
}
/// <summary>
/// Get the camera's Euler rotation in radians.                   @returns The rotation in radians in the form of \"x y z\".)
/// </summary>
public  Point3F getRotation(string camera){


return new Point3F ( m_ts.fnCamera_getRotation(camera));
}
/// <summary>
/// Get the velocity for the camera.                   @returns The camera's velocity in the form of \"x y z\".                   @note Only useful when the Camera is in Newton mode.)
/// </summary>
public  Point3F getVelocity(string camera){


return new Point3F ( m_ts.fnCamera_getVelocity(camera));
}
/// <summary>
/// Is the camera in edit orbit mode?                   @returns true if the camera is in edit orbit mode.)
/// </summary>
public  bool isEditOrbitMode(string camera){


return m_ts.fnCamera_isEditOrbitMode(camera);
}
/// <summary>
/// Is this a Newton Fly mode camera with damped rotation?                    @returns true if the camera uses a damped rotation.  i.e. Camera::newtonRotation is set to true.)
/// </summary>
public  bool isRotationDamped(string camera){


return m_ts.fnCamera_isRotationDamped(camera);
}
/// <summary>
/// Point the camera at the specified position.  Does not work in Orbit or Track modes.                   @param point The position to point the camera at.)
/// </summary>
public  void lookAt(string camera, Point3F point){


m_ts.fnCamera_lookAt(camera, point.AsString());
}
/// <summary>
/// Set the angular drag for a Newton mode camera.                   @param drag The angular drag applied while the camera is rotating.                   @note Only takes affect when Camera::newtonRotation is set to true.)
/// </summary>
public  void setAngularDrag(string camera, float drag){


m_ts.fnCamera_setAngularDrag(camera, drag);
}
/// <summary>
/// Set the angular force for a Newton mode camera.                   @param force The angular force applied when attempting to rotate the camera.                   @note Only takes affect when Camera::newtonRotation is set to true.)
/// </summary>
public  void setAngularForce(string camera, float force){


m_ts.fnCamera_setAngularForce(camera, force);
}
/// <summary>
/// Set the angular velocity for a Newton mode camera.                   @param velocity The angular velocity infor form of \"x y z\".                   @note Only takes affect when Camera::newtonRotation is set to true.)
/// </summary>
public  void setAngularVelocity(string camera, Point3F velocity){


m_ts.fnCamera_setAngularVelocity(camera, velocity.AsString());
}
/// <summary>
/// Set the Newton mode camera brake multiplier when trigger[1] is active.                   @param multiplier The brake multiplier to apply.                   @note Only used when Camera is in Newton mode.)
/// </summary>
public  void setBrakeMultiplier(string camera, float multiplier){


m_ts.fnCamera_setBrakeMultiplier(camera, multiplier);
}
/// <summary>
/// Set the drag for a Newton mode camera.                   @param drag The drag applied to the camera while moving.                   @note Only used when Camera is in Newton mode.)
/// </summary>
public  void setDrag(string camera, float drag){


m_ts.fnCamera_setDrag(camera, drag);
}
/// <summary>
/// Set the editor camera to orbit around a point set with Camera::setEditOrbitPoint().                    @note This method is generally used only within the World Editor and other tools.  To                     orbit about an object or point within a game, see Camera::setOrbitMode() and its helper methods.)
/// </summary>
public  void setEditOrbitMode(string camera){


m_ts.fnCamera_setEditOrbitMode(camera);
}
/// <summary>
/// Set the editor camera's orbit point.                   @param point The point the camera will orbit in the form of \"x y z\".)
/// </summary>
public  void setEditOrbitPoint(string camera, Point3F point){


m_ts.fnCamera_setEditOrbitPoint(camera, point.AsString());
}
/// <summary>
/// Set the force applied to a Newton mode camera while moving.                   @param force The force applied to the camera while attempting to move.                   @note Only used when Camera is in Newton mode.)
/// </summary>
public  void setFlyForce(string camera, float force){


m_ts.fnCamera_setFlyForce(camera, force);
}
/// <summary>
/// Set the camera to fly freely.                   Allows the camera to have 6 degrees of freedom.  Provides for instantaneous motion                    and rotation unless one of the Newton fields has been set to true.  See Camera::newtonMode                    and Camera::newtonRotation.)
/// </summary>
public  void setFlyMode(string camera){


m_ts.fnCamera_setFlyMode(camera);
}
/// <summary>
/// Set the mass for a Newton mode camera.                   @param mass The mass used during ease-in and ease-out calculations.                   @note Only used when Camera is in Newton mode.)
/// </summary>
public  void setMass(string camera, float mass){


m_ts.fnCamera_setMass(camera, mass);
}
/// <summary>
/// Set the camera to fly freely, but with ease-in and ease-out.                    This method allows for the same 6 degrees of freedom as Camera::setFlyMode() but                     activates the ease-in and ease-out on the camera's movement.  To also activate                     Newton mode for the camera's rotation, set Camera::newtonRotation to true.)
/// </summary>
public  void setNewtonFlyMode(string camera){


m_ts.fnCamera_setNewtonFlyMode(camera);
}
/// <summary>
/// Set the camera's offset.                   The offset is added to the camera's position when set to CameraMode::OrbitObject.                   @param offset The distance to offset the camera by in the form of \"x y z\".)
/// </summary>
public  void setOffset(string camera, Point3F offset){


m_ts.fnCamera_setOffset(camera, offset.AsString());
}
/// <summary>
/// Set the camera to orbit around the given object, or if none is given, around the given point.                    @param orbitObject The object to orbit around.  If no object is given (0 or blank string is passed in) use the orbitPoint instead                    @param orbitPoint The point to orbit around when no object is given.  In the form of \"x y z ax ay az aa\" such as returned by SceneObject::getTransform().                    @param minDistance The minimum distance allowed to the orbit object or point.                    @param maxDistance The maximum distance allowed from the orbit object or point.                    @param initDistance The initial distance from the orbit object or point.                    @param ownClientObj [optional] Are we orbiting an object that is owned by us?  Default is false.                    @param offset [optional] An offset added to the camera's position.  Default is no offset.                    @param locked [optional] Indicates the camera does not receive input from the player.  Default is false.                    @see Camera::setOrbitObject()                    @see Camera::setOrbitPoint())
/// </summary>
public  bool setOrbitMode(string camera, string orbitObject, TransformF orbitPoint, float minDistance, float maxDistance, float initDistance, bool ownClientObj = false, Point3F offset = null , bool lockedx = false){
if (offset== null) {offset = new Point3F(0.0f, 0.0f, 0.0f);}


return m_ts.fnCamera_setOrbitMode(camera, orbitObject, orbitPoint.AsString(), minDistance, maxDistance, initDistance, ownClientObj, offset.AsString(), lockedx);
}
/// <summary>
/// Set the camera to orbit around a given object.                    @param orbitObject The object to orbit around.                    @param rotation The initial camera rotation about the object in radians in the form of \"x y z\".                    @param minDistance The minimum distance allowed to the orbit object or point.                    @param maxDistance The maximum distance allowed from the orbit object or point.                    @param initDistance The initial distance from the orbit object or point.                    @param ownClientObject [optional] Are we orbiting an object that is owned by us?  Default is false.                    @param offset [optional] An offset added to the camera's position.  Default is no offset.                    @param locked [optional] Indicates the camera does not receive input from the player.  Default is false.                    @returns false if the given object could not be found.                    @see Camera::setOrbitMode())
/// </summary>
public  bool setOrbitObject(string camera, string orbitObject, Point3F rotation, float minDistance, float maxDistance, float initDistance, bool ownClientObject = false, Point3F offset = null , bool lockedx = false){
if (offset== null) {offset = new Point3F(0.0f, 0.0f, 0.0f);}


return m_ts.fnCamera_setOrbitObject(camera, orbitObject, rotation.AsString(), minDistance, maxDistance, initDistance, ownClientObject, offset.AsString(), lockedx);
}
/// <summary>
/// Set the camera to orbit around a given point.                    @param orbitPoint The point to orbit around.  In the form of \"x y z ax ay az aa\" such as returned by SceneObject::getTransform().                    @param minDistance The minimum distance allowed to the orbit object or point.                    @param maxDistance The maximum distance allowed from the orbit object or point.                    @param initDistance The initial distance from the orbit object or point.                    @param offset [optional] An offset added to the camera's position.  Default is no offset.                    @param locked [optional] Indicates the camera does not receive input from the player.  Default is false.                    @see Camera::setOrbitMode())
/// </summary>
public  void setOrbitPoint(string camera, TransformF orbitPoint, float minDistance, float maxDistance, float initDistance, Point3F offset = null , bool lockedx = false){
if (offset== null) {offset = new Point3F(0.0f, 0.0f, 0.0f);}


m_ts.fnCamera_setOrbitPoint(camera, orbitPoint.AsString(), minDistance, maxDistance, initDistance, offset.AsString(), lockedx);
}
/// <summary>
/// Set the camera's Euler rotation in radians.                   @param rot The rotation in radians in the form of \"x y z\".                   @note Rotation around the Y axis is ignored )
/// </summary>
public  void setRotation(string camera, Point3F rot){


m_ts.fnCamera_setRotation(camera, rot.AsString());
}
/// <summary>
/// Set the Newton mode camera speed multiplier when trigger[0] is active.                   @param multiplier The speed multiplier to apply.                   @note Only used when Camera is in Newton mode.)
/// </summary>
public  void setSpeedMultiplier(string camera, float multiplier){


m_ts.fnCamera_setSpeedMultiplier(camera, multiplier);
}
/// <summary>
/// Set the camera to track a given object.                    @param trackObject The object to track.                    @param offset [optional] An offset added to the camera's position.  Default is no offset.                    @returns false if the given object could not be found.)
/// </summary>
public  bool setTrackObject(string camera, string trackObject, Point3F offset = null ){
if (offset== null) {offset = new Point3F(0.0f, 0.0f, 0.0f);}


return m_ts.fnCamera_setTrackObject(camera, trackObject, offset.AsString());
}
/// <summary>
/// Set if there is a valid editor camera orbit point.                   When validPoint is set to false the Camera operates as if it is                    in Fly mode rather than an Orbit mode.                   @param validPoint Indicates the validity of the orbit point.                   @note Only used when Camera is in Edit Orbit Mode.)
/// </summary>
public  void setValidEditOrbitPoint(string camera, bool validPoint){


m_ts.fnCamera_setValidEditOrbitPoint(camera, validPoint);
}
/// <summary>
/// Set the velocity for the camera.                   @param velocity The camera's velocity in the form of \"x y z\".                   @note Only affects the Camera when in Newton mode.)
/// </summary>
public  void setVelocity(string camera, Point3F velocity){


m_ts.fnCamera_setVelocity(camera, velocity.AsString());
}
}
   /// <summary>
        /// 
        /// </summary>
 public class CloudLayerObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public CloudLayerObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Change coverage of the cloudlayer.)  
/// </summary>
public  void ChangeCoverage(string cloudlayer, float newCoverage){


m_ts.fnCloudLayer_ChangeCoverage(cloudlayer, newCoverage);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class CompoundUndoActionObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public CompoundUndoActionObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// addAction( UndoAction ) )
/// </summary>
public  void CompoundUndoAction_addAction(string compoundundoaction, string objName){


m_ts.fn_CompoundUndoAction_addAction(compoundundoaction, objName);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ConsoleLoggerObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ConsoleLoggerObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// () Attaches the logger to the console and begins writing to file			  @tsexample			  // Create the logger			  // Will automatically start writing to testLogging.txt with normal priority			  new ConsoleLogger(logger, \"testLogging.txt\", false);			  // Send something to the console, with the logger consumes and writes to file			  echo(\"This is logged to the file\");			  // Stop logging, but do not delete the logger			  logger.detach();			  echo(\"This is not logged to the file\");			  // Attach the logger to the console again			  logger.attach();			  // Logging has resumed			  echo(\"Logging has resumed\");			  @endtsexample)
/// </summary>
public  bool ConsoleLogger_attach(string consolelogger){


return m_ts.fn_ConsoleLogger_attach(consolelogger);
}
/// <summary>
/// () Detaches the logger from the console and stops writing to file			  @tsexample			  // Create the logger			  // Will automatically start writing to testLogging.txt with normal priority			  new ConsoleLogger(logger, \"testLogging.txt\", false);			  // Send something to the console, with the logger consumes and writes to file			  echo(\"This is logged to the file\");			  // Stop logging, but do not delete the logger			  logger.detach();			  echo(\"This is not logged to the file\");			  // Attach the logger to the console again			  logger.attach();			  // Logging has resumed			  echo(\"Logging has resumed\");			  @endtsexample)
/// </summary>
public  bool ConsoleLogger_detach(string consolelogger){


return m_ts.fn_ConsoleLogger_detach(consolelogger);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class CoverPointObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public CoverPointObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Returns true if someone is already using this cover point.)
/// 
/// </summary>
public  bool isOccupied(string coverpoint){


return m_ts.fnCoverPoint_isOccupied(coverpoint);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class CreatorTreeObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public CreatorTreeObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// (string group, string name, string value))
/// </summary>
public  int CreatorTree_addGroup(string creatortree, int group, string name, string value){


return m_ts.fn_CreatorTree_addGroup(creatortree, group, name, value);
}
/// <summary>
/// (Node group, string name, string value))
/// </summary>
public  int CreatorTree_addItem(string creatortree, int group, string name, string value){


return m_ts.fn_CreatorTree_addItem(creatortree, group, name, value);
}
/// <summary>
/// Clear the tree.)
/// </summary>
public  void CreatorTree_clear(string creatortree){


m_ts.fn_CreatorTree_clear(creatortree);
}
/// <summary>
/// (string world, string type, string filename))
/// </summary>
public  bool CreatorTree_fileNameMatch(string creatortree, string world, string type, string filename){


return m_ts.fn_CreatorTree_fileNameMatch(creatortree, world, type, filename);
}
/// <summary>
/// (Node item))
/// </summary>
public  string CreatorTree_getName(string creatortree, string item){


return m_ts.fn_CreatorTree_getName(creatortree, item);
}
/// <summary>
/// (Node n))
/// </summary>
public  int CreatorTree_getParent(string creatortree, int nodeValue){


return m_ts.fn_CreatorTree_getParent(creatortree, nodeValue);
}
/// <summary>
/// Return a handle to the currently selected item.)
/// </summary>
public  int CreatorTree_getSelected(string creatortree){


return m_ts.fn_CreatorTree_getSelected(creatortree);
}
/// <summary>
/// (Node n))
/// </summary>
public  string CreatorTree_getValue(string creatortree, int nodeValue){


return m_ts.fn_CreatorTree_getValue(creatortree, nodeValue);
}
/// <summary>
/// (Group g))
/// </summary>
public  bool CreatorTree_isGroup(string creatortree, string group){


return m_ts.fn_CreatorTree_isGroup(creatortree, group);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class CubemapDataObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public CubemapDataObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Returns the script filename of where the CubemapData object was    defined.  This is used by the material editor. )
/// </summary>
public  string getFilename(string cubemapdata){


return m_ts.fnCubemapData_getFilename(cubemapdata);
}
/// <summary>
/// Update the assigned cubemaps faces. )
/// </summary>
public  void updateFaces(string cubemapdata){


m_ts.fnCubemapData_updateFaces(cubemapdata);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class DbgFileViewObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public DbgFileViewObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ()              Clear all break points in the current file.)
/// </summary>
public  void DbgFileView_clearBreakPositions(string dbgfileview){


m_ts.fn_DbgFileView_clearBreakPositions(dbgfileview);
}
/// <summary>
/// (string findThis)              Find the specified string in the currently viewed file and               scroll it into view.)
/// </summary>
public  bool DbgFileView_findString(string dbgfileview, string findThis){


return m_ts.fn_DbgFileView_findString(dbgfileview, findThis);
}
/// <summary>
/// ()              Get the currently executing file and line, if any.              @returns A string containing the file, a tab, and then the line number.               Use getField() with this.)
/// </summary>
public  string DbgFileView_getCurrentLine(string dbgfileview){


return m_ts.fn_DbgFileView_getCurrentLine(dbgfileview);
}
/// <summary>
/// (string filename)              Open a file for viewing.              @note This loads the file from the local system.)
/// </summary>
public  bool DbgFileView_open(string dbgfileview, string filename){


return m_ts.fn_DbgFileView_open(dbgfileview, filename);
}
/// <summary>
/// (int line)              Remove a breakpoint from the specified line.)
/// </summary>
public  void DbgFileView_removeBreak(string dbgfileview, uint line){


m_ts.fn_DbgFileView_removeBreak(dbgfileview, line);
}
/// <summary>
/// (int line)              Set a breakpoint at the specified line.)
/// </summary>
public  void DbgFileView_setBreak(string dbgfileview, uint line){


m_ts.fn_DbgFileView_setBreak(dbgfileview, line);
}
/// <summary>
/// (int line)              Set a breakpoint at the specified line.)
/// </summary>
public  void DbgFileView_setBreakPosition(string dbgfileview, uint line){


m_ts.fn_DbgFileView_setBreakPosition(dbgfileview, line);
}
/// <summary>
/// (int line, bool selected)              Set the current highlighted line.)
/// </summary>
public  void DbgFileView_setCurrentLine(string dbgfileview, int line, bool selected){


m_ts.fn_DbgFileView_setCurrentLine(dbgfileview, line, selected);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class DebrisObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public DebrisObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// 1.0 1.0 1.0, 1.0 0.0 0.0),    @brief Manually set this piece of debris at the given position with the given velocity.   Usually you do not manually create Debris objects as they are generated through other means,    such as an Explosion.  This method exists when you do manually create a Debris object and    want to have it start moving.   @param inputPosition Position to place the debris.   @param inputVelocity Velocity to move the debris after it has been placed.   @return Always returns true.   @tsexample      // Define the position      %position = \"1.0 1.0 1.0\";      // Define the velocity      %velocity = \"1.0 0.0 0.0\";      // Inform the debris object of its new position and velocity      %debris.init(%position,%velocity);   @endtsexample)
/// </summary>
public  bool init(string debris, string inputPosition = "1.01.01.0", string inputVelocity = "1.00.00.0"){


return m_ts.fnDebris_init(debris, inputPosition, inputVelocity);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class DebugDrawerObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public DebugDrawerObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Draws an axis aligned box primitive within the two 3d points. )
/// </summary>
public  void drawBox(string debugdrawer, Point3F a, Point3F b, ColorF color = null ){
if (color== null) {color = new ColorF(1.0f, 1.0f, 1.0f,1.0f);}


m_ts.fnDebugDrawer_drawBox(debugdrawer, a.AsString(), b.AsString(), color.AsString());
}
/// <summary>
/// Draws a line primitive between two 3d points. )
/// </summary>
public  void drawLine(string debugdrawer, Point3F a, Point3F b, ColorF color = null ){
if (color== null) {color = new ColorF(1.0f, 1.0f, 1.0f,1.0f);}


m_ts.fnDebugDrawer_drawLine(debugdrawer, a.AsString(), b.AsString(), color.AsString());
}
/// <summary>
/// Sets the \"time to live\" (TTL) for the last rendered primitive. )
/// </summary>
public  void setLastTTL(string debugdrawer, uint ms){


m_ts.fnDebugDrawer_setLastTTL(debugdrawer, ms);
}
/// <summary>
/// Sets the z buffer reading state for the last rendered primitive. )
/// </summary>
public  void setLastZTest(string debugdrawer, bool enabled){


m_ts.fnDebugDrawer_setLastZTest(debugdrawer, enabled);
}
/// <summary>
/// Toggles the rendering of DebugDrawer primitives. )
/// </summary>
public  void toggleDrawing(string debugdrawer){


m_ts.fnDebugDrawer_toggleDrawing(debugdrawer);
}
/// <summary>
/// Toggles freeze mode which keeps the currently rendered primitives from expiring. )
/// </summary>
public  void toggleFreeze(string debugdrawer){


m_ts.fnDebugDrawer_toggleFreeze(debugdrawer);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class DecalDataObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public DecalDataObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Recompute the imagemap sub-texture rectangles for this DecalData.   @tsexample   // Inform the decal object to reload its imagemap and frame data.   %decalData.texRows = 4;   %decalData.postApply();   @endtsexample)
/// </summary>
public  void postApply(string decaldata){


m_ts.fnDecalData_postApply(decaldata);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class DecalRoadObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public DecalRoadObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Intended as a helper to developers and editor scripts.                   Force trigger an inspectPostApply. This will transmit                    the material and other fields ( not including nodes )                    to client objects.                  )
/// </summary>
public  void postApply(string decalroad){


m_ts.fnDecalRoad_postApply(decalroad);
}
/// <summary>
/// Intended as a helper to developers and editor scripts.                   Force DecalRoad to update it's spline and reclip geometry.                  )
/// </summary>
public  void regenerate(string decalroad){


m_ts.fnDecalRoad_regenerate(decalroad);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class DynamicConsoleMethodComponentObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public DynamicConsoleMethodComponentObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( DynamicConsoleMethodComponent, callMethod, void, 3, 64 , (methodName, argi) Calls script defined method			  @param methodName The method's name as a string			  @param argi Any arguments to pass to the method			  @return No return value			  @note %obj.callMethod( %methodName, %arg1, %arg2, ... );)
/// </summary>
public  void callMethod(string dynamicconsolemethodcomponent, string a2= "", string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= "", string a20= "", string a21= "", string a22= "", string a23= "", string a24= "", string a25= "", string a26= "", string a27= "", string a28= "", string a29= "", string a30= "", string a31= "", string a32= "", string a33= "", string a34= "", string a35= "", string a36= "", string a37= "", string a38= "", string a39= "", string a40= "", string a41= "", string a42= "", string a43= "", string a44= "", string a45= "", string a46= "", string a47= "", string a48= "", string a49= "", string a50= "", string a51= "", string a52= "", string a53= "", string a54= "", string a55= "", string a56= "", string a57= "", string a58= "", string a59= "", string a60= "", string a61= "", string a62= "", string a63= ""){


m_ts.fnDynamicConsoleMethodComponent_callMethod(dynamicconsolemethodcomponent, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a51, a52, a53, a54, a55, a56, a57, a58, a59, a60, a61, a62, a63);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class EditManagerObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public EditManagerObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Perform the onEditorDisabled callback on all SimObjects and set gEditingMission false )
/// </summary>
public  void EditManager_editorDisabled(string editmanager){


m_ts.fn_EditManager_editorDisabled(editmanager);
}
/// <summary>
/// Perform the onEditorEnabled callback on all SimObjects and set gEditingMission true )
/// </summary>
public  void EditManager_editorEnabled(string editmanager){


m_ts.fn_EditManager_editorEnabled(editmanager);
}
/// <summary>
/// (int slot))
/// </summary>
public  void EditManager_gotoBookmark(string editmanager, int val){


m_ts.fn_EditManager_gotoBookmark(editmanager, val);
}
/// <summary>
/// Return the value of gEditingMission. )
/// </summary>
public  bool EditManager_isEditorEnabled(string editmanager){


return m_ts.fn_EditManager_isEditorEnabled(editmanager);
}
/// <summary>
/// (int slot))
/// </summary>
public  void EditManager_setBookmark(string editmanager, int val){


m_ts.fn_EditManager_setBookmark(editmanager, val);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class EditTSCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public EditTSCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
///  )
/// </summary>
public  int getDisplayType(string edittsctrl){


return m_ts.fnEditTSCtrl_getDisplayType(edittsctrl);
}
/// <summary>
///  )
/// </summary>
public  int getGizmo(string edittsctrl){


return m_ts.fnEditTSCtrl_getGizmo(edittsctrl);
}
/// <summary>
/// Return the FOV for orthographic views. )
/// </summary>
public  float getOrthoFOV(string edittsctrl){


return m_ts.fnEditTSCtrl_getOrthoFOV(edittsctrl);
}
/// <summary>
///  )
/// </summary>
public  bool isMiddleMouseDown(string edittsctrl){


return m_ts.fnEditTSCtrl_isMiddleMouseDown(edittsctrl);
}
/// <summary>
///  )
/// </summary>
public  void renderBox(string edittsctrl, Point3F pos, Point3F size){


m_ts.fnEditTSCtrl_renderBox(edittsctrl, pos.AsString(), size.AsString());
}
/// <summary>
///  )
/// </summary>
public  void renderCircle(string edittsctrl, Point3F pos, Point3F normal, float radius, int segments = 0){


m_ts.fnEditTSCtrl_renderCircle(edittsctrl, pos.AsString(), normal.AsString(), radius, segments);
}
/// <summary>
///  )
/// </summary>
public  void renderLine(string edittsctrl, Point3F start, Point3F end, float lineWidth = 0){


m_ts.fnEditTSCtrl_renderLine(edittsctrl, start.AsString(), end.AsString(), lineWidth);
}
/// <summary>
///  )
/// </summary>
public  void renderSphere(string edittsctrl, Point3F pos, float radius, int sphereLevel = 0){


m_ts.fnEditTSCtrl_renderSphere(edittsctrl, pos.AsString(), radius, sphereLevel);
}
/// <summary>
///  )
/// </summary>
public  void renderTriangle(string edittsctrl, Point3F a, Point3F b, Point3F c){


m_ts.fnEditTSCtrl_renderTriangle(edittsctrl, a.AsString(), b.AsString(), c.AsString());
}
/// <summary>
///  )
/// </summary>
public  void setDisplayType(string edittsctrl, int displayType){


m_ts.fnEditTSCtrl_setDisplayType(edittsctrl, displayType);
}
/// <summary>
/// Set the FOV for to use for orthographic views. )
/// </summary>
public  void setOrthoFOV(string edittsctrl, float fov){


m_ts.fnEditTSCtrl_setOrthoFOV(edittsctrl, fov);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class EventManagerObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public EventManagerObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ()              Print all registered events to the console. )
/// </summary>
public  void EventManager_dumpEvents(string eventmanager){


m_ts.fn_EventManager_dumpEvents(eventmanager);
}
/// <summary>
/// ), ( String event )              Print all subscribers to an event to the console.              @param event The event whose subscribers are to be printed. If this parameter isn't specified, all events will be dumped. )
/// </summary>
public  void EventManager_dumpSubscribers(string eventmanager, string listenerName = ""){


m_ts.fn_EventManager_dumpSubscribers(eventmanager, listenerName);
}
/// <summary>
/// ( String event )              Check if an event is registered or not.              @param event The event to check.              @return Whether or not the event exists. )
/// </summary>
public  bool EventManager_isRegisteredEvent(string eventmanager, string evt){


return m_ts.fn_EventManager_isRegisteredEvent(eventmanager, evt);
}
/// <summary>
/// ), ( String event, String data )              ~Trigger an event.              @param event The event to trigger.              @param data The data associated with the event.              @return Whether or not the event was dispatched successfully. )
/// </summary>
public  bool EventManager_postEvent(string eventmanager, string evt, string data = ""){


return m_ts.fn_EventManager_postEvent(eventmanager, evt, data);
}
/// <summary>
/// ( String event )              Register an event with the event manager.              @param event The event to register.              @return Whether or not the event was registered successfully. )
/// </summary>
public  bool EventManager_registerEvent(string eventmanager, string evt){


return m_ts.fn_EventManager_registerEvent(eventmanager, evt);
}
/// <summary>
/// ( SimObject listener, String event )              Remove a listener from an event.              @param listener The listener to remove.              @param event The event to be removed from.)
/// </summary>
public  void EventManager_remove(string eventmanager, string listenerName, string evt){


m_ts.fn_EventManager_remove(eventmanager, listenerName, evt);
}
/// <summary>
/// ( SimObject listener )              Remove a listener from all events.              @param listener The listener to remove.)
/// </summary>
public  void EventManager_removeAll(string eventmanager, string listenerName){


m_ts.fn_EventManager_removeAll(eventmanager, listenerName);
}
/// <summary>
/// ), ( SimObject listener, String event, String callback )              Subscribe a listener to an event.              @param listener The listener to subscribe.              @param event The event to subscribe to.              @param callback Optional method name to receive the event notification. If this is not specified, \"on[event]\" will be used.              @return Whether or not the subscription was successful. )
/// </summary>
public  bool EventManager_subscribe(string eventmanager, string listenerName, string evt, string callback = ""){


return m_ts.fn_EventManager_subscribe(eventmanager, listenerName, evt, callback);
}
/// <summary>
/// ( String event )              Remove an event from the EventManager.              @param event The event to remove. )
/// </summary>
public  void EventManager_unregisterEvent(string eventmanager, string evt){


m_ts.fn_EventManager_unregisterEvent(eventmanager, evt);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class FieldBrushObjectObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public FieldBrushObjectObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ), (simObject, [fieldList]) Copy selected static-fields for selected object./                                                        @param simObject Object to copy static-fields from.                                                        @param fieldList fields to filter static-fields against.			                                            @return No return value.)
/// </summary>
public  void FieldBrushObject_copyFields(string fieldbrushobject, string simObjName, string pFieldList = ""){


m_ts.fn_FieldBrushObject_copyFields(fieldbrushobject, simObjName, pFieldList);
}
/// <summary>
/// (simObject) Paste copied static-fields to selected object./                                                        @param simObject Object to paste static-fields to.			                                            @return No return value.)
/// </summary>
public  void FieldBrushObject_pasteFields(string fieldbrushobject, string simObjName){


m_ts.fn_FieldBrushObject_pasteFields(fieldbrushobject, simObjName);
}
/// <summary>
/// ), (simObject, [groupList]) Query available static-fields for selected object./                                                                @param simObject Object to query static-fields on.                                                                @param groupList groups to filter static-fields against.			                                                    @return Space-seperated static-field list.)
/// </summary>
public  string FieldBrushObject_queryFields(string fieldbrushobject, string simObjName, string groupList = ""){


return m_ts.fn_FieldBrushObject_queryFields(fieldbrushobject, simObjName, groupList);
}
/// <summary>
/// (simObject) Query available static-field groups for selected object./                                                                @param simObject Object to query static-field groups on.			                                                    @return Space-seperated static-field group list.)
/// </summary>
public  string FieldBrushObject_queryGroups(string fieldbrushobject, string simObjName){


return m_ts.fn_FieldBrushObject_queryGroups(fieldbrushobject, simObjName);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class FileDialogObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public FileDialogObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Launches the OS file browser   After an Execute() call, the chosen file name and path is available in one of two areas.     If only a single file selection is permitted, the results will be stored in the @a fileName    attribute.   If multiple file selection is permitted, the results will be stored in the    @a files array.  The total number of files in the array will be stored in the    @a fileCount attribute.   @tsexample   // NOTE: This is not he preferred class to use, but this still works   // Create the file dialog   %baseFileDialog = new FileDialog()   {      // Allow browsing of all file types      filters = \"*.*\";      // No default file      defaultFile = ;      // Set default path relative to project      defaultPath = \"./\";      // Set the title      title = \"Durpa\";      // Allow changing of path you are browsing      changePath = true;   };    // Launch the file dialog    %baseFileDialog.Execute();        // Don't forget to cleanup    %baseFileDialog.delete();    // A better alternative is to use the     // derived classes which are specific to file open and save    // Create a dialog dedicated to opening files    %openFileDlg = new OpenFileDialog()    {       // Look for jpg image files       // First part is the descriptor|second part is the extension       Filters = \"Jepg Files|*.jpg\";       // Allow browsing through other folders       ChangePath = true;       // Only allow opening of one file at a time       MultipleFiles = false;    };    // Launch the open file dialog    %result = %openFileDlg.Execute();    // Obtain the chosen file name and path    if ( %result )    {       %seletedFile = %openFileDlg.file;    }    else    {       %selectedFile = \"\";    }    // Cleanup    %openFileDlg.delete();    // Create a dialog dedicated to saving a file    %saveFileDlg = new SaveFileDialog()    {       // Only allow for saving of COLLADA files       Filters = \"COLLADA Files (*.dae)|*.dae|\";       // Default save path to where the WorldEditor last saved       DefaultPath = $pref::WorldEditor::LastPath;       // No default file specified       DefaultFile = \"\";       // Do not allow the user to change to a new directory       ChangePath = false;       // Prompt the user if they are going to overwrite an existing file       OverwritePrompt = true;    };    // Launch the save file dialog    %result = %saveFileDlg.Execute();    // Obtain the file name    %selectedFile = \"\";    if ( %result )       %selectedFile = %saveFileDlg.file;    // Cleanup    %saveFileDlg.delete();   @endtsexample   @return True if the file was selected was successfully found (opened) or declared (saved).)
/// </summary>
public  bool Execute(string filedialog){


return m_ts.fnFileDialog_Execute(filedialog);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class FileObjectObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public FileObjectObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ), FileObject.writeObject(SimObject, object prepend) 			  @hide)
/// </summary>
public  void FileObject_writeObject(string fileobject, string simName, string objName = ""){


m_ts.fn_FileObject_writeObject(fileobject, simName, objName);
}
/// <summary>
/// @brief Close the file.      It is EXTREMELY important that you call this function when you are finished reading or writing to a file.    Failing to do so is not only a bad programming practice, but could result in bad data or corrupt files.    Remember: Open, Read/Write, Close, Delete...in that order!      @tsexample   // Create a file object for reading   %fileRead = new FileObject();   // Open a text file, if it exists   %fileRead.OpenForRead(\"./test.txt\");   // Peek the first line   %line = %fileRead.peekLine();   // Print the line we just peeked   echo(%line);   // If we peek again...   %line = %fileRead.peekLine();   // We will get the same output as the first time   // since the stream did not move forward   echo(%line);   // Close the file when finished   %fileWrite.close();   // Cleanup the file object   %fileWrite.delete();   @endtsexample)
/// </summary>
public  void close(string fileobject){


m_ts.fnFileObject_close(fileobject);
}
/// <summary>
/// @brief Determines if the parser for this FileObject has reached the end of the file      @tsexample   // Create a file object for reading   %fileRead = new FileObject();   // Open a text file, if it exists   %fileRead.OpenForRead(\"./test.txt\");   // Keep reading until we reach the end of the file   while( !%fileRead.isEOF() )   {      %line = %fileRead.readline();      echo(%line);   }   // Made it to the end   echo(\"Finished reading file\");   @endtsexample   @return True if the parser has reached the end of the file, false otherwise)
/// </summary>
public  bool isEOF(string fileobject){


return m_ts.fnFileObject_isEOF(fileobject);
}
/// <summary>
/// @brief Open a specified file for writing, adding data to the end of the file      There is no limit as to what kind of file you can write. Any format and data is allowable, not just text. Unlike openForWrite(),    which will erase an existing file if it is opened, openForAppend() preserves data in an existing file and adds to it.   @param filename Path, name, and extension of file to append to      @tsexample   // Create a file object for writing   %fileWrite = new FileObject();   // Open a file to write to, if it does not exist it will be created   // If it does exist, whatever we write will be added to the end   %result = %fileWrite.OpenForAppend(\"./test.txt\");   @endtsexample   @return True if file was successfully opened, false otherwise)
/// </summary>
public  bool openForAppend(string fileobject, string filename){


return m_ts.fnFileObject_openForAppend(fileobject, filename);
}
/// <summary>
/// @brief Open a specified file for reading      There is no limit as to what kind of file you can read. Any format and data contained within is accessible, not just text   @param filename Path, name, and extension of file to be read      @tsexample   // Create a file object for reading   %fileRead = new FileObject();   // Open a text file, if it exists   %result = %fileRead.OpenForRead(\"./test.txt\");   @endtsexample   @return True if file was successfully opened, false otherwise)
/// </summary>
public  bool openForRead(string fileobject, string filename){


return m_ts.fnFileObject_openForRead(fileobject, filename);
}
/// <summary>
/// @brief Open a specified file for writing      There is no limit as to what kind of file you can write. Any format and data is allowable, not just text   @param filename Path, name, and extension of file to write to      @tsexample   // Create a file object for writing   %fileWrite = new FileObject();   // Open a file to write to, if it does not exist it will be created   %result = %fileWrite.OpenForWrite(\"./test.txt\");   @endtsexample   @return True if file was successfully opened, false otherwise)
/// </summary>
public  bool openForWrite(string fileobject, string filename){


return m_ts.fnFileObject_openForWrite(fileobject, filename);
}
/// <summary>
/// @brief Read a line from the file without moving the stream position.      Emphasis on *line*, as in you cannot parse individual characters or chunks of data.     There is no limitation as to what kind of data you can read. Unlike readLine, the parser does not move forward after reading.   @param filename Path, name, and extension of file to be read      @tsexample   // Create a file object for reading   %fileRead = new FileObject();   // Open a text file, if it exists   %fileRead.OpenForRead(\"./test.txt\");   // Peek the first line   %line = %fileRead.peekLine();   // Print the line we just peeked   echo(%line);   // If we peek again...   %line = %fileRead.peekLine();   // We will get the same output as the first time   // since the stream did not move forward   echo(%line);   @endtsexample   @return String containing the line of data that was just peeked)
/// </summary>
public  string peekLine(string fileobject){


return m_ts.fnFileObject_peekLine(fileobject);
}
/// <summary>
/// @brief Read a line from file.      Emphasis on *line*, as in you cannot parse individual characters or chunks of data.     There is no limitation as to what kind of data you can read.      @tsexample   // Create a file object for reading   %fileRead = new FileObject();   // Open a text file, if it exists   %fileRead.OpenForRead(\"./test.txt\");   // Read in the first line   %line = %fileRead.readline();   // Print the line we just read   echo(%line);   @endtsexample   @return String containing the line of data that was just read)
/// </summary>
public  string readLine(string fileobject){


return m_ts.fnFileObject_readLine(fileobject);
}
/// <summary>
/// @brief Write a line to the file, if it was opened for writing.      There is no limit as to what kind of text you can write. Any format and data is allowable, not just text.    Be careful of what you write, as whitespace, current values, and literals will be preserved.   @param text The data we are writing out to file.      @tsexample   // Create a file object for writing   %fileWrite = new FileObject();   // Open a file to write to, if it does not exist it will be created   %fileWrite.OpenForWrite(\"./test.txt\");   // Write a line to the text files   %fileWrite.writeLine(\"READ. READ CODE. CODE\");   @endtsexample   @return True if file was successfully opened, false otherwise)
/// </summary>
public  void writeLine(string fileobject, string text){


m_ts.fnFileObject_writeLine(fileobject, text);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class FileStreamObjectObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public FileStreamObjectObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Close the file. You can no longer read or write to it unless you open it again.      @tsexample   // Create a file stream object for reading   %fsObject = new FileStreamObject();   // Open a file for reading   %fsObject.open(\"./test.txt\", \"read\");   // Always remember to close a file stream when finished   %fsObject.close();   @endtsexample      @see open())
/// </summary>
public  void close(string filestreamobject){


m_ts.fnFileStreamObject_close(filestreamobject);
}
/// <summary>
/// @brief Open a file for reading, writing, reading and writing, or appending      Using \"Read\" for the open mode allows you to parse the contents of file, but not making modifications. \"Write\" will create a new    file if it does not exist, or erase the contents of an existing file when opened. Write also allows you to modify the contents of the file.   \"ReadWrite\" will provide the ability to parse data (read it in) and manipulate data (write it out) interchangeably. Keep in mind the stream can    move during each operation. Finally, \"WriteAppend\" will open a file if it exists, but will not clear the contents. You can write new data starting     at the end of the files existing contents.   @param filename Name of file to open   @param openMode One of \"Read\", \"Write\", \"ReadWrite\" or \"WriteAppend\"   @tsexample   // Create a file stream object for reading   %fsObject = new FileStreamObject();   // Open a file for reading   %fsObject.open(\"./test.txt\", \"read\");   // Get the status and print it   %status = %fsObject.getStatus();   echo(%status);   // Always remember to close a file stream when finished   %fsObject.close();   @endtsexample   @return True if the file was successfully opened, false if something went wrong      @see close())
/// </summary>
public  bool open(string filestreamobject, string filename, string openMode){


return m_ts.fnFileStreamObject_open(filestreamobject, filename, openMode);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class FlyingVehicleObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public FlyingVehicleObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Set whether the vehicle should temporarily use the createHoverHeight    specified in the datablock.This can help avoid problems with spawning.   @param enabled true to use the datablock createHoverHeight, false otherwise )
/// </summary>
public  void useCreateHeight(string flyingvehicle, bool enabled){


m_ts.fnFlyingVehicle_useCreateHeight(flyingvehicle, enabled);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ForestObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ForestObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// () )
/// </summary>
public  void Forest_clear(string forest){


m_ts.fn_Forest_clear(forest);
}
/// <summary>
/// ())
/// </summary>
public  bool Forest_isDirty(string forest){


return m_ts.fn_Forest_isDirty(forest);
}
/// <summary>
/// ())
/// </summary>
public  void Forest_regenCells(string forest){


m_ts.fn_Forest_regenCells(forest);
}
/// <summary>
/// ), saveDataFile( [path] ) )
/// </summary>
public  void Forest_saveDataFile(string forest, string path = ""){


m_ts.fn_Forest_saveDataFile(forest, path);
}
/// <summary>
/// .)
/// </summary>
public  void addItem(string forest, string data, Point3F position, float rotation, float scale){


m_ts.fnForest_addItem(forest, data, position.AsString(), rotation, scale);
}
/// <summary>
/// .)
/// </summary>
public  void addItemWithTransform(string forest, string data, TransformF trans, float scale){


m_ts.fnForest_addItemWithTransform(forest, data, trans.AsString(), scale);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ForestBrushObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ForestBrushObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( ForestItemData obj ) )
/// </summary>
public  bool ForestBrush_containsItemData(string forestbrush, string obj){


return m_ts.fn_ForestBrush_containsItemData(forestbrush, obj);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ForestBrushToolObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ForestBrushToolObject(ref Omni ts){m_ts = ts;}
/// <summary>
///  )
/// </summary>
public  void ForestBrushTool_collectElements(string forestbrushtool){


m_ts.fn_ForestBrushTool_collectElements(forestbrushtool);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ForestEditorCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ForestEditorCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( ForestItemData obj ) )
/// </summary>
public  void ForestEditorCtrl_deleteMeshSafe(string foresteditorctrl, string obj){


m_ts.fn_ForestEditorCtrl_deleteMeshSafe(foresteditorctrl, obj);
}
/// <summary>
/// () )
/// </summary>
public  int ForestEditorCtrl_getActiveTool(string foresteditorctrl){


return m_ts.fn_ForestEditorCtrl_getActiveTool(foresteditorctrl);
}
/// <summary>
///  )
/// </summary>
public  bool ForestEditorCtrl_isDirty(string foresteditorctrl){


return m_ts.fn_ForestEditorCtrl_isDirty(foresteditorctrl);
}
/// <summary>
/// ( ForestTool tool ) )
/// </summary>
public  void ForestEditorCtrl_setActiveTool(string foresteditorctrl, string toolName){


m_ts.fn_ForestEditorCtrl_setActiveTool(foresteditorctrl, toolName);
}
/// <summary>
/// () )
/// </summary>
public  void ForestEditorCtrl_updateActiveForest(string foresteditorctrl){


m_ts.fn_ForestEditorCtrl_updateActiveForest(foresteditorctrl);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ForestSelectionToolObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ForestSelectionToolObject(ref Omni ts){m_ts = ts;}
/// <summary>
///  )
/// </summary>
public  void ForestSelectionTool_clearSelection(string forestselectiontool){


m_ts.fn_ForestSelectionTool_clearSelection(forestselectiontool);
}
/// <summary>
///  )
/// </summary>
public  void ForestSelectionTool_copySelection(string forestselectiontool){


m_ts.fn_ForestSelectionTool_copySelection(forestselectiontool);
}
/// <summary>
///  )
/// </summary>
public  void ForestSelectionTool_cutSelection(string forestselectiontool){


m_ts.fn_ForestSelectionTool_cutSelection(forestselectiontool);
}
/// <summary>
///  )
/// </summary>
public  void ForestSelectionTool_deleteSelection(string forestselectiontool){


m_ts.fn_ForestSelectionTool_deleteSelection(forestselectiontool);
}
/// <summary>
///  )
/// </summary>
public  int ForestSelectionTool_getSelectionCount(string forestselectiontool){


return m_ts.fn_ForestSelectionTool_getSelectionCount(forestselectiontool);
}
/// <summary>
///  )
/// </summary>
public  void ForestSelectionTool_pasteSelection(string forestselectiontool){


m_ts.fn_ForestSelectionTool_pasteSelection(forestselectiontool);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ForestWindEmitterObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ForestWindEmitterObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Mounts the wind emitter to another scene object   @param objectID Unique ID of the object wind emitter should attach to      @tsexample   // Wind emitter previously created and named %windEmitter   // Going to attach it to the player, making him a walking wind storm   %windEmitter.attachToObject(%player);   @endtsexample)
/// </summary>
public  void attachToObject(string forestwindemitter, uint objectID){


m_ts.fnForestWindEmitter_attachToObject(forestwindemitter, objectID);
}
/// <summary>
/// @brief Mounts the wind emitter to another scene object   @param )
/// </summary>
public  void resetWind(string forestwindemitter, int randomSeed){


m_ts.fnForestWindEmitter_resetWind(forestwindemitter, randomSeed);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GameBaseObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GameBaseObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Apply an impulse to this object as defined by a world position and velocity vector.   @param pos impulse world position   @param vel impulse velocity (impulse force F = m * v)   @return Always true   @note Not all objects that derrive from GameBase have this defined.)
/// </summary>
public  bool applyImpulse(string gamebase, Point3F pos, Point3F vel){


return m_ts.fnGameBase_applyImpulse(gamebase, pos.AsString(), vel.AsString());
}
/// <summary>
/// @brief Applies a radial impulse to the object using the given origin and force.   @param origin World point of origin of the radial impulse.   @param radius The radius of the impulse area.   @param magnitude The strength of the impulse.      @note Not all objects that derrive from GameBase have this defined.)
/// </summary>
public  void applyRadialImpulse(string gamebase, Point3F origin, float radius, float magnitude){


m_ts.fnGameBase_applyRadialImpulse(gamebase, origin.AsString(), radius, magnitude);
}
/// <summary>
/// @brief Get the datablock used by this object.   @return the datablock this GameBase is using.   @see setDataBlock())
/// </summary>
public  int getDataBlock(string gamebase){


return m_ts.fnGameBase_getDataBlock(gamebase);
}
/// <summary>
/// @brief Assign this GameBase to use the specified datablock.   @param data new datablock to use   @return true if successful, false if failed.   @see getDataBlock())
/// </summary>
public  bool setDataBlock(string gamebase, string data){


return m_ts.fnGameBase_setDataBlock(gamebase, data);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GameConnectionObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GameConnectionObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Called by the server during phase 2 of the mission download to start sending ghosts to the client.      Ghosts represent objects on the server that are in scope for the client.  These need    to be synchronized with the client in order for the client to see and interact with them.     This is typically done during the standard mission start phase 2 when following Torque's    example mission startup sequence.   @tsexample   function serverCmdMissionStartPhase2Ack(%client, %seq, %playerDB)   {      // Make sure to ignore calls from a previous mission load      if (%seq != $missionSequence || !$MissionRunning)         return;      if (%client.currentPhase != 1.5)         return;      %client.currentPhase = 2;         // Set the player datablock choice      %client.playerDB = %playerDB;         // Update mod paths, this needs to get there before the objects.      %client.transmitPaths();         // Start ghosting objects to the client      %client.activateGhosting();   }   @endtsexample   @see @ref ghosting_scoping for a description of the ghosting system.)
/// </summary>
public  void activateGhosting(string gameconnection){


m_ts.fnGameConnection_activateGhosting(gameconnection);
}
/// <summary>
/// @brief Sets the size of the chase camera's matrix queue.   @note This sets the queue size across all GameConnections.   @note This is not currently hooked up.)
/// </summary>
public  bool chaseCam(string gameconnection, int size){


return m_ts.fnGameConnection_chaseCam(gameconnection, size);
}
/// <summary>
/// @brief Clear the connection's camera object reference.      @see GameConnection::setCameraObject() and GameConnection::getCameraObject())
/// </summary>
public  void clearCameraObject(string gameconnection){


m_ts.fnGameConnection_clearCameraObject(gameconnection);
}
/// <summary>
/// @brief Clear any display device.   A display device may define a number of properties that are used during rendering.)
/// </summary>
public  void clearDisplayDevice(string gameconnection){


m_ts.fnGameConnection_clearDisplayDevice(gameconnection);
}
/// <summary>
/// ),   @brief On the server, disconnect a client and pass along an optional reason why.   This method performs two operations: it disconnects a client connection from the server,    and it deletes the connection object.  The optional reason is sent in the disconnect packet    and is often displayed to the user so they know why they've been disconnected.      @param reason [optional] The reason why the user has been disconnected from the server.      @tsexample   function kick(%client)   {      messageAll( 'MsgAdminForce', '\\c2The Admin has kicked %1.', %client.playerName);         if (!%client.isAIControlled())         BanList::add(%client.guid, %client.getAddress(), $Pref::Server::KickBanTime);      %client.delete(\"You have been kicked from this server\");   }   @endtsexample)
/// </summary>
public  void delete(string gameconnection, string reason = ""){


m_ts.fnGameConnection_delete(gameconnection, reason);
}
/// <summary>
/// @brief Returns the connection's camera object used when not viewing through the control object.      @see GameConnection::setCameraObject() and GameConnection::clearCameraObject())
/// </summary>
public  string getCameraObject(string gameconnection){


return m_ts.fnGameConnection_getCameraObject(gameconnection);
}
/// <summary>
/// @brief Returns the default field of view as used by the control object's camera.)
/// </summary>
public  float getControlCameraDefaultFov(string gameconnection){


return m_ts.fnGameConnection_getControlCameraDefaultFov(gameconnection);
}
/// <summary>
/// @brief Returns the field of view as used by the control object's camera.)
/// </summary>
public  float getControlCameraFov(string gameconnection){


return m_ts.fnGameConnection_getControlCameraFov(gameconnection);
}
/// <summary>
/// @brief On the server, returns the object that the client is controlling.   By default the control object is an instance of the Player class, but can also be an instance    of Camera (when editing the mission, for example), or any other ShapeBase derived class as    appropriate for the game.   @see GameConnection::setControlObject())
/// </summary>
public  string getControlObject(string gameconnection){


return m_ts.fnGameConnection_getControlObject(gameconnection);
}
/// <summary>
/// @brief Get the connection's control scheme absolute rotation property.      @return True if the connection's control object should use an absolute rotation control scheme.   @see GameConnection::setControlSchemeParameters())
/// </summary>
public  bool getControlSchemeAbsoluteRotation(string gameconnection){


return m_ts.fnGameConnection_getControlSchemeAbsoluteRotation(gameconnection);
}
/// <summary>
/// @brief On the client, get the control object's damage flash level.   @return flash level)
/// </summary>
public  float getDamageFlash(string gameconnection){


return m_ts.fnGameConnection_getDamageFlash(gameconnection);
}
/// <summary>
/// @brief On the client, get the control object's white-out level.   @return white-out level)
/// </summary>
public  float getWhiteOut(string gameconnection){


return m_ts.fnGameConnection_getWhiteOut(gameconnection);
}
/// <summary>
/// @brief Returns true if this connection is AI controlled.   @see AIConnection)
/// </summary>
public  bool isAIControlled(string gameconnection){


return m_ts.fnGameConnection_isAIControlled(gameconnection);
}
/// <summary>
/// @brief Returns true if the object being controlled by the client is making use    of a rotation damped camera.   @see Camera)
/// </summary>
public  bool isControlObjectRotDampedCamera(string gameconnection){


return m_ts.fnGameConnection_isControlObjectRotDampedCamera(gameconnection);
}
/// <summary>
/// @brief Returns true if a previously recorded demo file is now playing.      @see GameConnection::playDemo())
/// </summary>
public  bool isDemoPlaying(string gameconnection){


return m_ts.fnGameConnection_isDemoPlaying(gameconnection);
}
/// <summary>
/// @brief Returns true if a demo file is now being recorded.      @see GameConnection::startRecording(), GameConnection::stopRecording())
/// </summary>
public  bool isDemoRecording(string gameconnection){


return m_ts.fnGameConnection_isDemoRecording(gameconnection);
}
/// <summary>
/// @brief Returns true if this connection is in first person mode.   @note Transition to first person occurs over time via mCameraPos, so this    won't immediately return true after a set.)
/// </summary>
public  bool isFirstPerson(string gameconnection){


return m_ts.fnGameConnection_isFirstPerson(gameconnection);
}
/// <summary>
/// @brief List all of the classes that this connection knows about, and what their IDs are. Useful for debugging network problems.   @note The list is sent to the console.)
/// </summary>
public  void listClassIDs(string gameconnection){


m_ts.fnGameConnection_listClassIDs(gameconnection);
}
/// <summary>
///  )
/// </summary>
public  bool LoadDatablocksFromFile(string gameconnection, uint crc){


return m_ts.fnGameConnection_LoadDatablocksFromFile(gameconnection, crc);
}
/// <summary>
/// @brief Used on the server to play a 2D sound that is not attached to any object.   @param profile The SFXProfile that defines the sound to play.   @tsexample   function ServerPlay2D(%profile)   {      // Play the given sound profile on every client.      // The sounds will be transmitted as an event, not attached to any object.      for(%idx = 0; %idx  ClientGroup.getCount(); %idx++)         ClientGroup.getObject(%idx).play2D(%profile);   }   @endtsexample)
/// </summary>
public  bool play2D(string gameconnection, string profile){


return m_ts.fnGameConnection_play2D(gameconnection, profile);
}
/// <summary>
/// @brief Used on the server to play a 3D sound that is not attached to any object.      @param profile The SFXProfile that defines the sound to play.   @param location The position and orientation of the 3D sound given in the form of \"x y z ax ay az aa\".   @tsexample   function ServerPlay3D(%profile,%transform)   {      // Play the given sound profile at the given position on every client      // The sound will be transmitted as an event, not attached to any object.      for(%idx = 0; %idx  ClientGroup.getCount(); %idx++)         ClientGroup.getObject(%idx).play3D(%profile,%transform);   }   @endtsexample)
/// </summary>
public  bool play3D(string gameconnection, string profile, TransformF location){


return m_ts.fnGameConnection_play3D(gameconnection, profile, location.AsString());
}
/// <summary>
/// @brief On the client, play back a previously recorded game session.      It is often useful to play back a game session.  This could be for producing a    demo of the game that will be shown at a later time, or for debugging a game.     By recording the entire network stream it is possible to later play game the game    exactly as it unfolded during the actual play session.  This is because all user    control and server results pass through the connection.   @returns True if the playback was successful.  False if there was an issue, such as    not being able to open the demo file for playback.      @see GameConnection::startRecording(), GameConnection::stopRecording())
/// </summary>
public  bool playDemo(string gameconnection, string demoFileName){


return m_ts.fnGameConnection_playDemo(gameconnection, demoFileName);
}
/// <summary>
/// @brief On the server, resets the connection to indicate that ghosting has been disabled.   Typically when a mission has ended on the server, all connected clients are informed of this change    and their connections are reset back to a starting state.  This method resets a connection on the    server to indicate that ghosts are no longer being transmitted.  On the client end, all ghost    information will be deleted.   @tsexample      // Inform the clients      for (%clientIndex = 0; %clientIndex  ClientGroup.getCount(); %clientIndex++)      {         // clear ghosts and paths from all clients         %cl = ClientGroup.getObject(%clientIndex);         %cl.endMission();         %cl.resetGhosting();         %cl.clearPaths();      }   @endtsexample   @see @ref ghosting_scoping for a description of the ghosting system.)
/// </summary>
public  void resetGhosting(string gameconnection){


m_ts.fnGameConnection_resetGhosting(gameconnection);
}
/// <summary>
/// @brief On the server, sets the client's 3D display to fade to black.   @param doFade Set to true to fade to black, and false to fade from black.   @param timeMS Time it takes to perform the fade as measured in ms.   @note Not currently hooked up, and is not synchronized over the network.)
/// </summary>
public  void setBlackOut(string gameconnection, bool doFade, int timeMS){


m_ts.fnGameConnection_setBlackOut(gameconnection, doFade, timeMS);
}
/// <summary>
/// @brief On the server, set the connection's camera object used when not viewing    through the control object.      @see GameConnection::getCameraObject() and GameConnection::clearCameraObject())
/// </summary>
public  bool setCameraObject(string gameconnection, string camera){


return m_ts.fnGameConnection_setCameraObject(gameconnection, camera);
}
/// <summary>
/// (GameConnection, setConnectArgs, void, 3, 17,   (const char* args) @brief On the client, pass along a variable set of parameters to the server.      Once the connection is established with the server, the server calls its onConnect() method    with the client's passed in parameters as aruments.      @see GameConnection::onConnect())
/// </summary>
public  void setConnectArgs(string gameconnection, string a2= "", string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= ""){


m_ts.fnGameConnection_setConnectArgs(gameconnection, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16);
}
/// <summary>
/// @brief On the server, sets the control object's camera's field of view.   @param newFOV New field of view (in degrees) to force the control object's camera to use.  This value    is clamped to be within the range of 1 to 179 degrees.   @note When transmitted over the network to the client, the resolution is limited to    one degree.  Any fraction is dropped.)
/// </summary>
public  void setControlCameraFov(string gameconnection, float newFOV){


m_ts.fnGameConnection_setControlCameraFov(gameconnection, newFOV);
}
/// <summary>
/// @brief On the server, sets the object that the client will control.   By default the control object is an instance of the Player class, but can also be an instance    of Camera (when editing the mission, for example), or any other ShapeBase derived class as    appropriate for the game.   @param ctrlObj The GameBase object on the server to control.)
/// </summary>
public  bool setControlObject(string gameconnection, string ctrlObj){


return m_ts.fnGameConnection_setControlObject(gameconnection, ctrlObj);
}
/// <summary>
/// @brief Set the control scheme that may be used by a connection's control object.      @param absoluteRotation Use absolute rotation values from client, likely through ExtendedMove.   @param addYawToAbsRot Add relative yaw control to the absolute rotation calculation.  Only useful when absoluteRotation is true. )
/// </summary>
public  void setControlSchemeParameters(string gameconnection, bool absoluteRotation, bool addYawToAbsRot, bool addPitchToAbsRot){


m_ts.fnGameConnection_setControlSchemeParameters(gameconnection, absoluteRotation, addYawToAbsRot, addPitchToAbsRot);
}
/// <summary>
/// @brief On the server, sets this connection into or out of first person mode.      @param firstPerson Set to true to put the connection into first person mode.)
/// </summary>
public  void setFirstPerson(string gameconnection, bool firstPerson){


m_ts.fnGameConnection_setFirstPerson(gameconnection, firstPerson);
}
/// <summary>
/// @brief On the client, set the password that will be passed to the server.                            On the server, this password is compared with what is stored in $pref::Server::Password.                If $pref::Server::Password is empty then the client's sent password is ignored.  Otherwise,               if the passed in client password and the server password do not match, the CHR_PASSWORD               error string is sent back to the client and the connection is immediately terminated.                            This password checking is performed quite early on in the connection request process so as               to minimize the impact of multiple failed attempts -- also known as hacking.)
/// </summary>
public  void setJoinPassword(string gameconnection, string password){


m_ts.fnGameConnection_setJoinPassword(gameconnection, password);
}
/// <summary>
/// @brief On the server, transmits the mission file's CRC value to the client.   Typically, during the standard mission start phase 1, the mission file's CRC value    on the server is send to the client.  This allows the client to determine if the mission    has changed since the last time it downloaded this mission and act appropriately, such as    rebuilt cached lightmaps.   @param CRC The mission file's CRC value on the server.   @tsexample   function serverCmdMissionStartPhase1Ack(%client, %seq)   {      // Make sure to ignore calls from a previous mission load      if (%seq != $missionSequence || !$MissionRunning)         return;      if (%client.currentPhase != 0)         return;      %client.currentPhase = 1;         // Start with the CRC      %client.setMissionCRC( $missionCRC );         // Send over the datablocks...      // OnDataBlocksDone will get called when have confirmation      // that they've all been received.      %client.transmitDataBlocks($missionSequence);   }   @endtsexample)
/// </summary>
public  void setMissionCRC(string gameconnection, int CRC){


m_ts.fnGameConnection_setMissionCRC(gameconnection, CRC);
}
/// <summary>
/// @brief On the client, starts recording the network connection's traffic to a demo file.      It is often useful to play back a game session.  This could be for producing a    demo of the game that will be shown at a later time, or for debugging a game.     By recording the entire network stream it is possible to later play game the game    exactly as it unfolded during the actual play session.  This is because all user    control and server results pass through the connection.      @param fileName The file name to use for the demo recording.      @see GameConnection::stopRecording(), GameConnection::playDemo())
/// </summary>
public  void startRecording(string gameconnection, string fileName){


m_ts.fnGameConnection_startRecording(gameconnection, fileName);
}
/// <summary>
/// @brief On the client, stops the recording of a connection's network traffic to a file.      @see GameConnection::startRecording(), GameConnection::playDemo())
/// </summary>
public  void stopRecording(string gameconnection){


m_ts.fnGameConnection_stopRecording(gameconnection);
}
/// <summary>
/// @brief Sent by the server during phase 1 of the mission download to send the datablocks to the client.      SimDataBlocks, also known as just datablocks, need to be transmitted to the client    prior to the client entering the game world.  These represent the static data that    most objects in the world reference.  This is typically done during the standard    mission start phase 1 when following Torque's example mission startup sequence.   When the datablocks have all been transmitted, onDataBlocksDone() is called to move    the mission start process to the next phase.   @param sequence The sequence is common between the server and client and ensures    that the client is acting on the most recent mission start process.  If an errant    network packet (one that was lost but has now been found) is received by the client    with an incorrect sequence, it is just ignored.  This sequence number is updated on    the server every time a mission is loaded.   @tsexample   function serverCmdMissionStartPhase1Ack(%client, %seq)   {      // Make sure to ignore calls from a previous mission load      if (%seq != $missionSequence || !$MissionRunning)         return;      if (%client.currentPhase != 0)         return;      %client.currentPhase = 1;         // Start with the CRC      %client.setMissionCRC( $missionCRC );         // Send over the datablocks...      // OnDataBlocksDone will get called when have confirmation      // that they've all been received.      %client.transmitDataBlocks($missionSequence);   }   @endtsexample      @see GameConnection::onDataBlocksDone())
/// </summary>
public  void transmitDataBlocks(string gameconnection, int sequence){


m_ts.fnGameConnection_transmitDataBlocks(gameconnection, sequence);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GroundPlaneObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GroundPlaneObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Intended as a helper to developers and editor scripts.                   Force trigger an inspectPostApply. This will transmit                    material and other fields to client objects.                   )
/// </summary>
public  void postApply(string groundplane){


m_ts.fnGroundPlane_postApply(groundplane);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiAutoCompleteCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiAutoCompleteCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( GuiAutoCompleteCtrl, add, void, 3, 5, (string name, int idNum, int scheme=0))
/// </summary>
public  void add(string guiautocompletectrl, string a2= "", string a3= "", string a4= ""){


m_ts.fnGuiAutoCompleteCtrl_add(guiautocompletectrl, a2, a3, a4);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, addScheme, void, 6, 6, (int id, ColorI fontColor, ColorI fontColorHL, ColorI fontColorSEL))
/// </summary>
public  void addScheme(string guiautocompletectrl, string a2, string a3, string a4, string a5= ""){


m_ts.fnGuiAutoCompleteCtrl_addScheme(guiautocompletectrl, a2, a3, a4, a5);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, changeTextById, void, 4, 4, ( int id, string text ) )
/// </summary>
public  void changeTextById(string guiautocompletectrl, string a2, string a3= ""){


m_ts.fnGuiAutoCompleteCtrl_changeTextById(guiautocompletectrl, a2, a3);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, clear, void, 2, 2, Clear the popup list.)
/// </summary>
public  void clear(string guiautocompletectrl= ""){


m_ts.fnGuiAutoCompleteCtrl_clear(guiautocompletectrl);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, clearEntry, void, 3, 3, (S32 entry))
/// </summary>
public  void clearEntry(string guiautocompletectrl, string a2= ""){


m_ts.fnGuiAutoCompleteCtrl_clearEntry(guiautocompletectrl, a2);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, findText, S32, 3, 3, (string text)              Returns the position of the first entry containing the specified text.)
/// </summary>
public  int findText(string guiautocompletectrl, string a2= ""){


return m_ts.fnGuiAutoCompleteCtrl_findText(guiautocompletectrl, a2);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, forceClose, void, 2, 2, )
/// </summary>
public  void forceClose(string guiautocompletectrl= ""){


m_ts.fnGuiAutoCompleteCtrl_forceClose(guiautocompletectrl);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, forceOnAction, void, 2, 2, )
/// </summary>
public  void forceOnAction(string guiautocompletectrl= ""){


m_ts.fnGuiAutoCompleteCtrl_forceOnAction(guiautocompletectrl);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, getSelected, S32, 2, 2, )
/// </summary>
public  int getSelected(string guiautocompletectrl= ""){


return m_ts.fnGuiAutoCompleteCtrl_getSelected(guiautocompletectrl);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, getText, void, 2, 2, )
/// </summary>
public  void getText(string guiautocompletectrl= ""){


m_ts.fnGuiAutoCompleteCtrl_getText(guiautocompletectrl);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, getTextById, const char*, 3, 3,  (int id))
/// </summary>
public  string getTextById(string guiautocompletectrl, string a2= ""){


return m_ts.fnGuiAutoCompleteCtrl_getTextById(guiautocompletectrl, a2);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, replaceText, void, 3, 3, (bool doReplaceText))
/// </summary>
public  void replaceText(string guiautocompletectrl, string a2= ""){


m_ts.fnGuiAutoCompleteCtrl_replaceText(guiautocompletectrl, a2);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, setEnumContent, void, 4, 4, (string class, string enum)              This fills the popup with a classrep's field enumeration type info.              More of a helper function than anything.   If console access to the field list is added,               at least for the enumerated types, then this should go away..)
/// </summary>
public  void setEnumContent(string guiautocompletectrl, string a2, string a3= ""){


m_ts.fnGuiAutoCompleteCtrl_setEnumContent(guiautocompletectrl, a2, a3);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, setFirstSelected, void, 2, 3, ([scriptCallback=true]))
/// </summary>
public  void setFirstSelected(string guiautocompletectrl= "", string a2= ""){


m_ts.fnGuiAutoCompleteCtrl_setFirstSelected(guiautocompletectrl, a2);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, setNoneSelected, void, 2, 2, )
/// </summary>
public  void setNoneSelected(string guiautocompletectrl= ""){


m_ts.fnGuiAutoCompleteCtrl_setNoneSelected(guiautocompletectrl);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, setSelected, void, 3, 4, (int id, [scriptCallback=true]))
/// </summary>
public  void setSelected(string guiautocompletectrl, string a2= "", string a3= ""){


m_ts.fnGuiAutoCompleteCtrl_setSelected(guiautocompletectrl, a2, a3);
}
/// <summary>
/// ( GuiAutoCompleteCtrl, size, S32, 2, 2, Get the size of the menu - the number of entries in it.)
/// </summary>
public  int size(string guiautocompletectrl= ""){


return m_ts.fnGuiAutoCompleteCtrl_size(guiautocompletectrl);
}
/// <summary>
/// (GuiAutoCompleteCtrl, sort, void, 2, 2, Sort the list alphabetically.)
/// </summary>
public  void sort(string guiautocompletectrl= ""){


m_ts.fnGuiAutoCompleteCtrl_sort(guiautocompletectrl);
}
/// <summary>
/// (GuiAutoCompleteCtrl, sortID, void, 2, 2, Sort the list by ID.)
/// </summary>
public  void sortID(string guiautocompletectrl= ""){


m_ts.fnGuiAutoCompleteCtrl_sortID(guiautocompletectrl);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiAutoScrollCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiAutoScrollCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Reset scrolling. )
/// </summary>
public  void reset(string guiautoscrollctrl){


m_ts.fnGuiAutoScrollCtrl_reset(guiautoscrollctrl);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiBitmapButtonCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiBitmapButtonCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Set the bitmap to show on the button.   @param path Path to the texture file in any of the supported formats. )
/// </summary>
public  void setBitmap(string guibitmapbuttonctrl, string path){


m_ts.fnGuiBitmapButtonCtrl_setBitmap(guibitmapbuttonctrl, path);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiBitmapCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiBitmapCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( String filename | String filename, bool resize ) Assign an image to the control.   @hide )
/// </summary>
public  void GuiBitmapCtrl_setBitmap(string guibitmapctrl, string fileRoot, bool resize = false){


m_ts.fn_GuiBitmapCtrl_setBitmap(guibitmapctrl, fileRoot, resize);
}
/// <summary>
/// Set the offset of the bitmap within the control.   @param x The x-axis offset of the image.   @param y The y-axis offset of the image.)
/// </summary>
public  void setValue(string guibitmapctrl, int x, int y){


m_ts.fnGuiBitmapCtrl_setValue(guibitmapctrl, x, y);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiButtonBaseCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiButtonBaseCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Get the text display on the button's label (if any).   @return The button's label. )
/// </summary>
public  string getText(string guibuttonbasectrl){


return m_ts.fnGuiButtonBaseCtrl_getText(guibuttonbasectrl);
}
/// <summary>
/// Simulate a click on the button.   This method will trigger the button's action just as if the button had been pressed by the    user. )
/// </summary>
public  void performClick(string guibuttonbasectrl){


m_ts.fnGuiButtonBaseCtrl_performClick(guibuttonbasectrl);
}
/// <summary>
/// Reset the mousing state of the button.   This method should not generally be called. )
/// </summary>
public  void resetState(string guibuttonbasectrl){


m_ts.fnGuiButtonBaseCtrl_resetState(guibuttonbasectrl);
}
/// <summary>
/// For toggle or radio buttons, set whether the button is currently activated or not.  For radio buttons,    toggling a button on will toggle all other radio buttons in its group to off.   @param isOn If true, the button will be toggled on (if not already); if false, it will be toggled off.   @note Toggling the state of a button with this method will em>not/em> not trigger the action associated with the       button.  To do that, use performClick(). )
/// </summary>
public  void setStateOn(string guibuttonbasectrl, bool isOn = true){


m_ts.fnGuiButtonBaseCtrl_setStateOn(guibuttonbasectrl, isOn);
}
/// <summary>
/// Set the text displayed on the button's label.   @param text The text to display as the button's text label.   @note Not all buttons render text labels.   @see getText   @see setTextID )
/// </summary>
public  void setText(string guibuttonbasectrl, string text){


m_ts.fnGuiButtonBaseCtrl_setText(guibuttonbasectrl, text);
}
/// <summary>
/// Set the text displayed on the button's label using a string from the string table    assigned to the control.   @param id Name of the variable that contains the integer string ID.  Used to look up       string in table.   @note Not all buttons render text labels.   @see setText   @see getText   @see GuiControl::langTableMod   @see LangTable   @ref Gui_i18n )
/// </summary>
public  void setTextID(string guibuttonbasectrl, string id){


m_ts.fnGuiButtonBaseCtrl_setTextID(guibuttonbasectrl, id);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiCanvasObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiCanvasObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// () - Is this canvas currently fullscreen? )
/// </summary>
public  bool GuiCanvas_isFullscreen(string guicanvas){


return m_ts.fn_GuiCanvas_isFullscreen(guicanvas);
}
/// <summary>
/// () )
/// </summary>
public  bool GuiCanvas_isMaximized(string guicanvas){


return m_ts.fn_GuiCanvas_isMaximized(guicanvas);
}
/// <summary>
/// () )
/// </summary>
public  bool GuiCanvas_isMinimized(string guicanvas){


return m_ts.fn_GuiCanvas_isMinimized(guicanvas);
}
/// <summary>
/// () - maximize this canvas' window. )
/// </summary>
public  void GuiCanvas_maximizeWindow(string guicanvas){


m_ts.fn_GuiCanvas_maximizeWindow(guicanvas);
}
/// <summary>
/// () - minimize this canvas' window. )
/// </summary>
public  void GuiCanvas_minimizeWindow(string guicanvas){


m_ts.fn_GuiCanvas_minimizeWindow(guicanvas);
}
/// <summary>
/// (GuiControl ctrl=NULL)			  @hide)
/// </summary>
public  void GuiCanvas_popDialog(string guicanvas, string gui){


m_ts.fn_GuiCanvas_popDialog(guicanvas, gui);
}
/// <summary>
/// (int layer) 			  @hide)
/// </summary>
public  void GuiCanvas_popLayer(string guicanvas, int layer = 0){


m_ts.fn_GuiCanvas_popLayer(guicanvas, layer);
}
/// <summary>
/// (GuiControl ctrl, int layer=0, bool center=false)			  @hide)
/// </summary>
public  void GuiCanvas_pushDialog(string guicanvas, string ctrlName, int layer = 0, bool center = false){


m_ts.fn_GuiCanvas_pushDialog(guicanvas, ctrlName, layer, center);
}
/// <summary>
/// () - restore this canvas' window. )
/// </summary>
public  void GuiCanvas_restoreWindow(string guicanvas){


m_ts.fn_GuiCanvas_restoreWindow(guicanvas);
}
/// <summary>
/// (Point2I pos)			  @hide)
/// </summary>
public  void GuiCanvas_setCursorPos(string guicanvas, Point2I pos){


m_ts.fn_GuiCanvas_setCursorPos(guicanvas, pos.AsString());
}
/// <summary>
/// () - Claim OS input focus for this canvas' window.)
/// </summary>
public  void GuiCanvas_setFocus(string guicanvas){


m_ts.fn_GuiCanvas_setFocus(guicanvas);
}
/// <summary>
/// (int width, int height, bool fullscreen, [int bitDepth], [int refreshRate], [int antialiasLevel] )               Change the video mode of this canvas. This method has the side effect of setting the $pref::Video::mode to the new values.               \\param width The screen width to set.               \\param height The screen height to set.               \\param fullscreen Specify true to run fullscreen or false to run in a window               \\param bitDepth [optional] The desired bit-depth. Defaults to the current setting. This parameter is ignored if you are running in a window.               \\param refreshRate [optional] The desired refresh rate. Defaults to the current setting. This parameter is ignored if you are running in a window					\\param antialiasLevel [optional] The level of anti-aliasing to apply 0 = none )
/// </summary>
public  void GuiCanvas_setVideoMode(string guicanvas, uint width, uint height, bool fullscreen = false, uint bitDepth = 0, uint refreshRate = 0, uint antialiasLevel = 0){


m_ts.fn_GuiCanvas_setVideoMode(guicanvas, width, height, fullscreen, bitDepth, refreshRate, antialiasLevel);
}
/// <summary>
/// Translate a coordinate from canvas window-space to screen-space.   @param coordinate The coordinate in window-space.   @return The given coordinate translated to screen-space. )
/// </summary>
public  Point2I clientToScreen(string guicanvas, Point2I coordinate){


return new Point2I ( m_ts.fnGuiCanvas_clientToScreen(guicanvas, coordinate.AsString()));
}
/// <summary>
/// @brief Turns on the mouse off.				   @tsexample				   Canvas.cursorOff();				   @endtsexample)
/// </summary>
public  void cursorOff(string guicanvas){


m_ts.fnGuiCanvas_cursorOff(guicanvas);
}
/// <summary>
/// @brief Turns on the mouse cursor.				   @tsexample				   Canvas.cursorOn();				   @endtsexample)
/// </summary>
public  void cursorOn(string guicanvas){


m_ts.fnGuiCanvas_cursorOn(guicanvas);
}
/// <summary>
/// @brief Find the first monitor index that matches the given name.               The actual match algorithm depends on the implementation.               @param name The name to search for.				   @return The number of monitors attached to the system, including the default monoitor.)
/// </summary>
public  int findFirstMatchingMonitor(string guicanvas, string name){


return m_ts.fnGuiCanvas_findFirstMatchingMonitor(guicanvas, name);
}
/// <summary>
/// @brief Get the GuiControl which is being used as the content.				   @tsexample				   Canvas.getContent();				   @endtsexample				   @return ID of current content control)
/// </summary>
public  int getContent(string guicanvas){


return m_ts.fnGuiCanvas_getContent(guicanvas);
}
/// <summary>
/// @brief Get the current position of the cursor.				   @param param Description				   @tsexample				   %cursorPos = Canvas.getCursorPos();				   @endtsexample				   @return Screen coordinates of mouse cursor, in format \"X Y\")
/// </summary>
public  Point2I getCursorPos(string guicanvas){


return new Point2I ( m_ts.fnGuiCanvas_getCursorPos(guicanvas));
}
/// <summary>
/// @brief Returns the dimensions of the canvas				   @tsexample				   %extent = Canvas.getExtent();				   @endtsexample				   @return Width and height of canvas. Formatted as numerical values in a single string \"# #\")
/// </summary>
public  Point2I getExtent(string guicanvas){


return new Point2I ( m_ts.fnGuiCanvas_getExtent(guicanvas));
}
/// <summary>
/// @brief Gets information on the specified mode of this device.				   @param modeId Index of the mode to get data from.				   @return A video mode string given an adapter and mode index.				   @see GuiCanvas::getVideoMode())
/// </summary>
public  string getMode(string guicanvas, int modeId){


return m_ts.fnGuiCanvas_getMode(guicanvas, modeId);
}
/// <summary>
/// @brief Gets the number of modes available on this device.				   @param param Description				   @tsexample				   %modeCount = Canvas.getModeCount()				   @endtsexample				   @return The number of video modes supported by the device)
/// </summary>
public  int getModeCount(string guicanvas){


return m_ts.fnGuiCanvas_getModeCount(guicanvas);
}
/// <summary>
/// @brief Gets the number of monitors attached to the system.				   @return The number of monitors attached to the system, including the default monoitor.)
/// </summary>
public  int getMonitorCount(string guicanvas){


return m_ts.fnGuiCanvas_getMonitorCount(guicanvas);
}
/// <summary>
/// @brief Gets the name of the requested monitor.               @param index The monitor index.				   @return The name of the requested monitor.)
/// </summary>
public  string getMonitorName(string guicanvas, int index){


return m_ts.fnGuiCanvas_getMonitorName(guicanvas, index);
}
/// <summary>
/// @brief Gets the region of the requested monitor.               @param index The monitor index.				   @return The rectangular region of the requested monitor.)
/// </summary>
public  RectI getMonitorRect(string guicanvas, int index){


return new RectI ( m_ts.fnGuiCanvas_getMonitorRect(guicanvas, index));
}
/// <summary>
/// @brief Gets the gui control under the mouse.				   @tsexample				   %underMouse = Canvas.getMouseControl();				   @endtsexample				   @return ID of the gui control, if one was found. NULL otherwise)
/// </summary>
public  int getMouseControl(string guicanvas){


return m_ts.fnGuiCanvas_getMouseControl(guicanvas);
}
/// <summary>
/// @brief Gets the current screen mode as a string.				   The return string will contain 5 values (width, height, fullscreen, bitdepth, refreshRate). 				   You will need to parse out each one for individual use.				   @tsexample				   %screenWidth = getWord(Canvas.getVideoMode(), 0);				   %screenHeight = getWord(Canvas.getVideoMode(), 1);				   %isFullscreen = getWord(Canvas.getVideoMode(), 2);				   %bitdepth = getWord(Canvas.getVideoMode(), 3);				   %refreshRate = getWord(Canvas.getVideoMode(), 4);				   @endtsexample				   @return String formatted with screen width, screen height, screen mode, bit depth, and refresh rate.)
/// </summary>
public  string getVideoMode(string guicanvas){


return m_ts.fnGuiCanvas_getVideoMode(guicanvas);
}
/// <summary>
/// Get the current position of the platform window associated with the canvas.   @return The window position of the canvas in screen-space. )
/// </summary>
public  Point2I getWindowPosition(string guicanvas){


return new Point2I ( m_ts.fnGuiCanvas_getWindowPosition(guicanvas));
}
/// <summary>
/// @brief Disable rendering of the cursor.				   @tsexample				   Canvas.hideCursor();				   @endtsexample)
/// </summary>
public  void hideCursor(string guicanvas){


m_ts.fnGuiCanvas_hideCursor(guicanvas);
}
/// <summary>
/// @brief Determines if mouse cursor is enabled.				   @tsexample				   // Is cursor on?				   if(Canvas.isCursorOn())				   	echo(\"Canvas cursor is on\");				   @endtsexample				   @return Returns true if the cursor is on.)
/// </summary>
public  bool isCursorOn(string guicanvas){


return m_ts.fnGuiCanvas_isCursorOn(guicanvas);
}
/// <summary>
/// @brief Determines if mouse cursor is rendering.				   @tsexample				   // Is cursor rendering?				   if(Canvas.isCursorShown())				   	echo(\"Canvas cursor is rendering\");				   @endtsexample				   @return Returns true if the cursor is rendering.)
/// </summary>
public  bool isCursorShown(string guicanvas){


return m_ts.fnGuiCanvas_isCursorShown(guicanvas);
}
/// <summary>
/// @brief This turns on/off front-buffer rendering.				   @param enable True if all rendering should be done to the front buffer				   @tsexample				   Canvas.renderFront(false);				   @endtsexample)
/// </summary>
public  void renderFront(string guicanvas, bool enable){


m_ts.fnGuiCanvas_renderFront(guicanvas, enable);
}
/// <summary>
/// @brief Force canvas to redraw.               If the elapsed time is greater than the time since the last paint                then the repaint will be skipped.               @param elapsedMS The optional elapsed time in milliseconds.				   @tsexample				   Canvas.repaint();				   @endtsexample)
/// </summary>
public  void repaint(string guicanvas, int elapsedMS = 0){


m_ts.fnGuiCanvas_repaint(guicanvas, elapsedMS);
}
/// <summary>
/// @brief Reset the update regions for the canvas.				   @tsexample				   Canvas.reset();				   @endtsexample)
/// </summary>
public  void reset(string guicanvas){


m_ts.fnGuiCanvas_reset(guicanvas);
}
/// <summary>
/// Translate a coordinate from screen-space to canvas window-space.   @param coordinate The coordinate in screen-space.   @return The given coordinate translated to window-space. )
/// </summary>
public  Point2I screenToClient(string guicanvas, Point2I coordinate){


return new Point2I ( m_ts.fnGuiCanvas_screenToClient(guicanvas, coordinate.AsString()));
}
/// <summary>
/// @brief Set the content of the canvas to a specified control.				   @param ctrl ID or name of GuiControl to set content to				   @tsexample				   Canvas.setContent(PlayGui);				   @endtsexample)
/// </summary>
public  void setContent(string guicanvas, string ctrl){


m_ts.fnGuiCanvas_setContent(guicanvas, ctrl);
}
/// <summary>
/// @brief Sets the cursor for the canvas.				   @param cursor Name of the GuiCursor to use				   @tsexample				   Canvas.setCursor(\"DefaultCursor\");				   @endtsexample)
/// </summary>
public  void setCursor(string guicanvas, string cursor){


m_ts.fnGuiCanvas_setCursor(guicanvas, cursor);
}
/// <summary>
/// (bool shown) - Enabled when a context menu/popup menu is shown.)
/// </summary>
public  void setPopupShown(string guicanvas, bool shown){


m_ts.fnGuiCanvas_setPopupShown(guicanvas, shown);
}
/// <summary>
/// Set the position of the platform window associated with the canvas.   @param position The new position of the window in screen-space. )
/// </summary>
public  void setWindowPosition(string guicanvas, Point2I position){


m_ts.fnGuiCanvas_setWindowPosition(guicanvas, position.AsString());
}
/// <summary>
/// @brief Change the title of the OS window.				   @param newTitle String containing the new name				   @tsexample				   Canvas.setWindowTitle(\"Documentation Rocks!\");				   @endtsexample)
/// </summary>
public  void setWindowTitle(string guicanvas, string newTitle){


m_ts.fnGuiCanvas_setWindowTitle(guicanvas, newTitle);
}
/// <summary>
/// @brief Enable rendering of the cursor.				   @tsexample				   Canvas.showCursor();				   @endtsexample)
/// </summary>
public  void showCursor(string guicanvas){


m_ts.fnGuiCanvas_showCursor(guicanvas);
}
/// <summary>
/// @brief toggle canvas from fullscreen to windowed mode or back.				   @tsexample				   // If we are in windowed mode, the following will put is in fullscreen				   Canvas.toggleFullscreen();				   @endtsexample)
/// </summary>
public  void toggleFullscreen(string guicanvas){


m_ts.fnGuiCanvas_toggleFullscreen(guicanvas);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiCheckBoxCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiCheckBoxCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Test whether the checkbox is currently checked.   @return True if the checkbox is currently ticked, false otherwise. )
/// </summary>
public  bool isStateOn(string guicheckboxctrl){


return m_ts.fnGuiCheckBoxCtrl_isStateOn(guicheckboxctrl);
}
/// <summary>
/// Set whether the checkbox is ticked or not.   @param newState If true the box will be checked, if false, it will be unchecked.   @note This method will @b not trigger the command associated with the control.  To toggle the       checkbox state as if the user had clicked the control, use performClick(). )
/// </summary>
public  void setStateOn(string guicheckboxctrl, bool newState){


m_ts.fnGuiCheckBoxCtrl_setStateOn(guicheckboxctrl, newState);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiChunkedBitmapCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiChunkedBitmapCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Set the image rendered in this control.   @param filename The image name you want to set   @tsexample   ChunkedBitmap.setBitmap(\"images/background.png\");   @endtsexample)
/// </summary>
public  void setBitmap(string guichunkedbitmapctrl, string filename){


m_ts.fnGuiChunkedBitmapCtrl_setBitmap(guichunkedbitmapctrl, filename);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiClockHudObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiClockHudObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Returns the current time, in seconds.													@return timeInseconds Current time, in seconds													@tsexample														// Get the current time from the GuiClockHud control														%timeInSeconds = %guiClockHud.getTime();													@endtsexample				  )
/// </summary>
public  float getTime(string guiclockhud){


return m_ts.fnGuiClockHud_getTime(guiclockhud);
}
/// <summary>
/// @brief Sets a time for a countdown clock.   												Setting the time like this will cause the clock to count backwards from the specified time.													@param timeInSeconds Time to set the clock, in seconds (IE: 00:02 would be 120)													@see setTime				  )
/// </summary>
public  void setReverseTime(string guiclockhud, float timeInSeconds = 60){


m_ts.fnGuiClockHud_setReverseTime(guiclockhud, timeInSeconds);
}
/// <summary>
/// Sets the current base time for the clock.													@param timeInSeconds Time to set the clock, in seconds (IE: 00:02 would be 120)													@tsexample														// Define the time, in seconds														%timeInSeconds = 120;														// Change the time on the GuiClockHud control														%guiClockHud.setTime(%timeInSeconds);													@endtsexample				  )
/// </summary>
public  void setTime(string guiclockhud, float timeInSeconds = 60){


m_ts.fnGuiClockHud_setTime(guiclockhud, timeInSeconds);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiColorPickerCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiColorPickerCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Gets the current position of the selector)
/// </summary>
public  Point2I GuiColorPickerCtrl_getSelectorPos(string guicolorpickerctrl){


return new Point2I ( m_ts.fn_GuiColorPickerCtrl_getSelectorPos(guicolorpickerctrl));
}
/// <summary>
/// Sets the current position of the selector)
/// </summary>
public  void GuiColorPickerCtrl_setSelectorPos(string guicolorpickerctrl, Point2I newPos){


m_ts.fn_GuiColorPickerCtrl_setSelectorPos(guicolorpickerctrl, newPos.AsString());
}
/// <summary>
/// Forces update of pick color)
/// </summary>
public  void GuiColorPickerCtrl_updateColor(string guicolorpickerctrl){


m_ts.fn_GuiColorPickerCtrl_updateColor(guicolorpickerctrl);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiControlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiControlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// )
/// </summary>
public  RectI GuiControl_getBounds(string guicontrol){


return new RectI ( m_ts.fn_GuiControl_getBounds(guicontrol));
}
/// <summary>
/// )
/// </summary>
public  string GuiControl_getValue(string guicontrol){


return m_ts.fn_GuiControl_getValue(guicontrol);
}
/// <summary>
/// )
/// </summary>
public  bool GuiControl_isActive(string guicontrol){


return m_ts.fn_GuiControl_isActive(guicontrol);
}
/// <summary>
/// (bool isFirst))
/// </summary>
public  void GuiControl_makeFirstResponder(string guicontrol, bool isFirst){


m_ts.fn_GuiControl_makeFirstResponder(guicontrol, isFirst);
}
/// <summary>
///  Set the width and height of the control.   @hide )
/// </summary>
public  void GuiControl_setExtent(string guicontrol, Point2F ext){


m_ts.fn_GuiControl_setExtent(guicontrol, ext.AsString());
}
/// <summary>
/// Add the given control as a child to this control.   This is synonymous to calling SimGroup::addObject.   @param control The control to add as a child.   @note The control will retain its current position and size.   @see SimGroup::addObject   @ref GuiControl_Hierarchy )
/// </summary>
public  void addGuiControl(string guicontrol, string control){


m_ts.fnGuiControl_addGuiControl(guicontrol, control);
}
/// <summary>
/// Returns if the control's background color can be changed in the game or not. )
/// </summary>
public  bool canChangeContextBackColor(string guicontrol){


return m_ts.fnGuiControl_canChangeContextBackColor(guicontrol);
}
/// <summary>
/// Returns if the control's fill color can be changed in the game or not. )
/// </summary>
public  bool canChangeContextFillColor(string guicontrol){


return m_ts.fnGuiControl_canChangeContextFillColor(guicontrol);
}
/// <summary>
/// Returns if the control's font color can be changed in the game or not. )
/// </summary>
public  bool canChangeContextFontColor(string guicontrol){


return m_ts.fnGuiControl_canChangeContextFontColor(guicontrol);
}
/// <summary>
/// Returns if the control's font size can be changed in the game or not. )
/// </summary>
public  bool canChangeContextFontSize(string guicontrol){


return m_ts.fnGuiControl_canChangeContextFontSize(guicontrol);
}
/// <summary>
/// Returns if the control's window settings can be changed in the game or not. )
/// </summary>
public  bool canShowContextWindowSettings(string guicontrol){


return m_ts.fnGuiControl_canShowContextWindowSettings(guicontrol);
}
/// <summary>
/// Clear this control from being the first responder in its hierarchy chain.   @param ignored Ignored.  Supported for backwards-compatibility. )
/// </summary>
public  void clearFirstResponder(string guicontrol, bool ignored = false){


m_ts.fnGuiControl_clearFirstResponder(guicontrol, ignored);
}
/// <summary>
/// Test whether the given control is a direct or indirect child to this control.   @param control The potential child control.   @return True if the given control is a direct or indirect child to this control. )
/// </summary>
public  bool controlIsChild(string guicontrol, string control){


return m_ts.fnGuiControl_controlIsChild(guicontrol, control);
}
/// <summary>
/// Test whether the given control is a sibling of this control.   @param control The potential sibling control.   @return True if the given control is a sibling of this control. )
/// </summary>
public  bool controlIsSibling(string guicontrol, string control){


return m_ts.fnGuiControl_controlIsSibling(guicontrol, control);
}
/// <summary>
/// Find the topmost child control located at the given coordinates.   @note Only children that are both visible and have the 'modal' flag set in their profile will be considered in the search.   @param x The X coordinate in the control's own coordinate space.   @param y The Y coordinate in the control's own coordinate space.   @return The topmost child control at the given coordintes or the control on which the method was called if no matching child could be found.   @see GuiControlProfile::modal   @see findHitControls )
/// </summary>
public  string findHitControl(string guicontrol, int x, int y){


return m_ts.fnGuiControl_findHitControl(guicontrol, x, y);
}
/// <summary>
/// Find all visible child controls that intersect with the given rectangle.   @note Invisible child controls will not be included in the search.   @param x The X coordinate of the rectangle's upper left corner in the control's own coordinate space.   @param y The Y coordinate of the rectangle's upper left corner in the control's own coordinate space.   @param width The width of the search rectangle in pixels.   @param height The height of the search rectangle in pixels.   @return A space-separated list of the IDs of all visible control objects intersecting the given rectangle.   @tsexample   // Lock all controls in the rectangle at x=10 and y=10 and the extent width=100 and height=100.   foreach$( %ctrl in %this.findHitControls( 10, 10, 100, 100 ) )      %ctrl.setLocked( true );   @endtsexample   @see findHitControl )
/// </summary>
public  string findHitControls(string guicontrol, int x, int y, int width, int height){


return m_ts.fnGuiControl_findHitControls(guicontrol, x, y, width, height);
}
/// <summary>
/// Get the alpha fade time for the object. )
/// </summary>
public  int getAlphaFadeTime(string guicontrol){


return m_ts.fnGuiControl_getAlphaFadeTime(guicontrol);
}
/// <summary>
/// Get the alpha for the object. )
/// </summary>
public  float getAlphaValue(string guicontrol){


return m_ts.fnGuiControl_getAlphaValue(guicontrol);
}
/// <summary>
/// Get the aspect ratio of the control's extents.   @return The width of the control divided by its height.   @see getExtent )
/// </summary>
public  float getAspect(string guicontrol){


return m_ts.fnGuiControl_getAspect(guicontrol);
}
/// <summary>
/// Get the coordinate of the control's center point relative to its parent.   @return The coordinate of the control's center point in parent-relative coordinates. )
/// </summary>
public  Point2I getCenter(string guicontrol){


return new Point2I ( m_ts.fnGuiControl_getCenter(guicontrol));
}
/// <summary>
/// Sets the font size of a control. )
/// </summary>
public  int getControlFontSize(string guicontrol){


return m_ts.fnGuiControl_getControlFontSize(guicontrol);
}
/// <summary>
/// Returns if the control is locked or not. )
/// </summary>
public  bool getControlLock(string guicontrol){


return m_ts.fnGuiControl_getControlLock(guicontrol);
}
/// <summary>
/// Returns the filename of the texture of the control. )
/// </summary>
public  string getControlTextureFile(string guicontrol){


return m_ts.fnGuiControl_getControlTextureFile(guicontrol);
}
/// <summary>
/// Get the width and height of the control.   @return A point structure containing the width of the control in x and the height in y. )
/// </summary>
public  Point2I getExtent(string guicontrol){


return new Point2I ( m_ts.fnGuiControl_getExtent(guicontrol));
}
/// <summary>
/// Get the first responder set on this GuiControl tree.   @return The first responder set on the control's subtree.   @see isFirstResponder   @see makeFirstResponder   @see setFirstResponder   @ref GuiControl_FirstResponders )
/// </summary>
public  string getFirstResponder(string guicontrol){


return m_ts.fnGuiControl_getFirstResponder(guicontrol);
}
/// <summary>
/// Get the coordinate of the control's center point in coordinates relative to the root control in its control hierarchy.   @Return the center coordinate of the control in root-relative coordinates. )
/// </summary>
public  Point2I getGlobalCenter(string guicontrol){


return new Point2I ( m_ts.fnGuiControl_getGlobalCenter(guicontrol));
}
/// <summary>
/// Get the position of the control relative to the root of the GuiControl hierarchy it is contained in.   @return The control's current position in root-relative coordinates. )
/// </summary>
public  Point2I getGlobalPosition(string guicontrol){


return new Point2I ( m_ts.fnGuiControl_getGlobalPosition(guicontrol));
}
/// <summary>
/// Get the maximum allowed size of the control.   @return The maximum size to which the control can be shrunk.   @see maxExtent )
/// </summary>
public  Point2I getMaxExtent(string guicontrol){


return new Point2I ( m_ts.fnGuiControl_getMaxExtent(guicontrol));
}
/// <summary>
/// Get the minimum allowed size of the control.   @return The minimum size to which the control can be shrunk.   @see minExtent )
/// </summary>
public  Point2I getMinExtent(string guicontrol){


return new Point2I ( m_ts.fnGuiControl_getMinExtent(guicontrol));
}
/// <summary>
/// Get the mouse over alpha for the object. )
/// </summary>
public  float getMouseOverAlphaValue(string guicontrol){


return m_ts.fnGuiControl_getMouseOverAlphaValue(guicontrol);
}
/// <summary>
/// Get the immediate parent control of the control.   @return The immediate parent GuiControl or 0 if the control is not parented to a GuiControl. )
/// </summary>
public  string getParent(string guicontrol){


return m_ts.fnGuiControl_getParent(guicontrol);
}
/// <summary>
/// Get the control's current position relative to its parent.   @return The coordinate of the control in its parent's coordinate space. )
/// </summary>
public  Point2I getPosition(string guicontrol){


return new Point2I ( m_ts.fnGuiControl_getPosition(guicontrol));
}
/// <summary>
/// Get the canvas on which the control is placed.   @return The canvas on which the control's hierarchy is currently placed or 0 if the control is not currently placed on a GuiCanvas.   @see GuiControl_Hierarchy )
/// </summary>
public  string getRoot(string guicontrol){


return m_ts.fnGuiControl_getRoot(guicontrol);
}
/// <summary>
/// Get root control )
/// </summary>
public  string getRootControl(string guicontrol){


return m_ts.fnGuiControl_getRootControl(guicontrol);
}
/// <summary>
/// Test whether the control is currently awake.   If a control is awake it means that it is part of the GuiControl hierarchy of a GuiCanvas.   @return True if the control is awake.   @ref GuiControl_Waking )
/// </summary>
public  bool isAwake(string guicontrol){


return m_ts.fnGuiControl_isAwake(guicontrol);
}
/// <summary>
/// Returns if the control's alpha value can be changed in the game or not. )
/// </summary>
public  bool isContextAlphaEnabled(string guicontrol){


return m_ts.fnGuiControl_isContextAlphaEnabled(guicontrol);
}
/// <summary>
/// Returns if the control's alpha fade value can be changed in the game or not. )
/// </summary>
public  bool isContextAlphaFadeEnabled(string guicontrol){


return m_ts.fnGuiControl_isContextAlphaFadeEnabled(guicontrol);
}
/// <summary>
/// Returns if the control can be locked in the game or not. )
/// </summary>
public  bool isContextLockable(string guicontrol){


return m_ts.fnGuiControl_isContextLockable(guicontrol);
}
/// <summary>
/// Returns if the control's mouse-over alpha value can be changed in the game or not. )
/// </summary>
public  bool isContextMouseOverAlphaEnabled(string guicontrol){


return m_ts.fnGuiControl_isContextMouseOverAlphaEnabled(guicontrol);
}
/// <summary>
/// Returns if the control can be moved in the game or not. )
/// </summary>
public  bool isContextMovable(string guicontrol){


return m_ts.fnGuiControl_isContextMovable(guicontrol);
}
/// <summary>
/// Test whether the control is the current first responder.   @return True if the control is the current first responder.   @see makeFirstResponder   @see setFirstResponder   @ref GuiControl_FirstResponders )
/// </summary>
public  bool isFirstResponder(string guicontrol){


return m_ts.fnGuiControl_isFirstResponder(guicontrol);
}
/// <summary>
/// Indicates if the mouse is locked in this control.   @return True if the mouse is currently locked. )
/// </summary>
public  bool isMouseLocked(string guicontrol){


return m_ts.fnGuiControl_isMouseLocked(guicontrol);
}
/// <summary>
/// Test whether the control is currently set to be visible.   @return True if the control is currently set to be visible.   @note This method does not tell anything about whether the control is actually visible to       the user at the moment.   @ref GuiControl_VisibleActive )
/// </summary>
public  bool isVisible(string guicontrol){


return m_ts.fnGuiControl_isVisible(guicontrol);
}
/// <summary>
/// Test whether the given point lies within the rectangle of the control.   @param x X coordinate of the point in parent-relative coordinates.   @param y Y coordinate of the point in parent-relative coordinates.   @return True if the point is within the control, false if not.   @see getExtent   @see getPosition )
/// </summary>
public  bool pointInControl(string guicontrol, int x, int y){


return m_ts.fnGuiControl_pointInControl(guicontrol, x, y);
}
/// <summary>
/// Recalculates the position and size of this control and all its children. )
/// 
/// </summary>
public  void refresh(string guicontrol){


m_ts.fnGuiControl_refresh(guicontrol);
}
/// <summary>
/// Removes the plus cursor.   @param ignored Ignored.  Supported for backwards-compatibility. )
/// </summary>
public  void resetCur(string guicontrol){


m_ts.fnGuiControl_resetCur(guicontrol);
}
/// <summary>
/// Resize and reposition the control using the give coordinates and dimensions.  Child controls    will resize according to their layout behaviors.   @param x The new X coordinate of the control in its parent's coordinate space.   @param y The new Y coordinate of the control in its parent's coordinate space.   @param width The new width to which the control should be resized.   @param height The new height to which the control should be resized. )
/// </summary>
public  void resize(string guicontrol, int x, int y, int width, int height){


m_ts.fnGuiControl_resize(guicontrol, x, y, width, height);
}
/// <summary>
///  )
/// </summary>
public  void setActive(string guicontrol, bool state = true){


m_ts.fnGuiControl_setActive(guicontrol, state);
}
/// <summary>
/// Set the alpha for the object.   @param value Range 0, 1 for the transparency. )
/// </summary>
public  void setAlphaFadeTime(string guicontrol, int fadeTime = 1000){


m_ts.fnGuiControl_setAlphaFadeTime(guicontrol, fadeTime);
}
/// <summary>
/// Set the alpha for the object.   @param value Range 0, 1 for the transparency. )
/// </summary>
public  void setAlphaValue(string guicontrol, float alpha = 1){


m_ts.fnGuiControl_setAlphaValue(guicontrol, alpha);
}
/// <summary>
/// Set the control's position by its center point.   @param x The X coordinate of the new center point of the control relative to the control's parent.   @param y The Y coordinate of the new center point of the control relative to the control's parent. )
/// </summary>
public  void setCenter(string guicontrol, int x, int y){


m_ts.fnGuiControl_setCenter(guicontrol, x, y);
}
/// <summary>
/// Displays the option to set the alpha of the control in the game when true. )
/// </summary>
public  void setContextAlpha(string guicontrol, bool alpha){


m_ts.fnGuiControl_setContextAlpha(guicontrol, alpha);
}
/// <summary>
/// Displays the option to set the alpha fade value of the control in the game when true. )
/// </summary>
public  void setContextAlphaFade(string guicontrol, bool fade){


m_ts.fnGuiControl_setContextAlphaFade(guicontrol, fade);
}
/// <summary>
/// Displays the option to set the background color of the control in the game when true. )
/// </summary>
public  void setContextBackColor(string guicontrol, bool backColor){


m_ts.fnGuiControl_setContextBackColor(guicontrol, backColor);
}
/// <summary>
/// Displays the option to set the fill color of the control in the game when true. )
/// </summary>
public  void setContextFillColor(string guicontrol, bool fillColor){


m_ts.fnGuiControl_setContextFillColor(guicontrol, fillColor);
}
/// <summary>
/// Displays the option to set the font color of the control in the game when true. )
/// </summary>
public  void setContextFontColor(string guicontrol, bool fontColor){


m_ts.fnGuiControl_setContextFontColor(guicontrol, fontColor);
}
/// <summary>
/// Displays the option to set the font size of the control in the game when true. )
/// </summary>
public  void setContextFontSize(string guicontrol, bool fontSize){


m_ts.fnGuiControl_setContextFontSize(guicontrol, fontSize);
}
/// <summary>
/// Displays the option to lock the control in the game when true. )
/// </summary>
public  void setContextLockControl(string guicontrol, bool lockx){


m_ts.fnGuiControl_setContextLockControl(guicontrol, lockx);
}
/// <summary>
/// Displays the option to set the mouse-over alpha of the control in the game when true. )
/// </summary>
public  void setContextMouseOverAlpha(string guicontrol, bool mouseOver){


m_ts.fnGuiControl_setContextMouseOverAlpha(guicontrol, mouseOver);
}
/// <summary>
/// Displays the option to move the control in the game when true. )
/// </summary>
public  void setContextMoveControl(string guicontrol, bool move){


m_ts.fnGuiControl_setContextMoveControl(guicontrol, move);
}
/// <summary>
/// Set control background color. )
/// </summary>
public  void setControlBackgroundColor(string guicontrol, ColorI color){


m_ts.fnGuiControl_setControlBackgroundColor(guicontrol, color.AsString());
}
/// <summary>
/// Set control fill color. )
/// </summary>
public  void setControlFillColor(string guicontrol, ColorI color){


m_ts.fnGuiControl_setControlFillColor(guicontrol, color.AsString());
}
/// <summary>
/// Set control font color. )
/// </summary>
public  void setControlFontColor(string guicontrol, ColorI color){


m_ts.fnGuiControl_setControlFontColor(guicontrol, color.AsString());
}
/// <summary>
/// Sets the font size of a control. )
/// </summary>
public  void setControlFontSize(string guicontrol, int fontSize){


m_ts.fnGuiControl_setControlFontSize(guicontrol, fontSize);
}
/// <summary>
/// Lock the control. )
/// </summary>
public  void setControlLock(string guicontrol, bool lockedx){


m_ts.fnGuiControl_setControlLock(guicontrol, lockedx);
}
/// <summary>
/// Set control texture. )
/// </summary>
public  void setControlTexture(string guicontrol, string fileName){


m_ts.fnGuiControl_setControlTexture(guicontrol, fileName);
}
/// <summary>
/// Sets the cursor as a plus.   @param ignored Ignored.  Supported for backwards-compatibility. )
/// </summary>
public  void setCur(string guicontrol){


m_ts.fnGuiControl_setCur(guicontrol);
}
/// <summary>
/// Make this control the current first responder.   @note Only controls with a profile that has canKeyFocus enabled are able to become first responders.   @see GuiControlProfile::canKeyFocus   @see isFirstResponder   @ref GuiControl_FirstResponders )
/// </summary>
public  void setFirstResponder(string guicontrol){


m_ts.fnGuiControl_setFirstResponder(guicontrol);
}
/// <summary>
/// Set the alpha for the object.   @param value Range 0, 1 for the transparency. )
/// </summary>
public  void setMouseOverAlphaValue(string guicontrol, float alpha = 1){


m_ts.fnGuiControl_setMouseOverAlphaValue(guicontrol, alpha);
}
/// <summary>
/// Position the control in the local space of the parent control.   @param x The new X coordinate of the control relative to its parent's upper left corner.   @param y The new Y coordinate of the control relative to its parent's upper left corner. )
/// </summary>
public  void setPosition(string guicontrol, int x, int y){


m_ts.fnGuiControl_setPosition(guicontrol, x, y);
}
/// <summary>
/// Set position of the control relative to the root of the GuiControl hierarchy it is contained in.   @param x The new X coordinate of the control relative to the root's upper left corner.   @param y The new Y coordinate of the control relative to the root's upper left corner. )
/// </summary>
public  void setPositionGlobal(string guicontrol, int x, int y){


m_ts.fnGuiControl_setPositionGlobal(guicontrol, x, y);
}
/// <summary>
/// Set the control profile for the control to use.   The profile used by a control determines a great part of its behavior and appearance.   @param profile The new profile the control should use.   @ref GuiControl_Profiles )
/// </summary>
public  void setProfile(string guicontrol, string profile){


m_ts.fnGuiControl_setProfile(guicontrol, profile);
}
/// <summary>
/// Displays the option to set the window settings of the control in the game when true. )
/// </summary>
public  void setShowContextWindowSettings(string guicontrol, bool lockx){


m_ts.fnGuiControl_setShowContextWindowSettings(guicontrol, lockx);
}
/// <summary>
/// Set the value associated with the control.   @param value The new value for the control. )
/// </summary>
public  void setValue(string guicontrol, string value){


m_ts.fnGuiControl_setValue(guicontrol, value);
}
/// <summary>
/// Set whether the control is visible or not.   @param state The new visiblity flag state for the control.   @ref GuiControl_VisibleActive )
/// </summary>
public  void setVisible(string guicontrol, bool state = true){


m_ts.fnGuiControl_setVisible(guicontrol, state);
}
/// <summary>
/// Returns true if the control is transparent. )
/// </summary>
public  bool transparentControlCheck(string guicontrol){


return m_ts.fnGuiControl_transparentControlCheck(guicontrol);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiControlProfileObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiControlProfileObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( pString ) )
/// </summary>
public  int GuiControlProfile_getStringWidth(string guicontrolprofile, string pString){


return m_ts.fn_GuiControlProfile_getStringWidth(guicontrolprofile, pString);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiConvexEditorCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiConvexEditorCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
///  )
/// </summary>
public  void GuiConvexEditorCtrl_dropSelectionAtScreenCenter(string guiconvexeditorctrl){


m_ts.fn_GuiConvexEditorCtrl_dropSelectionAtScreenCenter(guiconvexeditorctrl);
}
/// <summary>
///  )
/// </summary>
public  void GuiConvexEditorCtrl_handleDelete(string guiconvexeditorctrl){


m_ts.fn_GuiConvexEditorCtrl_handleDelete(guiconvexeditorctrl);
}
/// <summary>
///  )
/// </summary>
public  void GuiConvexEditorCtrl_handleDeselect(string guiconvexeditorctrl){


m_ts.fn_GuiConvexEditorCtrl_handleDeselect(guiconvexeditorctrl);
}
/// <summary>
///  )
/// </summary>
public  int GuiConvexEditorCtrl_hasSelection(string guiconvexeditorctrl){


return m_ts.fn_GuiConvexEditorCtrl_hasSelection(guiconvexeditorctrl);
}
/// <summary>
///  )
/// </summary>
public  void GuiConvexEditorCtrl_hollowSelection(string guiconvexeditorctrl){


m_ts.fn_GuiConvexEditorCtrl_hollowSelection(guiconvexeditorctrl);
}
/// <summary>
///  )
/// </summary>
public  void GuiConvexEditorCtrl_recenterSelection(string guiconvexeditorctrl){


m_ts.fn_GuiConvexEditorCtrl_recenterSelection(guiconvexeditorctrl);
}
/// <summary>
/// ( ConvexShape ) )
/// </summary>
public  void GuiConvexEditorCtrl_selectConvex(string guiconvexeditorctrl, string convex){


m_ts.fn_GuiConvexEditorCtrl_selectConvex(guiconvexeditorctrl, convex);
}
/// <summary>
///  )
/// </summary>
public  void GuiConvexEditorCtrl_splitSelectedFace(string guiconvexeditorctrl){


m_ts.fn_GuiConvexEditorCtrl_splitSelectedFace(guiconvexeditorctrl);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiDecalEditorCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiDecalEditorCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// deleteSelectedDecalDatablock( String datablock ) )
/// </summary>
public  void GuiDecalEditorCtrl_deleteDecalDatablock(string guidecaleditorctrl, string datablock){


m_ts.fn_GuiDecalEditorCtrl_deleteDecalDatablock(guidecaleditorctrl, datablock);
}
/// <summary>
/// deleteSelectedDecal() )
/// </summary>
public  void GuiDecalEditorCtrl_deleteSelectedDecal(string guidecaleditorctrl){


m_ts.fn_GuiDecalEditorCtrl_deleteSelectedDecal(guidecaleditorctrl);
}
/// <summary>
/// editDecalDetails( S32 )() )
/// </summary>
public  void GuiDecalEditorCtrl_editDecalDetails(string guidecaleditorctrl, uint id, Point3F pos, Point3F tan, float size){


m_ts.fn_GuiDecalEditorCtrl_editDecalDetails(guidecaleditorctrl, id, pos.AsString(), tan.AsString(), size);
}
/// <summary>
/// getDecalCount() )
/// </summary>
public  int GuiDecalEditorCtrl_getDecalCount(string guidecaleditorctrl){


return m_ts.fn_GuiDecalEditorCtrl_getDecalCount(guidecaleditorctrl);
}
/// <summary>
/// getDecalLookupName( S32 )() )
/// </summary>
public  string GuiDecalEditorCtrl_getDecalLookupName(string guidecaleditorctrl, uint id){


return m_ts.fn_GuiDecalEditorCtrl_getDecalLookupName(guidecaleditorctrl, id);
}
/// <summary>
/// getDecalTransform() )
/// </summary>
public  string GuiDecalEditorCtrl_getDecalTransform(string guidecaleditorctrl, uint id){


return m_ts.fn_GuiDecalEditorCtrl_getDecalTransform(guidecaleditorctrl, id);
}
/// <summary>
/// getMode() )
/// </summary>
public  string GuiDecalEditorCtrl_getMode(string guidecaleditorctrl){


return m_ts.fn_GuiDecalEditorCtrl_getMode(guidecaleditorctrl);
}
/// <summary>
///  )
/// </summary>
public  int GuiDecalEditorCtrl_getSelectionCount(string guidecaleditorctrl){


return m_ts.fn_GuiDecalEditorCtrl_getSelectionCount(guidecaleditorctrl);
}
/// <summary>
///  )
/// </summary>
public  void GuiDecalEditorCtrl_retargetDecalDatablock(string guidecaleditorctrl, string dbFrom, string dbTo){


m_ts.fn_GuiDecalEditorCtrl_retargetDecalDatablock(guidecaleditorctrl, dbFrom, dbTo);
}
/// <summary>
/// selectDecal( S32 )() )
/// </summary>
public  void GuiDecalEditorCtrl_selectDecal(string guidecaleditorctrl, uint id){


m_ts.fn_GuiDecalEditorCtrl_selectDecal(guidecaleditorctrl, id);
}
/// <summary>
/// setMode( String mode )() )
/// </summary>
public  void GuiDecalEditorCtrl_setMode(string guidecaleditorctrl, string newMode){


m_ts.fn_GuiDecalEditorCtrl_setMode(guidecaleditorctrl, newMode);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiDirectoryFileListCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiDirectoryFileListCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Get the currently selected filename.   @return The filename of the currently selected file )
/// </summary>
public  string getSelectedFile(string guidirectoryfilelistctrl){


return m_ts.fnGuiDirectoryFileListCtrl_getSelectedFile(guidirectoryfilelistctrl);
}
/// <summary>
/// Get the list of selected files.   @return A space separated list of selected files )
/// </summary>
public  string getSelectedFiles(string guidirectoryfilelistctrl){


return m_ts.fnGuiDirectoryFileListCtrl_getSelectedFiles(guidirectoryfilelistctrl);
}
/// <summary>
/// Update the file list. )
/// </summary>
public  void reload(string guidirectoryfilelistctrl){


m_ts.fnGuiDirectoryFileListCtrl_reload(guidirectoryfilelistctrl);
}
/// <summary>
/// Set the file filter.   @param filter Tab-delimited list of file name patterns. Only matched files will be displayed. )
/// </summary>
public  void setFilter(string guidirectoryfilelistctrl, string filter){


m_ts.fnGuiDirectoryFileListCtrl_setFilter(guidirectoryfilelistctrl, filter);
}
/// <summary>
/// Set the search path and file filter.   @param path   Path in game directory from which to list files.   @param filter Tab-delimited list of file name patterns. Only matched files will be displayed. )
/// </summary>
public  bool setPath(string guidirectoryfilelistctrl, string path, string filter){


return m_ts.fnGuiDirectoryFileListCtrl_setPath(guidirectoryfilelistctrl, path, filter);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiDragAndDropControlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiDragAndDropControlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Start the drag operation.   @param x X coordinate for the mouse pointer offset which the drag control should position itself.   @param y Y coordinate for the mouse pointer offset which the drag control should position itself.)
/// </summary>
public  void startDragging(string guidraganddropcontrol, int x = 0, int y = 0){


m_ts.fnGuiDragAndDropControl_startDragging(guidraganddropcontrol, x, y);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiDynamicCtrlArrayControlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiDynamicCtrlArrayControlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Recalculates the position and size of this control and all its children. )
/// </summary>
public  void refresh(string guidynamicctrlarraycontrol){


m_ts.fnGuiDynamicCtrlArrayControl_refresh(guidynamicctrlarraycontrol);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiEditCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiEditCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// (GuiControl ctrl))
/// </summary>
public  void GuiEditCtrl_addNewCtrl(string guieditctrl, string ctrl){


m_ts.fn_GuiEditCtrl_addNewCtrl(guieditctrl, ctrl);
}
/// <summary>
/// selects a control.)
/// </summary>
public  void GuiEditCtrl_addSelection(string guieditctrl, int id){


m_ts.fn_GuiEditCtrl_addSelection(guieditctrl, id);
}
/// <summary>
/// )
/// </summary>
public  void GuiEditCtrl_bringToFront(string guieditctrl){


m_ts.fn_GuiEditCtrl_bringToFront(guieditctrl);
}
/// <summary>
/// ( [ int axis ] ) - Clear all currently set guide lines. )
/// </summary>
public  void GuiEditCtrl_clearGuides(string guieditctrl, int axis = -1){


m_ts.fn_GuiEditCtrl_clearGuides(guieditctrl, axis);
}
/// <summary>
/// Clear selected controls list.)
/// </summary>
public  void GuiEditCtrl_clearSelection(string guieditctrl){


m_ts.fn_GuiEditCtrl_clearSelection(guieditctrl);
}
/// <summary>
/// () - Delete the selected controls.)
/// </summary>
public  void GuiEditCtrl_deleteSelection(string guieditctrl){


m_ts.fn_GuiEditCtrl_deleteSelection(guieditctrl);
}
/// <summary>
/// ( bool width=true, bool height=true ) - Fit selected controls into their parents. )
/// </summary>
public  void GuiEditCtrl_fitIntoParents(string guieditctrl, bool width = true, bool height = true){


m_ts.fn_GuiEditCtrl_fitIntoParents(guieditctrl, width, height);
}
/// <summary>
/// () - Return the toplevel control edited inside the GUI editor. )
/// </summary>
public  int GuiEditCtrl_getContentControl(string guieditctrl){


return m_ts.fn_GuiEditCtrl_getContentControl(guieditctrl);
}
/// <summary>
/// Returns the set to which new controls will be added)
/// </summary>
public  int GuiEditCtrl_getCurrentAddSet(string guieditctrl){


return m_ts.fn_GuiEditCtrl_getCurrentAddSet(guieditctrl);
}
/// <summary>
/// () - Return the current mouse mode. )
/// </summary>
public  string GuiEditCtrl_getMouseMode(string guieditctrl){


return m_ts.fn_GuiEditCtrl_getMouseMode(guieditctrl);
}
/// <summary>
/// () - Return the number of controls currently selected. )
/// </summary>
public  int GuiEditCtrl_getNumSelected(string guieditctrl){


return m_ts.fn_GuiEditCtrl_getNumSelected(guieditctrl);
}
/// <summary>
/// () - Returns global bounds of current selection as vector 'x y width height'. )
/// </summary>
public  string GuiEditCtrl_getSelectionGlobalBounds(string guieditctrl){


return m_ts.fn_GuiEditCtrl_getSelectionGlobalBounds(guieditctrl);
}
/// <summary>
/// (int mode) )
/// </summary>
public  void GuiEditCtrl_justify(string guieditctrl, uint mode){


m_ts.fn_GuiEditCtrl_justify(guieditctrl, mode);
}
/// <summary>
/// ( string fileName=null ) - Load selection from file or clipboard.)
/// </summary>
public  void GuiEditCtrl_loadSelection(string guieditctrl, string filename = null ){
if (filename== null) {filename = null;}


m_ts.fn_GuiEditCtrl_loadSelection(guieditctrl, filename);
}
/// <summary>
/// Move all controls in the selection by (dx,dy) pixels.)
/// </summary>
public  void GuiEditCtrl_moveSelection(string guieditctrl, Point2I pos){


m_ts.fn_GuiEditCtrl_moveSelection(guieditctrl, pos.AsString());
}
/// <summary>
/// )
/// </summary>
public  void GuiEditCtrl_pushToBack(string guieditctrl){


m_ts.fn_GuiEditCtrl_pushToBack(guieditctrl);
}
/// <summary>
/// ( GuiControl ctrl [, int axis ] ) - Read the guides from the given control. )
/// </summary>
public  void GuiEditCtrl_readGuides(string guieditctrl, string ctrl, int axis = -1){


m_ts.fn_GuiEditCtrl_readGuides(guieditctrl, ctrl, axis);
}
/// <summary>
/// deselects a control.)
/// </summary>
public  void GuiEditCtrl_removeSelection(string guieditctrl, int id){


m_ts.fn_GuiEditCtrl_removeSelection(guieditctrl, id);
}
/// <summary>
/// ( string fileName=null ) - Save selection to file or clipboard.)
/// </summary>
public  void GuiEditCtrl_saveSelection(string guieditctrl, string filename = null ){
if (filename== null) {filename = null;}


m_ts.fn_GuiEditCtrl_saveSelection(guieditctrl, filename);
}
/// <summary>
/// (GuiControl ctrl))
/// </summary>
public  void GuiEditCtrl_select(string guieditctrl, string ctrl){


m_ts.fn_GuiEditCtrl_select(guieditctrl, ctrl);
}
/// <summary>
/// ())
/// </summary>
public  void GuiEditCtrl_selectAll(string guieditctrl){


m_ts.fn_GuiEditCtrl_selectAll(guieditctrl);
}
/// <summary>
/// ( bool addToSelection=false ) - Select children of currently selected controls. )
/// </summary>
public  void GuiEditCtrl_selectChildren(string guieditctrl, bool addToSelection = false){


m_ts.fn_GuiEditCtrl_selectChildren(guieditctrl, addToSelection);
}
/// <summary>
/// ( bool addToSelection=false ) - Select parents of currently selected controls. )
/// </summary>
public  void GuiEditCtrl_selectParents(string guieditctrl, bool addToSelection = false){


m_ts.fn_GuiEditCtrl_selectParents(guieditctrl, addToSelection);
}
/// <summary>
/// ( GuiControl ctrl ) - Set the toplevel control to edit in the GUI editor. )
/// </summary>
public  void GuiEditCtrl_setContentControl(string guieditctrl, string ctrl){


m_ts.fn_GuiEditCtrl_setContentControl(guieditctrl, ctrl);
}
/// <summary>
/// (GuiControl ctrl))
/// </summary>
public  void GuiEditCtrl_setCurrentAddSet(string guieditctrl, string addSet){


m_ts.fn_GuiEditCtrl_setCurrentAddSet(guieditctrl, addSet);
}
/// <summary>
/// GuiEditCtrl.setSnapToGrid(gridsize))
/// </summary>
public  void GuiEditCtrl_setSnapToGrid(string guieditctrl, uint gridsize){


m_ts.fn_GuiEditCtrl_setSnapToGrid(guieditctrl, gridsize);
}
/// <summary>
/// Toggle activation.)
/// </summary>
public  void GuiEditCtrl_toggle(string guieditctrl){


m_ts.fn_GuiEditCtrl_toggle(guieditctrl);
}
/// <summary>
/// ( GuiControl ctrl [, int axis ] ) - Write the guides to the given control. )
/// </summary>
public  void GuiEditCtrl_writeGuides(string guieditctrl, string ctrl, int axis = -1){


m_ts.fn_GuiEditCtrl_writeGuides(guieditctrl, ctrl, axis);
}
/// <summary>
/// Gets the set of GUI controls currently selected in the editor. )
/// </summary>
public  string getSelection(string guieditctrl){


return m_ts.fnGuiEditCtrl_getSelection(guieditctrl);
}
/// <summary>
/// Gets the GUI controls(s) that are currently in the trash.)
/// </summary>
public  string getTrash(string guieditctrl){


return m_ts.fnGuiEditCtrl_getTrash(guieditctrl);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiFileTreeCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiFileTreeCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// getSelectedPath() - returns the currently selected path in the tree)
/// </summary>
public  string GuiFileTreeCtrl_getSelectedPath(string guifiletreectrl){


return m_ts.fn_GuiFileTreeCtrl_getSelectedPath(guifiletreectrl);
}
/// <summary>
/// () - Reread the directory tree hierarchy. )
/// </summary>
public  void GuiFileTreeCtrl_reload(string guifiletreectrl){


m_ts.fn_GuiFileTreeCtrl_reload(guifiletreectrl);
}
/// <summary>
/// setSelectedPath(path) - expands the tree to the specified path)
/// </summary>
public  bool GuiFileTreeCtrl_setSelectedPath(string guifiletreectrl, string path){


return m_ts.fn_GuiFileTreeCtrl_setSelectedPath(guifiletreectrl, path);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiFilterCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiFilterCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Return a tuple containing all the values in the filter.			  @internal)
/// </summary>
public  string GuiFilterCtrl_getValue(string guifilterctrl){


return m_ts.fn_GuiFilterCtrl_getValue(guifilterctrl);
}
/// <summary>
/// Reset the filtering.			  @internal)
/// </summary>
public  void GuiFilterCtrl_identity(string guifilterctrl){


m_ts.fn_GuiFilterCtrl_identity(guifilterctrl);
}
/// <summary>
/// ( GuiFilterCtrl, setValue, void, 3, 20, (f1, f2, ...)              Reset the filter to use the specified points, spread equidistantly across the domain.			  @internal)
/// </summary>
public  void setValue(string guifilterctrl, string a2= "", string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){


m_ts.fnGuiFilterCtrl_setValue(guifilterctrl, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiFormCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiFormCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Get the ID of this form's menu.   @return The ID of the form menu )
/// </summary>
public  int getMenuID(string guiformctrl){


return m_ts.fnGuiFormCtrl_getMenuID(guiformctrl);
}
/// <summary>
/// Sets the title of the form.   @param caption Form caption )
/// </summary>
public  void setCaption(string guiformctrl, string caption){


m_ts.fnGuiFormCtrl_setCaption(guiformctrl, caption);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiFrameSetCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiFrameSetCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Add a new column. )
/// </summary>
public  void addColumn(string guiframesetctrl){


m_ts.fnGuiFrameSetCtrl_addColumn(guiframesetctrl);
}
/// <summary>
/// Add a new row. )
/// </summary>
public  void addRow(string guiframesetctrl){


m_ts.fnGuiFrameSetCtrl_addRow(guiframesetctrl);
}
/// <summary>
/// dynamic ),   Override the i>borderEnable/i> setting for this frame.   @param index  Index of the frame to modify   @param state  New borderEnable state: \"on\", \"off\" or \"dynamic\" )
/// </summary>
public  void frameBorder(string guiframesetctrl, int index, string state = "dynamic"){


m_ts.fnGuiFrameSetCtrl_frameBorder(guiframesetctrl, index, state);
}
/// <summary>
/// Set the minimum width and height for the frame. It will not be possible    for the user to resize the frame smaller than this.   @param index  Index of the frame to modify   @param width  Minimum width in pixels   @param height Minimum height in pixels )
/// </summary>
public  void frameMinExtent(string guiframesetctrl, int index, int width, int height){


m_ts.fnGuiFrameSetCtrl_frameMinExtent(guiframesetctrl, index, width, height);
}
/// <summary>
/// dynamic ),   Override the i>borderMovable/i> setting for this frame.   @param index  Index of the frame to modify   @param state  New borderEnable state: \"on\", \"off\" or \"dynamic\" )
/// </summary>
public  void frameMovable(string guiframesetctrl, int index, string state = "dynamic"){


m_ts.fnGuiFrameSetCtrl_frameMovable(guiframesetctrl, index, state);
}
/// <summary>
/// Set the padding for this frame. Padding introduces blank space on the inside    edge of the frame.   @param index     Index of the frame to modify   @param padding   Frame top, bottom, left, and right padding )
/// </summary>
public  void framePadding(string guiframesetctrl, int index, RectSpacingI padding){


m_ts.fnGuiFrameSetCtrl_framePadding(guiframesetctrl, index, padding.AsString());
}
/// <summary>
/// Get the number of columns.   @return The number of columns )
/// </summary>
public  int getColumnCount(string guiframesetctrl){


return m_ts.fnGuiFrameSetCtrl_getColumnCount(guiframesetctrl);
}
/// <summary>
/// Get the horizontal offset of a column.   @param index Index of the column to query   @return Column offset in pixels )
/// </summary>
public  int getColumnOffset(string guiframesetctrl, int index){


return m_ts.fnGuiFrameSetCtrl_getColumnOffset(guiframesetctrl, index);
}
/// <summary>
/// Get the padding for this frame.   @param index     Index of the frame to query )
/// </summary>
public  RectSpacingI getFramePadding(string guiframesetctrl, int index){


return new RectSpacingI ( m_ts.fnGuiFrameSetCtrl_getFramePadding(guiframesetctrl, index));
}
/// <summary>
/// Get the number of rows.   @return The number of rows )
/// </summary>
public  int getRowCount(string guiframesetctrl){


return m_ts.fnGuiFrameSetCtrl_getRowCount(guiframesetctrl);
}
/// <summary>
/// Get the vertical offset of a row.   @param index Index of the row to query   @return Row offset in pixels )
/// </summary>
public  int getRowOffset(string guiframesetctrl, int index){


return m_ts.fnGuiFrameSetCtrl_getRowOffset(guiframesetctrl, index);
}
/// <summary>
/// Remove the last (rightmost) column. )
/// </summary>
public  void removeColumn(string guiframesetctrl){


m_ts.fnGuiFrameSetCtrl_removeColumn(guiframesetctrl);
}
/// <summary>
/// Remove the last (bottom) row. )
/// </summary>
public  void removeRow(string guiframesetctrl){


m_ts.fnGuiFrameSetCtrl_removeRow(guiframesetctrl);
}
/// <summary>
/// Set the horizontal offset of a column.   Note that column offsets must always be in increasing order, and therefore    this offset must be between the offsets of the colunns either side.   @param index  Index of the column to modify   @param offset New column offset )
/// </summary>
public  void setColumnOffset(string guiframesetctrl, int index, int offset){


m_ts.fnGuiFrameSetCtrl_setColumnOffset(guiframesetctrl, index, offset);
}
/// <summary>
/// Set the vertical offset of a row.   Note that row offsets must always be in increasing order, and therefore    this offset must be between the offsets of the rows either side.   @param index  Index of the row to modify   @param offset New row offset )
/// </summary>
public  void setRowOffset(string guiframesetctrl, int index, int offset){


m_ts.fnGuiFrameSetCtrl_setRowOffset(guiframesetctrl, index, offset);
}
/// <summary>
/// Recalculates child control sizes. )
/// </summary>
public  void updateSizes(string guiframesetctrl){


m_ts.fnGuiFrameSetCtrl_updateSizes(guiframesetctrl);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiGameListMenuCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiGameListMenuCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Activates the current row. The script callback of  the current row will be called (if it has one). )
/// </summary>
public  void activateRow(string guigamelistmenuctrl){


m_ts.fnGuiGameListMenuCtrl_activateRow(guigamelistmenuctrl);
}
/// <summary>
/// Add a row to the list control.   @param label The text to display on the row as a label.   @param callback Name of a script function to use as a callback when this row is activated.   @param icon [optional] Index of the icon to use as a marker.   @param yPad [optional] An extra amount of height padding before the row. Does nothing on the first row.   @param useHighlightIcon [optional] Does this row use the highlight icon?.   @param enabled [optional] If this row is initially enabled. )
/// </summary>
public  void addRow(string guigamelistmenuctrl, string label, string callback, int icon = -1, int yPad = 0, bool useHighlightIcon = true, bool enabled = true){


m_ts.fnGuiGameListMenuCtrl_addRow(guigamelistmenuctrl, label, callback, icon, yPad, useHighlightIcon, enabled);
}
/// <summary>
/// Gets the number of rows on the control.   @return (int) The number of rows on the control. )
/// </summary>
public  int getRowCount(string guigamelistmenuctrl){


return m_ts.fnGuiGameListMenuCtrl_getRowCount(guigamelistmenuctrl);
}
/// <summary>
/// Gets the label displayed on the specified row.   @param row Index of the row to get the label of.   @return The label for the row. )
/// </summary>
public  string getRowLabel(string guigamelistmenuctrl, int row){


return m_ts.fnGuiGameListMenuCtrl_getRowLabel(guigamelistmenuctrl, row);
}
/// <summary>
/// Gets the index of the currently selected row.   @return Index of the selected row. )
/// </summary>
public  int getSelectedRow(string guigamelistmenuctrl){


return m_ts.fnGuiGameListMenuCtrl_getSelectedRow(guigamelistmenuctrl);
}
/// <summary>
/// Determines if the specified row is enabled or disabled.   @param row The row to set the enabled status of.   @return True if the specified row is enabled. False if the row is not enabled or the given index was not valid. )
/// </summary>
public  bool isRowEnabled(string guigamelistmenuctrl, int row){


return m_ts.fnGuiGameListMenuCtrl_isRowEnabled(guigamelistmenuctrl, row);
}
/// <summary>
/// Sets a row's enabled status according to the given parameters.   @param row The index to check for validity.   @param enabled Indicate true to enable the row or false to disable it. )
/// </summary>
public  void setRowEnabled(string guigamelistmenuctrl, int row, bool enabled){


m_ts.fnGuiGameListMenuCtrl_setRowEnabled(guigamelistmenuctrl, row, enabled);
}
/// <summary>
/// Sets the label on the given row.   @param row Index of the row to set the label on.   @param label Text to set as the label of the row. )
/// </summary>
public  void setRowLabel(string guigamelistmenuctrl, int row, string label){


m_ts.fnGuiGameListMenuCtrl_setRowLabel(guigamelistmenuctrl, row, label);
}
/// <summary>
/// Sets the selected row. Only rows that are enabled can be selected.   @param row Index of the row to set as selected. )
/// </summary>
public  void setSelected(string guigamelistmenuctrl, int row){


m_ts.fnGuiGameListMenuCtrl_setSelected(guigamelistmenuctrl, row);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiGameListOptionsCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiGameListOptionsCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Add a row to the list control.   @param label The text to display on the row as a label.   @param options A tab separated list of options.   @param wrapOptions Specify true to allow options to wrap at each end or false to prevent wrapping.   @param callback Name of a script function to use as a callback when this row is activated.   @param icon [optional] Index of the icon to use as a marker.   @param yPad [optional] An extra amount of height padding before the row. Does nothing on the first row.   @param enabled [optional] If this row is initially enabled. )
/// </summary>
public  void addRow(string guigamelistoptionsctrl, string label, string options, bool wrapOptions, string callback, int icon = -1, int yPad = 0, bool enabled = true){


m_ts.fnGuiGameListOptionsCtrl_addRow(guigamelistoptionsctrl, label, options, wrapOptions, callback, icon, yPad, enabled);
}
/// <summary>
/// Gets the text for the currently selected option of the given row.   @param row Index of the row to get the option from.   @return A string representing the text currently displayed as the selected option on the given row. If there is no such displayed text then the empty string is returned. )
/// </summary>
public  string getCurrentOption(string guigamelistoptionsctrl, int row){


return m_ts.fnGuiGameListOptionsCtrl_getCurrentOption(guigamelistoptionsctrl, row);
}
/// <summary>
/// Set the row's current option to the one specified   @param row Index of the row to set an option on.   @param option The option to be made active.   @return True if the row contained the option and was set, false otherwise. )
/// </summary>
public  bool selectOption(string guigamelistoptionsctrl, int row, string option){


return m_ts.fnGuiGameListOptionsCtrl_selectOption(guigamelistoptionsctrl, row, option);
}
/// <summary>
/// Sets the list of options on the given row.   @param row Index of the row to set options on.   @param optionsList A tab separated list of options for the control. )
/// </summary>
public  void setOptions(string guigamelistoptionsctrl, int row, string optionsList){


m_ts.fnGuiGameListOptionsCtrl_setOptions(guigamelistoptionsctrl, row, optionsList);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiGradientCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiGradientCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Get color value)
/// </summary>
public  ColorF GuiGradientCtrl_getColor(string guigradientctrl, int idx){


return new ColorF ( m_ts.fn_GuiGradientCtrl_getColor(guigradientctrl, idx));
}
/// <summary>
/// Get color count)
/// </summary>
public  int GuiGradientCtrl_getColorCount(string guigradientctrl){


return m_ts.fn_GuiGradientCtrl_getColorCount(guigradientctrl);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiGraphCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiGraphCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Sets up the given plotting curve to automatically plot the value of the @a variable with a    frequency of @a updateFrequency.   @param plotId Index of the plotting curve.  Must be 0=plotId6.   @param variable Name of the global variable.   @param updateFrequency Frequency with which to add new data points to the plotting curve (in milliseconds).   @tsexample   // Plot FPS counter at 1 second intervals.   %graph.addAutoPlot( 0, \"fps::real\", 1000 );   @endtsexample )
/// </summary>
public  void addAutoPlot(string guigraphctrl, int plotId, string variable, int updateFrequency){


m_ts.fnGuiGraphCtrl_addAutoPlot(guigraphctrl, plotId, variable, updateFrequency);
}
/// <summary>
/// Add a data point to the plot's curve.   @param plotId Index of the plotting curve to which to add the data point.  Must be 0=plotId6.   @param value Value of the data point to add to the curve.   @note Data values are added to the @b left end of the plotting curve.   @note A maximum number of 200 data points can be added to any single plotting curve at any one time.  If       this limit is exceeded, data points on the right end of the curve are culled. )
/// </summary>
public  void addDatum(string guigraphctrl, int plotId, float value){


m_ts.fnGuiGraphCtrl_addDatum(guigraphctrl, plotId, value);
}
/// <summary>
/// Get a data point on the given plotting curve.   @param plotId Index of the plotting curve from which to fetch the data point.  Must be 0=plotId6.   @param index Index of the data point on the curve.   @return The value of the data point or -1 if @a plotId or @a index are out of range. )
/// </summary>
public  float getDatum(string guigraphctrl, int plotId, int index){


return m_ts.fnGuiGraphCtrl_getDatum(guigraphctrl, plotId, index);
}
/// <summary>
/// Stop automatic variable plotting for the given curve.   @param plotId Index of the plotting curve.  Must be 0=plotId6. )
/// </summary>
public  void removeAutoPlot(string guigraphctrl, int plotId){


m_ts.fnGuiGraphCtrl_removeAutoPlot(guigraphctrl, plotId);
}
/// <summary>
/// Change the charting type of the given plotting curve.   @param plotId Index of the plotting curve.  Must be 0=plotId6.   @param graphType Charting type to use for the curve.   @note Instead of calling this method, you can directly assign to #plotType. )
/// </summary>
public  void setGraphType(string guigraphctrl, int plotId, TypeGuiGraphType graphType){


m_ts.fnGuiGraphCtrl_setGraphType(guigraphctrl, plotId, (int)graphType );
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiIconButtonCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiIconButtonCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Set the bitmap to use for the button portion of this control.   @param buttonFilename Filename for the image   @tsexample   // Define the button filename   %buttonFilename = \"pearlButton\";   // Inform the GuiIconButtonCtrl control to update its main button graphic to the defined bitmap   %thisGuiIconButtonCtrl.setBitmap(%buttonFilename);   @endtsexample   @see GuiControl   @see GuiButtonCtrl)
/// </summary>
public  void setBitmap(string guiiconbuttonctrl, string buttonFilename){


m_ts.fnGuiIconButtonCtrl_setBitmap(guiiconbuttonctrl, buttonFilename);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiIdleCamFadeBitmapCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiIdleCamFadeBitmapCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ()			  @internal)
/// </summary>
public  void GuiIdleCamFadeBitmapCtrl_fadeIn(string guiidlecamfadebitmapctrl){


m_ts.fn_GuiIdleCamFadeBitmapCtrl_fadeIn(guiidlecamfadebitmapctrl);
}
/// <summary>
/// ()			  @internal)
/// </summary>
public  void GuiIdleCamFadeBitmapCtrl_fadeOut(string guiidlecamfadebitmapctrl){


m_ts.fn_GuiIdleCamFadeBitmapCtrl_fadeOut(guiidlecamfadebitmapctrl);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiImageListObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiImageListObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Clears the imagelist   @tsexample   // Inform the GuiImageList control to clear itself.   %isFinished = %thisGuiImageList.clear();   @endtsexample   @return Returns true when finished.   @see SimObject)
/// </summary>
public  bool clear(string guiimagelist){


return m_ts.fnGuiImageList_clear(guiimagelist);
}
/// <summary>
/// @brief Gets the number of images in the list.   @tsexample   // Request the number of images from the GuiImageList control.   %imageCount = %thisGuiImageList.count();   @endtsexample   @return Number of images in the control.   @see SimObject)
/// </summary>
public  int count(string guiimagelist){


return m_ts.fnGuiImageList_count(guiimagelist);
}
/// <summary>
/// @brief Get a path to the texture at the specified index.   @param index Index of the image in the list.   @tsexample   // Define the image index/n   %index = \"5\";   // Request the image path location from the control.   %imagePath = %thisGuiImageList.getImage(%index);   @endtsexample   @return File path to the image map for the specified index.   @see SimObject)
/// </summary>
public  string getImage(string guiimagelist, int index){


return m_ts.fnGuiImageList_getImage(guiimagelist, index);
}
/// <summary>
/// @brief Retrieves the imageindex of a specified texture in the list.   @param imagePath Imagemap including filepath of image to search for   @tsexample   // Define the imagemap to search for   %imagePath = \"./game/client/data/images/thisImage\";   // Request the index entry for the defined imagemap   %imageIndex = %thisGuiImageList.getIndex(%imagePath);   @endtsexample   @return Index of the imagemap matching the defined image path.   @see SimObject)
/// </summary>
public  int getIndex(string guiimagelist, string imagePath){


return m_ts.fnGuiImageList_getIndex(guiimagelist, imagePath);
}
/// <summary>
/// @brief Insert an image into imagelist- returns the image index or -1 for failure.   @param imagePath Imagemap, with path, to add to the list.   @tsexample   // Define the imagemap to add to the list   %imagePath = \"./game/client/data/images/thisImage\";   // Request the GuiImageList control to add the defined image to its list.   %imageIndex = %thisGuiImageList.insert(%imagePath);   @endtsexample   @return The index of the newly inserted imagemap, or -1 if the insertion failed.   @see SimObject)
/// </summary>
public  int insert(string guiimagelist, string imagePath){


return m_ts.fnGuiImageList_insert(guiimagelist, imagePath);
}
/// <summary>
/// @brief Removes an image from the list by index.   @param index Image index to remove.   @tsexample   // Define the image index.   %imageIndex = \"4\";   // Inform the GuiImageList control to remove the image at the defined index.   %wasSuccessful = %thisGuiImageList.remove(%imageIndex);   @endtsexample   @return True if the operation was successful, false if it was not.   @see SimObject)
/// </summary>
public  bool remove(string guiimagelist, int index){


return m_ts.fnGuiImageList_remove(guiimagelist, index);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiInspectorObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiInspectorObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( id object, (bool autoSync = true) ) - Add the object to the list of objects being inspected. )
/// </summary>
public  void GuiInspector_addInspect(string guiinspector, string className, bool autoSync = true){


m_ts.fn_GuiInspector_addInspect(guiinspector, className, autoSync);
}
/// <summary>
/// apply() - Force application of inspected object's attributes )
/// </summary>
public  void GuiInspector_apply(string guiinspector){


m_ts.fn_GuiInspector_apply(guiinspector);
}
/// <summary>
/// getInspectObject( int index=0 ) - Returns currently inspected object )
/// </summary>
public  string GuiInspector_getInspectObject(string guiinspector, uint index = 0){


return m_ts.fn_GuiInspector_getInspectObject(guiinspector, index);
}
/// <summary>
/// () - Return the number of objects currently being inspected. )
/// </summary>
public  int GuiInspector_getNumInspectObjects(string guiinspector){


return m_ts.fn_GuiInspector_getNumInspectObjects(guiinspector);
}
/// <summary>
/// Inspect(Object))
/// </summary>
public  void GuiInspector_inspect(string guiinspector, string className){


m_ts.fn_GuiInspector_inspect(guiinspector, className);
}
/// <summary>
/// Reinspect the currently selected object. )
/// </summary>
public  void GuiInspector_refresh(string guiinspector){


m_ts.fn_GuiInspector_refresh(guiinspector);
}
/// <summary>
/// ( id object ) - Remove the object from the list of objects being inspected. )
/// </summary>
public  void GuiInspector_removeInspect(string guiinspector, string obj){


m_ts.fn_GuiInspector_removeInspect(guiinspector, obj);
}
/// <summary>
/// setName(NewObjectName))
/// </summary>
public  void GuiInspector_setName(string guiinspector, string newObjectName){


m_ts.fn_GuiInspector_setName(guiinspector, newObjectName);
}
/// <summary>
/// setObjectField( fieldname, data ) - Set a named fields value on the inspected object if it exists. This triggers all the usual callbacks that would occur if the field had been changed through the gui. )
/// </summary>
public  void GuiInspector_setObjectField(string guiinspector, string fieldname, string data){


m_ts.fn_GuiInspector_setObjectField(guiinspector, fieldname, data);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiInspectorDynamicFieldObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiInspectorDynamicFieldObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// field.renameField(newDynamicFieldName); )
/// </summary>
public  void GuiInspectorDynamicField_renameField(string guiinspectordynamicfield, string newDynamicFieldName){


m_ts.fn_GuiInspectorDynamicField_renameField(guiinspectordynamicfield, newDynamicFieldName);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiInspectorDynamicGroupObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiInspectorDynamicGroupObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// obj.addDynamicField(); )
/// </summary>
public  void GuiInspectorDynamicGroup_addDynamicField(string guiinspectordynamicgroup){


m_ts.fn_GuiInspectorDynamicGroup_addDynamicField(guiinspectordynamicgroup);
}
/// <summary>
/// Refreshes the dynamic fields in the inspector.)
/// </summary>
public  bool GuiInspectorDynamicGroup_inspectGroup(string guiinspectordynamicgroup){


return m_ts.fn_GuiInspectorDynamicGroup_inspectGroup(guiinspectordynamicgroup);
}
/// <summary>
///  )
/// </summary>
public  void GuiInspectorDynamicGroup_removeDynamicField(string guiinspectordynamicgroup){


m_ts.fn_GuiInspectorDynamicGroup_removeDynamicField(guiinspectordynamicgroup);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiInspectorFieldObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiInspectorFieldObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// , true), ( string newValue, bool callbacks=true ) - Set the field's value. Suppress callbacks for undo if callbacks=false. )
/// </summary>
public  void GuiInspectorField_apply(string guiinspectorfield, string newValue = "", bool callbacks = true){


m_ts.fn_GuiInspectorField_apply(guiinspectorfield, newValue, callbacks);
}
/// <summary>
/// () - Set field value without recording undo (same as 'apply( value, false )'). )
/// </summary>
public  void GuiInspectorField_applyWithoutUndo(string guiinspectorfield, string data){


m_ts.fn_GuiInspectorField_applyWithoutUndo(guiinspectorfield, data);
}
/// <summary>
/// () - Return the value currently displayed on the field. )
/// </summary>
public  string GuiInspectorField_getData(string guiinspectorfield){


return m_ts.fn_GuiInspectorField_getData(guiinspectorfield);
}
/// <summary>
/// () - Return the name of the field edited by this inspector field. )
/// </summary>
public  string GuiInspectorField_getInspectedFieldName(string guiinspectorfield){


return m_ts.fn_GuiInspectorField_getInspectedFieldName(guiinspectorfield);
}
/// <summary>
/// () - Return the type of the field edited by this inspector field. )
/// </summary>
public  string GuiInspectorField_getInspectedFieldType(string guiinspectorfield){


return m_ts.fn_GuiInspectorField_getInspectedFieldType(guiinspectorfield);
}
/// <summary>
/// () - Return the GuiInspector to which this field belongs. )
/// </summary>
public  int GuiInspectorField_getInspector(string guiinspectorfield){


return m_ts.fn_GuiInspectorField_getInspector(guiinspectorfield);
}
/// <summary>
/// () - Reset to default value. )
/// </summary>
public  void GuiInspectorField_reset(string guiinspectorfield){


m_ts.fn_GuiInspectorField_reset(guiinspectorfield);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiInspectorTypeBitMask32Object
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiInspectorTypeBitMask32Object(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( GuiInspectorTypeBitMask32, applyBit, void, 2,2, apply(); )
/// </summary>
public  void applyBit(string guiinspectortypebitmask32= ""){


m_ts.fnGuiInspectorTypeBitMask32_applyBit(guiinspectortypebitmask32);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiInspectorTypeFileNameObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiInspectorTypeFileNameObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( GuiInspectorTypeFileName, apply, void, 3,3, apply(newValue); )
/// </summary>
public  void apply(string guiinspectortypefilename, string a2= ""){


m_ts.fnGuiInspectorTypeFileName_apply(guiinspectortypefilename, a2);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiListBoxCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiListBoxCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Checks if there is an item with the exact text of what is passed in, and if so   the item is removed from the list and adds that item's data to the filtered list.   @param itemName Name of the item that we wish to add to the filtered item list of the GuiListBoxCtrl.   @tsexample   // Define the itemName that we wish to add to the filtered item list.   %itemName = \"This Item Name\";   // Add the item name to the filtered item list.   %thisGuiListBoxCtrl.addFilteredItem(%filteredItemName);   @endtsexample   @see GuiControl)
/// </summary>
public  void addFilteredItem(string guilistboxctrl, string newItem){


m_ts.fnGuiListBoxCtrl_addFilteredItem(guilistboxctrl, newItem);
}
/// <summary>
///  ),   @brief Adds an item to the end of the list with an optional color.   @param newItem New item to add to the list.   @param color Optional color parameter to add to the new item.   @tsexample   // Define the item to add to the list.   %newItem = \"Gideon's Blue Coat\";   // Define the optional color for the new list item.   %color = \"0.0 0.0 1.0\";   // Inform the GuiListBoxCtrl object to add the item to the end of the list with the defined color.   %thisGuiListBoxCtrl.addItem(%newItem,%color);   @endtsexample   @return If not void, return value and description   @see GuiControl   @hide)
/// </summary>
public  int addItem(string guilistboxctrl, string newItem, string color = ""){


return m_ts.fnGuiListBoxCtrl_addItem(guilistboxctrl, newItem, color);
}
/// <summary>
/// @brief Removes any custom coloring from an item at the defined index id in the list.   @param index Index id for the item to clear any custom color from.   @tsexample   // Define the index id   %index = \"4\";   // Request the GuiListBoxCtrl object to remove any custom coloring from the defined index entry   %thisGuiListBoxCtrl.clearItemColor(%index);   @endtsexample   @see GuiControl)
/// </summary>
public  void clearItemColor(string guilistboxctrl, int index){


m_ts.fnGuiListBoxCtrl_clearItemColor(guilistboxctrl, index);
}
/// <summary>
/// @brief Clears all the items in the listbox.   @tsexample   // Inform the GuiListBoxCtrl object to clear all items from its list.   %thisGuiListBoxCtrl.clearItems();   @endtsexample   @see GuiControl)
/// </summary>
public  void clearItems(string guilistboxctrl){


m_ts.fnGuiListBoxCtrl_clearItems(guilistboxctrl);
}
/// <summary>
/// @brief Sets all currently selected items to unselected.   Detailed description   @tsexample   // Inform the GuiListBoxCtrl object to set all of its items to unselected./n   %thisGuiListBoxCtrl.clearSelection();   @endtsexample   @see GuiControl)
/// </summary>
public  void clearSelection(string guilistboxctrl){


m_ts.fnGuiListBoxCtrl_clearSelection(guilistboxctrl);
}
/// <summary>
/// @brief Removes the list entry at the requested index id from the control and clears the memory associated with it.   @param itemIndex Index id location to remove the item from.   @tsexample   // Define the index id we want to remove from the list   %itemIndex = \"8\";   // Inform the GuiListBoxCtrl object to remove the item at the defined index id.   %thisGuiListBoxCtrl.deleteItem(%itemIndex);   @endtsexample   @see References)
/// </summary>
public  void deleteItem(string guilistboxctrl, int itemIndex){


m_ts.fnGuiListBoxCtrl_deleteItem(guilistboxctrl, itemIndex);
}
/// <summary>
/// @brief Informs the GuiListBoxCtrl object to mirror the contents of the GuiListBoxCtrl stored in the mirrorSet field.   @tsexample   \\ Inform the object to mirror the object located at %thisGuiListBox.mirrorSet   %thisGuiListBox.doMirror();   @endtsexample   @see GuiCore)
/// </summary>
public  void doMirror(string guilistboxctrl){


m_ts.fnGuiListBoxCtrl_doMirror(guilistboxctrl);
}
/// <summary>
/// @brief Returns index of item with matching text or -1 if none found.   @param findText Text in the list to find.   @param isCaseSensitive If true, the search will be case sensitive.   @tsexample   // Define the text we wish to find in the list.   %findText = \"Hickory Smoked Gideon\"/n/n   // Define if this is a case sensitive search or not.   %isCaseSensitive = \"false\";   // Ask the GuiListBoxCtrl object what item id in the list matches the requested text.   %matchingId = %thisGuiListBoxCtrl.findItemText(%findText,%isCaseSensitive);   @endtsexample   @return Index id of item with matching text or -1 if none found.   @see GuiControl)
/// </summary>
public  int findItemText(string guilistboxctrl, string findText, bool bCaseSensitive = false){


return m_ts.fnGuiListBoxCtrl_findItemText(guilistboxctrl, findText, bCaseSensitive);
}
/// <summary>
/// @brief Returns the number of items in the list.   @tsexample   // Request the number of items in the list of the GuiListBoxCtrl object.   %listItemCount = %thisGuiListBoxCtrl.getItemCount();   @endtsexample   @return The number of items in the list.   @see GuiControl)
/// </summary>
public  int getItemCount(string guilistboxctrl){


return m_ts.fnGuiListBoxCtrl_getItemCount(guilistboxctrl);
}
/// <summary>
/// @brief Returns the object associated with an item. This only makes sense if you are mirroring a simset.   @param index Index id to request the associated item from.   @tsexample   // Define the index id   %index = \"12\";   // Request the item from the GuiListBoxCtrl object   %object = %thisGuiListBoxCtrl.getItemObject(%index);   @endtsexample   @return The object associated with the item in the list.   @see References)
/// </summary>
public  string getItemObject(string guilistboxctrl, int index){


return m_ts.fnGuiListBoxCtrl_getItemObject(guilistboxctrl, index);
}
/// <summary>
/// @brief Returns the text of the item at the specified index.   @param index Index id to return the item text from.   @tsexample   // Define the index id entry to request the text from   %index = \"12\";   // Request the item id text from the GuiListBoxCtrl object.   %text = %thisGuiListBoxCtrl.getItemText(%index);   @endtsexample   @return The text of the requested index id.   @see GuiControl)
/// </summary>
public  string getItemText(string guilistboxctrl, int index){


return m_ts.fnGuiListBoxCtrl_getItemText(guilistboxctrl, index);
}
/// <summary>
/// @brief Request the item index for the item that was last clicked.   @tsexample   // Request the item index for the last clicked item in the list   %lastClickedIndex = %thisGuiListBoxCtrl.getLastClickItem();   @endtsexample   @return Index id for the last clicked item in the list.   @see GuiControl)
/// </summary>
public  int getLastClickItem(string guilistboxctrl){


return m_ts.fnGuiListBoxCtrl_getLastClickItem(guilistboxctrl);
}
/// <summary>
/// @brief Returns the number of items currently selected.   @tsexample   // Request the number of currently selected items   %selectedItemCount = %thisGuiListBoxCtrl.getSelCount();   @endtsexample   @return Number of currently selected items.   @see GuiControl)
/// </summary>
public  int getSelCount(string guilistboxctrl){


return m_ts.fnGuiListBoxCtrl_getSelCount(guilistboxctrl);
}
/// <summary>
/// @brief Returns the selected items index or -1 if none selected. If multiple selections exist it returns the first selected item.    @tsexample   // Request the index id of the currently selected item   %selectedItemId = %thisGuiListBoxCtrl.getSelectedItem();   @endtsexample   @return The selected items index or -1 if none selected.   @see GuiControl)
/// </summary>
public  int getSelectedItem(string guilistboxctrl){


return m_ts.fnGuiListBoxCtrl_getSelectedItem(guilistboxctrl);
}
/// <summary>
/// @brief Returns a space delimited list of the selected items indexes in the list.   @tsexample   // Request a space delimited list of the items in the GuiListBoxCtrl object.   %selectionList = %thisGuiListBoxCtrl.getSelectedItems();   @endtsexample   @return Space delimited list of the selected items indexes in the list   @see GuiControl)
/// </summary>
public  string getSelectedItems(string guilistboxctrl){


return m_ts.fnGuiListBoxCtrl_getSelectedItems(guilistboxctrl);
}
/// <summary>
/// @brief Inserts an item into the list at the specified index and returns the index assigned or -1 on error.   @param text Text item to add.   @param index Index id to insert the list item text at.   @tsexample   // Define the text to insert   %text = \"Secret Agent Gideon\";   // Define the index entry to insert the text at   %index = \"14\";   // In form the GuiListBoxCtrl object to insert the text at the defined index.   %assignedId = %thisGuiListBoxCtrl.insertItem(%text,%index);   @endtsexample   @return If successful will return the index id assigned. If unsuccessful, will return -1.   @see GuiControl)
/// </summary>
public  void insertItem(string guilistboxctrl, string text, int index){


m_ts.fnGuiListBoxCtrl_insertItem(guilistboxctrl, text, index);
}
/// <summary>
/// @brief Removes an item of the entered name from the filtered items list.   @param itemName Name of the item to remove from the filtered list.   @tsexample   // Define the itemName that you wish to remove.   %itemName = \"This Item Name\";   // Remove the itemName from the GuiListBoxCtrl   %thisGuiListBoxCtrl.removeFilteredItem(%itemName);   @endtsexample   @see GuiControl)
/// </summary>
public  void removeFilteredItem(string guilistboxctrl, string itemName){


m_ts.fnGuiListBoxCtrl_removeFilteredItem(guilistboxctrl, itemName);
}
/// <summary>
/// @brief Sets the currently selected item at the specified index.   @param indexId Index Id to set selected.   @tsexample   // Define the index id that we wish to select.   %selectId = \"4\";   // Inform the GuiListBoxCtrl object to set the requested index as selected.   %thisGuiListBoxCtrl.setCurSel(%selectId);   @endtsexample   @see GuiControl)
/// </summary>
public  void setCurSel(string guilistboxctrl, int indexId){


m_ts.fnGuiListBoxCtrl_setCurSel(guilistboxctrl, indexId);
}
/// <summary>
/// @brief Sets the current selection range from index start to stop. If no stop is specified it sets from start index to the end of the list   @param indexStart Index Id to start selection.   @param indexStop Index Id to end selection.   @tsexample   // Set start id   %indexStart = \"3\";   // Set end id   %indexEnd = \"6\";   // Request the GuiListBoxCtrl object to select the defined range.   %thisGuiListBoxCtrl.setCurSelRange(%indexStart,%indexEnd);   @endtsexample   @see GuiControl)
/// </summary>
public  void setCurSelRange(string guilistboxctrl, int indexStart, int indexStop = 999999){


m_ts.fnGuiListBoxCtrl_setCurSelRange(guilistboxctrl, indexStart, indexStop);
}
/// <summary>
/// @brief Sets the color of a single list entry at the specified index id.   @param index Index id to modify the color of in the list.   @param color Color value to set the list entry to.   @tsexample   // Define the index id value   %index = \"5\";   // Define the color value   %color = \"1.0 0.0 0.0\";   // Inform the GuiListBoxCtrl object to change the color of the requested index   %thisGuiListBoxCtrl.setItemColor(%index,%color);   @endtsexample   @see GuiControl)
/// </summary>
public  void setItemColor(string guilistboxctrl, int index, ColorF color){


m_ts.fnGuiListBoxCtrl_setItemColor(guilistboxctrl, index, color.AsString());
}
/// <summary>
/// @brief Sets the items text at the specified index.   @param index Index id to set the item text at.   @param newtext Text to change the list item at index id to.   @tsexample   // Define the index id/n   %index = \"12\";   // Define the text to set the list item to   %newtext = \"Gideon's Fancy Goggles\";   // Inform the GuiListBoxCtrl object to change the text at the requested index   %thisGuiListBoxCtrl.setItemText(%index,%newText);   @endtsexample   @see GuiControl)
/// </summary>
public  void setItemText(string guilistboxctrl, int index, string newtext){


m_ts.fnGuiListBoxCtrl_setItemText(guilistboxctrl, index, newtext);
}
/// <summary>
/// @brief Set the tooltip text to display for the given list item.   @param index Index id to change the tooltip text   @param text Text for the tooltip.   @tsexample   // Define the index id   %index = \"12\";   // Define the tooltip text   %tooltip = \"Gideon's goggles can see through space and time.\"   // Inform the GuiListBoxCtrl object to set the tooltop for the item at the defined index id   %thisGuiListBoxCtrl.setItemToolTip(%index,%tooltip);   @endtsexample   @see GuiControl)
/// </summary>
public  void setItemTooltip(string guilistboxctrl, int index, string text){


m_ts.fnGuiListBoxCtrl_setItemTooltip(guilistboxctrl, index, text);
}
/// <summary>
/// @brief Enable or disable multiple selections for this GuiListBoxCtrl object.   @param allowMultSelections Boolean variable to set the use of multiple selections or not.   @tsexample   // Define the multiple selection use state.   %allowMultSelections = \"true\";   // Set the allow  multiple selection state on the GuiListBoxCtrl object.   %thisGuiListBoxCtrl.setMultipleSelection(%allowMultSelections);   @endtsexample   @see GuiControl)
/// </summary>
public  void setMultipleSelection(string guilistboxctrl, bool allowMultSelections){


m_ts.fnGuiListBoxCtrl_setMultipleSelection(guilistboxctrl, allowMultSelections);
}
/// <summary>
/// @brief Sets the item at the index specified to selected or not.   Detailed description   @param index Item index to set selected or unselected.   @param setSelected Boolean selection state to set the requested item index.   @tsexample   // Define the index   %index = \"5\";   // Define the selection state   %selected = \"true\"   // Inform the GuiListBoxCtrl object of the new selection state for the requested index entry.   %thisGuiListBoxCtrl.setSelected(%index,%selected);   @endtsexample   @see GuiControl)
/// </summary>
public  void setSelected(string guilistboxctrl, int index, bool setSelected = true){


m_ts.fnGuiListBoxCtrl_setSelected(guilistboxctrl, index, setSelected);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiMaterialCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiMaterialCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( string materialName )               Set the material to be displayed in the control. )
/// </summary>
public  bool GuiMaterialCtrl_setMaterial(string guimaterialctrl, string materialName){


return m_ts.fn_GuiMaterialCtrl_setMaterial(guimaterialctrl, materialName);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiMaterialPreviewObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiMaterialPreviewObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Deletes the preview model.)
/// </summary>
public  void deleteModel(string guimaterialpreview){


m_ts.fnGuiMaterialPreview_deleteModel(guimaterialpreview);
}
/// <summary>
/// Resets the viewport to default zoom, pan, rotate and lighting.)
/// </summary>
public  void reset(string guimaterialpreview){


m_ts.fnGuiMaterialPreview_reset(guimaterialpreview);
}
/// <summary>
/// Sets the color of the ambient light in the scene.)
/// </summary>
public  void setAmbientLightColor(string guimaterialpreview, ColorF color){


m_ts.fnGuiMaterialPreview_setAmbientLightColor(guimaterialpreview, color.AsString());
}
/// <summary>
/// Sets the color of the light in the scene.)
/// </summary>
public  void setLightColor(string guimaterialpreview, ColorF color){


m_ts.fnGuiMaterialPreview_setLightColor(guimaterialpreview, color.AsString());
}
/// <summary>
/// Sets the model to be displayed in this control   @param shapeName Name of the model to display.)
/// </summary>
public  void setModel(string guimaterialpreview, string shapeName){


m_ts.fnGuiMaterialPreview_setModel(guimaterialpreview, shapeName);
}
/// <summary>
/// Sets the distance at which the camera orbits the object. Clamped to the    acceptable range defined in the class by min and max orbit distances.   @param distance The distance to set the orbit to (will be clamped).)
/// </summary>
public  void setOrbitDistance(string guimaterialpreview, float distance){


m_ts.fnGuiMaterialPreview_setOrbitDistance(guimaterialpreview, distance);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiMenuBarObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiMenuBarObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Adds a new menu to the menu bar.   @param menuText Text to display for the new menu item.   @param menuId ID for the new menu item.   @tsexample   // Define the menu text   %menuText = \"New Menu\";   // Define the menu ID.   %menuId = \"2\";   // Inform the GuiMenuBar control to add the new menu   %thisGuiMenuBar.addMenu(%menuText,%menuId);   @endtsexample   @see GuiTickCtrl)
/// </summary>
public  void addMenu(string guimenubar, string menuText, int menuId){


m_ts.fnGuiMenuBar_addMenu(guimenubar, menuText, menuId);
}
/// <summary>
/// ,,0,,-1),   @brief Adds a menu item to the specified menu.  The menu argument can be either the text of a menu or its id.   @param menu Menu name or menu Id to add the new item to.   @param menuItemText Text for the new menu item.   @param menuItemId Id for the new menu item.   @param accelerator Accelerator key for the new menu item.   @param checkGroup Check group to include this menu item in.   @tsexample   // Define the menu we wish to add the item to   %targetMenu = \"New Menu\";  or  %menu = \"4\";   // Define the text for the new menu item   %menuItemText = \"Menu Item\";   // Define the id for the new menu item   %menuItemId = \"3\";   // Set the accelerator key to toggle this menu item with   %accelerator = \"n\";   // Define the Check Group that this menu item will be in, if we want it to be in a check group. -1 sets it in no check group.   %checkGroup = \"4\";   // Inform the GuiMenuBar control to add the new menu item with the defined fields   %thisGuiMenuBar.addMenuItem(%menu,%menuItemText,%menuItemId,%accelerator,%checkGroup);   @endtsexample   @see GuiTickCtrl)
/// </summary>
public  void addMenuItem(string guimenubar, string targetMenu = "", string menuItemText = "", int menuItemId = 0, string accelerator = "", int checkGroup = -1){


m_ts.fnGuiMenuBar_addMenuItem(guimenubar, targetMenu, menuItemText, menuItemId, accelerator, checkGroup);
}
/// <summary>
/// @brief Adds a menu item to the specified menu.  The menu argument can be either the text of a menu or its id.   @param menuTarget Menu to affect a submenu in   @param menuItem Menu item to affect   @param submenuItemText Text to show for the new submenu   @param submenuItemId Id for the new submenu   @param accelerator Accelerator key for the new submenu   @param checkGroup Which check group the new submenu should be in, or -1 for none.   @tsexample   // Define the menuTarget   %menuTarget = \"New Menu\";  or  %menuTarget = \"3\";   // Define the menuItem   %menuItem = \"New Menu Item\";  or  %menuItem = \"5\";   // Define the text for the new submenu   %submenuItemText = \"New Submenu Item\";   // Define the id for the new submenu   %submenuItemId = \"4\";   // Define the accelerator key for the new submenu   %accelerator = \"n\";   // Define the checkgroup for the new submenu   %checkgroup = \"7\";   // Request the GuiMenuBar control to add the new submenu with the defined information   %thisGuiMenuBar.addSubmenuItem(%menuTarget,%menuItem,%submenuItemText,%submenuItemId,%accelerator,%checkgroup);   @endtsexample   @see GuiTickCtrl)
/// </summary>
public  void addSubmenuItem(string guimenubar, string menuTarget, string menuItem, string submenuItemText, int submenuItemId, string accelerator, int checkGroup){


m_ts.fnGuiMenuBar_addSubmenuItem(guimenubar, menuTarget, menuItem, submenuItemText, submenuItemId, accelerator, checkGroup);
}
/// <summary>
/// @brief Removes all the menu items from the specified menu.   @param menuTarget Menu to remove all items from     @tsexample   // Define the menuTarget   %menuTarget = \"New Menu\";  or %menuTarget = \"3\";   // Inform the GuiMenuBar control to clear all menu items from the defined menu   %thisGuiMenuBar.clearMenuItems(%menuTarget);   @endtsexample   @see GuiTickCtrl)
/// </summary>
public  void clearMenuItems(string guimenubar, string menuTarget){


m_ts.fnGuiMenuBar_clearMenuItems(guimenubar, menuTarget);
}
/// <summary>
/// @brief Clears all the menus from the menu bar.   @tsexample   // Inform the GuiMenuBar control to clear all menus from itself.   %thisGuiMenuBar.clearMenus();   @endtsexample   @see GuiTickCtrl)
/// </summary>
public  void clearMenus(string guimenubar, int param1, int param2){


m_ts.fnGuiMenuBar_clearMenus(guimenubar, param1, param2);
}
/// <summary>
/// @brief Removes all the menu items from the specified submenu.   @param menuTarget Menu to affect a submenu in   @param menuItem Menu item to affect   @tsexample   // Define the menuTarget   %menuTarget = \"New Menu\";  or %menuTarget = \"3\";   // Define the menuItem   %menuItem = \"New Menu Item\";  or  %menuItem = \"5\";   // Inform the GuiMenuBar to remove all submenu items from the defined menu item   %thisGuiMenuBar.clearSubmenuItems(%menuTarget,%menuItem);   @endtsexample   @see GuiControl)
/// </summary>
public  void clearSubmenuItems(string guimenubar, string menuTarget, string menuItem){


m_ts.fnGuiMenuBar_clearSubmenuItems(guimenubar, menuTarget, menuItem);
}
/// <summary>
/// @brief Removes the specified menu from the menu bar.   @param menuTarget Menu to remove from the menu bar     @tsexample   // Define the menuTarget   %menuTarget = \"New Menu\";  or %menuTarget = \"3\";   // Inform the GuiMenuBar to remove the defined menu from the menu bar   %thisGuiMenuBar.removeMenu(%menuTarget);   @endtsexample   @see GuiTickCtrl)
/// </summary>
public  void removeMenu(string guimenubar, string menuTarget){


m_ts.fnGuiMenuBar_removeMenu(guimenubar, menuTarget);
}
/// <summary>
/// @brief Removes the specified menu item from the menu.   @param menuTarget Menu to affect the menu item in   @param menuItem Menu item to affect   @tsexample   // Define the menuTarget   %menuTarget = \"New Menu\";  or %menuTarget = \"3\";   // Define the menuItem   %menuItem = \"New Menu Item\";  or  %menuItem = \"5\";   // Request the GuiMenuBar control to remove the define menu item   %thisGuiMenuBar.removeMenuItem(%menuTarget,%menuItem);   @endtsexample   @see GuiTickCtrl)
/// </summary>
public  void removeMenuItem(string guimenubar, string menuTarget, string menuItemTarget){


m_ts.fnGuiMenuBar_removeMenuItem(guimenubar, menuTarget, menuItemTarget);
}
/// <summary>
/// @brief Sets the menu bitmap index for the check mark image.   @param bitmapIndex Bitmap index for the check mark image.   @tsexample   // Define the bitmap index   %bitmapIndex = \"2\";   // Inform the GuiMenuBar control of the proper bitmap index for the check mark image   %thisGuiMenuBar.setCheckmarkBitmapIndex(%bitmapIndex);   @endtsexample   @see GuiTickCtrl)
/// </summary>
public  void setCheckmarkBitmapIndex(string guimenubar, int bitmapindex){


m_ts.fnGuiMenuBar_setCheckmarkBitmapIndex(guimenubar, bitmapindex);
}
/// <summary>
/// @brief Sets the bitmap index for the menu and toggles rendering only the bitmap.   @param menuTarget Menu to affect   @param bitmapindex Bitmap index to set for the menu   @param bitmaponly If true, only the bitmap will be rendered   @param drawborder If true, a border will be drawn around the menu.   @tsexample   // Define the menuTarget to affect   %menuTarget = \"New Menu\";  or %menuTarget = \"3\";   // Set the bitmap index   %bitmapIndex = \"5\";   // Set if we are only to render the bitmap or not   %bitmaponly = \"true\";   // Set if we are rendering a border or not   %drawborder = \"true\";   // Inform the GuiMenuBar of the bitmap and rendering changes   %thisGuiMenuBar.setMenuBitmapIndex(%menuTarget,%bitmapIndex,%bitmapOnly,%drawBorder);   @endtsexample   @see GuiTickCtrl)
/// </summary>
public  void setMenuBitmapIndex(string guimenubar, string menuTarget, int bitmapindex, bool bitmaponly, bool drawborder){


m_ts.fnGuiMenuBar_setMenuBitmapIndex(guimenubar, menuTarget, bitmapindex, bitmaponly, drawborder);
}
/// <summary>
/// @brief Sets the specified menu item bitmap index in the bitmap array.  Setting the item's index to -1 will remove any bitmap.   @param menuTarget Menu to affect the menuItem in   @param menuItem Menu item to affect   @param bitmapIndex Bitmap index to set the menu item to   @tsexample   // Define the menuTarget   %menuTarget = \"New Menu\";  or  %menuTarget = \"3\";   // Define the menuItem\"   %menuItem = \"New Menu Item\";  or %menuItem = \"2\";   // Define the bitmapIndex   %bitmapIndex = \"6\";   // Inform the GuiMenuBar control to set the menu item to the defined bitmap   %thisGuiMenuBar.setMenuItemBitmap(%menuTarget,%menuItem,%bitmapIndex);   @endtsexample   @see GuiTickCtrl)
/// </summary>
public  void setMenuItemBitmap(string guimenubar, string menuTarget, string menuItemTarget, int bitmapIndex){


m_ts.fnGuiMenuBar_setMenuItemBitmap(guimenubar, menuTarget, menuItemTarget, bitmapIndex);
}
/// <summary>
/// @brief Sets the menu item bitmap to a check mark, which by default is the first element in   the bitmap array (although this may be changed with setCheckmarkBitmapIndex()).   Any other menu items in the menu with the same check group become unchecked if they are checked.   @param menuTarget Menu to work in   @param menuItem Menu item to affect   @param checked Whether we are setting it to checked or not   @tsexample      @endtsexample   @return If not void, return value and description   @see References)
/// </summary>
public  void setMenuItemChecked(string guimenubar, string menuTarget, string menuItemTarget, bool checkedx){


m_ts.fnGuiMenuBar_setMenuItemChecked(guimenubar, menuTarget, menuItemTarget, checkedx);
}
/// <summary>
/// @brief sets the menu item to enabled or disabled based on the enable parameter.   The specified menu and menu item can either be text or ids.   Detailed description   @param menuTarget Menu to work in   @param menuItemTarget The menu item inside of the menu to enable or disable   @param enabled Boolean enable / disable value.   @tsexample   // Define the menu   %menu = \"New Menu\";  or  %menu = \"4\";   // Define the menu item   %menuItem = \"New Menu Item\";  or %menuItem = \"2\";   // Define the enabled state   %enabled = \"true\";   // Inform the GuiMenuBar control to set the enabled state of the requested menu item   %thisGuiMenuBar.setMenuItemEnable(%menu,%menuItme,%enabled);   @endtsexample   @see GuiTickCtrl)
/// </summary>
public  void setMenuItemEnable(string guimenubar, string menuTarget, string menuItemTarget, bool enabled){


m_ts.fnGuiMenuBar_setMenuItemEnable(guimenubar, menuTarget, menuItemTarget, enabled);
}
/// <summary>
/// @brief Sets the given menu item to be a submenu.   @param menuTarget Menu to affect a submenu in   @param menuItem Menu item to affect   @param isSubmenu Whether or not the menuItem will become a subMenu or not   @tsexample   // Define the menuTarget   %menuTarget = \"New Menu\";  or %menuTarget = \"3\";   // Define the menuItem   %menuItem = \"New Menu Item\";  or  %menuItem = \"5\";   // Define whether or not the Menu Item is a sub menu or not   %isSubmenu = \"true\";   // Inform the GuiMenuBar control to set the defined menu item to be a submenu or not.   %thisGuiMenuBar.setMenuItemSubmenuState(%menuTarget,%menuItem,%isSubmenu);   @endtsexample   @see GuiTickCtrl)
/// </summary>
public  void setMenuItemSubmenuState(string guimenubar, string menuTarget, string menuItem, bool isSubmenu){


m_ts.fnGuiMenuBar_setMenuItemSubmenuState(guimenubar, menuTarget, menuItem, isSubmenu);
}
/// <summary>
/// @brief Sets the text of the specified menu item to the new string.   @param menuTarget Menu to affect   @param menuItem Menu item in the menu to change the text at   @param newMenuItemText New menu text   @tsexample   // Define the menuTarget   %menuTarget = \"New Menu\";  or  %menuTarget = \"4\";   // Define the menuItem   %menuItem = \"New Menu Item\";  or  %menuItem = \"2\";   // Define the new text for the menu item   %newMenuItemText = \"Very New Menu Item\";   // Inform the GuiMenuBar control to change the defined menu item with the new text   %thisGuiMenuBar.setMenuItemText(%menuTarget,%menuItem,%newMenuItemText);   @endtsexample   @see GuiTickCtrl)
/// </summary>
public  void setMenuItemText(string guimenubar, string menuTarget, string menuItemTarget, string newMenuItemText){


m_ts.fnGuiMenuBar_setMenuItemText(guimenubar, menuTarget, menuItemTarget, newMenuItemText);
}
/// <summary>
/// @brief Brief Description.   Detailed description   @param menuTarget Menu to affect the menu item in   @param menuItem Menu item to affect   @param isVisible Visible state to set the menu item to.   @tsexample   // Define the menuTarget   %menuTarget = \"New Menu\";  or  %menuTarget = \"3\";   // Define the menuItem   %menuItem = \"New Menu Item\";  or  %menuItem = \"2\";   // Define the visibility state   %isVisible = \"true\";   // Inform the GuiMenuBarControl of the visibility state of the defined menu item   %thisGuiMenuBar.setMenuItemVisible(%menuTarget,%menuItem,%isVisible);   @endtsexample   @see GuiTickCtrl)
/// </summary>
public  void setMenuItemVisible(string guimenubar, string menuTarget, string menuItemTarget, bool isVisible){


m_ts.fnGuiMenuBar_setMenuItemVisible(guimenubar, menuTarget, menuItemTarget, isVisible);
}
/// <summary>
/// @brief Sets the menu rendering margins: horizontal, vertical, bitmap spacing.   Detailed description   @param horizontalMargin Number of pixels on the left and right side of a menu's text.   @param verticalMargin Number of pixels on the top and bottom of a menu's text.   @param bitmapToTextSpacing Number of pixels between a menu's bitmap and text.   @tsexample   // Define the horizontalMargin   %horizontalMargin = \"5\";   // Define the verticalMargin   %verticalMargin = \"5\";   // Define the bitmapToTextSpacing   %bitmapToTextSpacing = \"12\";   // Inform the GuiMenuBar control to set its margins based on the defined values.   %thisGuiMenuBar.setMenuMargins(%horizontalMargin,%verticalMargin,%bitmapToTextSpacing);   @endtsexample   @see GuiTickCtrl)
/// </summary>
public  void setMenuMargins(string guimenubar, int horizontalMargin, int verticalMargin, int bitmapToTextSpacing){


m_ts.fnGuiMenuBar_setMenuMargins(guimenubar, horizontalMargin, verticalMargin, bitmapToTextSpacing);
}
/// <summary>
/// @brief Sets the text of the specified menu to the new string.   @param menuTarget Menu to affect   @param newMenuText New menu text   @tsexample   // Define the menu to affect   %menu = \"New Menu\";  or %menu = \"3\";   // Define the text to change the menu to   %newMenuText = \"Still a New Menu\";   // Inform the GuiMenuBar control to change the defined menu to the defined text   %thisGuiMenuBar.setMenuText(%menu,%newMenuText);   @endtsexample   @see GuiTickCtrl)
/// </summary>
public  void setMenuText(string guimenubar, string menuTarget, string newMenuText){


m_ts.fnGuiMenuBar_setMenuText(guimenubar, menuTarget, newMenuText);
}
/// <summary>
/// @brief Sets the whether or not to display the specified menu.   @param menuTarget Menu item to affect   @param visible Whether the menu item will be visible or not   @tsexample   // Define the menu to work with   %menuTarget = \"New Menu\";  or  %menuTarget = \"4\";   // Define if the menu should be visible or not   %visible = \"true\";   // Inform the GuiMenuBar control of the new visibility state for the defined menu   %thisGuiMenuBar.setMenuVisible(%menuTarget,%visible);   @endtsexample   @see GuiTickCtrl)
/// </summary>
public  void setMenuVisible(string guimenubar, string menuTarget, bool visible){


m_ts.fnGuiMenuBar_setMenuVisible(guimenubar, menuTarget, visible);
}
/// <summary>
/// @brief Sets the menu item bitmap to a check mark, which by default is the first element in the   bitmap array (although this may be changed with setCheckmarkBitmapIndex()).   Any other menu items in the menu with the same check group become unchecked if they are checked.   @param menuTarget Menu to affect a submenu in   @param menuItem Menu item to affect   @param submenuItemText Text to show for submenu   @param checked Whether or not this submenu item will be checked.   @tsexample   // Define the menuTarget   %menuTarget = \"New Menu\";  or %menuTarget = \"3\";   // Define the menuItem   %menuItem = \"New Menu Item\";  or  %menuItem = \"5\";   // Define the text for the new submenu   %submenuItemText = \"Submenu Item\";   // Define if this submenu item should be checked or not   %checked = \"true\";   // Inform the GuiMenuBar control to set the checked state of the defined submenu item   %thisGuiMenuBar.setSubmenuItemChecked(%menuTarget,%menuItem,%submenuItemText,%checked);   @endtsexample   @return If not void, return value and description   @see References)
/// </summary>
public  void setSubmenuItemChecked(string guimenubar, string menuTarget, string menuItemTarget, string submenuItemText, bool checkedx){


m_ts.fnGuiMenuBar_setSubmenuItemChecked(guimenubar, menuTarget, menuItemTarget, submenuItemText, checkedx);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiMeshRoadEditorCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiMeshRoadEditorCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// deleteNode() )
/// </summary>
public  void GuiMeshRoadEditorCtrl_deleteNode(string guimeshroadeditorctrl){


m_ts.fn_GuiMeshRoadEditorCtrl_deleteNode(guimeshroadeditorctrl);
}
/// <summary>
///  )
/// </summary>
public  string GuiMeshRoadEditorCtrl_getMode(string guimeshroadeditorctrl){


return m_ts.fn_GuiMeshRoadEditorCtrl_getMode(guimeshroadeditorctrl);
}
/// <summary>
///  )
/// </summary>
public  float GuiMeshRoadEditorCtrl_getNodeDepth(string guimeshroadeditorctrl){


return m_ts.fn_GuiMeshRoadEditorCtrl_getNodeDepth(guimeshroadeditorctrl);
}
/// <summary>
///  )
/// </summary>
public  Point3F GuiMeshRoadEditorCtrl_getNodeNormal(string guimeshroadeditorctrl){


return new Point3F ( m_ts.fn_GuiMeshRoadEditorCtrl_getNodeNormal(guimeshroadeditorctrl));
}
/// <summary>
///  )
/// </summary>
public  Point3F GuiMeshRoadEditorCtrl_getNodePosition(string guimeshroadeditorctrl){


return new Point3F ( m_ts.fn_GuiMeshRoadEditorCtrl_getNodePosition(guimeshroadeditorctrl));
}
/// <summary>
///  )
/// </summary>
public  float GuiMeshRoadEditorCtrl_getNodeWidth(string guimeshroadeditorctrl){


return m_ts.fn_GuiMeshRoadEditorCtrl_getNodeWidth(guimeshroadeditorctrl);
}
/// <summary>
///  )
/// </summary>
public  int GuiMeshRoadEditorCtrl_getSelectedRoad(string guimeshroadeditorctrl){


return m_ts.fn_GuiMeshRoadEditorCtrl_getSelectedRoad(guimeshroadeditorctrl);
}
/// <summary>
///  )
/// </summary>
public  void GuiMeshRoadEditorCtrl_matchTerrainToRoad(string guimeshroadeditorctrl){


m_ts.fn_GuiMeshRoadEditorCtrl_matchTerrainToRoad(guimeshroadeditorctrl);
}
/// <summary>
///  )
/// </summary>
public  void GuiMeshRoadEditorCtrl_regenerate(string guimeshroadeditorctrl){


m_ts.fn_GuiMeshRoadEditorCtrl_regenerate(guimeshroadeditorctrl);
}
/// <summary>
/// setMode( String mode ) )
/// </summary>
public  void GuiMeshRoadEditorCtrl_setMode(string guimeshroadeditorctrl, string mode){


m_ts.fn_GuiMeshRoadEditorCtrl_setMode(guimeshroadeditorctrl, mode);
}
/// <summary>
///  )
/// </summary>
public  void GuiMeshRoadEditorCtrl_setNodeDepth(string guimeshroadeditorctrl, float depth){


m_ts.fn_GuiMeshRoadEditorCtrl_setNodeDepth(guimeshroadeditorctrl, depth);
}
/// <summary>
///  )
/// </summary>
public  void GuiMeshRoadEditorCtrl_setNodeNormal(string guimeshroadeditorctrl, Point3F normal){


m_ts.fn_GuiMeshRoadEditorCtrl_setNodeNormal(guimeshroadeditorctrl, normal.AsString());
}
/// <summary>
///  )
/// </summary>
public  void GuiMeshRoadEditorCtrl_setNodePosition(string guimeshroadeditorctrl, Point3F pos){


m_ts.fn_GuiMeshRoadEditorCtrl_setNodePosition(guimeshroadeditorctrl, pos.AsString());
}
/// <summary>
///  )
/// </summary>
public  void GuiMeshRoadEditorCtrl_setNodeWidth(string guimeshroadeditorctrl, float width){


m_ts.fn_GuiMeshRoadEditorCtrl_setNodeWidth(guimeshroadeditorctrl, width);
}
/// <summary>
/// ),  )
/// </summary>
public  void GuiMeshRoadEditorCtrl_setSelectedRoad(string guimeshroadeditorctrl, string objName = ""){


m_ts.fn_GuiMeshRoadEditorCtrl_setSelectedRoad(guimeshroadeditorctrl, objName);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiMessageVectorCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiMessageVectorCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Push a line onto the back of the list.	   @param item The GUI element being pushed into the control	   @tsexample	   // All messages are stored in this HudMessageVector, the actual	   // MainChatHud only displays the contents of this vector.	   new MessageVector(HudMessageVector);	   // Attach the MessageVector to the chat control	   chatHud.attach(HudMessageVector);	   @endtsexample	   @return Value)
/// </summary>
public  bool attach(string guimessagevectorctrl, string item){


return m_ts.fnGuiMessageVectorCtrl_attach(guimessagevectorctrl, item);
}
/// <summary>
/// @brief Stop listing messages from the MessageVector previously attached to, if any.				   Detailed description				   @param param Description				   @tsexample				   // Deatch the MessageVector from HudMessageVector				   // HudMessageVector will no longer render the text				   chatHud.detach();				   @endtsexample)
/// </summary>
public  void detach(string guimessagevectorctrl){


m_ts.fnGuiMessageVectorCtrl_detach(guimessagevectorctrl);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiMissionAreaCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiMissionAreaCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Set the MissionArea to edit.)
/// </summary>
public  void setMissionArea(string guimissionareactrl, string area){


m_ts.fnGuiMissionAreaCtrl_setMissionArea(guimissionareactrl, area);
}
/// <summary>
/// @brief Update the terrain bitmap.)
/// </summary>
public  void updateTerrain(string guimissionareactrl){


m_ts.fnGuiMissionAreaCtrl_updateTerrain(guimissionareactrl);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiMissionAreaEditorCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiMissionAreaEditorCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
///  )
/// </summary>
public  string GuiMissionAreaEditorCtrl_getSelectedMissionArea(string guimissionareaeditorctrl){


return m_ts.fn_GuiMissionAreaEditorCtrl_getSelectedMissionArea(guimissionareaeditorctrl);
}
/// <summary>
/// ),  )
/// </summary>
public  void GuiMissionAreaEditorCtrl_setSelectedMissionArea(string guimissionareaeditorctrl, string missionAreaName = ""){


m_ts.fn_GuiMissionAreaEditorCtrl_setSelectedMissionArea(guimissionareaeditorctrl, missionAreaName);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiMLTextCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiMLTextCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Appends the text in the control with additional text. Also .   @param text New text to append to the existing text.   @param reformat If true, the control will also be visually reset (defaults to true).   @tsexample   // Define new text to add   %text = \"New Text to Add\";   // Set reformat boolean   %reformat = \"true\";   // Inform the control to add the new text   %thisGuiMLTextCtrl.addText(%text,%reformat);   @endtsexample   @see GuiControl)
/// </summary>
public  void addText(string guimltextctrl, string text, bool reformat = true){


m_ts.fnGuiMLTextCtrl_addText(guimltextctrl, text, reformat);
}
/// <summary>
/// @brief Forces the text control to reflow the text after new text is added, possibly resizing the control.   @tsexample   // Define new text to add   %newText = \"BACON!\";   // Add the new text to the control   %thisGuiMLTextCtrl.addText(%newText);   // Inform the GuiMLTextCtrl object to force a reflow to ensure the added text fits properly.   %thisGuiMLTextCtrl.forceReflow();   @endtsexample   @see GuiControl)
/// </summary>
public  void forceReflow(string guimltextctrl){


m_ts.fnGuiMLTextCtrl_forceReflow(guimltextctrl);
}
/// <summary>
/// @brief Returns the text from the control, including TorqueML characters.   @tsexample   // Get the text displayed in the control   %controlText = %thisGuiMLTextCtrl.getText();   @endtsexample   @return Text string displayed in the control, including any TorqueML characters.   @see GuiControl)
/// </summary>
public  string getText(string guimltextctrl){


return m_ts.fnGuiMLTextCtrl_getText(guimltextctrl);
}
/// <summary>
/// @brief Scroll to the bottom of the text.   @tsexample   // Inform GuiMLTextCtrl object to scroll to its bottom   %thisGuiMLTextCtrl.scrollToBottom();   @endtsexample   @see GuiControl)
/// </summary>
public  void scrollToBottom(string guimltextctrl){


m_ts.fnGuiMLTextCtrl_scrollToBottom(guimltextctrl);
}
/// <summary>
/// @brief Scroll down to a specified tag.   Detailed description   @param tagID TagID to scroll the control to   @tsexample   // Define the TagID we want to scroll the control to   %tagId = \"4\";   // Inform the GuiMLTextCtrl to scroll to the defined TagID   %thisGuiMLTextCtrl.scrollToTag(%tagId);   @endtsexample   @see GuiControl)
/// </summary>
public  void scrollToTag(string guimltextctrl, int tagID){


m_ts.fnGuiMLTextCtrl_scrollToTag(guimltextctrl, tagID);
}
/// <summary>
/// @brief Scroll to the top of the text.   @tsexample   // Inform GuiMLTextCtrl object to scroll to its top   %thisGuiMLTextCtrl.scrollToTop();   @endtsexample   @see GuiControl)
/// </summary>
public  void scrollToTop(string guimltextctrl, int param1, int param2){


m_ts.fnGuiMLTextCtrl_scrollToTop(guimltextctrl, param1, param2);
}
/// <summary>
/// @brief Sets the alpha value of the control.   @param alphaVal n - 1.0 floating value for the alpha   @tsexample   // Define the alphe value   %alphaVal = \"0.5\";   // Inform the control to update its alpha value.   %thisGuiMLTextCtrl.setAlpha(%alphaVal);   @endtsexample   @see GuiControl)
/// </summary>
public  void setAlpha(string guimltextctrl, float alphaVal){


m_ts.fnGuiMLTextCtrl_setAlpha(guimltextctrl, alphaVal);
}
/// <summary>
/// @brief Change the text cursor's position to a new defined offset within the text in the control.   @param newPos Offset to place cursor.   @tsexample   // Define cursor offset position   %position = \"23\";   // Inform the GuiMLTextCtrl object to move the cursor to the new position.   %thisGuiMLTextCtrl.setCursorPosition(%position);   @endtsexample   @return Returns true if the cursor position moved, or false if the position was not changed.   @see GuiControl)
/// </summary>
public  bool setCursorPosition(string guimltextctrl, int newPos){


return m_ts.fnGuiMLTextCtrl_setCursorPosition(guimltextctrl, newPos);
}
/// <summary>
/// @brief Set the text contained in the control.   @param text The text to display in the control.   @tsexample   // Define the text to display   %text = \"Nifty Control Text\";   // Set the text displayed within the control   %thisGuiMLTextCtrl.setText(%text);   @endtsexample   @see GuiControl)
/// </summary>
public  void setText(string guimltextctrl, string text){


m_ts.fnGuiMLTextCtrl_setText(guimltextctrl, text);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiNavEditorCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiNavEditorCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// )
/// 
/// </summary>
public  string GuiNavEditorCtrl_getMode(string guinaveditorctrl){


return m_ts.fn_GuiNavEditorCtrl_getMode(guinaveditorctrl);
}
/// <summary>
/// setMode(String mode))
/// 
/// </summary>
public  void GuiNavEditorCtrl_setMode(string guinaveditorctrl, string newMode){


m_ts.fn_GuiNavEditorCtrl_setMode(guinaveditorctrl, newMode);
}
/// <summary>
/// @brief Build the currently selected tile.)
/// 
/// </summary>
public  void buildTile(string guinaveditorctrl){


m_ts.fnGuiNavEditorCtrl_buildTile(guinaveditorctrl);
}
/// <summary>
/// @brief Delete the currently selected link.)
/// 
/// </summary>
public  void deleteLink(string guinaveditorctrl){


m_ts.fnGuiNavEditorCtrl_deleteLink(guinaveditorctrl);
}
/// <summary>
/// @brief Deselect whatever is currently selected in the editor.)
/// 
/// </summary>
public  void deselect(string guinaveditorctrl){


m_ts.fnGuiNavEditorCtrl_deselect(guinaveditorctrl);
}
/// <summary>
/// @brief Select a NavMesh object.)
/// 
/// </summary>
public  int getMesh(string guinaveditorctrl){


return m_ts.fnGuiNavEditorCtrl_getMesh(guinaveditorctrl);
}
/// <summary>
/// @brief Select a NavMesh object.)
/// 
/// </summary>
public  int getPlayer(string guinaveditorctrl){


return m_ts.fnGuiNavEditorCtrl_getPlayer(guinaveditorctrl);
}
/// <summary>
/// @brief Select a NavMesh object.)
/// 
/// </summary>
public  void selectMesh(string guinaveditorctrl, int id){


m_ts.fnGuiNavEditorCtrl_selectMesh(guinaveditorctrl, id);
}
/// <summary>
/// @Brief Set jump and drop properties of the selected link.)
/// 
/// </summary>
public  void setLinkFlags(string guinaveditorctrl, uint flags){


m_ts.fnGuiNavEditorCtrl_setLinkFlags(guinaveditorctrl, flags);
}
/// <summary>
/// @brief Spawn an AIPlayer at the centre of the screen.)
/// 
/// </summary>
public  void spawnPlayer(string guinaveditorctrl){


m_ts.fnGuiNavEditorCtrl_spawnPlayer(guinaveditorctrl);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiObjectViewObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiObjectViewObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Return the current multiplier for camera zooming and rotation.   @tsexample   // Request the current camera zooming and rotation multiplier value   %multiplier = %thisGuiObjectView.getCameraSpeed();   @endtsexample   @return Camera zooming / rotation multiplier value.   @see GuiControl)
/// </summary>
public  float getCameraSpeed(string guiobjectview){


return m_ts.fnGuiObjectView_getCameraSpeed(guiobjectview);
}
/// <summary>
/// @brief Return the model displayed in this view.   @tsexample   // Request the displayed model name from the GuiObjectView object.   %modelName = %thisGuiObjectView.getModel();   @endtsexample   @return Name of the displayed model.   @see GuiControl)
/// </summary>
public  string getModel(string guiobjectview){


return m_ts.fnGuiObjectView_getModel(guiobjectview);
}
/// <summary>
/// @brief Return the name of the mounted model.   @tsexample   // Request the name of the mounted model from the GuiObjectView object   %mountedModelName = %thisGuiObjectView.getMountedModel();   @endtsexample   @return Name of the mounted model.   @see GuiControl)
/// </summary>
public  string getMountedModel(string guiobjectview){


return m_ts.fnGuiObjectView_getMountedModel(guiobjectview);
}
/// <summary>
/// @brief Return the name of skin used on the mounted model.   @tsexample   // Request the skin name from the model mounted on to the main model in the control   %mountModelSkin = %thisGuiObjectView.getMountSkin();   @endtsexample   @return Name of the skin used on the mounted model.   @see GuiControl)
/// </summary>
public  string getMountSkin(string guiobjectview, int param1, int param2){


return m_ts.fnGuiObjectView_getMountSkin(guiobjectview, param1, param2);
}
/// <summary>
/// @brief Return the current distance at which the camera orbits the object.   @tsexample   // Request the current orbit distance   %orbitDistance = %thisGuiObjectView.getOrbitDistance();   @endtsexample   @return The distance at which the camera orbits the object.   @see GuiControl)
/// </summary>
public  float getOrbitDistance(string guiobjectview){


return m_ts.fnGuiObjectView_getOrbitDistance(guiobjectview);
}
/// <summary>
/// @brief Return the name of skin used on the primary model.   @tsexample   // Request the name of the skin used on the primary model in the control   %skinName = %thisGuiObjectView.getSkin();   @endtsexample   @return Name of the skin used on the primary model.   @see GuiControl)
/// </summary>
public  string getSkin(string guiobjectview){


return m_ts.fnGuiObjectView_getSkin(guiobjectview);
}
/// <summary>
/// @brief Sets the multiplier for the camera rotation and zoom speed.   @param factor Multiplier for camera rotation and zoom speed.   @tsexample   // Set the factor value   %factor = \"0.75\";   // Inform the GuiObjectView object to set the camera speed.   %thisGuiObjectView.setCameraSpeed(%factor);   @endtsexample   @see GuiControl)
/// </summary>
public  void setCameraSpeed(string guiobjectview, float factor){


m_ts.fnGuiObjectView_setCameraSpeed(guiobjectview, factor);
}
/// <summary>
/// @brief Set the light ambient color on the sun object used to render the model.   @param color Ambient color of sunlight.   @tsexample   // Define the sun ambient color value   %color = \"1.0 0.4 0.6\";   // Inform the GuiObjectView object to set the sun ambient color to the requested value   %thisGuiObjectView.setLightAmbient(%color);   @endtsexample   @see GuiControl)
/// </summary>
public  void setLightAmbient(string guiobjectview, ColorF color){


m_ts.fnGuiObjectView_setLightAmbient(guiobjectview, color.AsString());
}
/// <summary>
/// @brief Set the light color on the sun object used to render the model.   @param color Color of sunlight.   @tsexample   // Set the color value for the sun   %color = \"1.0 0.4 0.5\";   // Inform the GuiObjectView object to change the sun color to the defined value   %thisGuiObjectView.setLightColor(%color);   @endtsexample   @see GuiControl)
/// </summary>
public  void setLightColor(string guiobjectview, ColorF color){


m_ts.fnGuiObjectView_setLightColor(guiobjectview, color.AsString());
}
/// <summary>
/// @brief Set the light direction from which to light the model.   @param direction XYZ direction from which the light will shine on the model   @tsexample   // Set the light direction   %direction = \"1.0 0.2 0.4\"   // Inform the GuiObjectView object to change the light direction to the defined value   %thisGuiObjectView.setLightDirection(%direction);   @endtsexample   @see GuiControl)
/// </summary>
public  void setLightDirection(string guiobjectview, Point3F direction){


m_ts.fnGuiObjectView_setLightDirection(guiobjectview, direction.AsString());
}
/// <summary>
/// @brief Sets the model to be displayed in this control.   @param shapeName Name of the model to display.   @tsexample   // Define the model we want to display   %shapeName = \"gideon.dts\";   // Tell the GuiObjectView object to display the defined model   %thisGuiObjectView.setModel(%shapeName);   @endtsexample   @see GuiControl)
/// </summary>
public  void setModel(string guiobjectview, string shapeName){


m_ts.fnGuiObjectView_setModel(guiobjectview, shapeName);
}
/// <summary>
/// @brief Mounts the given model to the specified mount point of the primary model displayed in this control.   Detailed description   @param shapeName Name of the model to mount.   @param mountNodeIndexOrName Index or name of the mount point to be mounted to. If index, corresponds to \"mountN\" in your shape where N is the number passed here.   @tsexample   // Set the shapeName to mount   %shapeName = \"GideonGlasses.dts\"   // Set the mount node of the primary model in the control to mount the new shape at   %mountNodeIndexOrName = \"3\";   //OR:   %mountNodeIndexOrName = \"Face\";   // Inform the GuiObjectView object to mount the shape at the specified node.   %thisGuiObjectView.setMount(%shapeName,%mountNodeIndexOrName);   @endtsexample   @see GuiControl)
/// </summary>
public  void setMount(string guiobjectview, string shapeName, string mountNodeIndexOrName){


m_ts.fnGuiObjectView_setMount(guiobjectview, shapeName, mountNodeIndexOrName);
}
/// <summary>
/// @brief Sets the model to be mounted on the primary model.   @param shapeName Name of the model to mount.   @tsexample   // Define the model name to mount   %modelToMount = \"GideonGlasses.dts\";   // Inform the GuiObjectView object to mount the defined model to the existing model in the control   %thisGuiObjectView.setMountedModel(%modelToMount);   @endtsexample   @see GuiControl)
/// </summary>
public  void setMountedModel(string guiobjectview, string shapeName){


m_ts.fnGuiObjectView_setMountedModel(guiobjectview, shapeName);
}
/// <summary>
/// @brief Sets the skin to use on the mounted model.   @param skinName Name of the skin to set on the model mounted to the main model in the control   @tsexample   // Define the name of the skin   %skinName = \"BronzeGlasses\";   // Inform the GuiObjectView Control of the skin to use on the mounted model   %thisGuiObjectViewCtrl.setMountSkin(%skinName);   @endtsexample   @see GuiControl)
/// </summary>
public  void setMountSkin(string guiobjectview, string skinName){


m_ts.fnGuiObjectView_setMountSkin(guiobjectview, skinName);
}
/// <summary>
/// @brief Sets the distance at which the camera orbits the object. Clamped to the acceptable range defined in the class by min and max orbit distances.   Detailed description   @param distance The distance to set the orbit to (will be clamped).   @tsexample   // Define the orbit distance value   %orbitDistance = \"1.5\";   // Inform the GuiObjectView object to set the orbit distance to the defined value   %thisGuiObjectView.setOrbitDistance(%orbitDistance);   @endtsexample   @see GuiControl)
/// </summary>
public  void setOrbitDistance(string guiobjectview, float distance){


m_ts.fnGuiObjectView_setOrbitDistance(guiobjectview, distance);
}
/// <summary>
/// @brief Sets the animation to play for the viewed object.   @param indexOrName The index or name of the animation to play.   @tsexample   // Set the animation index value, or animation sequence name.   %indexVal = \"3\";   //OR:   %indexVal = \"idle\";   // Inform the GuiObjectView object to set the animation sequence of the object in the control.   %thisGuiObjectVew.setSeq(%indexVal);   @endtsexample   @see GuiControl)
/// </summary>
public  void setSeq(string guiobjectview, string indexOrName){


m_ts.fnGuiObjectView_setSeq(guiobjectview, indexOrName);
}
/// <summary>
/// @brief Sets the skin to use on the model being displayed.   @param skinName Name of the skin to use.   @tsexample   // Define the skin we want to apply to the main model in the control   %skinName = \"disco_gideon\";   // Inform the GuiObjectView control to update the skin the to defined skin   %thisGuiObjectView.setSkin(%skinName);   @endtsexample   @see GuiControl)
/// </summary>
public  void setSkin(string guiobjectview, string skinName){


m_ts.fnGuiObjectView_setSkin(guiobjectview, skinName);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiPaneControlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiPaneControlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Collapse or un-collapse the control.   @param collapse True to collapse the control, false to un-collapse it )
/// </summary>
public  void setCollapsed(string guipanecontrol, bool collapse){


m_ts.fnGuiPaneControl_setCollapsed(guipanecontrol, collapse);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiParticleGraphCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiParticleGraphCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// (int plotID, float x, float y, bool setAdded = true;)              Add a data point to the given plot.			  @return)
/// </summary>
public  string GuiParticleGraphCtrl_addPlotPoint(string guiparticlegraphctrl, int plotID, float x, float y, bool setAdded = true){


return m_ts.fn_GuiParticleGraphCtrl_addPlotPoint(guiparticlegraphctrl, plotID, x, y, setAdded);
}
/// <summary>
/// (int plotID, int i, float x, float y)              Change a data point to the given plot and plot position.			  @param plotID The plot you want to access			  @param i The data point.			  @param x,y The plot position.			  @return No return value.)
/// </summary>
public  string GuiParticleGraphCtrl_changePlotPoint(string guiparticlegraphctrl, int plotID, int i, float x, float y){


return m_ts.fn_GuiParticleGraphCtrl_changePlotPoint(guiparticlegraphctrl, plotID, i, x, y);
}
/// <summary>
/// ()              Clear all of the graphs.			  @return No return value)
/// </summary>
public  void GuiParticleGraphCtrl_clearAllGraphs(string guiparticlegraphctrl){


m_ts.fn_GuiParticleGraphCtrl_clearAllGraphs(guiparticlegraphctrl);
}
/// <summary>
/// (int plotID)              Clear the graph of the given plot.			  @return No return value)
/// </summary>
public  void GuiParticleGraphCtrl_clearGraph(string guiparticlegraphctrl, int plotID){


m_ts.fn_GuiParticleGraphCtrl_clearGraph(guiparticlegraphctrl, plotID);
}
/// <summary>
/// (int plotID)              Get the color of the graph passed.			  @return Returns the color of the graph as a string of RGB values formatted as \"R G B\")
/// </summary>
public  string GuiParticleGraphCtrl_getGraphColor(string guiparticlegraphctrl, int plotID){


return m_ts.fn_GuiParticleGraphCtrl_getGraphColor(guiparticlegraphctrl, plotID);
}
/// <summary>
/// (int plotID) 			  Get the maximum values of the graph ranges.			  @return Returns the maximum of the range formatted as \"x-max y-max\")
/// </summary>
public  string GuiParticleGraphCtrl_getGraphMax(string guiparticlegraphctrl, int plotID){


return m_ts.fn_GuiParticleGraphCtrl_getGraphMax(guiparticlegraphctrl, plotID);
}
/// <summary>
/// (int plotID)               Get the minimum values of the graph ranges.			  @return Returns the minimum of the range formatted as \"x-min y-min\")
/// </summary>
public  string GuiParticleGraphCtrl_getGraphMin(string guiparticlegraphctrl, int plotID){


return m_ts.fn_GuiParticleGraphCtrl_getGraphMin(guiparticlegraphctrl, plotID);
}
/// <summary>
/// (int plotID)               Get the name of the graph passed.			  @return Returns the name of the plot)
/// </summary>
public  string GuiParticleGraphCtrl_getGraphName(string guiparticlegraphctrl, int plotID){


return m_ts.fn_GuiParticleGraphCtrl_getGraphName(guiparticlegraphctrl, plotID);
}
/// <summary>
/// (int plotID, float x, float y)              Gets the index of the point passed on the plotID passed (graph ID).			  @param plotID The plot you wish to check.			  @param x,y The coordinates of the point to get.			  @return Returns the index of the point.)
/// </summary>
public  string GuiParticleGraphCtrl_getPlotIndex(string guiparticlegraphctrl, int plotID, float x, float y){


return m_ts.fn_GuiParticleGraphCtrl_getPlotIndex(guiparticlegraphctrl, plotID, x, y);
}
/// <summary>
/// (int plotID, int samples)              Get a data point from the plot specified, samples from the start of the graph.			  @return The data point ID)
/// </summary>
public  string GuiParticleGraphCtrl_getPlotPoint(string guiparticlegraphctrl, int plotID, int samples){


return m_ts.fn_GuiParticleGraphCtrl_getPlotPoint(guiparticlegraphctrl, plotID, samples);
}
/// <summary>
/// ()               Gets the selected Plot (a.k.a. graph).			  @return The plot's ID.)
/// </summary>
public  string GuiParticleGraphCtrl_getSelectedPlot(string guiparticlegraphctrl){


return m_ts.fn_GuiParticleGraphCtrl_getSelectedPlot(guiparticlegraphctrl);
}
/// <summary>
/// ()              Gets the selected Point on the Plot (a.k.a. graph).			  @return The last selected point ID)
/// </summary>
public  string GuiParticleGraphCtrl_getSelectedPoint(string guiparticlegraphctrl){


return m_ts.fn_GuiParticleGraphCtrl_getSelectedPoint(guiparticlegraphctrl);
}
/// <summary>
/// (int plotID, int i, float x, float y)              Insert a data point to the given plot and plot position.			  @param plotID The plot you want to access			  @param i The data point.			  @param x,y The plot position.			  @return No return value.)
/// </summary>
public  void GuiParticleGraphCtrl_insertPlotPoint(string guiparticlegraphctrl, int plotID, int i, float x, float y){


m_ts.fn_GuiParticleGraphCtrl_insertPlotPoint(guiparticlegraphctrl, plotID, i, x, y);
}
/// <summary>
/// (int plotID, int samples)              @return Returns true or false whether or not the point in the plot passed is an existing point.)
/// </summary>
public  string GuiParticleGraphCtrl_isExistingPoint(string guiparticlegraphctrl, int plotID, int samples){


return m_ts.fn_GuiParticleGraphCtrl_isExistingPoint(guiparticlegraphctrl, plotID, samples);
}
/// <summary>
/// ()			  This will reset the currently selected point to nothing.			  @return No return value.)
/// </summary>
public  void GuiParticleGraphCtrl_resetSelectedPoint(string guiparticlegraphctrl){


m_ts.fn_GuiParticleGraphCtrl_resetSelectedPoint(guiparticlegraphctrl);
}
/// <summary>
/// (bool autoMax) 			  Set whether the max will automatically be set when adding points 			  (ie if you add a value over the current max, the max is increased to that value).			  @return No return value.)
/// </summary>
public  void GuiParticleGraphCtrl_setAutoGraphMax(string guiparticlegraphctrl, bool autoMax){


m_ts.fn_GuiParticleGraphCtrl_setAutoGraphMax(guiparticlegraphctrl, autoMax);
}
/// <summary>
/// (bool autoRemove) 			  Set whether or not a point should be deleted when you drag another one over it.			  @return No return value.)
/// </summary>
public  void GuiParticleGraphCtrl_setAutoRemove(string guiparticlegraphctrl, bool autoRemove){


m_ts.fn_GuiParticleGraphCtrl_setAutoRemove(guiparticlegraphctrl, autoRemove);
}
/// <summary>
/// (int plotID, bool isHidden)			  Set whether the graph number passed is hidden or not.			  @return No return value.)
/// </summary>
public  void GuiParticleGraphCtrl_setGraphHidden(string guiparticlegraphctrl, int plotID, bool isHidden){


m_ts.fn_GuiParticleGraphCtrl_setGraphHidden(guiparticlegraphctrl, plotID, isHidden);
}
/// <summary>
/// (int plotID, float maxX, float maxY) 			  Set the max values of the graph of plotID.			  @param plotID The plot to modify			  @param maxX,maxY The maximum bound of the value range.			  @return No return value.)
/// </summary>
public  void GuiParticleGraphCtrl_setGraphMax(string guiparticlegraphctrl, int plotID, float maxX, float maxY){


m_ts.fn_GuiParticleGraphCtrl_setGraphMax(guiparticlegraphctrl, plotID, maxX, maxY);
}
/// <summary>
/// (int plotID, float maxX)			  Set the max X value of the graph of plotID.			  @param plotID The plot to modify.			  @param maxX The maximum x value.			  @return No return Value.)
/// </summary>
public  void GuiParticleGraphCtrl_setGraphMaxX(string guiparticlegraphctrl, int plotID, float maxX){


m_ts.fn_GuiParticleGraphCtrl_setGraphMaxX(guiparticlegraphctrl, plotID, maxX);
}
/// <summary>
/// (int plotID, float maxY)			  Set the max Y value of the graph of plotID.			  @param plotID The plot to modify.			  @param maxY The maximum y value.			  @return No return Value.)
/// </summary>
public  void GuiParticleGraphCtrl_setGraphMaxY(string guiparticlegraphctrl, int plotID, float maxX){


m_ts.fn_GuiParticleGraphCtrl_setGraphMaxY(guiparticlegraphctrl, plotID, maxX);
}
/// <summary>
/// (int plotID, float minX, float minY) 			  Set the min values of the graph of plotID.			  @param plotID The plot to modify			  @param minX,minY The minimum bound of the value range.			  @return No return value.)
/// </summary>
public  void GuiParticleGraphCtrl_setGraphMin(string guiparticlegraphctrl, int plotID, float minX, float minY){


m_ts.fn_GuiParticleGraphCtrl_setGraphMin(guiparticlegraphctrl, plotID, minX, minY);
}
/// <summary>
/// (int plotID, float minX) 			  Set the min X value of the graph of plotID.			  @param plotID The plot to modify.			  @param minX The minimum x value.			  @return No return Value.)
/// </summary>
public  void GuiParticleGraphCtrl_setGraphMinX(string guiparticlegraphctrl, int plotID, float minX){


m_ts.fn_GuiParticleGraphCtrl_setGraphMinX(guiparticlegraphctrl, plotID, minX);
}
/// <summary>
/// (int plotID, float minY) 			  Set the min Y value of the graph of plotID.			  @param plotID The plot to modify.			  @param minY The minimum y value.			  @return No return Value.)
/// </summary>
public  void GuiParticleGraphCtrl_setGraphMinY(string guiparticlegraphctrl, int plotID, float minX){


m_ts.fn_GuiParticleGraphCtrl_setGraphMinY(guiparticlegraphctrl, plotID, minX);
}
/// <summary>
/// (int plotID, string graphName) 			  Set the name of the given plot.			  @param plotID The plot to modify.			  @param graphName The name to set on the plot.			  @return No return value.)
/// </summary>
public  void GuiParticleGraphCtrl_setGraphName(string guiparticlegraphctrl, int plotID, string graphName){


m_ts.fn_GuiParticleGraphCtrl_setGraphName(guiparticlegraphctrl, plotID, graphName);
}
/// <summary>
/// (bool clamped)			  Set whether the x position of the selected graph point should be clamped			  @return No return value.)
/// </summary>
public  void GuiParticleGraphCtrl_setPointXMovementClamped(string guiparticlegraphctrl, bool autoRemove){


m_ts.fn_GuiParticleGraphCtrl_setPointXMovementClamped(guiparticlegraphctrl, autoRemove);
}
/// <summary>
/// (bool renderAll)			  Set whether or not a position should be rendered on every point or just the last selected.			  @return No return value.)
/// </summary>
public  void GuiParticleGraphCtrl_setRenderAll(string guiparticlegraphctrl, bool autoRemove){


m_ts.fn_GuiParticleGraphCtrl_setRenderAll(guiparticlegraphctrl, autoRemove);
}
/// <summary>
/// (bool renderGraphTooltip)			  Set whether or not to render the graph tooltip.			  @return No return value.)
/// </summary>
public  void GuiParticleGraphCtrl_setRenderGraphTooltip(string guiparticlegraphctrl, bool autoRemove){


m_ts.fn_GuiParticleGraphCtrl_setRenderGraphTooltip(guiparticlegraphctrl, autoRemove);
}
/// <summary>
/// (int plotID)              Set the selected plot (a.k.a. graph).			  @return No return value )
/// </summary>
public  void GuiParticleGraphCtrl_setSelectedPlot(string guiparticlegraphctrl, int plotID){


m_ts.fn_GuiParticleGraphCtrl_setSelectedPlot(guiparticlegraphctrl, plotID);
}
/// <summary>
/// (int point)              Set the selected point on the graph.			  @return No return value)
/// </summary>
public  void GuiParticleGraphCtrl_setSelectedPoint(string guiparticlegraphctrl, int point){


m_ts.fn_GuiParticleGraphCtrl_setSelectedPoint(guiparticlegraphctrl, point);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiPopUpMenuCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiPopUpMenuCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// , -1, 0), (string name, int idNum, int scheme=0))
/// </summary>
public  void GuiPopUpMenuCtrl_add(string guipopupmenuctrl, string name = "", int idNum = -1, uint scheme = 0){


m_ts.fn_GuiPopUpMenuCtrl_add(guipopupmenuctrl, name, idNum, scheme);
}
/// <summary>
/// (int id, ColorI fontColor, ColorI fontColorHL, ColorI fontColorSEL))
/// </summary>
public  void GuiPopUpMenuCtrl_addScheme(string guipopupmenuctrl, uint id, ColorI fontColor, ColorI fontColorHL, ColorI fontColorSEL){


m_ts.fn_GuiPopUpMenuCtrl_addScheme(guipopupmenuctrl, id, fontColor.AsString(), fontColorHL.AsString(), fontColorSEL.AsString());
}
/// <summary>
/// ( int id, string text ) )
/// </summary>
public  void GuiPopUpMenuCtrl_changeTextById(string guipopupmenuctrl, int id, string text){


m_ts.fn_GuiPopUpMenuCtrl_changeTextById(guipopupmenuctrl, id, text);
}
/// <summary>
/// Clear the popup list.)
/// </summary>
public  void GuiPopUpMenuCtrl_clear(string guipopupmenuctrl){


m_ts.fn_GuiPopUpMenuCtrl_clear(guipopupmenuctrl);
}
/// <summary>
/// (S32 entry))
/// </summary>
public  void GuiPopUpMenuCtrl_clearEntry(string guipopupmenuctrl, int entry){


m_ts.fn_GuiPopUpMenuCtrl_clearEntry(guipopupmenuctrl, entry);
}
/// <summary>
/// (string text)              Returns the position of the first entry containing the specified text.)
/// </summary>
public  int GuiPopUpMenuCtrl_findText(string guipopupmenuctrl, string text){


return m_ts.fn_GuiPopUpMenuCtrl_findText(guipopupmenuctrl, text);
}
/// <summary>
/// )
/// </summary>
public  void GuiPopUpMenuCtrl_forceClose(string guipopupmenuctrl){


m_ts.fn_GuiPopUpMenuCtrl_forceClose(guipopupmenuctrl);
}
/// <summary>
/// )
/// </summary>
public  void GuiPopUpMenuCtrl_forceOnAction(string guipopupmenuctrl){


m_ts.fn_GuiPopUpMenuCtrl_forceOnAction(guipopupmenuctrl);
}
/// <summary>
/// )
/// </summary>
public  int GuiPopUpMenuCtrl_getSelected(string guipopupmenuctrl){


return m_ts.fn_GuiPopUpMenuCtrl_getSelected(guipopupmenuctrl);
}
/// <summary>
/// )
/// </summary>
public  string GuiPopUpMenuCtrl_getText(string guipopupmenuctrl){


return m_ts.fn_GuiPopUpMenuCtrl_getText(guipopupmenuctrl);
}
/// <summary>
/// (int id))
/// </summary>
public  string GuiPopUpMenuCtrl_getTextById(string guipopupmenuctrl, int id){


return m_ts.fn_GuiPopUpMenuCtrl_getTextById(guipopupmenuctrl, id);
}
/// <summary>
/// (bool doReplaceText))
/// </summary>
public  void GuiPopUpMenuCtrl_replaceText(string guipopupmenuctrl, bool doReplaceText){


m_ts.fn_GuiPopUpMenuCtrl_replaceText(guipopupmenuctrl, doReplaceText);
}
/// <summary>
/// (string class, string enum)              This fills the popup with a classrep's field enumeration type info.              More of a helper function than anything.   If console access to the field list is added,               at least for the enumerated types, then this should go away..)
/// </summary>
public  void GuiPopUpMenuCtrl_setEnumContent(string guipopupmenuctrl, string className, string enumName){


m_ts.fn_GuiPopUpMenuCtrl_setEnumContent(guipopupmenuctrl, className, enumName);
}
/// <summary>
/// ([scriptCallback=true]))
/// </summary>
public  void GuiPopUpMenuCtrl_setFirstSelected(string guipopupmenuctrl, bool scriptCallback = true){


m_ts.fn_GuiPopUpMenuCtrl_setFirstSelected(guipopupmenuctrl, scriptCallback);
}
/// <summary>
/// )
/// </summary>
public  void GuiPopUpMenuCtrl_setNoneSelected(string guipopupmenuctrl){


m_ts.fn_GuiPopUpMenuCtrl_setNoneSelected(guipopupmenuctrl);
}
/// <summary>
/// (int id, [scriptCallback=true]))
/// </summary>
public  void GuiPopUpMenuCtrl_setSelected(string guipopupmenuctrl, int id, bool scriptCallback = true){


m_ts.fn_GuiPopUpMenuCtrl_setSelected(guipopupmenuctrl, id, scriptCallback);
}
/// <summary>
/// Get the size of the menu - the number of entries in it.)
/// </summary>
public  int GuiPopUpMenuCtrl_size(string guipopupmenuctrl){


return m_ts.fn_GuiPopUpMenuCtrl_size(guipopupmenuctrl);
}
/// <summary>
/// Sort the list alphabetically.)
/// </summary>
public  void GuiPopUpMenuCtrl_sort(string guipopupmenuctrl){


m_ts.fn_GuiPopUpMenuCtrl_sort(guipopupmenuctrl);
}
/// <summary>
/// Sort the list by ID.)
/// </summary>
public  void GuiPopUpMenuCtrl_sortID(string guipopupmenuctrl){


m_ts.fn_GuiPopUpMenuCtrl_sortID(guipopupmenuctrl);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiPopUpMenuCtrlExObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiPopUpMenuCtrlExObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// , -1, 0), (string name, int idNum, int scheme=0))
/// </summary>
public  void GuiPopUpMenuCtrlEx_add(string guipopupmenuctrlex, string name = "", int idNum = -1, uint scheme = 0){


m_ts.fn_GuiPopUpMenuCtrlEx_add(guipopupmenuctrlex, name, idNum, scheme);
}
/// <summary>
/// (S32 entry))
/// </summary>
public  void GuiPopUpMenuCtrlEx_clearEntry(string guipopupmenuctrlex, int entry){


m_ts.fn_GuiPopUpMenuCtrlEx_clearEntry(guipopupmenuctrlex, entry);
}
/// <summary>
/// (string text)              Returns the id of the first entry containing the specified text or -1 if not found.			  @param text String value used for the query			  @return Numerical ID of entry containing the text.)
/// </summary>
public  int GuiPopUpMenuCtrlEx_findText(string guipopupmenuctrlex, string text){


return m_ts.fn_GuiPopUpMenuCtrlEx_findText(guipopupmenuctrlex, text);
}
/// <summary>
/// @brief Get color of an entry's box			  @param id ID number of entry to query			  @return ColorI in the format of \"Red Green Blue Alpha\", each of with is a value between 0 - 255)
/// </summary>
public  ColorI GuiPopUpMenuCtrlEx_getColorById(string guipopupmenuctrlex, int id){


return new ColorI ( m_ts.fn_GuiPopUpMenuCtrlEx_getColorById(guipopupmenuctrlex, id));
}
/// <summary>
/// @brief Flag that causes each new text addition to replace the current entry			  @param True to turn on replacing, false to disable it)
/// </summary>
public  void GuiPopUpMenuCtrlEx_replaceText(string guipopupmenuctrlex, int boolVal){


m_ts.fn_GuiPopUpMenuCtrlEx_replaceText(guipopupmenuctrlex, boolVal);
}
/// <summary>
/// @brief This fills the popup with a classrep's field enumeration type info.              More of a helper function than anything.   If console access to the field list is added,               at least for the enumerated types, then this should go away.			  @param class Name of the class containing the enum			  @param enum Name of the enum value to acces)
/// </summary>
public  void GuiPopUpMenuCtrlEx_setEnumContent(string guipopupmenuctrlex, string className, string enumName){


m_ts.fn_GuiPopUpMenuCtrlEx_setEnumContent(guipopupmenuctrlex, className, enumName);
}
/// <summary>
/// ([scriptCallback=true])			  @hide)
/// </summary>
public  void GuiPopUpMenuCtrlEx_setFirstSelected(string guipopupmenuctrlex, bool scriptCallback = true){


m_ts.fn_GuiPopUpMenuCtrlEx_setFirstSelected(guipopupmenuctrlex, scriptCallback);
}
/// <summary>
/// (int id, [scriptCallback=true])			  @hide)
/// </summary>
public  void GuiPopUpMenuCtrlEx_setSelected(string guipopupmenuctrlex, int id, bool scriptCallback = true){


m_ts.fn_GuiPopUpMenuCtrlEx_setSelected(guipopupmenuctrlex, id, scriptCallback);
}
/// <summary>
/// @brief Get the size of the menu			  @return Number of entries in the menu)
/// </summary>
public  int GuiPopUpMenuCtrlEx_size(string guipopupmenuctrlex){


return m_ts.fn_GuiPopUpMenuCtrlEx_size(guipopupmenuctrlex);
}
/// <summary>
/// @brief Add a category to the list.				   Acts as a separator between entries, allowing for sub-lists				   @param text Name of the new category)
/// </summary>
public  void addCategory(string guipopupmenuctrlex, string text){


m_ts.fnGuiPopUpMenuCtrlEx_addCategory(guipopupmenuctrlex, text);
}
/// <summary>
/// @brief Create a new scheme and add it to the list of choices for when a new text entry is added.				   @param id Numerical id associated with this scheme				   @param fontColor The base text font color. Formatted as \"Red Green Blue\", each a numerical between 0 and 255.				   @param fontColorHL Color of text when being highlighted. Formatted as \"Red Green Blue\", each a numerical between 0 and 255.				   @param fontColorSel Color of text when being selected. Formatted as \"Red Green Blue\", each a numerical between 0 and 255.)
/// </summary>
public  void addScheme(string guipopupmenuctrlex, int id, ColorI fontColor, ColorI fontColorHL, ColorI fontColorSEL){


m_ts.fnGuiPopUpMenuCtrlEx_addScheme(guipopupmenuctrlex, id, fontColor.AsString(), fontColorHL.AsString(), fontColorSEL.AsString());
}
/// <summary>
/// @brief Clear the popup list.)
/// </summary>
public  void clear(string guipopupmenuctrlex){


m_ts.fnGuiPopUpMenuCtrlEx_clear(guipopupmenuctrlex);
}
/// <summary>
/// @brief Manually force this control to collapse and close.)
/// </summary>
public  void forceClose(string guipopupmenuctrlex){


m_ts.fnGuiPopUpMenuCtrlEx_forceClose(guipopupmenuctrlex);
}
/// <summary>
/// @brief Manually for the onAction function, which updates everything in this control.)
/// </summary>
public  void forceOnAction(string guipopupmenuctrlex){


m_ts.fnGuiPopUpMenuCtrlEx_forceOnAction(guipopupmenuctrlex);
}
/// <summary>
/// @brief Get the current selection of the menu.				   @return Returns the ID of the currently selected entry)
/// </summary>
public  int getSelected(string guipopupmenuctrlex){


return m_ts.fnGuiPopUpMenuCtrlEx_getSelected(guipopupmenuctrlex);
}
/// <summary>
/// @brief Get the.				   Detailed description				   @param param Description				   @tsexample				   // Comment				   code();				   @endtsexample				   @return Returns current text in string format)
/// </summary>
public  string getText(string guipopupmenuctrlex){


return m_ts.fnGuiPopUpMenuCtrlEx_getText(guipopupmenuctrlex);
}
/// <summary>
/// @brief Get the text of an entry based on an ID.				   @param id The ID assigned to the entry being queried				   @return String contained by the specified entry, NULL if empty or bad ID)
/// </summary>
public  string getTextById(string guipopupmenuctrlex, int id){


return m_ts.fnGuiPopUpMenuCtrlEx_getTextById(guipopupmenuctrlex, id);
}
/// <summary>
/// @brief Clears selection in the menu.)
/// </summary>
public  void setNoneSelected(string guipopupmenuctrlex, int param){


m_ts.fnGuiPopUpMenuCtrlEx_setNoneSelected(guipopupmenuctrlex, param);
}
/// <summary>
/// @brief Set the current text to a specified value.				   @param text String containing new text to set)
/// </summary>
public  void setText(string guipopupmenuctrlex, string text){


m_ts.fnGuiPopUpMenuCtrlEx_setText(guipopupmenuctrlex, text);
}
/// <summary>
/// @brief Sort the list alphabetically.)
/// </summary>
public  void sort(string guipopupmenuctrlex){


m_ts.fnGuiPopUpMenuCtrlEx_sort(guipopupmenuctrlex);
}
/// <summary>
/// @brief Sort the list by ID.)
/// </summary>
public  void sortID(string guipopupmenuctrlex){


m_ts.fnGuiPopUpMenuCtrlEx_sortID(guipopupmenuctrlex);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiProgressBitmapCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiProgressBitmapCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Set the bitmap to use for rendering the progress bar.   @param filename ~Path to the bitmap file.   @note Directly assign to #bitmap rather than using this method.   @see GuiProgressBitmapCtrl::setBitmap )
/// </summary>
public  void setBitmap(string guiprogressbitmapctrl, string filename){


m_ts.fnGuiProgressBitmapCtrl_setBitmap(guiprogressbitmapctrl, filename);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiRiverEditorCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiRiverEditorCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// deleteNode() )
/// </summary>
public  void GuiRiverEditorCtrl_deleteNode(string guirivereditorctrl){


m_ts.fn_GuiRiverEditorCtrl_deleteNode(guirivereditorctrl);
}
/// <summary>
///  )
/// </summary>
public  string GuiRiverEditorCtrl_getMode(string guirivereditorctrl){


return m_ts.fn_GuiRiverEditorCtrl_getMode(guirivereditorctrl);
}
/// <summary>
///  )
/// </summary>
public  float GuiRiverEditorCtrl_getNodeDepth(string guirivereditorctrl){


return m_ts.fn_GuiRiverEditorCtrl_getNodeDepth(guirivereditorctrl);
}
/// <summary>
///  )
/// </summary>
public  Point3F GuiRiverEditorCtrl_getNodeNormal(string guirivereditorctrl){


return new Point3F ( m_ts.fn_GuiRiverEditorCtrl_getNodeNormal(guirivereditorctrl));
}
/// <summary>
///  )
/// </summary>
public  Point3F GuiRiverEditorCtrl_getNodePosition(string guirivereditorctrl){


return new Point3F ( m_ts.fn_GuiRiverEditorCtrl_getNodePosition(guirivereditorctrl));
}
/// <summary>
///  )
/// </summary>
public  float GuiRiverEditorCtrl_getNodeWidth(string guirivereditorctrl){


return m_ts.fn_GuiRiverEditorCtrl_getNodeWidth(guirivereditorctrl);
}
/// <summary>
///  )
/// </summary>
public  int GuiRiverEditorCtrl_getSelectedRiver(string guirivereditorctrl){


return m_ts.fn_GuiRiverEditorCtrl_getSelectedRiver(guirivereditorctrl);
}
/// <summary>
///  )
/// </summary>
public  void GuiRiverEditorCtrl_regenerate(string guirivereditorctrl){


m_ts.fn_GuiRiverEditorCtrl_regenerate(guirivereditorctrl);
}
/// <summary>
/// setMode( String mode ) )
/// </summary>
public  void GuiRiverEditorCtrl_setMode(string guirivereditorctrl, string mode){


m_ts.fn_GuiRiverEditorCtrl_setMode(guirivereditorctrl, mode);
}
/// <summary>
///  )
/// </summary>
public  void GuiRiverEditorCtrl_setNodeDepth(string guirivereditorctrl, float depth){


m_ts.fn_GuiRiverEditorCtrl_setNodeDepth(guirivereditorctrl, depth);
}
/// <summary>
///  )
/// </summary>
public  void GuiRiverEditorCtrl_setNodeNormal(string guirivereditorctrl, Point3F normal){


m_ts.fn_GuiRiverEditorCtrl_setNodeNormal(guirivereditorctrl, normal.AsString());
}
/// <summary>
///  )
/// </summary>
public  void GuiRiverEditorCtrl_setNodePosition(string guirivereditorctrl, Point3F pos){


m_ts.fn_GuiRiverEditorCtrl_setNodePosition(guirivereditorctrl, pos.AsString());
}
/// <summary>
///  )
/// </summary>
public  void GuiRiverEditorCtrl_setNodeWidth(string guirivereditorctrl, float width){


m_ts.fn_GuiRiverEditorCtrl_setNodeWidth(guirivereditorctrl, width);
}
/// <summary>
/// ),  )
/// </summary>
public  void GuiRiverEditorCtrl_setSelectedRiver(string guirivereditorctrl, string objName = ""){


m_ts.fn_GuiRiverEditorCtrl_setSelectedRiver(guirivereditorctrl, objName);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiRoadEditorCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiRoadEditorCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// deleteNode() )
/// </summary>
public  void GuiRoadEditorCtrl_deleteNode(string guiroadeditorctrl){


m_ts.fn_GuiRoadEditorCtrl_deleteNode(guiroadeditorctrl);
}
/// <summary>
///  )
/// </summary>
public  void GuiRoadEditorCtrl_deleteRoad(string guiroadeditorctrl){


m_ts.fn_GuiRoadEditorCtrl_deleteRoad(guiroadeditorctrl);
}
/// <summary>
///  )
/// </summary>
public  string GuiRoadEditorCtrl_getMode(string guiroadeditorctrl){


return m_ts.fn_GuiRoadEditorCtrl_getMode(guiroadeditorctrl);
}
/// <summary>
///  )
/// </summary>
public  Point3F GuiRoadEditorCtrl_getNodePosition(string guiroadeditorctrl){


return new Point3F ( m_ts.fn_GuiRoadEditorCtrl_getNodePosition(guiroadeditorctrl));
}
/// <summary>
///  )
/// </summary>
public  float GuiRoadEditorCtrl_getNodeWidth(string guiroadeditorctrl){


return m_ts.fn_GuiRoadEditorCtrl_getNodeWidth(guiroadeditorctrl);
}
/// <summary>
///  )
/// </summary>
public  int GuiRoadEditorCtrl_getSelectedNode(string guiroadeditorctrl){


return m_ts.fn_GuiRoadEditorCtrl_getSelectedNode(guiroadeditorctrl);
}
/// <summary>
///  )
/// </summary>
public  int GuiRoadEditorCtrl_getSelectedRoad(string guiroadeditorctrl){


return m_ts.fn_GuiRoadEditorCtrl_getSelectedRoad(guiroadeditorctrl);
}
/// <summary>
/// setMode( String mode ) )
/// </summary>
public  void GuiRoadEditorCtrl_setMode(string guiroadeditorctrl, string mode){


m_ts.fn_GuiRoadEditorCtrl_setMode(guiroadeditorctrl, mode);
}
/// <summary>
///  )
/// </summary>
public  void GuiRoadEditorCtrl_setNodePosition(string guiroadeditorctrl, Point3F pos){


m_ts.fn_GuiRoadEditorCtrl_setNodePosition(guiroadeditorctrl, pos.AsString());
}
/// <summary>
///  )
/// </summary>
public  void GuiRoadEditorCtrl_setNodeWidth(string guiroadeditorctrl, float width){


m_ts.fn_GuiRoadEditorCtrl_setNodeWidth(guiroadeditorctrl, width);
}
/// <summary>
/// ),  )
/// </summary>
public  void GuiRoadEditorCtrl_setSelectedRoad(string guiroadeditorctrl, string pathRoad = ""){


m_ts.fn_GuiRoadEditorCtrl_setSelectedRoad(guiroadeditorctrl, pathRoad);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiRolloutCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiRolloutCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Collapse the rollout if it is currently expanded.  This will make the rollout's child control invisible.   @note The rollout will animate to collapsed state.  To instantly collapse without animation, use instantCollapse(). )
/// </summary>
public  void collapse(string guirolloutctrl){


m_ts.fnGuiRolloutCtrl_collapse(guirolloutctrl);
}
/// <summary>
/// Expand the rollout if it is currently collapsed.  This will make the rollout's child control visible.   @note The rollout will animate to expanded state.  To instantly expand without animation, use instantExpand(). )
/// </summary>
public  void expand(string guirolloutctrl){


m_ts.fnGuiRolloutCtrl_expand(guirolloutctrl);
}
/// <summary>
/// Instantly collapse the rollout without animation.  To smoothly slide the rollout to collapsed state, use collapse(). )
/// </summary>
public  void instantCollapse(string guirolloutctrl){


m_ts.fnGuiRolloutCtrl_instantCollapse(guirolloutctrl);
}
/// <summary>
/// Instantly expand the rollout without animation.  To smoothly slide the rollout to expanded state, use expand(). )
/// </summary>
public  void instantExpand(string guirolloutctrl){


m_ts.fnGuiRolloutCtrl_instantExpand(guirolloutctrl);
}
/// <summary>
/// Determine whether the rollout is currently expanded, i.e. whether the child control is visible.   @return True if the rollout is expanded, false if not. )
/// </summary>
public  bool isExpanded(string guirolloutctrl){


return m_ts.fnGuiRolloutCtrl_isExpanded(guirolloutctrl);
}
/// <summary>
/// Resize the rollout to exactly fit around its child control.  This can be used to manually trigger a recomputation of    the rollout size. )
/// </summary>
public  void sizeToContents(string guirolloutctrl){


m_ts.fnGuiRolloutCtrl_sizeToContents(guirolloutctrl);
}
/// <summary>
/// Toggle the current collapse state of the rollout.  If it is currently expanded, then collapse it.  If it    is currently collapsed, then expand it. )
/// </summary>
public  void toggleCollapse(string guirolloutctrl){


m_ts.fnGuiRolloutCtrl_toggleCollapse(guirolloutctrl);
}
/// <summary>
/// Toggle the current expansion state of the rollout  If it is currently expanded, then collapse it.  If it    is currently collapsed, then expand it.   @param instant If true, the rollout will toggle its state without animation.  Otherwise, the rollout will       smoothly slide into the opposite state. )
/// </summary>
public  void toggleExpanded(string guirolloutctrl, bool instantly = false){


m_ts.fnGuiRolloutCtrl_toggleExpanded(guirolloutctrl, instantly);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiScrollCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiScrollCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Refresh sizing and positioning of child controls. )
/// </summary>
public  void computeSizes(string guiscrollctrl){


m_ts.fnGuiScrollCtrl_computeSizes(guiscrollctrl);
}
/// <summary>
/// Get the current coordinates of the scrolled content.   @return The current position of the scrolled content. )
/// </summary>
public  Point2I getScrollPosition(string guiscrollctrl){


return new Point2I ( m_ts.fnGuiScrollCtrl_getScrollPosition(guiscrollctrl));
}
/// <summary>
/// Get the current X coordinate of the scrolled content.   @return The current X coordinate of the scrolled content. )
/// </summary>
public  int getScrollPositionX(string guiscrollctrl){


return m_ts.fnGuiScrollCtrl_getScrollPositionX(guiscrollctrl);
}
/// <summary>
/// Get the current Y coordinate of the scrolled content.   @return The current Y coordinate of the scrolled content. )
/// </summary>
public  int getScrollPositionY(string guiscrollctrl){


return m_ts.fnGuiScrollCtrl_getScrollPositionY(guiscrollctrl);
}
/// <summary>
/// Scroll all the way to the bottom of the vertical scrollbar and the left of the horizontal bar. )
/// </summary>
public  void scrollToBottom(string guiscrollctrl){


m_ts.fnGuiScrollCtrl_scrollToBottom(guiscrollctrl);
}
/// <summary>
/// Scroll the control so that the given child @a control is visible.   @param control A child control. )
/// </summary>
public  void scrollToObject(string guiscrollctrl, string control){


m_ts.fnGuiScrollCtrl_scrollToObject(guiscrollctrl, control);
}
/// <summary>
/// Scroll all the way to the top of the vertical and left of the horizontal scrollbar. )
/// </summary>
public  void scrollToTop(string guiscrollctrl){


m_ts.fnGuiScrollCtrl_scrollToTop(guiscrollctrl);
}
/// <summary>
/// Set the position of the scrolled content.   @param x Position on X axis.   @param y Position on y axis. )
/// </summary>
public  void setScrollPosition(string guiscrollctrl, int x, int y){


m_ts.fnGuiScrollCtrl_setScrollPosition(guiscrollctrl, x, y);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiShapeEdPreviewObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiShapeEdPreviewObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Add a new thread (initially without any sequence set) )
/// </summary>
public  void addThread(string guishapeedpreview){


m_ts.fnGuiShapeEdPreview_addThread(guishapeedpreview);
}
/// <summary>
/// Compute the bounding box of the shape using the current detail and node transforms   @return the bounding box \"min.x min.y min.z max.x max.y max.z\" )
/// </summary>
public  Box3F computeShapeBounds(string guishapeedpreview){


return new Box3F ( m_ts.fnGuiShapeEdPreview_computeShapeBounds(guishapeedpreview));
}
/// <summary>
/// Export the current shape and all mounted objects to COLLADA (.dae).   Note that animation is not exported, and all geometry is combined into a    single mesh.   @param path Destination filename )
/// </summary>
public  void exportToCollada(string guishapeedpreview, string path){


m_ts.fnGuiShapeEdPreview_exportToCollada(guishapeedpreview, path);
}
/// <summary>
/// Adjust the camera position and zoom to fit the shape within the view. )
/// </summary>
public  void fitToShape(string guishapeedpreview){


m_ts.fnGuiShapeEdPreview_fitToShape(guishapeedpreview);
}
/// <summary>
/// Return whether the named object is currently hidden )
/// </summary>
public  bool getMeshHidden(string guishapeedpreview, string name){


return m_ts.fnGuiShapeEdPreview_getMeshHidden(guishapeedpreview, name);
}
/// <summary>
/// Get the playback direction of the sequence playing on this mounted shape   @param slot mounted shape slot   @return direction of the sequence (-1=reverse, 0=paused, 1=forward) )
/// </summary>
public  float getMountThreadDir(string guishapeedpreview, int slot){


return m_ts.fnGuiShapeEdPreview_getMountThreadDir(guishapeedpreview, slot);
}
/// <summary>
/// Get the playback position of the sequence playing on this mounted shape   @param slot mounted shape slot   @return playback position of the sequence (0-1) )
/// </summary>
public  float getMountThreadPos(string guishapeedpreview, int slot){


return m_ts.fnGuiShapeEdPreview_getMountThreadPos(guishapeedpreview, slot);
}
/// <summary>
/// Get the name of the sequence playing on this mounted shape   @param slot mounted shape slot   @return name of the sequence (if any) )
/// </summary>
public  string getMountThreadSequence(string guishapeedpreview, int slot){


return m_ts.fnGuiShapeEdPreview_getMountThreadSequence(guishapeedpreview, slot);
}
/// <summary>
/// Get the number of threads   @return the number of threads )
/// </summary>
public  int getThreadCount(string guishapeedpreview){


return m_ts.fnGuiShapeEdPreview_getThreadCount(guishapeedpreview);
}
/// <summary>
/// Get the name of the sequence assigned to the active thread )
/// </summary>
public  string getThreadSequence(string guishapeedpreview){


return m_ts.fnGuiShapeEdPreview_getThreadSequence(guishapeedpreview);
}
/// <summary>
/// Mount a shape onto the main shape at the specified node   @param shapePath path to the shape to mount   @param nodeName name of the node on the main shape to mount to   @param type type of mounting to use (Object, Image or Wheel)   @param slot mount slot )
/// </summary>
public  bool mountShape(string guishapeedpreview, string shapePath, string nodeName, string type, int slot){


return m_ts.fnGuiShapeEdPreview_mountShape(guishapeedpreview, shapePath, nodeName, type, slot);
}
/// <summary>
/// Refresh the shape (used when the shape meshes or nodes have been added or removed) )
/// </summary>
public  void refreshShape(string guishapeedpreview){


m_ts.fnGuiShapeEdPreview_refreshShape(guishapeedpreview);
}
/// <summary>
/// Refreshes thread sequences (in case of removed/renamed sequences )
/// </summary>
public  void refreshThreadSequences(string guishapeedpreview){


m_ts.fnGuiShapeEdPreview_refreshThreadSequences(guishapeedpreview);
}
/// <summary>
/// Removes the specifed thread   @param slot index of the thread to remove )
/// </summary>
public  void removeThread(string guishapeedpreview, int slot){


m_ts.fnGuiShapeEdPreview_removeThread(guishapeedpreview, slot);
}
/// <summary>
/// Show or hide all objects in the shape )
/// </summary>
public  void setAllMeshesHidden(string guishapeedpreview, bool hidden){


m_ts.fnGuiShapeEdPreview_setAllMeshesHidden(guishapeedpreview, hidden);
}
/// <summary>
/// Show or hide the named object in the shape )
/// </summary>
public  void setMeshHidden(string guishapeedpreview, string name, bool hidden){


m_ts.fnGuiShapeEdPreview_setMeshHidden(guishapeedpreview, name, hidden);
}
/// <summary>
/// Sets the model to be displayed in this control   @param shapeName Name of the model to display.   @return True if the model was loaded successfully, false otherwise. )
/// </summary>
public  bool setModel(string guishapeedpreview, string shapePath){


return m_ts.fnGuiShapeEdPreview_setModel(guishapeedpreview, shapePath);
}
/// <summary>
/// Set the node a shape is mounted to.   @param slot mounted shape slot   @param nodename name of the node to mount to )
/// </summary>
public  void setMountNode(string guishapeedpreview, int slot, string nodeName){


m_ts.fnGuiShapeEdPreview_setMountNode(guishapeedpreview, slot, nodeName);
}
/// <summary>
/// Set the playback direction of the shape mounted in the specified slot   @param slot mounted shape slot   @param dir playback direction (-1=backwards, 0=paused, 1=forwards) )
/// </summary>
public  void setMountThreadDir(string guishapeedpreview, int slot, float dir){


m_ts.fnGuiShapeEdPreview_setMountThreadDir(guishapeedpreview, slot, dir);
}
/// <summary>
/// Set the sequence position of the shape mounted in the specified slot   @param slot mounted shape slot   @param pos sequence position (0-1) )
/// </summary>
public  void setMountThreadPos(string guishapeedpreview, int slot, float pos){


m_ts.fnGuiShapeEdPreview_setMountThreadPos(guishapeedpreview, slot, pos);
}
/// <summary>
/// Set the sequence to play for the shape mounted in the specified slot   @param slot mounted shape slot   @param name name of the sequence to play )
/// </summary>
public  void setMountThreadSequence(string guishapeedpreview, int slot, string name){


m_ts.fnGuiShapeEdPreview_setMountThreadSequence(guishapeedpreview, slot, name);
}
/// <summary>
/// Set the camera orbit position   @param pos Position in the form \"x y z\" )
/// </summary>
public  void setOrbitPos(string guishapeedpreview, Point3F pos){


m_ts.fnGuiShapeEdPreview_setOrbitPos(guishapeedpreview, pos.AsString());
}
/// <summary>
/// Sets the sequence to play for the active thread.   @param name name of the sequence to play   @param duration transition duration (0 for no transition)   @param pos position in the new sequence to transition to   @param play if true, the new sequence will play during the transition )
/// </summary>
public  void setThreadSequence(string guishapeedpreview, string name, float duration = 0, float pos = 0, bool play = false){


m_ts.fnGuiShapeEdPreview_setThreadSequence(guishapeedpreview, name, duration, pos, play);
}
/// <summary>
/// Set the time scale of all threads   @param scale new time scale value )
/// </summary>
public  void setTimeScale(string guishapeedpreview, float scale){


m_ts.fnGuiShapeEdPreview_setTimeScale(guishapeedpreview, scale);
}
/// <summary>
/// Unmount all shapes )
/// </summary>
public  void unmountAll(string guishapeedpreview){


m_ts.fnGuiShapeEdPreview_unmountAll(guishapeedpreview);
}
/// <summary>
/// Unmount the shape in the specified slot   @param slot mounted shape slot )
/// </summary>
public  void unmountShape(string guishapeedpreview, int slot){


m_ts.fnGuiShapeEdPreview_unmountShape(guishapeedpreview, slot);
}
/// <summary>
/// Refresh the shape node transforms (used when a node transform has been modified externally) )
/// </summary>
public  void updateNodeTransforms(string guishapeedpreview){


m_ts.fnGuiShapeEdPreview_updateNodeTransforms(guishapeedpreview);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiSliderCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiSliderCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Get the current value of the slider based on the position of the thumb.   @return Slider position (from range.x to range.y). )
/// </summary>
public  float getValue(string guisliderctrl){


return m_ts.fnGuiSliderCtrl_getValue(guisliderctrl);
}
/// <summary>
/// Returns true if the thumb is currently being dragged by the user.  This method is mainly useful    for scrubbing type sliders where the slider position is sync'd to a changing value.  When the    user is dragging the thumb, however, the sync'ing should pause and not get in the way of the user. )
/// </summary>
public  bool isThumbBeingDragged(string guisliderctrl){


return m_ts.fnGuiSliderCtrl_isThumbBeingDragged(guisliderctrl);
}
/// <summary>
/// Set position of the thumb on the slider.   @param pos New slider position (from range.x to range.y)   @param doCallback If true, the altCommand callback will be invoked )
/// </summary>
public  void setValue(string guisliderctrl, float pos, bool doCallback = false){


m_ts.fnGuiSliderCtrl_setValue(guisliderctrl, pos, doCallback);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiStackControlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiStackControlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Prevents control from restacking - useful when adding or removing child controls   @param freeze True to freeze the control, false to unfreeze it   @tsexample   %stackCtrl.freeze(true);   // add controls to stack   %stackCtrl.freeze(false);   @endtsexample )
/// </summary>
public  void freeze(string guistackcontrol, bool freeze){


m_ts.fnGuiStackControl_freeze(guistackcontrol, freeze);
}
/// <summary>
/// Return whether or not this control is frozen )
/// </summary>
public  bool isFrozen(string guistackcontrol){


return m_ts.fnGuiStackControl_isFrozen(guistackcontrol);
}
/// <summary>
/// Restack the child controls. )
/// </summary>
public  void updateStack(string guistackcontrol){


m_ts.fnGuiStackControl_updateStack(guistackcontrol);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiSwatchButtonCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiSwatchButtonCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Set the color of the swatch control.   @param newColor The new color string given to the swatch control in float format \"r g b a\".   @note It's also important to note that when setColor is called causes   the control's altCommand field to be executed. )
/// </summary>
public  void setColor(string guiswatchbuttonctrl, string newColor){


m_ts.fnGuiSwatchButtonCtrl_setColor(guiswatchbuttonctrl, newColor);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiTabBookCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiTabBookCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
///  ),   Add a new tab page to the control.   @param title Title text for the tab page header. )
/// </summary>
public  void addPage(string guitabbookctrl, string title = ""){


m_ts.fnGuiTabBookCtrl_addPage(guitabbookctrl, title);
}
/// <summary>
/// Get the index of the currently selected tab page.   @return Index of the selected tab page or -1 if no tab page is selected. )
/// </summary>
public  int getSelectedPage(string guitabbookctrl){


return m_ts.fnGuiTabBookCtrl_getSelectedPage(guitabbookctrl);
}
/// <summary>
/// Set the selected tab page.   @param index Index of the tab page. )
/// </summary>
public  void selectPage(string guitabbookctrl, int index){


m_ts.fnGuiTabBookCtrl_selectPage(guitabbookctrl, index);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiTableControlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiTableControlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// )
/// 
/// </summary>
public  void addChildRow(string guitablecontrol, string text, int index){


m_ts.fnGuiTableControl_addChildRow(guitablecontrol, text, index);
}
/// <summary>
/// )
/// 
/// </summary>
public  void addHeading(string guitablecontrol, string text, int index){


m_ts.fnGuiTableControl_addHeading(guitablecontrol, text, index);
}
/// <summary>
/// )
/// 
/// </summary>
public  void clearChildren(string guitablecontrol){


m_ts.fnGuiTableControl_clearChildren(guitablecontrol);
}
/// <summary>
/// )
/// 
/// </summary>
public  int findColumnTextIndex(string guitablecontrol, int columnId, string columnText){


return m_ts.fnGuiTableControl_findColumnTextIndex(guitablecontrol, columnId, columnText);
}
/// <summary>
/// @brief Returns the selected row index (not the row ID).
///    @tsexample
///    // Acquire the selected row index
///    %rowIndex = %thisGuiTextListCtrl.getSelectedRow();
///    @endtsexample
///    @return Index of the selected row
///    @see GuiControl)
/// 
/// </summary>
public  int getSelectedRow(string guitablecontrol){


return m_ts.fnGuiTableControl_getSelectedRow(guitablecontrol);
}
/// <summary>
/// )
/// 
/// </summary>
public  void setColumnSort(string guitablecontrol, int column, bool ascending){


m_ts.fnGuiTableControl_setColumnSort(guitablecontrol, column, ascending);
}
/// <summary>
/// @briefSelects the specified row.
///    @param rowNum Row number to set selected.
///    @tsexample
///    // Define the row number to set selected
///    %rowNum = \"4\";
///    %guiTextListCtrl.setSelectedRow(%rowNum);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
public  void setSelectedRow(string guitablecontrol, int rowNum){


m_ts.fnGuiTableControl_setSelectedRow(guitablecontrol, rowNum);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiTabPageCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiTabPageCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Select this page in its tab book. )
/// </summary>
public  void select(string guitabpagectrl){


m_ts.fnGuiTabPageCtrl_select(guitabpagectrl);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiTerrPreviewCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiTerrPreviewCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Return a Point2F containing the position of the origin.)
/// </summary>
public  Point2F GuiTerrPreviewCtrl_getOrigin(string guiterrpreviewctrl){


return new Point2F ( m_ts.fn_GuiTerrPreviewCtrl_getOrigin(guiterrpreviewctrl));
}
/// <summary>
/// Return a Point2F representing the position of the root.)
/// </summary>
public  Point2F GuiTerrPreviewCtrl_getRoot(string guiterrpreviewctrl){


return new Point2F ( m_ts.fn_GuiTerrPreviewCtrl_getRoot(guiterrpreviewctrl));
}
/// <summary>
/// Returns a 4-tuple containing: root_x root_y origin_x origin_y)
/// </summary>
public  string GuiTerrPreviewCtrl_getValue(string guiterrpreviewctrl){


return m_ts.fn_GuiTerrPreviewCtrl_getValue(guiterrpreviewctrl);
}
/// <summary>
/// Reset the view of the terrain.)
/// </summary>
public  void GuiTerrPreviewCtrl_reset(string guiterrpreviewctrl){


m_ts.fn_GuiTerrPreviewCtrl_reset(guiterrpreviewctrl);
}
/// <summary>
/// (float x, float y)              Set the origin of the view.)
/// </summary>
public  void GuiTerrPreviewCtrl_setOrigin(string guiterrpreviewctrl, Point2F pos){


m_ts.fn_GuiTerrPreviewCtrl_setOrigin(guiterrpreviewctrl, pos.AsString());
}
/// <summary>
/// Add the origin to the root and reset the origin.)
/// </summary>
public  void GuiTerrPreviewCtrl_setRoot(string guiterrpreviewctrl){


m_ts.fn_GuiTerrPreviewCtrl_setRoot(guiterrpreviewctrl);
}
/// <summary>
/// Accepts a 4-tuple in the same form as getValue returns.              @see GuiTerrPreviewCtrl::getValue())
/// </summary>
public  void GuiTerrPreviewCtrl_setValue(string guiterrpreviewctrl, string tuple){


m_ts.fn_GuiTerrPreviewCtrl_setValue(guiterrpreviewctrl, tuple);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiTextCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiTextCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Sets the text in the control.   @param text Text to display in the control.   @tsexample   // Set the text to show in the control   %text = \"Gideon - Destroyer of World\";   // Inform the GuiTextCtrl control to change its text to the defined value   %thisGuiTextCtrl.setText(%text);   @endtsexample   @see GuiControl)
/// </summary>
public  void setText(string guitextctrl, string text){


m_ts.fnGuiTextCtrl_setText(guitextctrl, text);
}
/// <summary>
/// @brief Maps the text ctrl to a variable used in localization, rather than raw text.   @param textID Name of variable text should be mapped to   @tsexample   // Inform the GuiTextCtrl control of the textID to use   %thisGuiTextCtrl.setTextID(\"STR_QUIT\");   @endtsexample   @see GuiControl   @see Localization)
/// </summary>
public  void setTextID(string guitextctrl, string textID){


m_ts.fnGuiTextCtrl_setTextID(guitextctrl, textID);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiTextEditCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiTextEditCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// textEditCtrl.selectText( %startBlock, %endBlock ) )
/// </summary>
public  void GuiTextEditCtrl_selectText(string guitexteditctrl, int startBlock, int endBlock){


m_ts.fn_GuiTextEditCtrl_selectText(guitexteditctrl, startBlock, endBlock);
}
/// <summary>
/// @brief Unselects all selected text in the control.   @tsexample   // Inform the control to unselect all of its selected text   %thisGuiTextEditCtrl.clearSelectedText();   @endtsexample   @see GuiControl)
/// </summary>
public  void clearSelectedText(string guitexteditctrl){


m_ts.fnGuiTextEditCtrl_clearSelectedText(guitexteditctrl);
}
/// <summary>
/// @brief Force a validation to occur.   @tsexample   // Inform the control to force a validation of its text.   %thisGuiTextEditCtrl.forceValidateText();   @endtsexample   @see GuiControl)
/// </summary>
public  void forceValidateText(string guitexteditctrl){


m_ts.fnGuiTextEditCtrl_forceValidateText(guitexteditctrl);
}
/// <summary>
/// @brief Returns the current position of the text cursor in the control.   @tsexample   // Acquire the cursor position in the control   %position = %thisGuiTextEditCtrl.getCursorPost();   @endtsexample   @return Text cursor position within the control.   @see GuiControl)
/// </summary>
public  int getCursorPos(string guitexteditctrl){


return m_ts.fnGuiTextEditCtrl_getCursorPos(guitexteditctrl);
}
/// <summary>
/// @brief Acquires the current text displayed in this control.   @tsexample   // Acquire the value of the text control.   %text = %thisGuiTextEditCtrl.getText();   @endtsexample   @return The current text within the control.   @see GuiControl)
/// </summary>
public  string getText(string guitexteditctrl){


return m_ts.fnGuiTextEditCtrl_getText(guitexteditctrl);
}
/// <summary>
/// @brief Checks to see if all text in the control has been selected.   @tsexample   // Check to see if all text has been selected or not.   %allSelected = %thisGuiTextEditCtrl.isAllTextSelected();   @endtsexample   @return True if all text in the control is selected, otherwise false.   @see GuiControl)
/// </summary>
public  bool isAllTextSelected(string guitexteditctrl){


return m_ts.fnGuiTextEditCtrl_isAllTextSelected(guitexteditctrl);
}
/// <summary>
/// @brief Selects all text within the control.   @tsexample   // Inform the control to select all of its text.   %thisGuiTextEditCtrl.selectAllText();   @endtsexample   @see GuiControl)
/// </summary>
public  void selectAllText(string guitexteditctrl){


m_ts.fnGuiTextEditCtrl_selectAllText(guitexteditctrl);
}
/// <summary>
/// @brief Sets the text cursor at the defined position within the control.   @param position Text position to set the text cursor.   @tsexample   // Define the cursor position   %position = \"12\";   // Inform the GuiTextEditCtrl control to place the text cursor at the defined position   %thisGuiTextEditCtrl.setCursorPos(%position);   @endtsexample   @see GuiControl)
/// </summary>
public  void setCursorPos(string guitexteditctrl, int position){


m_ts.fnGuiTextEditCtrl_setCursorPos(guitexteditctrl, position);
}
/// <summary>
/// @brief Sets the text in the control.   @param text Text to place in the control.   @tsexample   // Define the text to display   %text = \"Text!\"   // Inform the GuiTextEditCtrl to display the defined text   %thisGuiTextEditCtrl.setText(%text);   @endtsexample   @see GuiControl)
/// </summary>
public  void setText(string guitexteditctrl, string text){


m_ts.fnGuiTextEditCtrl_setText(guitexteditctrl, text);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiTextListCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiTextListCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ,-1),   @brief Adds a new row at end of the list with the defined id and text.   If index is used, then the new row is inserted at the row location of 'index'.   @param id Id of the new row.   @param text Text to display at the new row.   @param index Index to insert the new row at. If not used, new row will be placed at the end of the list.   @tsexample   // Define the id   %id = \"4\";   // Define the text to display   %text = \"Display Text\"   // Define the index (optional)   %index = \"2\"   // Inform the GuiTextListCtrl control to add the new row with the defined information.   %rowIndex = %thisGuiTextListCtrl.addRow(%id,%text,%index);   @endtsexample   @return Returns the row index of the new row. If 'index' was defined, then this just returns the number of rows in the list.   @see References)
/// </summary>
public  int addRow(string guitextlistctrl, int id = 0, string text = "", int index = -1){


return m_ts.fnGuiTextListCtrl_addRow(guitextlistctrl, id, text, index);
}
/// <summary>
/// @brief Clear the list.   @tsexample   // Inform the GuiTextListCtrl control to clear its contents   %thisGuiTextListCtrl.clear();   @endtsexample   @see GuiControl)
/// </summary>
public  void clear(string guitextlistctrl){


m_ts.fnGuiTextListCtrl_clear(guitextlistctrl);
}
/// <summary>
/// @brief Set the selection to nothing.   @tsexample   // Deselect anything that is currently selected   %thisGuiTextListCtrl.clearSelection();   @endtsexample   @see GuiControl)
/// </summary>
public  void clearSelection(string guitextlistctrl){


m_ts.fnGuiTextListCtrl_clearSelection(guitextlistctrl);
}
/// <summary>
/// )
/// </summary>
public  int findColumnTextIndex(string guitextlistctrl, int columnId, string columnText){


return m_ts.fnGuiTextListCtrl_findColumnTextIndex(guitextlistctrl, columnId, columnText);
}
/// <summary>
/// @brief Find needle in the list, and return the row number it was found in.   @param needle Text to find in the list.   @tsexample   // Define the text to find in the list   %needle = \"Text To Find\";   // Request the row number that contains the defined text to find   %rowNumber = %thisGuiTextListCtrl.findTextIndex(%needle);   @endtsexample   @return Row number that the defined text was found in,   @see GuiControl)
/// </summary>
public  int findTextIndex(string guitextlistctrl, string needle){


return m_ts.fnGuiTextListCtrl_findTextIndex(guitextlistctrl, needle);
}
/// <summary>
/// @brief Get the row ID for an index.   @param index Index to get the RowID at   @tsexample   // Define the index   %index = \"3\";   // Request the row ID at the defined index   %rowId = %thisGuiTextListCtrl.getRowId(%index);   @endtsexample   @return RowId at the defined index.   @see GuiControl)
/// </summary>
public  int getRowId(string guitextlistctrl, int index){


return m_ts.fnGuiTextListCtrl_getRowId(guitextlistctrl, index);
}
/// <summary>
/// @brief Get the row number for a specified id.   @param id Id to get the row number at   @tsexample   // Define the id   %id = \"4\";   // Request the row number from the GuiTextListCtrl control at the defined id.   %rowNumber = %thisGuiTextListCtrl.getRowNumById(%id);   @endtsexample   @see GuiControl)
/// </summary>
public  int getRowNumById(string guitextlistctrl, int id){


return m_ts.fnGuiTextListCtrl_getRowNumById(guitextlistctrl, id);
}
/// <summary>
/// @brief Get the text of the row with the specified index.   @param index Row index to acquire the text at.   @tsexample   // Define the row index   %index = \"5\";   // Request the text from the row at the defined index   %rowText = %thisGuiTextListCtrl.getRowText(%index);   @endtsexample   @return Text at the defined row index.   @see GuiControl)
/// </summary>
public  string getRowText(string guitextlistctrl, int index){


return m_ts.fnGuiTextListCtrl_getRowText(guitextlistctrl, index);
}
/// <summary>
/// @brief Get the text of a row with the specified id.   @tsexample   // Define the id   %id = \"4\";   // Inform the GuiTextListCtrl control to return the text at the defined row id   %rowText = %thisGuiTextListCtrl.getRowTextById(%id);   @endtsexample   @return Row text at the requested row id.   @see GuiControl)
/// </summary>
public  string getRowTextById(string guitextlistctrl, int id){


return m_ts.fnGuiTextListCtrl_getRowTextById(guitextlistctrl, id);
}
/// <summary>
/// @brief Get the ID of the currently selected item.   @tsexample   // Acquire the ID of the selected item in the list.   %id = %thisGuiTextListCtrl.getSelectedId();   @endtsexample   @return The id of the selected item in the list.   @see GuiControl)
/// </summary>
public  int getSelectedId(string guitextlistctrl){


return m_ts.fnGuiTextListCtrl_getSelectedId(guitextlistctrl);
}
/// <summary>
/// @brief Returns the selected row index (not the row ID).   @tsexample   // Acquire the selected row index   %rowIndex = %thisGuiTextListCtrl.getSelectedRow();   @endtsexample   @return Index of the selected row   @see GuiControl)
/// </summary>
public  int getSelectedRow(string guitextlistctrl){


return m_ts.fnGuiTextListCtrl_getSelectedRow(guitextlistctrl);
}
/// <summary>
/// @brief Check if the specified row is currently active or not.   @param rowNum Row number to check the active state.   @tsexample   // Define the row number   %rowNum = \"5\";   // Request the active state of the defined row number from the GuiTextListCtrl control.   %rowActiveState = %thisGuiTextListCtrl.isRowActive(%rowNum);   @endtsexample   @return Active state of the defined row number.   @see GuiControl)
/// </summary>
public  bool isRowActive(string guitextlistctrl, int rowNum){


return m_ts.fnGuiTextListCtrl_isRowActive(guitextlistctrl, rowNum);
}
/// <summary>
/// @brief Remove a row from the table, based on its index.   @param index Row index to remove from the list.   @tsexample   // Define the row index   %index = \"4\";   // Inform the GuiTextListCtrl control to remove the row at the defined row index   %thisGuiTextListCtrl.removeRow(%index);   @endtsexample   @see GuiControl)
/// </summary>
public  void removeRow(string guitextlistctrl, int index){


m_ts.fnGuiTextListCtrl_removeRow(guitextlistctrl, index);
}
/// <summary>
/// @brief Remove row with the specified id.   @param id Id to remove the row entry at   @tsexample   // Define the id   %id = \"4\";   // Inform the GuiTextListCtrl control to remove the row at the defined id   %thisGuiTextListCtrl.removeRowById(%id);   @endtsexample   @see GuiControl)
/// </summary>
public  void removeRowById(string guitextlistctrl, int id){


m_ts.fnGuiTextListCtrl_removeRowById(guitextlistctrl, id);
}
/// <summary>
/// @brief Get the number of rows.   @tsexample   // Get the number of rows in the list   %rowCount = %thisGuiTextListCtrl.rowCount();   @endtsexample   @return Number of rows in the list.   @see GuiControl)
/// </summary>
public  int rowCount(string guitextlistctrl){


return m_ts.fnGuiTextListCtrl_rowCount(guitextlistctrl);
}
/// <summary>
/// @brief Scroll so the specified row is visible   @param rowNum Row number to make visible   @tsexample   // Define the row number to make visible   %rowNum = \"4\";   // Inform the GuiTextListCtrl control to scroll the list so the defined rowNum is visible.   %thisGuiTextListCtrl.scrollVisible(%rowNum);   @endtsexample   @see GuiControl)
/// </summary>
public  void scrollVisible(string guitextlistctrl, int rowNum){


m_ts.fnGuiTextListCtrl_scrollVisible(guitextlistctrl, rowNum);
}
/// <summary>
/// @brief Mark a specified row as active/not.   @param rowNum Row number to change the active state.   @param active Boolean active state to set the row number.   @tsexample   // Define the row number   %rowNum = \"4\";   // Define the boolean active state   %active = \"true\";   // Informthe GuiTextListCtrl control to set the defined active state at the defined row number.   %thisGuiTextListCtrl.setRowActive(%rowNum,%active);   @endtsexample   @see GuiControl)
/// </summary>
public  void setRowActive(string guitextlistctrl, int rowNum, bool active){


m_ts.fnGuiTextListCtrl_setRowActive(guitextlistctrl, rowNum, active);
}
/// <summary>
/// @brief Sets the text at the defined id.   @param id Id to change.   @param text Text to use at the Id.   @tsexample   // Define the id   %id = \"4\";   // Define the text   %text = \"Text To Display\";   // Inform the GuiTextListCtrl control to display the defined text at the defined id   %thisGuiTextListCtrl.setRowById(%id,%text);   @endtsexample   @see GuiControl)
/// </summary>
public  void setRowById(string guitextlistctrl, int id, string text){


m_ts.fnGuiTextListCtrl_setRowById(guitextlistctrl, id, text);
}
/// <summary>
/// @brief Finds the specified entry by id, then marks its row as selected.   @param id Entry within the text list to make selected.   @tsexample   // Define the id   %id = \"5\";   // Inform the GuiTextListCtrl control to set the defined id entry as selected   %thisGuiTextListCtrl.setSelectedById(%id);   @endtsexample   @see GuiControl)
/// </summary>
public  void setSelectedById(string guitextlistctrl, int id){


m_ts.fnGuiTextListCtrl_setSelectedById(guitextlistctrl, id);
}
/// <summary>
/// @briefSelects the specified row.   @param rowNum Row number to set selected.   @tsexample   // Define the row number to set selected   %rowNum = \"4\";   %guiTextListCtrl.setSelectedRow(%rowNum);   @endtsexample   @see GuiControl)
/// </summary>
public  void setSelectedRow(string guitextlistctrl, int rowNum){


m_ts.fnGuiTextListCtrl_setSelectedRow(guitextlistctrl, rowNum);
}
/// <summary>
/// @brief Performs a standard (alphabetical) sort on the values in the specified column.   @param columnId Column ID to perform the sort on.   @param increasing If false, sort will be performed in reverse.   @tsexample   // Define the columnId   %id = \"1\";   // Define if we are increasing or not   %increasing = \"false\";   // Inform the GuiTextListCtrl to perform the sort operation   %thisGuiTextListCtrl.sort(%id,%increasing);   @endtsexample   @see GuiControl)
/// </summary>
public  void sort(string guitextlistctrl, int columnId, bool increasing = true){


m_ts.fnGuiTextListCtrl_sort(guitextlistctrl, columnId, increasing);
}
/// <summary>
/// @brief Perform a numerical sort on the values in the specified column.   Detailed description   @param columnId Column ID to perform the sort on.   @param increasing If false, sort will be performed in reverse.   @tsexample   // Define the columnId   %id = \"1\";   // Define if we are increasing or not   %increasing = \"false\";   // Inform the GuiTextListCtrl to perform the sort operation   %thisGuiTextListCtrl.sortNumerical(%id,%increasing);   @endtsexample   @see GuiControl)
/// </summary>
public  void sortNumerical(string guitextlistctrl, int columnID, bool increasing = true){


m_ts.fnGuiTextListCtrl_sortNumerical(guitextlistctrl, columnID, increasing);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiTheoraCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiTheoraCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Get the current playback time.   @return The elapsed playback time in seconds. )
/// </summary>
public  float getCurrentTime(string guitheoractrl){


return m_ts.fnGuiTheoraCtrl_getCurrentTime(guitheoractrl);
}
/// <summary>
/// Test whether the video has finished playing.   @return True if the video has finished playing, false otherwise. )
/// </summary>
public  bool isPlaybackDone(string guitheoractrl){


return m_ts.fnGuiTheoraCtrl_isPlaybackDone(guitheoractrl);
}
/// <summary>
/// Pause playback of the video.  If the video is not currently playing, the call is ignored.   While stopped, the control displays the last frame. )
/// </summary>
public  void pause(string guitheoractrl){


m_ts.fnGuiTheoraCtrl_pause(guitheoractrl);
}
/// <summary>
/// Start playing the video.  If the video is already playing, the call is ignored. )
/// </summary>
public  void play(string guitheoractrl){


m_ts.fnGuiTheoraCtrl_play(guitheoractrl);
}
/// <summary>
/// Set the video file to play.  If a video is already playing, playback is stopped and    the new video file is loaded.   @param filename The video file to load. )
/// </summary>
public  void setFile(string guitheoractrl, string filename){


m_ts.fnGuiTheoraCtrl_setFile(guitheoractrl, filename);
}
/// <summary>
/// Stop playback of the video.  The next call to play() will then start playback from the beginning of the video.   While stopped, the control renders empty with just the background color. )
/// </summary>
public  void stop(string guitheoractrl){


m_ts.fnGuiTheoraCtrl_stop(guitheoractrl);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiTickCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiTickCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( [tick = true] ) - This will set this object to either be processing ticks or not )
/// </summary>
public  void GuiTickCtrl_setProcessTicks(string guitickctrl, bool tick = true){


m_ts.fn_GuiTickCtrl_setProcessTicks(guitickctrl, tick);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiToolboxButtonCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiToolboxButtonCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( filepath name ) sets the bitmap that shows when the button is disabled)
/// </summary>
public  void GuiToolboxButtonCtrl_setHoverBitmap(string guitoolboxbuttonctrl, string name){


m_ts.fn_GuiToolboxButtonCtrl_setHoverBitmap(guitoolboxbuttonctrl, name);
}
/// <summary>
/// ( filepath name ) sets the bitmap that shows when the button is disabled)
/// </summary>
public  void GuiToolboxButtonCtrl_setLoweredBitmap(string guitoolboxbuttonctrl, string name){


m_ts.fn_GuiToolboxButtonCtrl_setLoweredBitmap(guitoolboxbuttonctrl, name);
}
/// <summary>
/// ( filepath name ) sets the bitmap that shows when the button is active)
/// </summary>
public  void GuiToolboxButtonCtrl_setNormalBitmap(string guitoolboxbuttonctrl, string name){


m_ts.fn_GuiToolboxButtonCtrl_setNormalBitmap(guitoolboxbuttonctrl, name);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiTreeViewCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiTreeViewCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// addChildSelectionByValue(TreeItemId parent, value))
/// </summary>
public  void GuiTreeViewCtrl_addChildSelectionByValue(string guitreeviewctrl, int id, string tableEntry){


m_ts.fn_GuiTreeViewCtrl_addChildSelectionByValue(guitreeviewctrl, id, tableEntry);
}
/// <summary>
/// (builds an icon table))
/// </summary>
public  bool GuiTreeViewCtrl_buildIconTable(string guitreeviewctrl, string icons){


return m_ts.fn_GuiTreeViewCtrl_buildIconTable(guitreeviewctrl, icons);
}
/// <summary>
/// Build the visible tree)
/// </summary>
public  void GuiTreeViewCtrl_buildVisibleTree(string guitreeviewctrl, bool forceFullUpdate = false){


m_ts.fn_GuiTreeViewCtrl_buildVisibleTree(guitreeviewctrl, forceFullUpdate);
}
/// <summary>
/// For internal use. )
/// </summary>
public  void GuiTreeViewCtrl_cancelRename(string guitreeviewctrl){


m_ts.fn_GuiTreeViewCtrl_cancelRename(guitreeviewctrl);
}
/// <summary>
/// () - empty tree)
/// </summary>
public  void GuiTreeViewCtrl_clear(string guitreeviewctrl){


m_ts.fn_GuiTreeViewCtrl_clear(guitreeviewctrl);
}
/// <summary>
/// (TreeItemId item, string newText, string newValue))
/// </summary>
public  bool GuiTreeViewCtrl_editItem(string guitreeviewctrl, int item, string newText, string newValue){


return m_ts.fn_GuiTreeViewCtrl_editItem(guitreeviewctrl, item, newText, newValue);
}
/// <summary>
/// (TreeItemId item, bool expand=true))
/// </summary>
public  bool GuiTreeViewCtrl_expandItem(string guitreeviewctrl, int id, bool expand = true){


return m_ts.fn_GuiTreeViewCtrl_expandItem(guitreeviewctrl, id, expand);
}
/// <summary>
/// (find item by object id and returns the mId))
/// </summary>
public  int GuiTreeViewCtrl_findItemByObjectId(string guitreeviewctrl, int itemId){


return m_ts.fn_GuiTreeViewCtrl_findItemByObjectId(guitreeviewctrl, itemId);
}
/// <summary>
/// (TreeItemId item))
/// </summary>
public  int GuiTreeViewCtrl_getChild(string guitreeviewctrl, int itemId){


return m_ts.fn_GuiTreeViewCtrl_getChild(guitreeviewctrl, itemId);
}
/// <summary>
/// Get id for root item.)
/// </summary>
public  int GuiTreeViewCtrl_getFirstRootItem(string guitreeviewctrl){


return m_ts.fn_GuiTreeViewCtrl_getFirstRootItem(guitreeviewctrl);
}
/// <summary>
/// )
/// </summary>
public  int GuiTreeViewCtrl_getItemCount(string guitreeviewctrl){


return m_ts.fn_GuiTreeViewCtrl_getItemCount(guitreeviewctrl);
}
/// <summary>
/// (TreeItemId item))
/// </summary>
public  string GuiTreeViewCtrl_getItemText(string guitreeviewctrl, int index){


return m_ts.fn_GuiTreeViewCtrl_getItemText(guitreeviewctrl, index);
}
/// <summary>
/// (TreeItemId item))
/// </summary>
public  string GuiTreeViewCtrl_getItemValue(string guitreeviewctrl, int itemId){


return m_ts.fn_GuiTreeViewCtrl_getItemValue(guitreeviewctrl, itemId);
}
/// <summary>
/// (TreeItemId item))
/// </summary>
public  int GuiTreeViewCtrl_getNextSibling(string guitreeviewctrl, int itemId){


return m_ts.fn_GuiTreeViewCtrl_getNextSibling(guitreeviewctrl, itemId);
}
/// <summary>
/// (TreeItemId item))
/// </summary>
public  int GuiTreeViewCtrl_getParentItem(string guitreeviewctrl, int itemId){


return m_ts.fn_GuiTreeViewCtrl_getParentItem(guitreeviewctrl, itemId);
}
/// <summary>
/// (TreeItemId item))
/// </summary>
public  int GuiTreeViewCtrl_getPrevSibling(string guitreeviewctrl, int itemId){


return m_ts.fn_GuiTreeViewCtrl_getPrevSibling(guitreeviewctrl, itemId);
}
/// <summary>
/// ( int index=0 ) - Return the selected item at the given index.)
/// </summary>
public  int GuiTreeViewCtrl_getSelectedItem(string guitreeviewctrl, int index = 0){


return m_ts.fn_GuiTreeViewCtrl_getSelectedItem(guitreeviewctrl, index);
}
/// <summary>
/// returns a space seperated list of mulitple item ids)
/// </summary>
public  string GuiTreeViewCtrl_getSelectedItemList(string guitreeviewctrl){


return m_ts.fn_GuiTreeViewCtrl_getSelectedItemList(guitreeviewctrl);
}
/// <summary>
/// )
/// </summary>
public  int GuiTreeViewCtrl_getSelectedItemsCount(string guitreeviewctrl){


return m_ts.fn_GuiTreeViewCtrl_getSelectedItemsCount(guitreeviewctrl);
}
/// <summary>
/// ( int index=0 ) - Return the currently selected SimObject at the given index in inspector mode or -1)
/// </summary>
public  int GuiTreeViewCtrl_getSelectedObject(string guitreeviewctrl, int index = 0){


return m_ts.fn_GuiTreeViewCtrl_getSelectedObject(guitreeviewctrl, index);
}
/// <summary>
/// Returns a space sperated list of all selected object ids.)
/// </summary>
public  string GuiTreeViewCtrl_getSelectedObjectList(string guitreeviewctrl){


return m_ts.fn_GuiTreeViewCtrl_getSelectedObjectList(guitreeviewctrl);
}
/// <summary>
/// (TreeItemId item,Delimiter=none) gets the text from the current node to the root, concatenating at each branch upward, with a specified delimiter optionally)
/// </summary>
public  string GuiTreeViewCtrl_getTextToRoot(string guitreeviewctrl, int itemId, string delimiter){


return m_ts.fn_GuiTreeViewCtrl_getTextToRoot(guitreeviewctrl, itemId, delimiter);
}
/// <summary>
/// ( int id ) - Returns true if the given item contains child items. )
/// </summary>
public  bool GuiTreeViewCtrl_isParentItem(string guitreeviewctrl, int id){


return m_ts.fn_GuiTreeViewCtrl_isParentItem(guitreeviewctrl, id);
}
/// <summary>
/// (TreeItemId item, bool mark=true))
/// </summary>
public  bool GuiTreeViewCtrl_markItem(string guitreeviewctrl, int id, bool mark = true){


return m_ts.fn_GuiTreeViewCtrl_markItem(guitreeviewctrl, id, mark);
}
/// <summary>
/// (TreeItemId item))
/// </summary>
public  void GuiTreeViewCtrl_moveItemDown(string guitreeviewctrl, int index){


m_ts.fn_GuiTreeViewCtrl_moveItemDown(guitreeviewctrl, index);
}
/// <summary>
/// (TreeItemId item))
/// </summary>
public  void GuiTreeViewCtrl_moveItemUp(string guitreeviewctrl, int index){


m_ts.fn_GuiTreeViewCtrl_moveItemUp(guitreeviewctrl, index);
}
/// <summary>
/// For internal use. )
/// </summary>
public  void GuiTreeViewCtrl_onRenameValidate(string guitreeviewctrl){


m_ts.fn_GuiTreeViewCtrl_onRenameValidate(guitreeviewctrl);
}
/// <summary>
/// (SimSet obj, bool okToEdit=true) Set the root of the tree view to the specified object, or to the root set.)
/// </summary>
public  void GuiTreeViewCtrl_open(string guitreeviewctrl, string objName, bool okToEdit = true){


m_ts.fn_GuiTreeViewCtrl_open(guitreeviewctrl, objName, okToEdit);
}
/// <summary>
/// removeAllChildren(TreeItemId parent))
/// </summary>
public  void GuiTreeViewCtrl_removeAllChildren(string guitreeviewctrl, int itemId){


m_ts.fn_GuiTreeViewCtrl_removeAllChildren(guitreeviewctrl, itemId);
}
/// <summary>
/// removeChildSelectionByValue(TreeItemId parent, value))
/// </summary>
public  void GuiTreeViewCtrl_removeChildSelectionByValue(string guitreeviewctrl, int id, string tableEntry){


m_ts.fn_GuiTreeViewCtrl_removeChildSelectionByValue(guitreeviewctrl, id, tableEntry);
}
/// <summary>
/// (TreeItemId item))
/// </summary>
public  bool GuiTreeViewCtrl_removeItem(string guitreeviewctrl, int itemId){


return m_ts.fn_GuiTreeViewCtrl_removeItem(guitreeviewctrl, itemId);
}
/// <summary>
/// (deselects an item))
/// </summary>
public  void GuiTreeViewCtrl_removeSelection(string guitreeviewctrl, int id){


m_ts.fn_GuiTreeViewCtrl_removeSelection(guitreeviewctrl, id);
}
/// <summary>
/// (TreeItemId item))
/// </summary>
public  void GuiTreeViewCtrl_scrollVisible(string guitreeviewctrl, int itemId){


m_ts.fn_GuiTreeViewCtrl_scrollVisible(guitreeviewctrl, itemId);
}
/// <summary>
/// (show item by object id. returns true if sucessful.))
/// </summary>
public  int GuiTreeViewCtrl_scrollVisibleByObjectId(string guitreeviewctrl, int itemId){


return m_ts.fn_GuiTreeViewCtrl_scrollVisibleByObjectId(guitreeviewctrl, itemId);
}
/// <summary>
/// (TreeItemId item, bool select=true))
/// </summary>
public  bool GuiTreeViewCtrl_selectItem(string guitreeviewctrl, int id, bool select = true){


return m_ts.fn_GuiTreeViewCtrl_selectItem(guitreeviewctrl, id, select);
}
/// <summary>
/// ( bool value=true ) - Enable/disable debug output. )
/// </summary>
public  void GuiTreeViewCtrl_setDebug(string guitreeviewctrl, bool value = true){


m_ts.fn_GuiTreeViewCtrl_setDebug(guitreeviewctrl, value);
}
/// <summary>
/// ( int id, int normalImage, int expandedImage ) - Sets the normal and expanded images to show for the given item. )
/// </summary>
public  void GuiTreeViewCtrl_setItemImages(string guitreeviewctrl, int id, sbyte normalImage, sbyte expandedImage){


m_ts.fn_GuiTreeViewCtrl_setItemImages(guitreeviewctrl, id, normalImage, expandedImage);
}
/// <summary>
/// ( int id, string text ) - Set the tooltip to show for the given item. )
/// </summary>
public  void GuiTreeViewCtrl_setItemTooltip(string guitreeviewctrl, int id, string text){


m_ts.fn_GuiTreeViewCtrl_setItemTooltip(guitreeviewctrl, id, text);
}
/// <summary>
/// ( TreeItemId id ) - Show the rename text field for the given item (only one at a time). )
/// </summary>
public  void GuiTreeViewCtrl_showItemRenameCtrl(string guitreeviewctrl, int id){


m_ts.fn_GuiTreeViewCtrl_showItemRenameCtrl(guitreeviewctrl, id);
}
/// <summary>
/// ( int parent, bool traverseHierarchy=false, bool parentsFirst=false, bool caseSensitive=true ) - Sorts all items of the given parent (or root).  With 'hierarchy', traverses hierarchy. )
/// </summary>
public  void GuiTreeViewCtrl_sort(string guitreeviewctrl, int parent = 0, bool traverseHierarchy = false, bool parentsFirst = false, bool caseSensitive = true){


m_ts.fn_GuiTreeViewCtrl_sort(guitreeviewctrl, parent, traverseHierarchy, parentsFirst, caseSensitive);
}
/// <summary>
/// Add an item/object to the current selection.   @param id ID of item/object to add to the selection.   @param isLastSelection Whether there are more pending items/objects to be added to the selection.  If false,       the control will defer refreshing the tree and wait until addSelection() is called with this parameter set       to true. )
/// </summary>
public  void addSelection(string guitreeviewctrl, int id, bool isLastSelection = true){


m_ts.fnGuiTreeViewCtrl_addSelection(guitreeviewctrl, id, isLastSelection);
}
/// <summary>
/// Clear the current item filtering pattern.   @see setFilterText   @see getFilterText )
/// </summary>
public  void clearFilterText(string guitreeviewctrl){


m_ts.fnGuiTreeViewCtrl_clearFilterText(guitreeviewctrl);
}
/// <summary>
/// Unselect all currently selected items. )
/// </summary>
public  void clearSelection(string guitreeviewctrl){


m_ts.fnGuiTreeViewCtrl_clearSelection(guitreeviewctrl);
}
/// <summary>
/// Delete all items/objects in the current selection. )
/// </summary>
public  void deleteSelection(string guitreeviewctrl){


m_ts.fnGuiTreeViewCtrl_deleteSelection(guitreeviewctrl);
}
/// <summary>
/// Get the child item of the given parent item whose text matches @a childName.   @param parentId Item ID of the parent in which to look for the child.   @param childName Text of the child item to find.   @return ID of the child item or -1 if no child in @a parentId has the given text @a childName.   @note This method does not recurse, i.e. it only looks for direct children. )
/// </summary>
public  int findChildItemByName(string guitreeviewctrl, int parentId, string childName){


return m_ts.fnGuiTreeViewCtrl_findChildItemByName(guitreeviewctrl, parentId, childName);
}
/// <summary>
/// Get the ID of the item whose text matches the given @a text.   @param text Item text to match.   @return ID of the item or -1 if no item matches the given text. )
/// </summary>
public  int findItemByName(string guitreeviewctrl, string text){


return m_ts.fnGuiTreeViewCtrl_findItemByName(guitreeviewctrl, text);
}
/// <summary>
/// Get the ID of the item whose value matches @a value.   @param value Value text to match.   @return ID of the item or -1 if no item has the given value. )
/// </summary>
public  int findItemByValue(string guitreeviewctrl, string value){


return m_ts.fnGuiTreeViewCtrl_findItemByValue(guitreeviewctrl, value);
}
/// <summary>
/// Get the current filter expression.  Only tree items whose text matches this expression    are displayed.  By default, the expression is empty and all items are shown.   @return The current filter pattern or an empty string if no filter pattern is currently active.   @see setFilterText   @see clearFilterText )
/// </summary>
public  string getFilterText(string guitreeviewctrl){


return m_ts.fnGuiTreeViewCtrl_getFilterText(guitreeviewctrl);
}
/// <summary>
/// Call SimObject::setHidden( @a state ) on all objects in the current selection.   @param state Visibility state to set objects in selection to. )
/// </summary>
public  void hideSelection(string guitreeviewctrl, bool state = true){


m_ts.fnGuiTreeViewCtrl_hideSelection(guitreeviewctrl, state);
}
/// <summary>
/// , , 0, 0 ),   Add a new item to the tree.   @param parentId Item ID of parent to which to add the item as a child.  0 is root item.   @param text Text to display on the item in the tree.   @param value Behind-the-scenes value of the item.   @param icon   @param normalImage   @param expandedImage   @return The ID of the newly added item. )
/// </summary>
public  int insertItem(string guitreeviewctrl, int parentId, string text, string value = "", string icon = "", int normalImage = 0, int expandedImage = 0){


return m_ts.fnGuiTreeViewCtrl_insertItem(guitreeviewctrl, parentId, text, value, icon, normalImage, expandedImage);
}
/// <summary>
/// Inserts object as a child to the given parent. )
/// </summary>
public  int insertObject(string guitreeviewctrl, int parentId, string obj, bool OKToEdit = false){


return m_ts.fnGuiTreeViewCtrl_insertObject(guitreeviewctrl, parentId, obj, OKToEdit);
}
/// <summary>
/// Check whether the given item is currently selected in the tree.   @param id Item/object ID.   @return True if the given item/object is currently selected in the tree. )
/// </summary>
public  bool isItemSelected(string guitreeviewctrl, int id){


return m_ts.fnGuiTreeViewCtrl_isItemSelected(guitreeviewctrl, id);
}
/// <summary>
/// Set whether the current selection can be changed by the user or not.   @param lock If true, the current selection is frozen and cannot be changed.  If false,       the selection may be modified. )
/// </summary>
public  void lockSelection(string guitreeviewctrl, bool lockx = true){


m_ts.fnGuiTreeViewCtrl_lockSelection(guitreeviewctrl, lockx);
}
/// <summary>
/// Set the pattern by which to filter items in the tree.  Only items in the tree whose text    matches this pattern are displayed.   @param pattern New pattern based on which visible items in the tree should be filtered.  If empty, all items become visible.   @see getFilterText   @see clearFilterText )
/// </summary>
public  void setFilterText(string guitreeviewctrl, string pattern){


m_ts.fnGuiTreeViewCtrl_setFilterText(guitreeviewctrl, pattern);
}
/// <summary>
/// Toggle the hidden state of all objects in the current selection. )
/// </summary>
public  void toggleHideSelection(string guitreeviewctrl){


m_ts.fnGuiTreeViewCtrl_toggleHideSelection(guitreeviewctrl);
}
/// <summary>
/// Toggle the locked state of all objects in the current selection. )
/// </summary>
public  void toggleLockSelection(string guitreeviewctrl){


m_ts.fnGuiTreeViewCtrl_toggleLockSelection(guitreeviewctrl);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiTSCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiTSCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Given the camera's current FOV, get the distance from the camera's viewpoint at which the given radius will fit in the render area.   @param radius Radius in world-space units which should fit in the view.   @return The distance from the viewpoint at which the given radius would be fully visible. )
/// </summary>
public  float calculateViewDistance(string guitsctrl, float radius){


return m_ts.fnGuiTSCtrl_calculateViewDistance(guitsctrl, radius);
}
/// <summary>
/// )
/// </summary>
public  string getClickVector(string guitsctrl, Point2I mousePoint){


return m_ts.fnGuiTSCtrl_getClickVector(guitsctrl, mousePoint.AsString());
}
/// <summary>
/// )
/// </summary>
public  string getWorldPosition(string guitsctrl, Point2I mousePoint){


return m_ts.fnGuiTSCtrl_getWorldPosition(guitsctrl, mousePoint.AsString());
}
/// <summary>
/// Get the ratio between world-space units and pixels.   @return The amount of world-space units covered by the extent of a single pixel. )
/// </summary>
public  Point2F getWorldToScreenScale(string guitsctrl){


return new Point2F ( m_ts.fnGuiTSCtrl_getWorldToScreenScale(guitsctrl));
}
/// <summary>
/// Transform world-space coordinates to screen-space (x, y, depth) coordinates.   @param worldPosition The world-space position to transform to screen-space.   @return The  )
/// </summary>
public  Point3F project(string guitsctrl, Point3F worldPosition){


return new Point3F ( m_ts.fnGuiTSCtrl_project(guitsctrl, worldPosition.AsString()));
}
/// <summary>
/// Transform 3D screen-space coordinates (x, y, depth) to world space.   This method can be, for example, used to find the world-space position relating to the current mouse cursor position.   @param screenPosition The x/y position on the screen plus the depth from the screen-plane outwards.   @return The world-space position corresponding to the given screen-space coordinates. )
/// </summary>
public  Point3F unproject(string guitsctrl, Point3F screenPosition){


return new Point3F ( m_ts.fnGuiTSCtrl_unproject(guitsctrl, screenPosition.AsString()));
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiVariableInspectorObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiVariableInspectorObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// loadVars( searchString ) )
/// </summary>
public  void GuiVariableInspector_loadVars(string guivariableinspector, string searchString){


m_ts.fn_GuiVariableInspector_loadVars(guivariableinspector, searchString);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class GuiWindowCtrlObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public GuiWindowCtrlObject(ref Omni ts){m_ts = ts;}
/// <summary>
///  )
/// </summary>
public  void attachTo(string guiwindowctrl, string window){


m_ts.fnGuiWindowCtrl_attachTo(guiwindowctrl, window);
}
/// <summary>
/// Puts the guiwindow back on the main canvas. )
/// </summary>
public  void ClosePopOut(string guiwindowctrl){


m_ts.fnGuiWindowCtrl_ClosePopOut(guiwindowctrl);
}
/// <summary>
/// Returns the title of the window. )
/// </summary>
public  string getWindowTitle(string guiwindowctrl){


return m_ts.fnGuiWindowCtrl_getWindowTitle(guiwindowctrl);
}
/// <summary>
/// Returns if the title can be set or not. )
/// </summary>
public  bool isTitleSet(string guiwindowctrl){


return m_ts.fnGuiWindowCtrl_isTitleSet(guiwindowctrl);
}
/// <summary>
/// Puts the guiwindow on a new canvas. )
/// </summary>
public  void OpenPopOut(string guiwindowctrl){


m_ts.fnGuiWindowCtrl_OpenPopOut(guiwindowctrl);
}
/// <summary>
/// Bring the window to the front. )
/// </summary>
public  void selectWindow(string guiwindowctrl){


m_ts.fnGuiWindowCtrl_selectWindow(guiwindowctrl);
}
/// <summary>
/// Set the window's collapsing state. )
/// </summary>
public  void setCollapseGroup(string guiwindowctrl, bool state){


m_ts.fnGuiWindowCtrl_setCollapseGroup(guiwindowctrl, state);
}
/// <summary>
/// Displays the option to set the title of the window. )
/// </summary>
public  void setContextTitle(string guiwindowctrl, bool title){


m_ts.fnGuiWindowCtrl_setContextTitle(guiwindowctrl, title);
}
/// <summary>
/// Sets the title of the window. )
/// </summary>
public  void setWindowTitle(string guiwindowctrl, string title){


m_ts.fnGuiWindowCtrl_setWindowTitle(guiwindowctrl, title);
}
/// <summary>
/// Toggle the window collapsing. )
/// </summary>
public  void toggleCollapseGroup(string guiwindowctrl){


m_ts.fnGuiWindowCtrl_toggleCollapseGroup(guiwindowctrl);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class HTTPObjectObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public HTTPObjectObject(ref Omni ts){m_ts = ts;}
/// <summary>
///  ),   @brief Send a GET command to a server to send or retrieve data.   @param Address HTTP web address to send this get call to. Be sure to include the port at the end (IE: \"www.garagegames.com:80\").   @param requirstURI Specific location on the server to access (IE: \"index.php\".)   @param query Optional. Actual data to transmit to the server. Can be anything required providing it sticks with limitations of the HTTP protocol.    If you were building the URL manually, this is the text that follows the question mark.  For example: http://www.google.com/ig/api?b>weather=Las-Vegas,US/b>      @tsexample	   // Create an HTTP object for communications	   %httpObj = new HTTPObject();	   // Specify a URL to transmit to      %url = \"www.garagegames.com:80\";	   // Specify a URI to communicate with	   %URI = \"/index.php\";	   // Specify a query to send.	   %query = \"\";	   // Send the GET command to the server	   %httpObj.get(%url,%URI,%query);   @endtsexample   )
/// </summary>
public  void get(string httpobject, string Address, string requirstURI, string query = ""){


m_ts.fnHTTPObject_get(httpobject, Address, requirstURI, query);
}
/// <summary>
/// @brief Send POST command to a server to send or retrieve data.   @param Address HTTP web address to send this get call to. Be sure to include the port at the end (IE: \"www.garagegames.com:80\").   @param requirstURI Specific location on the server to access (IE: \"index.php\".)   @param query Actual data to transmit to the server. Can be anything required providing it sticks with limitations of the HTTP protocol.    @param post Submission data to be processed.      @note The post() method is currently non-functional.   @tsexample	   // Create an HTTP object for communications	   %httpObj = new HTTPObject();	   // Specify a URL to transmit to      %url = \"www.garagegames.com:80\";	   // Specify a URI to communicate with	   %URI = \"/index.php\";	   // Specify a query to send.	   %query = \"\";	   // Specify the submission data.	   %post = \"\";	   // Send the POST command to the server	   %httpObj.POST(%url,%URI,%query,%post);   @endtsexample   )
/// </summary>
public  void post(string httpobject, string Address, string requirstURI, string query, string post){


m_ts.fnHTTPObject_post(httpobject, Address, requirstURI, query, post);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ItemObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ItemObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Get the normal of the surface on which the object is stuck.      @return Returns The XYZ normal from where this Item is stuck.   @tsexample	   // Acquire the position where this Item is currently stuck	   %stuckPosition = %item.getLastStickPos();   @endtsexample   @note Server side only.   )
/// </summary>
public  string getLastStickyNormal(string item){


return m_ts.fnItem_getLastStickyNormal(item);
}
/// <summary>
/// @brief Get the position on the surface on which this Item is stuck.      @return Returns The XYZ position of where this Item is stuck.   @tsexample	   // Acquire the position where this Item is currently stuck	   %stuckPosition = %item.getLastStickPos();   @endtsexample   @note Server side only.   )
/// </summary>
public  string getLastStickyPos(string item){


return m_ts.fnItem_getLastStickyPos(item);
}
/// <summary>
/// @brief Is the object at rest (ie, no longer moving)?      @return True if the object is at rest, false if it is not.   @tsexample	   // Query the item on if it is or is not at rest.	   %isAtRest = %item.isAtRest();   @endtsexample   )
/// </summary>
public  bool isAtRest(string item){


return m_ts.fnItem_isAtRest(item);
}
/// <summary>
/// @brief Is the object still rotating?      @return True if the object is still rotating, false if it is not.   @tsexample	   // Query the item on if it is or is not rotating.	   %isRotating = %itemData.isRotating();   @endtsexample   @see rotate   )
/// </summary>
public  bool isRotating(string item){


return m_ts.fnItem_isRotating(item);
}
/// <summary>
/// @brief Is the object static (ie, non-movable)?      @return True if the object is static, false if it is not.   @tsexample	   // Query the item on if it is or is not static.	   %isStatic = %itemData.isStatic();   @endtsexample   @see static   )
/// </summary>
public  bool isStatic(string item){


return m_ts.fnItem_isStatic(item);
}
/// <summary>
/// @brief Temporarily disable collisions against a specific ShapeBase object.   This is useful to prevent a player from immediately picking up an Item they have    just thrown.  Only one object may be on the timeout list at a time.  The timeout is    defined as 15 ticks.   @param objectID ShapeBase object ID to disable collisions against.   @return Returns true if the ShapeBase object requested could be found, false if it could not.   @tsexample	   // Set the ShapeBase Object ID to disable collisions against	   %ignoreColObj = %player.getID();	   // Inform this Item object to ignore collisions temproarily against the %ignoreColObj.	   %item.setCollisionTimeout(%ignoreColObj);   @endtsexample   )
/// </summary>
public  bool setCollisionTimeout(string item, int ignoreColObj){


return m_ts.fnItem_setCollisionTimeout(item, ignoreColObj);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class LangTableObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public LangTableObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// , ), 			  (string filename, [string languageName])			  @brief Adds a language to the table			  @param filename Name and path to the language file			  @param languageName Optional name to assign to the new language entry			  @return True If file was successfully found and language created			  )
/// </summary>
public  int LangTable_addLanguage(string langtable, string filename = "", string languageName = ""){


return m_ts.fn_LangTable_addLanguage(langtable, filename, languageName);
}
/// <summary>
/// ()			  @brief Get the ID of the current language table			  @return Numerical ID of the current language table)
/// </summary>
public  int LangTable_getCurrentLanguage(string langtable){


return m_ts.fn_LangTable_getCurrentLanguage(langtable);
}
/// <summary>
/// (int language)			  @brief Return the readable name of the language table			  @param language Numerical ID of the language table to access			  @return String containing the name of the table, NULL if ID was invalid or name was never specified)
/// </summary>
public  string LangTable_getLangName(string langtable, int langId){


return m_ts.fn_LangTable_getLangName(langtable, langId);
}
/// <summary>
/// ()			  @brief Used to find out how many languages are in the table			  @return Size of the vector containing the languages, numerical)
/// </summary>
public  int LangTable_getNumLang(string langtable){


return m_ts.fn_LangTable_getNumLang(langtable);
}
/// <summary>
/// (string filename)			  @brief Grabs a string from the specified table			  If an invalid is passed, the function will attempt to 			  to grab from the default table			  @param filename Name of the language table to access			  @return Text from the specified language table, \"\" if ID was invalid and default table is not set)
/// </summary>
public  string LangTable_getString(string langtable, uint id){


return m_ts.fn_LangTable_getString(langtable, id);
}
/// <summary>
/// (int language)			  @brief Sets the current language table for grabbing text			  @param language ID of the table)
/// </summary>
public  void LangTable_setCurrentLanguage(string langtable, int langId){


m_ts.fn_LangTable_setCurrentLanguage(langtable, langId);
}
/// <summary>
/// (int language)			  @brief Sets the default language table			  @param language ID of the table)
/// </summary>
public  void LangTable_setDefaultLanguage(string langtable, int langId){


m_ts.fn_LangTable_setDefaultLanguage(langtable, langId);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class LevelInfoObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public LevelInfoObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( LevelInfo, setNearClip, void, 3, 3, ( F32 nearClip ))
/// </summary>
public  void setNearClip(string levelinfo, string a2= ""){


m_ts.fnLevelInfo_setNearClip(levelinfo, a2);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class LightBaseObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public LightBaseObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Stops the light animation. )
/// </summary>
public  void LightBase_pauseAnimation(string lightbase){


m_ts.fn_LightBase_pauseAnimation(lightbase);
}
/// <summary>
/// ), ( [LightAnimData anim] )\t   Plays a light animation on the light.  If no LightAnimData is passed the    existing one is played.   @hide)
/// </summary>
public  void LightBase_playAnimation(string lightbase, string anim = ""){


m_ts.fn_LightBase_playAnimation(lightbase, anim);
}
/// <summary>
/// @brief Toggles the light on and off      @param state Turns the light on (true) or off (false)   @tsexample   // Disable the light   CrystalLight.setLightEnabled(false);   // Renable the light   CrystalLight.setLightEnabled(true);      @endtsexample)
/// </summary>
public  void setLightEnabled(string lightbase, bool state){


m_ts.fnLightBase_setLightEnabled(lightbase, state);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class LightDescriptionObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public LightDescriptionObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Force an inspectPostApply call for the benefit of tweaking via the console      Normally this functionality is only exposed to objects via the World Editor, once changes have been made.    Exposing apply to script allows you to make changes to it on the fly without the World Editor.   @note This is intended for debugging and tweaking, not for game play   @tsexample   // Change a property of the light description   RocketLauncherLightDesc.brightness = 10;   // Make it so   RocketLauncherLightDesc.apply();      @endtsexample)
/// </summary>
public  void apply(string lightdescription){


m_ts.fnLightDescription_apply(lightdescription);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class LightFlareDataObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public LightFlareDataObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Intended as a helper to developers and editor scripts.                   Force trigger an inspectPostApply                   )
/// </summary>
public  void apply(string lightflaredata){


m_ts.fnLightFlareData_apply(lightflaredata);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class LightningObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public LightningObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Creates a LightningStrikeEvent which strikes a specific object.   @note This method is currently unimplemented. )
/// </summary>
public  void strikeObject(string lightning, string pSB){


m_ts.fnLightning_strikeObject(lightning, pSB);
}
/// <summary>
/// Creates a LightningStrikeEvent which attempts to strike and damage a random    object in range of the Lightning object.   @tsexample   // Generate a damaging lightning strike effect on all clients   %lightning.strikeRandomPoint();   @endtsexample )
/// </summary>
public  void strikeRandomPoint(string lightning){


m_ts.fnLightning_strikeRandomPoint(lightning);
}
/// <summary>
/// @brief Creates a LightningStrikeEvent that triggers harmless lightning    bolts on all clients.   No objects will be damaged by these bolts.   @tsexample   // Generate a harmless lightning strike effect on all clients   %lightning.warningFlashes();   @endtsexample )
/// </summary>
public  void warningFlashes(string lightning){


m_ts.fnLightning_warningFlashes(lightning);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class MaterialObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public MaterialObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Dumps a formatted list of the currently allocated material instances for this material to the console. )
/// </summary>
public  void Material_dumpInstances(string material){


m_ts.fn_Material_dumpInstances(material);
}
/// <summary>
/// Flushes all material instances that use this material. )
/// </summary>
public  void Material_flush(string material){


m_ts.fn_Material_flush(material);
}
/// <summary>
///  )
/// </summary>
public  string Material_getAnimFlags(string material, uint id){


return m_ts.fn_Material_getAnimFlags(material, id);
}
/// <summary>
/// Get filename of material)
/// </summary>
public  string Material_getFilename(string material){


return m_ts.fn_Material_getFilename(material);
}
/// <summary>
/// Returns true if this Material was automatically generated by MaterialList::mapMaterials() )
/// </summary>
public  bool Material_isAutoGenerated(string material){


return m_ts.fn_Material_isAutoGenerated(material);
}
/// <summary>
/// Reloads all material instances that use this material. )
/// </summary>
public  void Material_reload(string material){


m_ts.fn_Material_reload(material);
}
/// <summary>
/// setAutoGenerated(bool isAutoGenerated): Set whether or not the Material is autogenerated. )
/// </summary>
public  void Material_setAutoGenerated(string material, bool isAutoGenerated){


m_ts.fn_Material_setAutoGenerated(material, isAutoGenerated);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class MECreateUndoActionObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public MECreateUndoActionObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( SimObject obj ))
/// </summary>
public  void MECreateUndoAction_addObject(string mecreateundoaction, string obj){


m_ts.fn_MECreateUndoAction_addObject(mecreateundoaction, obj);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class MEDeleteUndoActionObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public MEDeleteUndoActionObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( SimObject obj ))
/// </summary>
public  void MEDeleteUndoAction_deleteObject(string medeleteundoaction, string obj){


m_ts.fn_MEDeleteUndoAction_deleteObject(medeleteundoaction, obj);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class MenuBarObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public MenuBarObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// (GuiCanvas, pos))
/// </summary>
public  void MenuBar_attachToCanvas(string menubar, string canvas, int pos){


m_ts.fn_MenuBar_attachToCanvas(menubar, canvas, pos);
}
/// <summary>
/// (object, pos) insert object at position)
/// </summary>
public  void MenuBar_insert(string menubar, string pObject, int pos){


m_ts.fn_MenuBar_insert(menubar, pObject, pos);
}
/// <summary>
/// ())
/// </summary>
public  void MenuBar_removeFromCanvas(string menubar){


m_ts.fn_MenuBar_removeFromCanvas(menubar);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class MeshRoadObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public MeshRoadObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Intended as a helper to developers and editor scripts.                   Force trigger an inspectPostApply. This will transmit                    material and other fields ( not including nodes ) to client objects.                   )
/// </summary>
public  void postApply(string meshroad){


m_ts.fnMeshRoad_postApply(meshroad);
}
/// <summary>
/// Intended as a helper to developers and editor scripts.                   Force MeshRoad to recreate its geometry.                   )
/// </summary>
public  void regenerate(string meshroad){


m_ts.fnMeshRoad_regenerate(meshroad);
}
/// <summary>
/// Intended as a helper to developers and editor scripts.                   Sets the depth in meters of a particular node.                   )
/// </summary>
public  void setNodeDepth(string meshroad, int idx, float meters){


m_ts.fnMeshRoad_setNodeDepth(meshroad, idx, meters);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class MessageObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public MessageObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// () Increment the reference count for this message)
/// </summary>
public  void Message_addReference(string message){


m_ts.fn_Message_addReference(message);
}
/// <summary>
/// () Decrement the reference count for this message)
/// </summary>
public  void Message_freeReference(string message){


m_ts.fn_Message_freeReference(message);
}
/// <summary>
/// () Get message type (script class name or C++ class name if no script defined class))
/// </summary>
public  string Message_getType(string message){


return m_ts.fn_Message_getType(message);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class MessageVectorObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public MessageVectorObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ), (string filename, string header=NULL)              Dump the message vector to a file, optionally prefixing a header.			  @hide)
/// </summary>
public  void MessageVector_dump(string messagevector, string filename, string header = ""){


m_ts.fn_MessageVector_dump(messagevector, filename, header);
}
/// <summary>
/// Clear all messages in the vector   @tsexample   HudMessageVector.clear();   @endtsexample)
/// </summary>
public  void clear(string messagevector){


m_ts.fnMessageVector_clear(messagevector);
}
/// <summary>
/// Delete the line at the specified position.   @param deletePos Position in the vector containing the line to be deleted   @tsexample   // Delete the first line (index 0) in the vector...   HudMessageVector.deleteLine(0);   @endtsexample   @return False if deletePos is greater than the number of lines in the current vector)
/// </summary>
public  bool deleteLine(string messagevector, int deletePos){


return m_ts.fnMessageVector_deleteLine(messagevector, deletePos);
}
/// <summary>
/// Scan through the vector, returning the line number of the first line that matches the specified tag; else returns -1 if no match was found.   @param tag Numerical value assigned to a message when it was added or inserted   @tsexample   // Locate a line of text tagged with the value \"1\", then delete it.   %taggedLine = HudMessageVector.getLineIndexByTag(1);   HudMessageVector.deleteLine(%taggedLine);   @endtsexample   @return Line with matching tag, other wise -1)
/// </summary>
public  int getLineIndexByTag(string messagevector, int tag){


return m_ts.fnMessageVector_getLineIndexByTag(messagevector, tag);
}
/// <summary>
/// Get the tag of a specified line.   @param pos Position in vector to grab tag from   @tsexample   // Remove all lines that do not have a tag value of 1.   while( HudMessageVector.getNumLines())   {      %tag = HudMessageVector.getLineTag(1);      if(%tag != 1)         %tag.delete();      HudMessageVector.popFrontLine();   }   @endtsexample   @return Tag value of a given line, if the position is greater than the number of lines return 0)
/// </summary>
public  int getLineTag(string messagevector, int pos){


return m_ts.fnMessageVector_getLineTag(messagevector, pos);
}
/// <summary>
/// Get the text at a specified line.   @param pos Position in vector to grab text from   @tsexample   // Print a line of text at position 1.   %text = HudMessageVector.getLineText(1);   echo(%text);   @endtsexample   @return Text at specified line, if the position is greater than the number of lines return \"\")
/// </summary>
public  string getLineText(string messagevector, int pos){


return m_ts.fnMessageVector_getLineText(messagevector, pos);
}
/// <summary>
/// Scan through the lines in the vector, returning the first line that has a matching tag.   @param tag Numerical value assigned to a message when it was added or inserted   @tsexample   // Locate text in the vector tagged with the value \"1\", then print it   %taggedText = HudMessageVector.getLineTextByTag(1);   echo(%taggedText);   @endtsexample   @return Text from a line with matching tag, other wise \"\")
/// </summary>
public  string getLineTextByTag(string messagevector, int tag){


return m_ts.fnMessageVector_getLineTextByTag(messagevector, tag);
}
/// <summary>
/// Get the number of lines in the vector.   @tsexample   // Find out how many lines have been stored in HudMessageVector   %chatLines = HudMessageVector.getNumLines();   echo(%chatLines);   @endtsexample)
/// </summary>
public  int getNumLines(string messagevector){


return m_ts.fnMessageVector_getNumLines(messagevector);
}
/// <summary>
/// Push a line onto the back of the list.   @param msg Text that makes up the message   @param tag Numerical value associated with this message, useful for searching.   @tsexample   // Add the message...   HudMessageVector.insertLine(1, \"Hello World\", 0);   @endtsexample   @return False if insertPos is greater than the number of lines in the current vector)
/// </summary>
public  bool insertLine(string messagevector, int insertPos, string msg, int tag){


return m_ts.fnMessageVector_insertLine(messagevector, insertPos, msg, tag);
}
/// <summary>
/// Pop a line from the back of the list; destroys the line.   @tsexample   HudMessageVector.popBackLine();   @endtsexample   @return False if there are no lines to pop (underflow), true otherwise)
/// </summary>
public  bool popBackLine(string messagevector){


return m_ts.fnMessageVector_popBackLine(messagevector);
}
/// <summary>
/// Pop a line from the front of the vector, destroying the line.   @tsexample   HudMessageVector.popFrontLine();   @endtsexample   @return False if there are no lines to pop (underflow), true otherwise)
/// </summary>
public  bool popFrontLine(string messagevector){


return m_ts.fnMessageVector_popFrontLine(messagevector);
}
/// <summary>
/// Push a line onto the back of the list.   @param msg Text that makes up the message   @param tag Numerical value associated with this message, useful for searching.   @tsexample   // Add the message...   HudMessageVector.pushBackLine(\"Hello World\", 0);   @endtsexample)
/// </summary>
public  void pushBackLine(string messagevector, string msg, int tag){


m_ts.fnMessageVector_pushBackLine(messagevector, msg, tag);
}
/// <summary>
/// Push a line onto the front of the vector.   @param msg Text that makes up the message   @param tag Numerical value associated with this message, useful for searching.   @tsexample   // Add the message...   HudMessageVector.pushFrontLine(\"Hello World\", 0);   @endtsexample)
/// </summary>
public  void pushFrontLine(string messagevector, string msg, int tag){


m_ts.fnMessageVector_pushFrontLine(messagevector, msg, tag);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class MissionAreaObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public MissionAreaObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Returns 4 fields: starting x, starting y, extents x, extents y.)
/// </summary>
public  string getArea(string missionarea){


return m_ts.fnMissionArea_getArea(missionarea);
}
/// <summary>
/// Intended as a helper to developers and editor scripts.                   Force trigger an inspectPostApply. This will transmit                    material and other fields ( not including nodes ) to client objects.                   )
/// </summary>
public  void postApply(string missionarea){


m_ts.fnMissionArea_postApply(missionarea);
}
/// <summary>
/// @brief - Defines the size of the MissionArea			  param x Starting X coordinate position for MissionArea			  param y Starting Y coordinate position for MissionArea			  param width New width of the MissionArea			  param height New height of the MissionArea           @note Only the server object may be set.			  )
/// </summary>
public  void setArea(string missionarea, int x, int y, int width, int height){


m_ts.fnMissionArea_setArea(missionarea, x, y, width, height);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class NavMeshObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public NavMeshObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Add a link to this NavMesh between two points.
///    )
/// 
/// </summary>
public  int addLink(string navmesh, Point3F from, Point3F to, uint flags = 0){


return m_ts.fnNavMesh_addLink(navmesh, from.AsString(), to.AsString(), flags);
}
/// <summary>
/// @brief Create a Recast nav mesh.)
/// 
/// </summary>
public  bool build(string navmesh, bool background = true, bool save = false){


return m_ts.fnNavMesh_build(navmesh, background, save);
}
/// <summary>
/// @brief Build tiles of this mesh where there are unsynchronised links.)
/// 
/// </summary>
public  void buildLinks(string navmesh){


m_ts.fnNavMesh_buildLinks(navmesh);
}
/// <summary>
/// @brief Rebuild the tiles overlapped by the input box.)
/// 
/// </summary>
public  void buildTiles(string navmesh, Box3F box){


m_ts.fnNavMesh_buildTiles(navmesh, box.AsString());
}
/// <summary>
/// @brief Cancel the current NavMesh build.)
/// 
/// </summary>
public  void cancelBuild(string navmesh){


m_ts.fnNavMesh_cancelBuild(navmesh);
}
/// <summary>
/// @brief Create cover points for this NavMesh.)
/// 
/// </summary>
public  bool createCoverPoints(string navmesh){


return m_ts.fnNavMesh_createCoverPoints(navmesh);
}
/// <summary>
/// @brief Remove all cover points for this NavMesh.)
/// 
/// </summary>
public  void deleteCoverPoints(string navmesh){


m_ts.fnNavMesh_deleteCoverPoints(navmesh);
}
/// <summary>
/// Delete a given off-mesh link.)
/// 
/// </summary>
public  void deleteLink(string navmesh, uint id){


m_ts.fnNavMesh_deleteLink(navmesh, id);
}
/// <summary>
/// Deletes all off-mesh links on this NavMesh.)
/// 
/// </summary>
public  void deleteLinks(string navmesh){


m_ts.fnNavMesh_deleteLinks(navmesh);
}
/// <summary>
/// Get the off-mesh link closest to a given world point.)
/// 
/// </summary>
public  int getLink(string navmesh, Point3F pos){


return m_ts.fnNavMesh_getLink(navmesh, pos.AsString());
}
/// <summary>
/// Return the number of links this mesh has.)
/// 
/// </summary>
public  int getLinkCount(string navmesh){


return m_ts.fnNavMesh_getLinkCount(navmesh);
}
/// <summary>
/// Get the ending point of an off-mesh link.)
/// 
/// </summary>
public  Point3F getLinkEnd(string navmesh, uint id){


return new Point3F ( m_ts.fnNavMesh_getLinkEnd(navmesh, id));
}
/// <summary>
/// Get the flags set for a particular off-mesh link.)
/// 
/// </summary>
public  int getLinkFlags(string navmesh, uint id){


return m_ts.fnNavMesh_getLinkFlags(navmesh, id);
}
/// <summary>
/// Get the starting point of an off-mesh link.)
/// 
/// </summary>
public  Point3F getLinkStart(string navmesh, uint id){


return new Point3F ( m_ts.fnNavMesh_getLinkStart(navmesh, id));
}
/// <summary>
/// @brief Load this NavMesh from its file.)
/// 
/// </summary>
public  bool load(string navmesh){


return m_ts.fnNavMesh_load(navmesh);
}
/// <summary>
/// @brief Save this NavMesh to its file.)
/// 
/// </summary>
public  void save(string navmesh){


m_ts.fnNavMesh_save(navmesh);
}
/// <summary>
/// Set the flags of a particular off-mesh link.)
/// 
/// </summary>
public  void setLinkFlags(string navmesh, uint id, uint flags){


m_ts.fnNavMesh_setLinkFlags(navmesh, id, flags);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class NavPathObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public NavPathObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Get a specified node along the path.)
/// 
/// </summary>
public  int getFlags(string navpath, int idx){


return m_ts.fnNavPath_getFlags(navpath, idx);
}
/// <summary>
/// @brief Get the length of this path.)
/// 
/// </summary>
public  float getLength(string navpath){


return m_ts.fnNavPath_getLength(navpath);
}
/// <summary>
/// @brief Get a specified node along the path.)
/// 
/// </summary>
public  Point3F getNode(string navpath, int idx){


return new Point3F ( m_ts.fnNavPath_getNode(navpath, idx));
}
/// <summary>
/// @brief Callback when this path's NavMesh is loaded or rebuilt.)
/// 
/// </summary>
public  void onNavMeshUpdate(string navpath, string data){


m_ts.fnNavPath_onNavMeshUpdate(navpath, data);
}
/// <summary>
/// @brief Callback when a particular area in this path's NavMesh is rebuilt.)
/// 
/// </summary>
public  void onNavMeshUpdateBox(string navpath, string data){


m_ts.fnNavPath_onNavMeshUpdateBox(navpath, data);
}
/// <summary>
/// @brief Find a path using the already-specified path properties.)
/// 
/// </summary>
public  bool plan(string navpath){


return m_ts.fnNavPath_plan(navpath);
}
/// <summary>
/// @brief Return the number of nodes in this path.)
/// 
/// </summary>
public  int size(string navpath){


return m_ts.fnNavPath_size(navpath);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class NetConnectionObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public NetConnectionObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Ensures that all configured packet rates and sizes meet minimum requirements.   This method is normally only called when a NetConnection class is first constructed.  It need    only be manually called if the global variables that set the packet rate or size have changed.   @note If @$pref::Net::PacketRateToServer, @$pref::Net::PacketRateToClient or @$pref::Net::PacketSize    have been changed since a NetConnection has been created, this method must be called on    all connections for them to follow the new rates or size.)
/// </summary>
public  void checkMaxRate(string netconnection){


m_ts.fnNetConnection_checkMaxRate(netconnection);
}
/// <summary>
/// @brief On the server, resets the connection to indicate that motion spline paths have not been transmitted.   Typically when a mission has ended on the server, all connected clients are informed of this change    and their connections are reset back to a starting state.  This method resets a connection on the    server to indicate that motion spline paths have not been transmitted.   @tsexample      // Inform the clients      for (%clientIndex = 0; %clientIndex  ClientGroup.getCount(); %clientIndex++)      {         // clear ghosts and paths from all clients         %cl = ClientGroup.getObject(%clientIndex);         %cl.endMission();         %cl.resetGhosting();         %cl.clearPaths();      }   @endtsexample      @see transmitPaths()   @see Path)
/// </summary>
public  void clearPaths(string netconnection){


m_ts.fnNetConnection_clearPaths(netconnection);
}
/// <summary>
/// @brief Connects to the remote address.   Attempts to connect with another NetConnection on the given address.  Typically once    connected, a game's information is passed along from the server to the client, followed    by the player entering the game world.  The actual procedure is dependent on    the NetConnection subclass that is used.  i.e. GameConnection.   @param remoteAddress The address to connect to in the form of IP:address>:port    although the i>IP:/i> portion is optional.  The i>address/i> portion may be in the form    of w.x.y.z or as a host name, in which case a DNS lookup will be performed.  You may also    substitue the word i>broadcast/i> for the address to broadcast the connect request over    the local subnet.   @see NetConnection::connectLocal() to connect to a server running within the same process    as the client.   )
/// </summary>
public  void connect(string netconnection, string remoteAddress){


m_ts.fnNetConnection_connect(netconnection, remoteAddress);
}
/// <summary>
/// @brief Connects with the server that is running within the same process as the client.   @returns An error text message upon failure, or an empty string when successful.   @see See @ref local_connections for a description of local connections and their use.  See    NetConnection::connect() to connect to a server running in another process (on the same machine or not).)
/// </summary>
public  string connectLocal(string netconnection){


return m_ts.fnNetConnection_connectLocal(netconnection);
}
/// <summary>
/// @brief Returns the far end network address for the connection.   The address will be in one of the following forms:   - b>IP:Broadcast:port>/b> for broadcast type addresses   - b>IP:address>:port>/b> for IP addresses   - b>local/b> when connected locally (server and client running in same process)
/// </summary>
public  string getAddress(string netconnection){


return m_ts.fnNetConnection_getAddress(netconnection);
}
/// <summary>
/// @brief On server or client, convert a real id to the ghost id for this connection.   Torque's network ghosting system only exchanges ghost ID's between the server and client.  Use    this method on the server or client to discover an object's ghost ID based on its real SimObject ID.   @param realID The real SimObject ID of the object.   @returns The ghost ID of the object for this connection, or -1 if it could not be resolved.   @see @ref ghosting_scoping for a description of the ghosting system.)
/// </summary>
public  int getGhostID(string netconnection, int realID){


return m_ts.fnNetConnection_getGhostID(netconnection, realID);
}
/// <summary>
/// Returns the ghost-index for an object.
/// 	@ingroup AFX)
/// 
/// </summary>
public  int GetGhostIndex(string netconnection, string obj){


return m_ts.fnNetConnection_GetGhostIndex(netconnection, obj);
}
/// <summary>
/// @brief Provides the number of active ghosts on the connection.   @returns The number of active ghosts.   @see @ref ghosting_scoping for a description of the ghosting system.)
/// </summary>
public  int getGhostsActive(string netconnection){


return m_ts.fnNetConnection_getGhostsActive(netconnection);
}
/// <summary>
/// @brief Returns the percentage of packets lost per tick.   @note This method is not yet hooked up.)
/// </summary>
public  int getPacketLoss(string netconnection){


return m_ts.fnNetConnection_getPacketLoss(netconnection);
}
/// <summary>
/// @brief Returns the average round trip time (in ms) for the connection.   The round trip time is recalculated every time a notify packet is received.  Notify    packets are used to information the connection that the far end successfully received    the sent packet.)
/// </summary>
public  int getPing(string netconnection){


return m_ts.fnNetConnection_getPing(netconnection);
}
/// <summary>
/// Resolves a ghost-index into an object ID.
/// 	@ingroup AFX)
/// 
/// </summary>
public  int ResolveGhost(string netconnection, int ghostIndex){


return m_ts.fnNetConnection_ResolveGhost(netconnection, ghostIndex);
}
/// <summary>
/// @brief On the client, convert a ghost ID from this connection to a real SimObject ID.   Torque's network ghosting system only exchanges ghost ID's between the server and client.  Use    this method on the client to discover an object's local SimObject ID when you only have a    ghost ID.   @param ghostID The ghost ID of the object as sent by the server.   @returns The SimObject ID of the object, or 0 if it could not be resolved.   @tsexample      %object = ServerConnection.resolveGhostID( %ghostId );   @endtsexample   @see @ref ghosting_scoping for a description of the ghosting system.)
/// </summary>
public  int resolveGhostID(string netconnection, int ghostID){


return m_ts.fnNetConnection_resolveGhostID(netconnection, ghostID);
}
/// <summary>
/// @brief On the server, convert a ghost ID from this connection to a real SimObject ID.   Torque's network ghosting system only exchanges ghost ID's between the server and client.  Use    this method on the server to discover an object's local SimObject ID when you only have a    ghost ID.   @param ghostID The ghost ID of the object as sent by the server.   @returns The SimObject ID of the object, or 0 if it could not be resolved.   @tsexample      %object = %client.resolveObjectFromGhostIndex( %ghostId );   @endtsexample   @see @ref ghosting_scoping for a description of the ghosting system.)
/// </summary>
public  int resolveObjectFromGhostIndex(string netconnection, int ghostID){


return m_ts.fnNetConnection_resolveObjectFromGhostIndex(netconnection, ghostID);
}
/// <summary>
/// @brief Simulate network issues on the connection for testing.   @param packetLoss The fraction of packets that will be lost.  Ranges from 0.0 (no loss) to 1.0 (complete loss)   @param delay Delays packets being transmitted by simulating a particular ping.  This is an absolute    integer, measured in ms.)
/// </summary>
public  void setSimulatedNetParams(string netconnection, float packetLoss, int delay){


m_ts.fnNetConnection_setSimulatedNetParams(netconnection, packetLoss, delay);
}
/// <summary>
/// @brief Sent by the server during phase 2 of the mission download to update motion spline paths.   The server transmits all spline motion paths that are within the mission (Path) separate from    other objects.  This is due to the potentially large number of nodes within each path, which may    saturate a packet sent to the client.  By managing this step separately, Torque has finer control    over how packets are organised vs. doing it during the ghosting stage.   Internally a PathManager is used to track all paths defined within a mission on the server, and each    one is transmitted using a PathManagerEvent.  The client side collects these events and builds the    given paths within its own PathManager.  This is typically done during the standard mission start    phase 2 when following Torque's example mission startup sequence.   When a mission is ended, all paths need to be cleared from their respective path managers.   @tsexample   function serverCmdMissionStartPhase2Ack(%client, %seq, %playerDB)   {      // Make sure to ignore calls from a previous mission load      if (%seq != $missionSequence || !$MissionRunning)         return;      if (%client.currentPhase != 1.5)         return;      %client.currentPhase = 2;         // Set the player datablock choice      %client.playerDB = %playerDB;         // Update mission paths (SimPath), this needs to get there before the objects.      %client.transmitPaths();         // Start ghosting objects to the client      %client.activateGhosting();   }   @endtsexample      @see clearPaths()   @see Path)
/// </summary>
public  void transmitPaths(string netconnection){


m_ts.fnNetConnection_transmitPaths(netconnection);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class NetObjectObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public NetObjectObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Undo the effects of a scopeToClient() call.   @param client The connection to remove this object's scoping from       @see scopeToClient())
/// </summary>
public  void clearScopeToClient(string netobject, string client){


m_ts.fnNetObject_clearScopeToClient(netobject, client);
}
/// <summary>
/// @brief Returns a pointer to the client object when on a local connection.   Short-Circuit-Networking: this is only valid for a local-client / singleplayer situation.   @returns the SimObject ID of the client object.   @tsexample      // Psuedo-code, some values left out for this example      %node = new ParticleEmitterNode(){};      %clientObject = %node.getClientObject();      if(isObject(%clientObject)      	%clientObject.setTransform(\"0 0 0\");   @endtsexample      @see @ref local_connections)
/// </summary>
public  int getClientObject(string netobject){


return m_ts.fnNetObject_getClientObject(netobject);
}
/// <summary>
/// @brief Get the ghost index of this object from the server.   @returns The ghost ID of this NetObject on the server   @tsexample      %ghostID = LocalClientConnection.getGhostId( %serverObject );   @endtsexample)
/// </summary>
public  int getGhostID(string netobject){


return m_ts.fnNetObject_getGhostID(netobject);
}
/// <summary>
/// @brief Returns a pointer to the client object when on a local connection.   Short-Circuit-Netorking: this is only valid for a local-client / singleplayer situation.      @returns The SimObject ID of the server object.   @tsexample      // Psuedo-code, some values left out for this example      %node = new ParticleEmitterNode(){};      %serverObject = %node.getServerObject();      if(isObject(%serverObject)      	%serverObject.setTransform(\"0 0 0\");   @endtsexample      @see @ref local_connections)
/// </summary>
public  int getServerObject(string netobject){


return m_ts.fnNetObject_getServerObject(netobject);
}
/// <summary>
/// @brief Called to check if an object resides on the clientside.   @return True if the object resides on the client, false otherwise.)
/// </summary>
public  bool isClientObject(string netobject){


return m_ts.fnNetObject_isClientObject(netobject);
}
/// <summary>
/// @brief Checks if an object resides on the server.   @return True if the object resides on the server, false otherwise.)
/// </summary>
public  bool isServerObject(string netobject){


return m_ts.fnNetObject_isServerObject(netobject);
}
/// <summary>
/// @brief Cause the NetObject to be forced as scoped on the specified NetConnection.   @param client The connection this object will always be scoped to   @tsexample      // Called to create new cameras in TorqueScript      // %this - The active GameConnection      // %spawnPoint - The spawn point location where we creat the camera      function GameConnection::spawnCamera(%this, %spawnPoint)      {      	// If this connection's camera exists      	if(isObject(%this.camera))      	{      		// Add it to the mission group to be cleaned up later      		MissionCleanup.add( %this.camera );      		// Force it to scope to the client side      		%this.camera.scopeToClient(%this);      	}      }   @endtsexample      @see clearScopeToClient())
/// </summary>
public  void scopeToClient(string netobject, string client){


m_ts.fnNetObject_scopeToClient(netobject, client);
}
/// <summary>
/// @brief Always scope this object on all connections.   The object is marked as ScopeAlways and is immediately ghosted to    all active connections.  This function has no effect if the object    is not marked as Ghostable.)
/// </summary>
public  void setScopeAlways(string netobject){


m_ts.fnNetObject_setScopeAlways(netobject);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ParticleDataObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ParticleDataObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Reloads this particle.   @tsexample   // Get the editor's current particle   %particle = PE_ParticleEditor.currParticle   // Change a particle value   %particle.setFieldValue( %propertyField, %value );   // Reload it   %particle.reload();   @endtsexample )
/// </summary>
public  void reload(string particledata){


m_ts.fnParticleData_reload(particledata);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ParticleEmitterDataObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ParticleEmitterDataObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Reloads the ParticleData datablocks and other fields used by this emitter.   @tsexample   // Get the editor's current particle emitter   %emitter = PE_EmitterEditor.currEmitter   // Change a field value   %emitter.setFieldValue( %propertyField, %value );   // Reload this emitter   %emitter.reload();   @endtsexample)
/// </summary>
public  void reload(string particleemitterdata){


m_ts.fnParticleEmitterData_reload(particleemitterdata);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ParticleEmitterNodeObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ParticleEmitterNodeObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Turns the emitter on or off.   @param active New emitter state )
/// </summary>
public  void setActive(string particleemitternode, bool active){


m_ts.fnParticleEmitterNode_setActive(particleemitternode, active);
}
/// <summary>
/// Assigns the datablock for this emitter node.   @param emitterDatablock ParticleEmitterData datablock to assign   @tsexample   // Assign a new emitter datablock   %emitter.setEmitterDatablock( %emitterDatablock );   @endtsexample )
/// </summary>
public  void setEmitterDataBlock(string particleemitternode, string emitterDatablock = null ){
if (emitterDatablock== null) {emitterDatablock = null;}


m_ts.fnParticleEmitterNode_setEmitterDataBlock(particleemitternode, emitterDatablock);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class PathCameraObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public PathCameraObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Removes the knot at the front of the camera's path.													@tsexample														// Remove the first knot in the camera's path.														%pathCamera.popFront();													@endtsexample)
/// </summary>
public  void popFront(string pathcamera){


m_ts.fnPathCamera_popFront(pathcamera);
}
/// <summary>
/// Normal, Linear), 											      @brief Adds a new knot to the back of a path camera's path.													@param transform Transform for the new knot.  In the form of \"x y z ax ay az aa\" such as returned by SceneObject::getTransform()													@param speed Speed setting for this knot.													@param type Knot type (Normal, Position Only, Kink).													@param path %Path type (Linear, Spline).													@tsexample														// Transform vector for new knot. (Pos_X Pos_Y Pos_Z Rot_X Rot_Y Rot_Z Angle)														%transform = \"15.0 5.0 5.0 1.4 1.0 0.2 1.0\"														// Speed setting for knot.														%speed = \"1.0\"														// Knot type. (Normal, Position Only, Kink)														%type = \"Normal\";														// Path Type. (Linear, Spline)														%path = \"Linear\";														// Inform the path camera to add a new knot to the back of its path														%pathCamera.pushBack(%transform,%speed,%type,%path);													@endtsexample)
/// </summary>
public  void pushBack(string pathcamera, TransformF transform, float speed = 1.0f, string type = "Normal", string path = "Linear"){


m_ts.fnPathCamera_pushBack(pathcamera, transform.AsString(), speed, type, path);
}
/// <summary>
/// Normal, Linear), 											      @brief Adds a new knot to the front of a path camera's path.													@param transform Transform for the new knot. In the form of \"x y z ax ay az aa\" such as returned by SceneObject::getTransform()													@param speed Speed setting for this knot.													@param type Knot type (Normal, Position Only, Kink).													@param path %Path type (Linear, Spline).													@tsexample														// Transform vector for new knot. (Pos_X,Pos_Y,Pos_Z,Rot_X,Rot_Y,Rot_Z,Angle)														%transform = \"15.0 5.0 5.0 1.4 1.0 0.2 1.0\"														// Speed setting for knot.														%speed = \"1.0\";														// Knot type. (Normal, Position Only, Kink)														%type = \"Normal\";														// Path Type. (Linear, Spline)														%path = \"Linear\";														// Inform the path camera to add a new knot to the front of its path														%pathCamera.pushFront(%transform, %speed, %type, %path);													@endtsexample)
/// </summary>
public  void pushFront(string pathcamera, TransformF transform, float speed = 1.0f, string type = "Normal", string path = "Linear"){


m_ts.fnPathCamera_pushFront(pathcamera, transform.AsString(), speed, type, path);
}
/// <summary>
/// @brief Clear the camera's path and set the camera's current transform as the start of the new path.                                       What specifically occurs is a new knot is created from the camera's current transform.  Then the current path                                        is cleared and the new knot is pushed onto the path.  Any previous target is cleared and the camera's movement                                        state is set to Forward.  The camera is now ready for a new path to be defined.													@param speed Speed for the camera to move along its path after being reset.													@tsexample														//Determine the new movement speed of this camera. If not set, the speed will default to 1.0.														%speed = \"0.50\";														// Inform the path camera to start a new path at                                          // the camera's current position, and set the new                                           // path's speed value.														%pathCamera.reset(%speed);                                       @endtsexample)
/// </summary>
public  void reset(string pathcamera, float speed = 1.0f){


m_ts.fnPathCamera_reset(pathcamera, speed);
}
/// <summary>
/// Set the current position of the camera along the path.													@param position Position along the path, from 0.0 (path start) - 1.0 (path end), to place the camera.													@tsexample                                          // Set the camera on a position along its path from 0.0 - 1.0.														%position = \"0.35\";														// Force the pathCamera to its new position along the path.														%pathCamera.setPosition(%position);													@endtsexample)
/// </summary>
public  void setPosition(string pathcamera, float position = 0.0f){


m_ts.fnPathCamera_setPosition(pathcamera, position);
}
/// <summary>
/// forward), Set the movement state for this path camera.													@param newState New movement state type for this camera. Forward, Backward or Stop.													@tsexample														// Set the state type (forward, backward, stop).                                          // In this example, the camera will travel from the first node                                          // to the last node (or target if given with setTarget())														%state = \"forward\";														// Inform the pathCamera to change its movement state to the defined value.														%pathCamera.setState(%state);													@endtsexample)
/// </summary>
public  void setState(string pathcamera, string newState = "forward"){


m_ts.fnPathCamera_setState(pathcamera, newState);
}
/// <summary>
/// @brief Set the movement target for this camera along its path.                                       The camera will attempt to move along the path to the given target in the direction provided                                        by setState() (the default is forwards).  Once the camera moves past this target it will come                                        to a stop, and the target state will be cleared.													@param position Target position, between 0.0 (path start) and 1.0 (path end), for the camera to move to along its path.													@tsexample                                          // Set the position target, between 0.0 (path start) and 1.0 (path end), for this camera to move to.														%position = \"0.50\";														// Inform the pathCamera of the new target position it will move to.														%pathCamera.setTarget(%position);													@endtsexample)
/// </summary>
public  void setTarget(string pathcamera, float position = 1.0f){


m_ts.fnPathCamera_setTarget(pathcamera, position);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class PersistenceManagerObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public PersistenceManagerObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ()              Clears all the tracked objects without saving them. )
/// </summary>
public  void PersistenceManager_clearAll(string persistencemanager){


m_ts.fn_PersistenceManager_clearAll(persistencemanager);
}
/// <summary>
/// ( fileName )              Delete all of the objects that are created from the given file. )
/// </summary>
public  void PersistenceManager_deleteObjectsFromFile(string persistencemanager, string fileName){


m_ts.fn_PersistenceManager_deleteObjectsFromFile(persistencemanager, fileName);
}
/// <summary>
/// ( index )              Returns the ith dirty object. )
/// </summary>
public  int PersistenceManager_getDirtyObject(string persistencemanager, int index){


return m_ts.fn_PersistenceManager_getDirtyObject(persistencemanager, index);
}
/// <summary>
/// ()              Returns the number of dirty objects. )
/// </summary>
public  int PersistenceManager_getDirtyObjectCount(string persistencemanager){


return m_ts.fn_PersistenceManager_getDirtyObjectCount(persistencemanager);
}
/// <summary>
/// ()              Returns true if the manager has dirty objects to save. )
/// </summary>
public  bool PersistenceManager_hasDirty(string persistencemanager){


return m_ts.fn_PersistenceManager_hasDirty(persistencemanager);
}
/// <summary>
/// (SimObject object)              Returns true if the SimObject is on the dirty list.)
/// </summary>
public  bool PersistenceManager_isDirty(string persistencemanager, string objName){


return m_ts.fn_PersistenceManager_isDirty(persistencemanager, objName);
}
/// <summary>
/// ()              Prints the dirty list to the console.)
/// </summary>
public  void PersistenceManager_listDirty(string persistencemanager){


m_ts.fn_PersistenceManager_listDirty(persistencemanager);
}
/// <summary>
/// (SimObject object)              Remove a SimObject from the dirty list.)
/// </summary>
public  void PersistenceManager_removeDirty(string persistencemanager, string objName){


m_ts.fn_PersistenceManager_removeDirty(persistencemanager, objName);
}
/// <summary>
/// (SimObject object, string fieldName)              Remove a specific field from an object declaration.)
/// </summary>
public  void PersistenceManager_removeField(string persistencemanager, string objName, string fieldName){


m_ts.fn_PersistenceManager_removeField(persistencemanager, objName, fieldName);
}
/// <summary>
/// ) , (SimObject object, [filename])              Remove an existing SimObject from a file (can optionally specify a different file than \               the one it was created in.)
/// </summary>
public  void PersistenceManager_removeObjectFromFile(string persistencemanager, string objName, string filename = ""){


m_ts.fn_PersistenceManager_removeObjectFromFile(persistencemanager, objName, filename);
}
/// <summary>
/// ()              Saves all of the SimObject's on the dirty list to their respective files.)
/// </summary>
public  bool PersistenceManager_saveDirty(string persistencemanager){


return m_ts.fn_PersistenceManager_saveDirty(persistencemanager);
}
/// <summary>
/// (SimObject object)              Save a dirty SimObject to it's file.)
/// </summary>
public  bool PersistenceManager_saveDirtyObject(string persistencemanager, string objName){


return m_ts.fn_PersistenceManager_saveDirtyObject(persistencemanager, objName);
}
/// <summary>
/// ), (SimObject object, [filename])              Mark an existing SimObject as dirty (will be written out when saveDirty() is called).)
/// </summary>
public  void PersistenceManager_setDirty(string persistencemanager, string objName, string fileName = ""){


m_ts.fn_PersistenceManager_setDirty(persistencemanager, objName, fileName);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class PhysicalZoneObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public PhysicalZoneObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Activate the physical zone's effects.													@tsexample														// Activate effects for a specific physical zone.														%thisPhysicalZone.activate();													@endtsexample													@ingroup Datablocks				  )
/// </summary>
public  void activate(string physicalzone){


m_ts.fnPhysicalZone_activate(physicalzone);
}
/// <summary>
/// Deactivate the physical zone's effects.													@tsexample														// Deactivate effects for a specific physical zone.														%thisPhysicalZone.deactivate();													@endtsexample													@ingroup Datablocks				  )
/// </summary>
public  void deactivate(string physicalzone){


m_ts.fnPhysicalZone_deactivate(physicalzone);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class PhysicsDebrisDataObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public PhysicsDebrisDataObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Loads some information to have readily available at simulation time.   Forces generation of shaders, materials, and other data used by the %PhysicsDebris object.    This function should be used while a level is loading in order to shorten    the amount of time to create a PhysicsDebris in game.)
/// </summary>
public  void PhysicsDebrisData_preload(string physicsdebrisdata){


m_ts.fn_PhysicsDebrisData_preload(physicsdebrisdata);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class PhysicsForceObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public PhysicsForceObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Attempts to associate the PhysicsForce with a PhysicsBody.   Performs a physics ray cast of the provided length and direction. The %PhysicsForce     will attach itself to the first dynamic PhysicsBody the ray collides with.    On every tick, the attached body will be attracted towards the position of the %PhysicsForce.   A %PhysicsForce can only be attached to one body at a time.   @note To determine if an %attach was successful, check isAttached() immediately after    calling this function.n)
/// </summary>
public  void attach(string physicsforce, Point3F start, Point3F direction, float maxDist){


m_ts.fnPhysicsForce_attach(physicsforce, start.AsString(), direction.AsString(), maxDist);
}
/// <summary>
/// @brief Disassociates the PhysicsForce from any attached PhysicsBody.   @param force Optional force to apply to the attached PhysicsBody    before detaching.   @note Has no effect if the %PhysicsForce is not attached to anything.)
/// </summary>
public  void detach(string physicsforce, Point3F force = null ){
if (force== null) {force = new Point3F(0.0f, 0.0f, 0.0f);}


m_ts.fnPhysicsForce_detach(physicsforce, force.AsString());
}
/// <summary>
/// @brief Returns true if the %PhysicsForce is currently attached to an object.   @see PhysicsForce::attach())
/// </summary>
public  bool isAttached(string physicsforce){


return m_ts.fnPhysicsForce_isAttached(physicsforce);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class PhysicsShapeObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public PhysicsShapeObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Disables rendering and physical simulation.   Calling destroy() will also spawn any explosions, debris, and/or destroyedShape    defined for it, as well as remove it from the scene graph.   Destroyed objects are only created on the server. Ghosting will later update the client.   @note This does not actually delete the PhysicsShape. )
/// </summary>
public  void destroy(string physicsshape){


m_ts.fnPhysicsShape_destroy(physicsshape);
}
/// <summary>
/// @brief Returns if a PhysicsShape has been destroyed or not. )
/// </summary>
public  bool isDestroyed(string physicsshape){


return m_ts.fnPhysicsShape_isDestroyed(physicsshape);
}
/// <summary>
/// @brief Restores the shape to its state before being destroyed.   Re-enables rendering and physical simulation on the object and    adds it to the client's scene graph.    Has no effect if the shape is not destroyed.)
/// </summary>
public  void restore(string physicsshape){


m_ts.fnPhysicsShape_restore(physicsshape);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class PlayerObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public PlayerObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Allow all poses a chance to occur.   This method resets any poses that have manually been blocked from occuring.     This includes the regular pose states such as sprinting, crouch, being prone    and swimming.  It also includes being able to jump and jet jump.  While this    is allowing these poses to occur it doesn't mean that they all can due to other    conditions.  We're just not manually blocking them from being allowed.   @see allowJumping()   @see allowJetJumping()   @see allowSprinting()   @see allowCrouching()   @see allowProne()   @see allowSwimming() )
/// </summary>
public  void allowAllPoses(string player){


m_ts.fnPlayer_allowAllPoses(player);
}
/// <summary>
/// @brief Set if the Player is allowed to crouch.   The default is to allow crouching unless there are other environmental concerns    that prevent it.  This method is mainly used to explicitly disallow crouching    at any time.   @param state Set to true to allow crouching, false to disable it.   @see allowAllPoses() )
/// </summary>
public  void allowCrouching(string player, bool state){


m_ts.fnPlayer_allowCrouching(player, state);
}
/// <summary>
/// @brief Set if the Player is allowed to jet jump.   The default is to allow jet jumping unless there are other environmental concerns    that prevent it.  This method is mainly used to explicitly disallow jet jumping    at any time.   @param state Set to true to allow jet jumping, false to disable it.   @see allowAllPoses() )
/// </summary>
public  void allowJetJumping(string player, bool state){


m_ts.fnPlayer_allowJetJumping(player, state);
}
/// <summary>
/// @brief Set if the Player is allowed to jump.   The default is to allow jumping unless there are other environmental concerns    that prevent it.  This method is mainly used to explicitly disallow jumping    at any time.   @param state Set to true to allow jumping, false to disable it.   @see allowAllPoses() )
/// </summary>
public  void allowJumping(string player, bool state){


m_ts.fnPlayer_allowJumping(player, state);
}
/// <summary>
/// @brief Set if the Player is allowed to go prone.   The default is to allow being prone unless there are other environmental concerns    that prevent it.  This method is mainly used to explicitly disallow going prone    at any time.   @param state Set to true to allow being prone, false to disable it.   @see allowAllPoses() )
/// </summary>
public  void allowProne(string player, bool state){


m_ts.fnPlayer_allowProne(player, state);
}
/// <summary>
/// @brief Set if the Player is allowed to sprint.   The default is to allow sprinting unless there are other environmental concerns    that prevent it.  This method is mainly used to explicitly disallow sprinting    at any time.   @param state Set to true to allow sprinting, false to disable it.   @see allowAllPoses() )
/// </summary>
public  void allowSprinting(string player, bool state){


m_ts.fnPlayer_allowSprinting(player, state);
}
/// <summary>
/// @brief Set if the Player is allowed to swim.   The default is to allow swimming unless there are other environmental concerns    that prevent it.  This method is mainly used to explicitly disallow swimming    at any time.   @param state Set to true to allow swimming, false to disable it.   @see allowAllPoses() )
/// </summary>
public  void allowSwimming(string player, bool state){


m_ts.fnPlayer_allowSwimming(player, state);
}
/// <summary>
/// @brief Check if it is safe to dismount at this position.   Internally this method casts a ray from oldPos to pos to determine if it hits the    terrain, an interior object, a water object, another player, a static shape,    a vehicle (exluding the one currently mounted), or physical zone.  If this ray    is in the clear, then the player's bounding box is also checked for a collision at    the pos position.  If this displaced bounding box is also in the clear, then    checkDismountPoint() returns true.   @param oldPos The player's current position   @param pos The dismount position to check   @return True if the dismount position is clear, false if not      @note The player must be already mounted for this method to not assert.)
/// </summary>
public  bool checkDismountPoint(string player, Point3F oldPos, Point3F pos){


return m_ts.fnPlayer_checkDismountPoint(player, oldPos.AsString(), pos.AsString());
}
/// <summary>
/// @brief Clears the player's current control object.   Returns control to the player. This internally calls    Player::setControlObject(0).   @tsexample		%player.clearControlObject();      echo(%player.getControlObject()); //-- Returns 0, player assumes control      %player.setControlObject(%vehicle);      echo(%player.getControlObject()); //-- Returns %vehicle, player controls the vehicle now.	@endtsexample   @note If the player does not have a control object, the player will receive all moves    from its GameConnection.  If you're looking to remove control from the player itself    (i.e. stop sending moves to the player) use GameConnection::setControlObject() to transfer    control to another object, such as a camera.   @see setControlObject()   @see getControlObject()   @see GameConnection::setControlObject())
/// </summary>
public  void clearControlObject(string player){


m_ts.fnPlayer_clearControlObject(player);
}
/// <summary>
/// @brief Get the current object we are controlling.   @return ID of the ShapeBase object we control, or 0 if not controlling an    object.   @see setControlObject()   @see clearControlObject())
/// </summary>
public  int getControlObject(string player){


return m_ts.fnPlayer_getControlObject(player);
}
/// <summary>
/// @brief Get the named damage location and modifier for a given world position.   the Player object can simulate different hit locations based on a pre-defined set    of PlayerData defined percentages.  These hit percentages divide up the Player's    bounding box into different regions.  The diagram below demonstrates how the various    PlayerData properties split up the bounding volume:   img src=\"images/player_damageloc.png\">   While you may pass in any world position and getDamageLocation() will provide a best-fit    location, you should be aware that this can produce some interesting results.  For example,    any position that is above PlayerData::boxHeadPercentage will be considered a 'head' hit, even    if the world position is high in the sky.  Therefore it may be wise to keep the passed in point    to somewhere on the surface of, or within, the Player's bounding volume.   @note This method will not return an accurate location when the player is    prone or swimming.   @param pos A world position for which to retrieve a body region on this player.   @return a string containing two words (space separated strings), where the    first is a location and the second is a modifier.   Posible locations:ul>   li>head/li>   li>torso/li>   li>legs/li>/ul>   Head modifiers:ul>   li>left_back/li>   li>middle_back/li>   li>right_back/li>   li>left_middle/li>   li>middle_middle/li>   li>right_middle/li>   li>left_front/li>   li>middle_front/li>   li>right_front/li>/ul>   Legs/Torso modifiers:ul>   li>front_left/li>   li>front_right/li>   li>back_left/li>   li>back_right/li>/ul>   @see PlayerData::boxHeadPercentage   @see PlayerData::boxHeadFrontPercentage   @see PlayerData::boxHeadBackPercentage   @see PlayerData::boxHeadLeftPercentage   @see PlayerData::boxHeadRightPercentage   @see PlayerData::boxTorsoPercentage   )
/// </summary>
public  string getDamageLocation(string player, Point3F pos){


return m_ts.fnPlayer_getDamageLocation(player, pos.AsString());
}
/// <summary>
/// @brief Get the number of death animations available to this player.   Death animations are assumed to be named death1-N using consecutive indices. )
/// </summary>
public  int getNumDeathAnimations(string player){


return m_ts.fnPlayer_getNumDeathAnimations(player);
}
/// <summary>
/// @brief Get the name of the player's current pose.   The pose is one of the following:ul>   li>Stand - Standard movement pose./li>   li>Sprint - Sprinting pose./li>   li>Crouch - Crouch pose./li>   li>Prone - Prone pose./li>   li>Swim - Swimming pose./li>/ul>   @return The current pose; one of: \"Stand\", \"Sprint\", \"Crouch\", \"Prone\", \"Swim\" )
/// </summary>
public  string getPose(string player){


return m_ts.fnPlayer_getPose(player);
}
/// <summary>
/// @brief Get the name of the player's current state.   The state is one of the following:ul>   li>Dead - The Player is dead./li>   li>Mounted - The Player is mounted to an object such as a vehicle./li>   li>Move - The Player is free to move.  The usual state./li>   li>Recover - The Player is recovering from a fall.  See PlayerData::recoverDelay./li>/ul>   @return The current state; one of: \"Dead\", \"Mounted\", \"Move\", \"Recover\" )
/// </summary>
public  string getState(string player){


return m_ts.fnPlayer_getState(player);
}
/// <summary>
/// @brief Set the main action sequence to play for this player.   @param name Name of the action sequence to set   @param hold Set to false to get a callback on the datablock when the sequence ends (PlayerData::animationDone()).     When set to true no callback is made.   @param fsp True if first person and none of the spine nodes in the shape should animate.  False will allow the shape's    spine nodes to animate.   @return True if succesful, false if failed      @note The spine nodes for the Player's shape are named as follows:ul>   li>Bip01 Pelvis/li>   li>Bip01 Spine/li>   li>Bip01 Spine1/li>   li>Bip01 Spine2/li>   li>Bip01 Neck/li>   li>Bip01 Head/li>/ul>      You cannot use setActionThread() to have the Player play one of the motion    determined action animation sequences.  These sequences are chosen based on how    the Player moves and the Player's current pose.  The names of these sequences are:ul>   li>root/li>   li>run/li>   li>side/li>   li>side_right/li>   li>crouch_root/li>   li>crouch_forward/li>   li>crouch_backward/li>   li>crouch_side/li>   li>crouch_right/li>   li>prone_root/li>   li>prone_forward/li>   li>prone_backward/li>   li>swim_root/li>   li>swim_forward/li>   li>swim_backward/li>   li>swim_left/li>   li>swim_right/li>   li>fall/li>   li>jump/li>   li>standjump/li>   li>land/li>   li>jet/li>/ul>      If the player moves in any direction then the animation sequence set using this    method will be cancelled and the chosen mation-based sequence will take over.  This makes    great for times when the Player cannot move, such as when mounted, or when it doesn't matter    if the action sequence changes, such as waving and saluting.      @tsexample      // Place the player in a sitting position after being mounted      %player.setActionThread( \"sitting\", true, true );	@endtsexample)
/// </summary>
public  bool setActionThread(string player, string name, bool hold = false, bool fsp = true){


return m_ts.fnPlayer_setActionThread(player, name, hold, fsp);
}
/// <summary>
/// @brief Set the sequence that controls the player's arms (dynamically adjusted    to match look direction).   @param name Name of the sequence to play on the player's arms.   @return true if successful, false if failed.   @note By default the 'look' sequence is used, if available.)
/// </summary>
public  bool setArmThread(string player, string name){


return m_ts.fnPlayer_setArmThread(player, name);
}
/// <summary>
/// @brief Set the object to be controlled by this player   It is possible to have the moves sent to the Player object from the    GameConnection to be passed along to another object.  This happens, for example    when a player is mounted to a vehicle.  The move commands pass through the Player    and on to the vehicle (while the player remains stationary within the vehicle).     With setControlObject() you can have the Player pass along its moves to any object.     One possible use is for a player to move a remote controlled vehicle.  In this case    the player does not mount the vehicle directly, but still wants to be able to control it.   @param obj Object to control with this player   @return True if the object is valid, false if not   @see getControlObject()   @see clearControlObject()   @see GameConnection::setControlObject())
/// </summary>
public  bool setControlObject(string player, string obj){


return m_ts.fnPlayer_setControlObject(player, obj);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class PopupMenuObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public PopupMenuObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// (GuiCanvas, pos, title))
/// </summary>
public  void PopupMenu_attachToMenuBar(string popupmenu, string canvasName, int pos, string title){


m_ts.fn_PopupMenu_attachToMenuBar(popupmenu, canvasName, pos, title);
}
/// <summary>
/// (pos, checked))
/// </summary>
public  void PopupMenu_checkItem(string popupmenu, int pos, bool checkedx){


m_ts.fn_PopupMenu_checkItem(popupmenu, pos, checkedx);
}
/// <summary>
/// (firstPos, lastPos, checkPos))
/// </summary>
public  void PopupMenu_checkRadioItem(string popupmenu, int firstPos, int lastPos, int checkPos){


m_ts.fn_PopupMenu_checkRadioItem(popupmenu, firstPos, lastPos, checkPos);
}
/// <summary>
/// (pos, enabled))
/// </summary>
public  void PopupMenu_enableItem(string popupmenu, int pos, bool enabled){


m_ts.fn_PopupMenu_enableItem(popupmenu, pos, enabled);
}
/// <summary>
/// ())
/// </summary>
public  int PopupMenu_getItemCount(string popupmenu){


return m_ts.fn_PopupMenu_getItemCount(popupmenu);
}
/// <summary>
/// , ), (pos[, title][, accelerator]))
/// </summary>
public  int PopupMenu_insertItem(string popupmenu, int pos, string title = "", string accelerator = ""){


return m_ts.fn_PopupMenu_insertItem(popupmenu, pos, title, accelerator);
}
/// <summary>
/// (pos, title, subMenu))
/// </summary>
public  int PopupMenu_insertSubMenu(string popupmenu, int pos, string title, string subMenu){


return m_ts.fn_PopupMenu_insertSubMenu(popupmenu, pos, title, subMenu);
}
/// <summary>
/// (pos))
/// </summary>
public  bool PopupMenu_isItemChecked(string popupmenu, int pos){


return m_ts.fn_PopupMenu_isItemChecked(popupmenu, pos);
}
/// <summary>
/// ())
/// </summary>
public  void PopupMenu_removeFromMenuBar(string popupmenu){


m_ts.fn_PopupMenu_removeFromMenuBar(popupmenu);
}
/// <summary>
/// (pos))
/// </summary>
public  void PopupMenu_removeItem(string popupmenu, int pos){


m_ts.fn_PopupMenu_removeItem(popupmenu, pos);
}
/// <summary>
/// ), (pos, title[, accelerator]))
/// </summary>
public  bool PopupMenu_setItem(string popupmenu, int pos, string title, string accelerator = ""){


return m_ts.fn_PopupMenu_setItem(popupmenu, pos, title, accelerator);
}
/// <summary>
/// (Canvas,[x, y]))
/// </summary>
public  void PopupMenu_showPopup(string popupmenu, string canvasName, int x = -1, int y = -1){


m_ts.fn_PopupMenu_showPopup(popupmenu, canvasName, x, y);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class PortalObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public PortalObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Test whether the portal connects interior zones to the outdoor zone.   @return True if the portal is an exterior portal. )
/// </summary>
public  bool isExteriorPortal(string portal){


return m_ts.fnPortal_isExteriorPortal(portal);
}
/// <summary>
/// Test whether the portal connects interior zones only.   @return True if the portal is an interior portal. )
/// </summary>
public  bool isInteriorPortal(string portal){


return m_ts.fnPortal_isInteriorPortal(portal);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class PostEffectObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public PostEffectObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Remove all shader macros. )
/// </summary>
public  void clearShaderMacros(string posteffect){


m_ts.fnPostEffect_clearShaderMacros(posteffect);
}
/// <summary>
/// Disables the effect. )
/// </summary>
public  void disable(string posteffect){


m_ts.fnPostEffect_disable(posteffect);
}
/// <summary>
/// Dumps this PostEffect shader's disassembly to a temporary text file.   @return Full path to the dumped file or an empty string if failed. )
/// </summary>
public  string dumpShaderDisassembly(string posteffect){


return m_ts.fnPostEffect_dumpShaderDisassembly(posteffect);
}
/// <summary>
/// Enables the effect. )
/// </summary>
public  void enable(string posteffect){


m_ts.fnPostEffect_enable(posteffect);
}
/// <summary>
/// @return Width over height of the backbuffer. )
/// </summary>
public  float getAspectRatio(string posteffect){


return m_ts.fnPostEffect_getAspectRatio(posteffect);
}
/// <summary>
/// @return True if the effect is enabled. )
/// </summary>
public  bool isEnabled(string posteffect){


return m_ts.fnPostEffect_isEnabled(posteffect);
}
/// <summary>
/// Reloads the effect shader and textures. )
/// </summary>
public  void reload(string posteffect){


m_ts.fnPostEffect_reload(posteffect);
}
/// <summary>
/// Remove a shader macro. This will usually be called within the preProcess callback.   @param key Macro to remove. )
/// </summary>
public  void removeShaderMacro(string posteffect, string key){


m_ts.fnPostEffect_removeShaderMacro(posteffect, key);
}
/// <summary>
/// Sets the value of a uniform defined in the shader. This will usually    be called within the setShaderConsts callback. Array type constants are    not supported.       @param name Name of the constanst, prefixed with '$'.    @param value Value to set, space seperate values with more than one element.   @tsexample   function MyPfx::setShaderConsts( %this )   {      // example float4 uniform      %this.setShaderConst( \"$colorMod\", \"1.0 0.9 1.0 1.0\" );      // example float1 uniform      %this.setShaderConst( \"$strength\", \"3.0\" );      // example integer uniform      %this.setShaderConst( \"$loops\", \"5\" );   }   @endtsexample )   
/// </summary>
public  void setShaderConst(string posteffect, string name, string value){


m_ts.fnPostEffect_setShaderConst(posteffect, name, value);
}
/// <summary>
///  ),   Adds a macro to the effect's shader or sets an existing one's value.    This will usually be called within the onAdd or preProcess callback.   @param key lval of the macro.   @param value rval of the macro, or may be empty.   @tsexample   function MyPfx::onAdd( %this )   {      %this.setShaderMacro( \"NUM_SAMPLES\", \"10\" );      %this.setShaderMacro( \"HIGH_QUALITY_MODE\" );            // In the shader looks like...       // #define NUM_SAMPLES 10      // #define HIGH_QUALITY_MODE   }   @endtsexample )
/// </summary>
public  void setShaderMacro(string posteffect, string key, string value = ""){


m_ts.fnPostEffect_setShaderMacro(posteffect, key, value);
}
/// <summary>
/// This is used to set the texture file and load the texture on a running effect.    If the texture file is not different from the current file nothing is changed.  If    the texture cannot be found a null texture is assigned.       @param index The texture stage index.    @param filePath The file name of the texture to set. )
/// </summary>
public  void setTexture(string posteffect, int index, string filePath){


m_ts.fnPostEffect_setTexture(posteffect, index, filePath);
}
/// <summary>
/// Toggles the effect between enabled / disabled.   @return True if effect is enabled. )
/// </summary>
public  bool toggle(string posteffect){


return m_ts.fnPostEffect_toggle(posteffect);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class PrecipitationObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public PrecipitationObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Smoothly change the maximum number of drops in the effect (from current    value to #numDrops * @a percentage).   This method can be used to simulate a storm building or fading in intensity    as the number of drops in the Precipitation box changes.   @param percentage New maximum number of drops value (as a percentage of    #numDrops). Valid range is 0-1.   @param seconds Length of time (in seconds) over which to increase the drops    percentage value. Set to 0 to change instantly.   @tsexample   %percentage = 0.5;  // The percentage, from 0 to 1, of the maximum drops to display   %seconds = 5.0;     // The length of time over which to make the change.   %precipitation.modifyStorm( %percentage, %seconds );   @endtsexample )
/// </summary>
public  void modifyStorm(string precipitation, float percentage = 1.0f, float seconds = 5.0f){


m_ts.fnPrecipitation_modifyStorm(precipitation, percentage, seconds);
}
/// <summary>
/// Sets the maximum number of drops in the effect, as a percentage of #numDrops.   The change occurs instantly (use modifyStorm() to change the number of drops    over a period of time.   @param percentage New maximum number of drops value (as a percentage of    #numDrops). Valid range is 0-1.   @tsexample   %percentage = 0.5;  // The percentage, from 0 to 1, of the maximum drops to display   %precipitation.setPercentage( %percentage );   @endtsexample   @see modifyStorm )
/// </summary>
public  void setPercentage(string precipitation, float percentage = 1.0f){


m_ts.fnPrecipitation_setPercentage(precipitation, percentage);
}
/// <summary>
/// Smoothly change the turbulence parameters over a period of time.   @param max New #maxTurbulence value. Set to 0 to disable turbulence.   @param speed New #turbulenceSpeed value.   @param seconds Length of time (in seconds) over which to interpolate the    turbulence settings. Set to 0 to change instantly.   @tsexample   %turbulence = 0.5;     // Set the new turbulence value. Set to 0 to disable turbulence.   %speed = 5.0;          // The new speed of the turbulance effect.   %seconds = 5.0;        // The length of time over which to make the change.   %precipitation.setTurbulence( %turbulence, %speed, %seconds );   @endtsexample )
/// </summary>
public  void setTurbulence(string precipitation, float max = 1.0f, float speed = 5.0f, float seconds = 5.0f){


m_ts.fnPrecipitation_setTurbulence(precipitation, max, speed, seconds);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ProjectileObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ProjectileObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Updates the projectile's positional and collision information.                                       This function will first delete the projectile if it is a server object and is outside it's ProjectileData::lifetime.                                        Also responsible for applying gravity, determining collisions, triggering explosions,                                        emitting trail particles, and calculating bounces if necessary.									            @param seconds Amount of time, in seconds since the simulation's start, to advance.									            @tsexample									               // Tell the projectile to process a simulation event, and provide the amount of time										            // that has passed since the simulation began.										            %seconds = 2.0;										            %projectile.presimulate(%seconds);									            @endtsexample                                       @note This function is not called if the SimObject::hidden is true.)
/// </summary>
public  void presimulate(string projectile, float seconds = 1.0f){


m_ts.fnProjectile_presimulate(projectile, seconds);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ProximityMineObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ProximityMineObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Manually cause the mine to explode.)
/// </summary>
public  void explode(string proximitymine){


m_ts.fnProximityMine_explode(proximitymine);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ReadXMLObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ReadXMLObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// readXMLObj.readFile();)
/// 
/// </summary>
public  bool ReadXML_readFile(string readxml){


return m_ts.fn_ReadXML_readFile(readxml);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class RenderBinManagerObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public RenderBinManagerObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Returns the bin type string. )
/// </summary>
public  string getBinType(string renderbinmanager){


return m_ts.fnRenderBinManager_getBinType(renderbinmanager);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class RenderMeshExampleObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public RenderMeshExampleObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// A utility method for forcing a network update.)
/// </summary>
public  void postApply(string rendermeshexample){


m_ts.fnRenderMeshExample_postApply(rendermeshexample);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class RenderPassManagerObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public RenderPassManagerObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Add as a render bin manager to the pass. )
/// </summary>
public  void addManager(string renderpassmanager, string renderBin){


m_ts.fnRenderPassManager_addManager(renderpassmanager, renderBin);
}
/// <summary>
/// Returns the render bin manager at the index or null if the index is out of range. )
/// </summary>
public  string getManager(string renderpassmanager, int index){


return m_ts.fnRenderPassManager_getManager(renderpassmanager, index);
}
/// <summary>
/// Returns the total number of bin managers. )
/// </summary>
public  int getManagerCount(string renderpassmanager){


return m_ts.fnRenderPassManager_getManagerCount(renderpassmanager);
}
/// <summary>
/// Removes a render bin manager. )
/// </summary>
public  void removeManager(string renderpassmanager, string renderBin){


m_ts.fnRenderPassManager_removeManager(renderpassmanager, renderBin);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class RenderPassStateTokenObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public RenderPassStateTokenObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Disables the token.)
/// </summary>
public  void disable(string renderpassstatetoken){


m_ts.fnRenderPassStateToken_disable(renderpassstatetoken);
}
/// <summary>
/// @brief Enables the token. )
/// </summary>
public  void enable(string renderpassstatetoken){


m_ts.fnRenderPassStateToken_enable(renderpassstatetoken);
}
/// <summary>
/// @brief Toggles the token from enabled to disabled or vice versa. )
/// </summary>
public  void toggle(string renderpassstatetoken){


m_ts.fnRenderPassStateToken_toggle(renderpassstatetoken);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class RigidShapeObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public RigidShapeObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Forces the client to jump to the RigidShape's transform rather then warp to it.)
/// </summary>
public  void forceClientTransform(string rigidshape){


m_ts.fnRigidShape_forceClientTransform(rigidshape);
}
/// <summary>
/// @brief Enables or disables the physics simulation on the RigidShape object.   @param isFrozen Boolean frozen state to set the object.   @tsexample   // Define the frozen state.   %isFrozen = \"true\";   // Inform the object of the defined frozen state   %thisRigidShape.freezeSim(%isFrozen);   @endtsexample   @see ShapeBaseData)
/// </summary>
public  void freezeSim(string rigidshape, bool isFrozen){


m_ts.fnRigidShape_freezeSim(rigidshape, isFrozen);
}
/// <summary>
/// @brief Clears physic forces from the shape and sets it at rest.   @tsexample   // Inform the RigidShape object to reset.   %thisRigidShape.reset();   @endtsexample   @see ShapeBaseData)
/// </summary>
public  void reset(string rigidshape){


m_ts.fnRigidShape_reset(rigidshape);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class RiverObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public RiverObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Intended as a helper to developers and editor scripts.                   Force River to recreate its geometry.                   )
/// </summary>
public  void regenerate(string river){


m_ts.fnRiver_regenerate(river);
}
/// <summary>
/// Intended as a helper to developers and editor scripts.                   BatchSize is not currently used.                   )
/// </summary>
public  void setBatchSize(string river, float meters){


m_ts.fnRiver_setBatchSize(river, meters);
}
/// <summary>
/// Intended as a helper to developers and editor scripts.                   @see SubdivideLength field.                   )
/// </summary>
public  void setMaxDivisionSize(string river, float meters){


m_ts.fnRiver_setMaxDivisionSize(river, meters);
}
/// <summary>
/// Intended as a helper to developers and editor scripts.                   @see SegmentLength field.                   )
/// </summary>
public  void setMetersPerSegment(string river, float meters){


m_ts.fnRiver_setMetersPerSegment(river, meters);
}
/// <summary>
/// Intended as a helper to developers and editor scripts.                   Sets the depth in meters of a particular node.                   )
/// </summary>
public  void setNodeDepth(string river, int idx, float meters){


m_ts.fnRiver_setNodeDepth(river, idx, meters);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ScatterSkyObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ScatterSkyObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Apply a full network update of all fields to all clients.                  )
/// </summary>
public  void applyChanges(string scattersky){


m_ts.fnScatterSky_applyChanges(scattersky);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SceneObjectObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SceneObjectObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Get Euler rotation of this object.   @return the orientation of the object in the form of rotations around the    X, Y and Z axes in degrees. )
/// </summary>
public  Point3F getEulerRotation(string sceneobject){


return new Point3F ( m_ts.fnSceneObject_getEulerRotation(sceneobject));
}
/// <summary>
/// Get the direction this object is facing.   @return a vector indicating the direction this object is facing.   @note This is the object's y axis. )
/// </summary>
public  Point3F getForwardVector(string sceneobject){


return new Point3F ( m_ts.fnSceneObject_getForwardVector(sceneobject));
}
/// <summary>
/// Get the object's inverse transform.   @return the inverse transform of the object )
/// </summary>
public  TransformF getInverseTransform(string sceneobject){


return new TransformF ( m_ts.fnSceneObject_getInverseTransform(sceneobject));
}
/// <summary>
/// Get the object mounted at a particular slot.   @param slot mount slot index to query   @return ID of the object mounted in the slot, or 0 if no object. )
/// </summary>
public  int getMountedObject(string sceneobject, int slot){


return m_ts.fnSceneObject_getMountedObject(sceneobject, slot);
}
/// <summary>
/// Get the number of objects mounted to us.   @return the number of mounted objects. )
/// </summary>
public  int getMountedObjectCount(string sceneobject){


return m_ts.fnSceneObject_getMountedObjectCount(sceneobject);
}
/// <summary>
/// @brief Get the mount node index of the object mounted at our given slot.   @param slot mount slot index to query   @return index of the mount node used by the object mounted in this slot. )
/// </summary>
public  int getMountedObjectNode(string sceneobject, int slot){


return m_ts.fnSceneObject_getMountedObjectNode(sceneobject, slot);
}
/// <summary>
/// @brief Get the object mounted at our given node index.   @param node mount node index to query   @return ID of the first object mounted at the node, or 0 if none found. )
/// </summary>
public  int getMountNodeObject(string sceneobject, int node){


return m_ts.fnSceneObject_getMountNodeObject(sceneobject, node);
}
/// <summary>
/// Get the object's bounding box (relative to the object's origin).   @return six fields, two Point3Fs, containing the min and max points of the    objectbox. )
/// </summary>
public  Box3F getObjectBox(string sceneobject){


return new Box3F ( m_ts.fnSceneObject_getObjectBox(sceneobject));
}
/// <summary>
/// @brief Get the object we are mounted to.   @return the SimObjectID of the object we're mounted to, or 0 if not mounted. )
/// </summary>
public  int getObjectMount(string sceneobject){


return m_ts.fnSceneObject_getObjectMount(sceneobject);
}
/// <summary>
/// Get the object's world position.   @return the current world position of the object )
/// </summary>
public  Point3F getPosition(string sceneobject){


return new Point3F ( m_ts.fnSceneObject_getPosition(sceneobject));
}
/// <summary>
/// Get the right vector of the object.   @return a vector indicating the right direction of this object.   @note This is the object's x axis. )
/// </summary>
public  Point3F getRightVector(string sceneobject){


return new Point3F ( m_ts.fnSceneObject_getRightVector(sceneobject));
}
/// <summary>
/// Get the object's scale.   @return object scale as a Point3F )
/// </summary>
public  Point3F getScale(string sceneobject){


return new Point3F ( m_ts.fnSceneObject_getScale(sceneobject));
}
/// <summary>
/// Get the object's transform.   @return the current transform of the object )
/// </summary>
public  TransformF getTransform(string sceneobject){


return new TransformF ( m_ts.fnSceneObject_getTransform(sceneobject));
}
/// <summary>
/// Return the type mask for this object.   @return The numeric type mask for the object. )
/// </summary>
public  int getType(string sceneobject){


return m_ts.fnSceneObject_getType(sceneobject);
}
/// <summary>
/// Get the up vector of the object.   @return a vector indicating the up direction of this object.   @note This is the object's z axis. )
/// </summary>
public  Point3F getUpVector(string sceneobject){


return new Point3F ( m_ts.fnSceneObject_getUpVector(sceneobject));
}
/// <summary>
/// Get the object's world bounding box.   @return six fields, two Point3Fs, containing the min and max points of the    worldbox. )
/// </summary>
public  Box3F getWorldBox(string sceneobject){


return new Box3F ( m_ts.fnSceneObject_getWorldBox(sceneobject));
}
/// <summary>
/// Get the center of the object's world bounding box.   @return the center of the world bounding box for this object. )
/// </summary>
public  Point3F getWorldBoxCenter(string sceneobject){


return new Point3F ( m_ts.fnSceneObject_getWorldBoxCenter(sceneobject));
}
/// <summary>
/// Check if this object has a global bounds set.   If global bounds are set to be true, then the object is assumed to have an    infinitely large bounding box for collision and rendering purposes.   @return true if the object has a global bounds. )
/// </summary>
public  bool isGlobalBounds(string sceneobject){


return m_ts.fnSceneObject_isGlobalBounds(sceneobject);
}
/// <summary>
/// @brief Check if we are mounted to another object.   @return true if mounted to another object, false if not mounted. )
/// </summary>
public  bool isMounted(string sceneobject){


return m_ts.fnSceneObject_isMounted(sceneobject);
}
/// <summary>
/// @brief Mount objB to this object at the desired slot with optional transform.   @param objB  Object to mount onto us   @param slot  Mount slot ID   @param txfm (optional) mount offset transform   @return true if successful, false if failed (objB is not valid) )
/// </summary>
public  bool mountObject(string sceneobject, string objB, int slot, TransformF txfm = null ){
if (txfm== null) {txfm = new TransformF("0.000000,0.000000,0.000000,1.000000,0.000000,0.000000,0.000000");}


return m_ts.fnSceneObject_mountObject(sceneobject, objB, slot, txfm.AsString());
}
/// <summary>
/// Set the object's scale.   @param scale object scale to set )
/// </summary>
public  void setScale(string sceneobject, Point3F scale){


m_ts.fnSceneObject_setScale(sceneobject, scale.AsString());
}
/// <summary>
/// Set the object's transform (orientation and position).   @param txfm object transform to set )
/// </summary>
public  void setTransform(string sceneobject, TransformF txfm){


m_ts.fnSceneObject_setTransform(sceneobject, txfm.AsString());
}
/// <summary>
/// @brief Adds a new counter or updates an existing counter to be tracked via ticks.   @return true if successful, false if failed )
/// </summary>
public  bool TickCounterAdd(string sceneobject, string countername, uint interval){


return m_ts.fnSceneObject_TickCounterAdd(sceneobject, countername, interval);
}
/// <summary>
/// @brief returns the interval for a counter.   @return true if successful, false if failed )
/// </summary>
public  uint TickCounterGetInterval(string sceneobject, string countername){


return m_ts.fnSceneObject_TickCounterGetInterval(sceneobject, countername);
}
/// <summary>
/// @brief Checks to see if the counter exists.   @return true if successful, false if failed )
/// </summary>
public  bool TickCounterHas(string sceneobject, string countername){


return m_ts.fnSceneObject_TickCounterHas(sceneobject, countername);
}
/// <summary>
/// @brief Removes a counter to be tracked via ticks.   @return true if successful, false if failed )
/// </summary>
public  bool TickCounterRemove(string sceneobject, string countername){


return m_ts.fnSceneObject_TickCounterRemove(sceneobject, countername);
}
/// <summary>
/// @brief resets the current count for a counter.   @return true if successful, false if failed )
/// </summary>
public  void TickCounterReset(string sceneobject, string countername){


m_ts.fnSceneObject_TickCounterReset(sceneobject, countername);
}
/// <summary>
/// @brief Clears all counters from the object.)   
/// </summary>
public  void TickCountersClear(string sceneobject){


m_ts.fnSceneObject_TickCountersClear(sceneobject);
}
/// <summary>
/// @brief Adds a new counter to be tracked via ticks.    )
/// </summary>
public  void TickCounterSuspend(string sceneobject, string countername, bool suspend){


m_ts.fnSceneObject_TickCounterSuspend(sceneobject, countername, suspend);
}
/// <summary>
/// Unmount us from the currently mounted object if any. )
/// </summary>
public  void unmount(string sceneobject){


m_ts.fnSceneObject_unmount(sceneobject);
}
/// <summary>
/// @brief Unmount an object from ourselves.   @param target object to unmount   @return true if successful, false if failed )
/// </summary>
public  bool unmountObject(string sceneobject, string target){


return m_ts.fnSceneObject_unmountObject(sceneobject, target);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ScriptTickObjectObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ScriptTickObjectObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Is this object wanting to receive tick notifications.   If this object is set to receive tick notifications then its onInterpolateTick() and    onProcessTick() callbacks are called.   @return True if object wants tick notifications )
/// </summary>
public  bool isProcessingTicks(string scripttickobject){


return m_ts.fnScriptTickObject_isProcessingTicks(scripttickobject);
}
/// <summary>
/// @brief Sets this object as either tick processing or not.   @param tick This object's onInterpolateTick() and onProcessTick() callbacks are called if set to true.)
/// </summary>
public  void setProcessTicks(string scripttickobject, bool tick){


m_ts.fnScriptTickObject_setProcessTicks(scripttickobject, tick);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SettingsObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SettingsObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// settingObj.beginGroup(groupName, fromStart = false);)
/// </summary>
public  void Settings_beginGroup(string settings, string groupName, bool includeDefaults = false){


m_ts.fn_Settings_beginGroup(settings, groupName, includeDefaults);
}
/// <summary>
/// settingObj.clearGroups();)
/// </summary>
public  void Settings_clearGroups(string settings){


m_ts.fn_Settings_clearGroups(settings);
}
/// <summary>
/// settingObj.endGroup();)
/// </summary>
public  void Settings_endGroup(string settings){


m_ts.fn_Settings_endGroup(settings);
}
/// <summary>
/// , false, false), settingObj.findFirstValue();)
/// </summary>
public  string Settings_findFirstValue(string settings, string pattern = "", bool deepSearch = false, bool includeDefaults = false){


return m_ts.fn_Settings_findFirstValue(settings, pattern, deepSearch, includeDefaults);
}
/// <summary>
/// settingObj.findNextValue();)
/// </summary>
public  string Settings_findNextValue(string settings){


return m_ts.fn_Settings_findNextValue(settings);
}
/// <summary>
/// settingObj.getCurrentGroups();)
/// </summary>
public  string Settings_getCurrentGroups(string settings){


return m_ts.fn_Settings_getCurrentGroups(settings);
}
/// <summary>
/// %success = settingObj.read();)
/// </summary>
public  bool Settings_read(string settings){


return m_ts.fn_Settings_read(settings);
}
/// <summary>
/// settingObj.remove(settingName, includeDefaults = false);)
/// </summary>
public  void Settings_remove(string settings, string settingName, bool includeDefaults = false){


m_ts.fn_Settings_remove(settings, settingName, includeDefaults);
}
/// <summary>
/// settingObj.setDefaultValue(settingName, value);)
/// </summary>
public  void Settings_setDefaultValue(string settings, string settingName, string value){


m_ts.fn_Settings_setDefaultValue(settings, settingName, value);
}
/// <summary>
/// ), settingObj.setValue(settingName, value);)
/// </summary>
public  void Settings_setValue(string settings, string settingName, string value = ""){


m_ts.fn_Settings_setValue(settings, settingName, value);
}
/// <summary>
/// ), settingObj.value(settingName, defaultValue);)
/// </summary>
public  string Settings_value(string settings, string settingName, string defaultValue = ""){


return m_ts.fn_Settings_value(settings, settingName, defaultValue);
}
/// <summary>
/// (Settings, write, bool, 2, 2, %success = settingObj.write();)
/// </summary>
public  bool write(string settings= ""){


return m_ts.fnSettings_write(settings);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SFXControllerObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SFXControllerObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Get the index of the playlist slot currently processed by the controller.   @return The slot index currently being played.   @see SFXPlayList )
/// </summary>
public  int getCurrentSlot(string sfxcontroller){


return m_ts.fnSFXController_getCurrentSlot(sfxcontroller);
}
/// <summary>
/// Set the index of the playlist slot to play by the controller.  This can be used to seek in the playlist.   @param index Index of the playlist slot. )
/// </summary>
public  void setCurrentSlot(string sfxcontroller, int index){


m_ts.fnSFXController_setCurrentSlot(sfxcontroller, index);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SFXEmitterObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SFXEmitterObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Get the sound source object from the emitter.   @return The sound source used by the emitter or null.   @note This method will return null when called on the server-side SFXEmitter object.  Only client-side ghosts       actually hold on to %SFXSources. )
/// </summary>
public  string getSource(string sfxemitter){


return m_ts.fnSFXEmitter_getSource(sfxemitter);
}
/// <summary>
/// Manually start playback of the emitter's sound.   If this is called on the server-side object, the play command will be related to all client-side ghosts. )
/// </summary>
public  void play(string sfxemitter){


m_ts.fnSFXEmitter_play(sfxemitter);
}
/// <summary>
/// Manually stop playback of the emitter's sound.   If this is called on the server-side object, the stop command will be related to all client-side ghosts. )
/// </summary>
public  void stop(string sfxemitter){


m_ts.fnSFXEmitter_stop(sfxemitter);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SFXParameterObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SFXParameterObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Get the name of the parameter.   @return The paramete name. )
/// </summary>
public  string getParameterName(string sfxparameter){


return m_ts.fnSFXParameter_getParameterName(sfxparameter);
}
/// <summary>
/// Reset the parameter's value to its default.   @see SFXParameter::defaultValue )
/// </summary>
public  void reset(string sfxparameter){


m_ts.fnSFXParameter_reset(sfxparameter);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SFXProfileObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SFXProfileObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Return the length of the sound data in seconds.   @return The length of the sound data in seconds or 0 if the sound referenced by the profile could not be found. )
/// </summary>
public  float getSoundDuration(string sfxprofile){


return m_ts.fnSFXProfile_getSoundDuration(sfxprofile);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SFXSoundObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SFXSoundObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Get the total play time (in seconds) of the sound data attached to the sound.   @return    @note Be aware that for looped sounds, this will not return the total playback time of the sound. )
/// </summary>
public  float getDuration(string sfxsound){


return m_ts.fnSFXSound_getDuration(sfxsound);
}
/// <summary>
/// Get the current playback position in seconds.   @return The current play cursor offset. )
/// </summary>
public  float getPosition(string sfxsound){


return m_ts.fnSFXSound_getPosition(sfxsound);
}
/// <summary>
/// Test whether the sound data associated with the sound has been fully loaded and is ready for playback.   For streamed sounds, this will be false during playback when the stream queue for the sound is starved and    waiting for data.  For buffered sounds, only an initial loading phase will potentially cause isReady to    return false.   @return True if the sound is ready for playback. )
/// </summary>
public  bool isReady(string sfxsound){


return m_ts.fnSFXSound_isReady(sfxsound);
}
/// <summary>
/// Set the current playback position in seconds.   If the source is currently playing, playback will jump to the new position.  If playback is stopped or paused,    playback will resume at the given position when play() is called.   @param position The new position of the play cursor (in seconds). )
/// </summary>
public  void setPosition(string sfxsound, float position){


m_ts.fnSFXSound_setPosition(sfxsound, position);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SFXSourceObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SFXSourceObject(ref Omni ts){m_ts = ts;}
/// <summary>
///  ),   ( vector position [, vector direction ] )    Set the position and orientation of a 3D sound source.   @hide )
/// </summary>
public  void SFXSource_setTransform(string sfxsource, string position, string direction = ""){


m_ts.fn_SFXSource_setTransform(sfxsource, position, direction);
}
/// <summary>
/// Add a notification marker called @a name at @a pos seconds of playback.   @param name Symbolic name for the marker that will be passed to the onMarkerPassed() callback.   @param pos Playback position in seconds when the notification should trigger.  Note that this is a soft limit and there       may be a delay between the play cursor actually passing the position and the callback being triggered.   @note For looped sounds, the marker will trigger on each iteration.   @tsexample   // Create a new source.   $source = sfxCreateSource( AudioMusicLoop2D, \"art/sound/backgroundMusic\" );      // Assign a class to the source.   $source.class = \"BackgroundMusic\";      // Add a playback marker at one minute into playback.   $source.addMarker( \"first\", 60 );      // Define the callback function.  This function will be called when the playback position passes the one minute mark.   function BackgroundMusic::onMarkerPassed( %this, %markerName )   {      if( %markerName $= \"first\" )         echo( \"Playback has passed the 60 seconds mark.\" );   }      // Play the sound.   $source.play();   @endtsexample )
/// </summary>
public  void addMarker(string sfxsource, string name, float pos){


m_ts.fnSFXSource_addMarker(sfxsource, name, pos);
}
/// <summary>
/// Attach @a parameter to the source,   Once attached, the source will react to value changes of the given @a parameter.  Attaching a parameter    will also trigger an initial read-out of the parameter's current value.   @param parameter The parameter to attach to the source. )
/// </summary>
public  void addParameter(string sfxsource, string parameter){


m_ts.fnSFXSource_addParameter(sfxsource, parameter);
}
/// <summary>
/// Get the final effective volume level of the source.   This method returns the volume level as it is after source group volume modulation, fades, and distance-based    volume attenuation have been applied to the base volume level.   @return The effective volume of the source.   @ref SFXSource_volume )
/// </summary>
public  float getAttenuatedVolume(string sfxsource){


return m_ts.fnSFXSource_getAttenuatedVolume(sfxsource);
}
/// <summary>
/// Get the fade-in time set on the source.   This will initially be SFXDescription::fadeInTime.   @return The fade-in time set on the source in seconds.   @see SFXDescription::fadeInTime   @ref SFXSource_fades )
/// </summary>
public  float getFadeInTime(string sfxsource){


return m_ts.fnSFXSource_getFadeInTime(sfxsource);
}
/// <summary>
/// Get the fade-out time set on the source.   This will initially be SFXDescription::fadeOutTime.   @return The fade-out time set on the source in seconds.   @see SFXDescription::fadeOutTime   @ref SFXSource_fades )
/// </summary>
public  float getFadeOutTime(string sfxsource){


return m_ts.fnSFXSource_getFadeOutTime(sfxsource);
}
/// <summary>
/// Get the parameter at the given index.   @param index Index of the parameter to fetch.  Must be 0=index=getParameterCount().   @return The parameter at the given @a index or null if @a index is out of range.   @tsexample      // Print the name ofo each parameter attached to %source.      %numParams = %source.getParameterCount();      for( %i = 0; %i  %numParams; %i ++ )         echo( %source.getParameter( %i ).getParameterName() );   @endtsexample   @see getParameterCount )
/// </summary>
public  string getParameter(string sfxsource, int index){


return m_ts.fnSFXSource_getParameter(sfxsource, index);
}
/// <summary>
/// Get the number of SFXParameters that are attached to the source.   @return The number of parameters attached to the source.   @tsexample      // Print the name ofo each parameter attached to %source.      %numParams = %source.getParameterCount();      for( %i = 0; %i  %numParams; %i ++ )         echo( %source.getParameter( %i ).getParameterName() );   @endtsexample   @see getParameter   @see addParameter )
/// </summary>
public  int getParameterCount(string sfxsource){


return m_ts.fnSFXSource_getParameterCount(sfxsource);
}
/// <summary>
/// Get the pitch scale of the source.   Pitch determines the playback speed of the source (default: 1).   @return The current pitch scale factor of the source.   @see setPitch   @see SFXDescription::pitch )
/// </summary>
public  float getPitch(string sfxsource){


return m_ts.fnSFXSource_getPitch(sfxsource);
}
/// <summary>
/// Get the current playback status.   @return Te current playback status )
/// </summary>
public  TypeSFXStatus getStatus(string sfxsource){


return (TypeSFXStatus)( m_ts.fnSFXSource_getStatus(sfxsource));
}
/// <summary>
/// Get the current base volume level of the source.   This is not the final effective volume that the source is playing at but rather the starting    volume level before source group modulation, fades, or distance-based volume attenuation are applied.   @return The current base volume level.   @see setVolume   @see SFXDescription::volume   @ref SFXSource_volume )
/// </summary>
public  float getVolume(string sfxsource){


return m_ts.fnSFXSource_getVolume(sfxsource);
}
/// <summary>
/// Test whether the source is currently paused.   @return True if the source is in paused state, false otherwise.   @see pause   @see getStatus   @see SFXStatus )
/// </summary>
public  bool isPaused(string sfxsource){


return m_ts.fnSFXSource_isPaused(sfxsource);
}
/// <summary>
/// Test whether the source is currently playing.   @return True if the source is in playing state, false otherwise.   @see play   @see getStatus   @see SFXStatus )
/// </summary>
public  bool isPlaying(string sfxsource){


return m_ts.fnSFXSource_isPlaying(sfxsource);
}
/// <summary>
/// Test whether the source is currently stopped.   @return True if the source is in stopped state, false otherwise.   @see stop   @see getStatus   @see SFXStatus )
/// </summary>
public  bool isStopped(string sfxsource){


return m_ts.fnSFXSource_isStopped(sfxsource);
}
/// <summary>
/// Pause playback of the source.   @param fadeOutTime Seconds for the sound to fade down to zero volume.  If -1, the SFXDescription::fadeOutTime       set in the source's associated description is used.  Pass 0 to disable a fade-out effect that may be       configured on the description.      Be aware that if a fade-out effect is used, the source will not immediately to paused state but will       rather remain in playing state until the fade-out time has expired.. )
/// </summary>
public  void pause(string sfxsource, float fadeOutTime = -1.0f){


m_ts.fnSFXSource_pause(sfxsource, fadeOutTime);
}
/// <summary>
/// Start playback of the source.   If the sound data for the source has not yet been fully loaded, there will be a delay after calling    play and playback will start after the data has become available.   @param fadeInTime Seconds for the sound to reach full volume.  If -1, the SFXDescription::fadeInTime       set in the source's associated description is used.  Pass 0 to disable a fade-in effect that may       be configured on the description. )
/// </summary>
public  void play(string sfxsource, float fadeInTime = -1.0f){


m_ts.fnSFXSource_play(sfxsource, fadeInTime);
}
/// <summary>
/// Detach @a parameter from the source.   Once detached, the source will no longer react to value changes of the given @a parameter.   If the parameter is not attached to the source, the method will do nothing.   @param parameter The parameter to detach from the source. )
/// </summary>
public  void removeParameter(string sfxsource, string parameter){


m_ts.fnSFXSource_removeParameter(sfxsource, parameter);
}
/// <summary>
/// Set up the 3D volume cone for the source.   @param innerAngle Angle of the inner sound cone in degrees (@ref SFXDescription::coneInsideAngle).  Must be 0=innerAngle=360.   @param outerAngle Angle of the outer sound cone in degrees (@ref SFXDescription::coneOutsideAngle).  Must be 0=outerAngle=360.   @param outsideVolume Volume scale factor outside of outer cone (@ref SFXDescription::coneOutsideVolume).  Must be 0=outsideVolume=1.   @note This method has no effect on the source if the source is not 3D. )
/// </summary>
public  void setCone(string sfxsource, float innerAngle, float outerAngle, float outsideVolume){


m_ts.fnSFXSource_setCone(sfxsource, innerAngle, outerAngle, outsideVolume);
}
/// <summary>
/// Set the fade time parameters of the source.   @param fadeInTime The new fade-in time in seconds.   @param fadeOutTime The new fade-out time in seconds.   @see SFXDescription::fadeInTime   @see SFXDescription::fadeOutTime   @ref SFXSource_fades )
/// </summary>
public  void setFadeTimes(string sfxsource, float fadeInTime, float fadeOutTime){


m_ts.fnSFXSource_setFadeTimes(sfxsource, fadeInTime, fadeOutTime);
}
/// <summary>
/// Set the pitch scale of the source.   Pitch determines the playback speed of the source (default: 1).   @param pitch The new pitch scale factor.   @see getPitch   @see SFXDescription::pitch )
/// </summary>
public  void setPitch(string sfxsource, float pitch){


m_ts.fnSFXSource_setPitch(sfxsource, pitch);
}
/// <summary>
/// Set the base volume level for the source.   This volume will be the starting point for source group volume modulation, fades, and distance-based    volume attenuation.   @param volume The new base volume level for the source.  Must be 0>=volume=1.   @see getVolume   @ref SFXSource_volume )
/// </summary>
public  void setVolume(string sfxsource, float volume){


m_ts.fnSFXSource_setVolume(sfxsource, volume);
}
/// <summary>
/// Stop playback of the source.   @param fadeOutTime Seconds for the sound to fade down to zero volume.  If -1, the SFXDescription::fadeOutTime       set in the source's associated description is used.  Pass 0 to disable a fade-out effect that may be       configured on the description.      Be aware that if a fade-out effect is used, the source will not immediately transtion to stopped state but       will rather remain in playing state until the fade-out time has expired. )
/// </summary>
public  void stop(string sfxsource, float fadeOutTime = -1.0f){


m_ts.fnSFXSource_stop(sfxsource, fadeOutTime);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SFXStateObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SFXStateObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Increase the activation count on the state.   If the state isn't already active and it is not disabled, the state will be activated.   @see isActive   @see deactivate )
/// </summary>
public  void activate(string sfxstate){


m_ts.fnSFXState_activate(sfxstate);
}
/// <summary>
/// Decrease the activation count on the state.   If the count reaches zero and the state was not disabled, the state will be deactivated.   @see isActive   @see activate )
/// </summary>
public  void deactivate(string sfxstate){


m_ts.fnSFXState_deactivate(sfxstate);
}
/// <summary>
/// Increase the disabling count of the state.   If the state is currently active, it will be deactivated.   @see isDisabled )
/// </summary>
public  void disable(string sfxstate){


m_ts.fnSFXState_disable(sfxstate);
}
/// <summary>
/// Decrease the disabling count of the state.   If the disabling count reaches zero while the activation count is still non-zero,       the state will be reactivated again.   @see isDisabled )
/// </summary>
public  void enable(string sfxstate){


m_ts.fnSFXState_enable(sfxstate);
}
/// <summary>
/// Test whether the state is currently active.   This is true when the activation count is >0 and the disabling count is =0.   @return True if the state is currently active.   @see activate )
/// </summary>
public  bool isActive(string sfxstate){


return m_ts.fnSFXState_isActive(sfxstate);
}
/// <summary>
/// Test whether the state is currently disabled.   This is true when the disabling count of the state is non-zero.   @return True if the state is disabled.   @see disable )
/// </summary>
public  bool isDisabled(string sfxstate){


return m_ts.fnSFXState_isDisabled(sfxstate);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ShaderDataObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ShaderDataObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Rebuilds all the vertex and pixel shader instances created from this ShaderData.				   @tsexample				   // Rebuild the shader instances from ShaderData CloudLayerShader				   CloudLayerShader.reload();				   @endtsexample)
/// </summary>
public  void reload(string shaderdata){


m_ts.fnShaderData_reload(shaderdata);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ShapeBaseObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ShapeBaseObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Increment the current damage level by the specified amount.   @param amount value to add to current damage level )
/// </summary>
public  void applyDamage(string shapebase, float amount){


m_ts.fnShapeBase_applyDamage(shapebase, amount);
}
/// <summary>
/// @brief Apply an impulse to the object.   @param pos world position of the impulse   @param vec impulse momentum (velocity * mass)   @return true )
/// </summary>
public  bool applyImpulse(string shapebase, Point3F pos, Point3F vec){


return m_ts.fnShapeBase_applyImpulse(shapebase, pos.AsString(), vec.AsString());
}
/// <summary>
/// @brief Repair damage by the specified amount.   Note that the damage level is only reduced by repairRate per tick, so it may    take several ticks for the total repair to complete.   @param amount total repair value (subtracted from damage level over time) )
/// </summary>
public  void applyRepair(string shapebase, float amount){


m_ts.fnShapeBase_applyRepair(shapebase, amount);
}
/// <summary>
/// @brief Explodes an object into pieces.)
/// </summary>
public  void blowUp(string shapebase){


m_ts.fnShapeBase_blowUp(shapebase);
}
/// <summary>
/// @brief Check if this object can cloak.   @return true      @note Not implemented as it always returns true.)
/// </summary>
public  bool canCloak(string shapebase){


return m_ts.fnShapeBase_canCloak(shapebase);
}
/// <summary>
/// @brief Change one of the materials on the shape.   This method changes materials per mapTo with others. The material that    is being replaced is mapped to unmapped_mat as a part of this transition.   @note Warning, right now this only sort of works. It doesn't do a live    update like it should.   @param mapTo the name of the material target to remap (from getTargetName)   @param oldMat the old Material that was mapped    @param newMat the new Material to map   @tsexample   // remap the first material in the shape   %mapTo = %obj.getTargetName( 0 );   %obj.changeMaterial( %mapTo, 0, MyMaterial );   @endtsexample )
/// </summary>
public  void changeMaterial(string shapebase, string mapTo, string oldMat, string newMat){


m_ts.fnShapeBase_changeMaterial(shapebase, mapTo, oldMat, newMat);
}
/// <summary>
/// @brief Destroy an animation thread, which prevents it from playing.   @param slot thread slot to destroy   @return true if successful, false if failed      @see playThread )
/// </summary>
public  bool destroyThread(string shapebase, int slot){


return m_ts.fnShapeBase_destroyThread(shapebase, slot);
}
/// <summary>
/// @brief Print a list of visible and hidden meshes in the shape to the console    for debugging purposes.   @note Only in a SHIPPING build.)
/// </summary>
public  void dumpMeshVisibility(string shapebase){


m_ts.fnShapeBase_dumpMeshVisibility(shapebase);
}
/// <summary>
/// @brief Get the position at which the AI should stand to repair things.   If the shape defines a node called \"AIRepairNode\", this method will    return the current world position of that node, otherwise \"0 0 0\".   @return the AI repair position )
/// </summary>
public  Point3F getAIRepairPoint(string shapebase){


return new Point3F ( m_ts.fnShapeBase_getAIRepairPoint(shapebase));
}
/// <summary>
/// @brief Returns the vertical field of view in degrees for this object if used as a camera.   @return current FOV as defined in ShapeBaseData::cameraDefaultFov )
/// </summary>
public  float getCameraFov(string shapebase){


return m_ts.fnShapeBase_getCameraFov(shapebase);
}
/// <summary>
/// @brief Get the client (if any) that controls this object.   The controlling client is the one that will send moves to us to act on.   @return the ID of the controlling GameConnection, or 0 if this object is not    controlled by any client.      @see GameConnection)
/// </summary>
public  int getControllingClient(string shapebase){


return m_ts.fnShapeBase_getControllingClient(shapebase);
}
/// <summary>
/// @brief Get the object (if any) that controls this object.   @return the ID of the controlling ShapeBase object, or 0 if this object is    not controlled by another object. )
/// </summary>
public  int getControllingObject(string shapebase){


return m_ts.fnShapeBase_getControllingObject(shapebase);
}
/// <summary>
/// @brief Get the damage flash level.   @return flash level   @see setDamageFlash )
/// </summary>
public  float getDamageFlash(string shapebase){


return m_ts.fnShapeBase_getDamageFlash(shapebase);
}
/// <summary>
/// @brief Get the object's current damage level.   @return damage level      @see setDamageLevel())
/// </summary>
public  float getDamageLevel(string shapebase){


return m_ts.fnShapeBase_getDamageLevel(shapebase);
}
/// <summary>
/// @brief Get the object's current damage level as a percentage of maxDamage.   @return damageLevel / datablock.maxDamage      @see setDamageLevel())
/// </summary>
public  float getDamagePercent(string shapebase){


return m_ts.fnShapeBase_getDamagePercent(shapebase);
}
/// <summary>
/// @brief Get the object's damage state.   @return the damage state; one of \"Enabled\", \"Disabled\", \"Destroyed\"      @see setDamageState())
/// </summary>
public  string getDamageState(string shapebase){


return m_ts.fnShapeBase_getDamageState(shapebase);
}
/// <summary>
/// @brief Returns the default vertical field of view in degrees for this object if used as a camera.   @return Default FOV )
/// </summary>
public  float getDefaultCameraFov(string shapebase){


return m_ts.fnShapeBase_getDefaultCameraFov(shapebase);
}
/// <summary>
/// @brief Get the object's current energy level.   @return energy level      @see setEnergyLevel())
/// </summary>
public  float getEnergyLevel(string shapebase){


return m_ts.fnShapeBase_getEnergyLevel(shapebase);
}
/// <summary>
/// @brief Get the object's current energy level as a percentage of maxEnergy.   @return energyLevel / datablock.maxEnergy   @see setEnergyLevel())
/// </summary>
public  float getEnergyPercent(string shapebase){


return m_ts.fnShapeBase_getEnergyPercent(shapebase);
}
/// <summary>
/// @brief Get the position of the 'eye' for this object.   If the object model has a node called 'eye', this method will return that    node's current world position, otherwise it will return the object's current    world position.   @return the eye position for this object   @see getEyeVector   @see getEyeTransform )
/// </summary>
public  Point3F getEyePoint(string shapebase){


return new Point3F ( m_ts.fnShapeBase_getEyePoint(shapebase));
}
/// <summary>
/// @brief Get the 'eye' transform for this object.   If the object model has a node called 'eye', this method will return that    node's current transform, otherwise it will return the object's current    transform.   @return the eye transform for this object   @see getEyeVector   @see getEyePoint )
/// </summary>
public  TransformF getEyeTransform(string shapebase){


return new TransformF ( m_ts.fnShapeBase_getEyeTransform(shapebase));
}
/// <summary>
/// @brief Get the forward direction of the 'eye' for this object.   If the object model has a node called 'eye', this method will return that    node's current forward direction vector, otherwise it will return the    object's current forward direction vector.   @return the eye vector for this object   @see getEyePoint   @see getEyeTransform )
/// </summary>
public  Point3F getEyeVector(string shapebase){


return new Point3F ( m_ts.fnShapeBase_getEyeVector(shapebase));
}
/// <summary>
/// @brief Get the alt trigger state of the Image mounted in the specified slot.   @param slot Image slot to query   @return the Image's current alt trigger state )
/// </summary>
public  bool getImageAltTrigger(string shapebase, int slot){


return m_ts.fnShapeBase_getImageAltTrigger(shapebase, slot);
}
/// <summary>
/// @brief Get the ammo state of the Image mounted in the specified slot.   @param slot Image slot to query   @return the Image's current ammo state )
/// </summary>
public  bool getImageAmmo(string shapebase, int slot){


return m_ts.fnShapeBase_getImageAmmo(shapebase, slot);
}
/// <summary>
/// @brief Get the generic trigger state of the Image mounted in the specified slot.   @param slot Image slot to query   @param trigger Generic trigger number   @return the Image's current generic trigger state )
/// </summary>
public  bool getImageGenericTrigger(string shapebase, int slot, int trigger){


return m_ts.fnShapeBase_getImageGenericTrigger(shapebase, slot, trigger);
}
/// <summary>
/// @brief Get the loaded state of the Image mounted in the specified slot.   @param slot Image slot to query   @return the Image's current loaded state )
/// </summary>
public  bool getImageLoaded(string shapebase, int slot){


return m_ts.fnShapeBase_getImageLoaded(shapebase, slot);
}
/// <summary>
/// @brief Get the script animation prefix of the Image mounted in the specified slot.   @param slot Image slot to query   @return the Image's current script animation prefix )
/// </summary>
public  string getImageScriptAnimPrefix(string shapebase, int slot){


return m_ts.fnShapeBase_getImageScriptAnimPrefix(shapebase, slot);
}
/// <summary>
/// @brief Get the skin tag ID for the Image mounted in the specified slot.   @param slot Image slot to query   @return the skinTag value passed to mountImage when the image was    mounted )
/// </summary>
public  int getImageSkinTag(string shapebase, int slot){


return m_ts.fnShapeBase_getImageSkinTag(shapebase, slot);
}
/// <summary>
/// @brief Get the name of the current state of the Image in the specified slot.   @param slot Image slot to query   @return name of the current Image state, or \"Error\" if slot is invalid )
/// </summary>
public  string getImageState(string shapebase, int slot){


return m_ts.fnShapeBase_getImageState(shapebase, slot);
}
/// <summary>
/// @brief Get the target state of the Image mounted in the specified slot.   @param slot Image slot to query   @return the Image's current target state )
/// </summary>
public  bool getImageTarget(string shapebase, int slot){


return m_ts.fnShapeBase_getImageTarget(shapebase, slot);
}
/// <summary>
/// @brief Get the trigger state of the Image mounted in the specified slot.   @param slot Image slot to query   @return the Image's current trigger state )
/// </summary>
public  bool getImageTrigger(string shapebase, int slot){


return m_ts.fnShapeBase_getImageTrigger(shapebase, slot);
}
/// <summary>
/// @brief Get the world position this object is looking at.   Casts a ray from the eye and returns information about what the ray hits.   @param distance maximum distance of the raycast   @param typeMask typeMask of objects to include for raycast collision testing   @return look-at information as \"Object HitX HitY HitZ [Material]\" or empty string for no hit   @tsexample   %lookat = %obj.getLookAtPoint();   echo( \"Looking at: \" @ getWords( %lookat, 1, 3 ) );   @endtsexample )
/// </summary>
public  string getLookAtPoint(string shapebase, float distance = 2000, uint typeMask = 0xFFFFFFFF){


return m_ts.fnShapeBase_getLookAtPoint(shapebase, distance, typeMask);
}
/// <summary>
/// Get the object's maxDamage level.     @return datablock.maxDamage)    
/// </summary>
public  float getMaxDamage(string shapebase){


return m_ts.fnShapeBase_getMaxDamage(shapebase);
}
/// <summary>
/// @brief Get the model filename used by this shape.   @return the shape filename )
/// </summary>
public  string getModelFile(string shapebase){


return m_ts.fnShapeBase_getModelFile(shapebase);
}
/// <summary>
/// @brief Get the Image mounted in the specified slot.   @param slot Image slot to query   @return ID of the ShapeBaseImageData datablock mounted in the slot, or 0    if no Image is mounted there. )
/// </summary>
public  int getMountedImage(string shapebase, int slot){


return m_ts.fnShapeBase_getMountedImage(shapebase, slot);
}
/// <summary>
/// @brief Get the first slot the given datablock is mounted to on this object.   @param image ShapeBaseImageData datablock to query   @return index of the first slot the Image is mounted in, or -1 if the Image    is not mounted in any slot on this object. )
/// </summary>
public  int getMountSlot(string shapebase, string image){


return m_ts.fnShapeBase_getMountSlot(shapebase, image);
}
/// <summary>
/// @brief Get the muzzle position of the Image mounted in the specified slot.   If the Image shape contains a node called 'muzzlePoint', then the muzzle    position is the position of that node in world space. If no such node    is specified, the slot's mount node is used instead.   @param slot Image slot to query   @return the muzzle position, or \"0 0 0\" if the slot is invalid )
/// </summary>
public  Point3F getMuzzlePoint(string shapebase, int slot){


return new Point3F ( m_ts.fnShapeBase_getMuzzlePoint(shapebase, slot));
}
/// <summary>
/// @brief Get the muzzle vector of the Image mounted in the specified slot.   If the Image shape contains a node called 'muzzlePoint', then the muzzle    vector is the forward direction vector of that node's transform in world    space. If no such node is specified, the slot's mount node is used    instead.   If the correctMuzzleVector flag (correctMuzzleVectorTP in 3rd person)    is set in the Image, the muzzle vector is computed to point at whatever    object is right in front of the object's 'eye' node.   @param slot Image slot to query   @return the muzzle vector, or \"0 1 0\" if the slot is invalid )
/// </summary>
public  Point3F getMuzzleVector(string shapebase, int slot){


return new Point3F ( m_ts.fnShapeBase_getMuzzleVector(shapebase, slot));
}
/// <summary>
/// @brief Get the Image that will be mounted next in the specified slot.   Calling mountImage when an Image is already mounted does one of two things:    ol>li>Mount the new Image immediately, the old Image is discarded and    whatever state it was in is ignored./li>   li>If the current Image state does not allow Image changes, the new    Image is marked as pending, and will not be mounted until the current    state completes. eg. if the user changes weapons, you may wish to ensure    that the current weapon firing state plays to completion first./li>/ol>   This command retrieves the ID of the pending Image (2nd case above).      @param slot Image slot to query   @return ID of the pending ShapeBaseImageData datablock, or 0 if none. )
/// </summary>
public  int getPendingImage(string shapebase, int slot){


return m_ts.fnShapeBase_getPendingImage(shapebase, slot);
}
/// <summary>
/// @brief Get the current recharge rate.   @return the recharge rate (per tick)      @see setRechargeRate())
/// </summary>
public  float getRechargeRate(string shapebase){


return m_ts.fnShapeBase_getRechargeRate(shapebase);
}
/// <summary>
/// @brief Get the per-tick repair amount.   @return the current value to be subtracted from damage level each tick   @see setRepairRate )
/// </summary>
public  float getRepairRate(string shapebase){


return m_ts.fnShapeBase_getRepairRate(shapebase);
}
/// <summary>
/// @brief Get the name of the shape.   @note This is the name of the shape object that is sent to the client,    not the DTS or DAE model filename.   @return the name of the shape       @see setShapeName())
/// </summary>
public  string getShapeName(string shapebase){


return m_ts.fnShapeBase_getShapeName(shapebase);
}
/// <summary>
/// @brief Get the name of the skin applied to this shape.   @return the name of the skin    @see skin   @see setSkinName())
/// </summary>
public  string getSkinName(string shapebase){


return m_ts.fnShapeBase_getSkinName(shapebase);
}
/// <summary>
/// @brief Get the world transform of the specified mount slot.   @param slot Image slot to query   @return the mount transform )
/// </summary>
public  TransformF getSlotTransform(string shapebase, int slot){


return new TransformF ( m_ts.fnShapeBase_getSlotTransform(shapebase, slot));
}
/// <summary>
/// @brief Get the number of materials in the shape.   @return the number of materials in the shape.       @see getTargetName())
/// </summary>
public  int getTargetCount(string shapebase){


return m_ts.fnShapeBase_getTargetCount(shapebase);
}
/// <summary>
/// @brief Get the name of the indexed shape material.   @param index index of the material to get (valid range is 0 - getTargetCount()-1).   @return the name of the indexed material.      @see getTargetCount())
/// </summary>
public  string getTargetName(string shapebase, int index){


return m_ts.fnShapeBase_getTargetName(shapebase, index);
}
/// <summary>
/// @brief Get the object's current velocity.   @return the current velocity )
/// </summary>
public  Point3F getVelocity(string shapebase){


return new Point3F ( m_ts.fnShapeBase_getVelocity(shapebase));
}
/// <summary>
/// @brief Get the white-out level.   @return white-out level   @see setWhiteOut )
/// </summary>
public  float getWhiteOut(string shapebase){


return m_ts.fnShapeBase_getWhiteOut(shapebase);
}
/// <summary>
/// @brief Check if the given state exists on the mounted Image.   @param slot Image slot to query   @param state Image state to check for   @return true if the Image has the requested state defined. )
/// </summary>
public  bool hasImageState(string shapebase, int slot, string state){


return m_ts.fnShapeBase_hasImageState(shapebase, slot, state);
}
/// <summary>
/// @brief Check if this object is cloaked.   @return true if cloaked, false if not       @see setCloaked())
/// </summary>
public  bool isCloaked(string shapebase){


return m_ts.fnShapeBase_isCloaked(shapebase);
}
/// <summary>
/// @brief Check if the object is in the Destroyed damage state.   @return true if damage state is \"Destroyed\", false if not       @see isDisabled()   @see isEnabled())
/// </summary>
public  bool isDestroyed(string shapebase){


return m_ts.fnShapeBase_isDestroyed(shapebase);
}
/// <summary>
/// @brief Check if the object is in the Disabled or Destroyed damage state.   @return true if damage state is not \"Enabled\", false if it is      @see isDestroyed()   @see isEnabled())
/// </summary>
public  bool isDisabled(string shapebase){


return m_ts.fnShapeBase_isDisabled(shapebase);
}
/// <summary>
/// @brief Check if the object is in the Enabled damage state.   @return true if damage state is \"Enabled\", false if not      @see isDestroyed()   @see isDisabled())
/// </summary>
public  bool isEnabled(string shapebase){


return m_ts.fnShapeBase_isEnabled(shapebase);
}
/// <summary>
/// Check if the object is hidden.   @return true if the object is hidden, false if visible. )
/// </summary>
public  bool isHidden(string shapebase){


return m_ts.fnShapeBase_isHidden(shapebase);
}
/// <summary>
/// @brief Check if the current Image state is firing.   @param slot Image slot to query   @return true if the current Image state in this slot has the 'stateFire' flag set. )
/// </summary>
public  bool isImageFiring(string shapebase, int slot){


return m_ts.fnShapeBase_isImageFiring(shapebase, slot);
}
/// <summary>
/// @brief Check if the given datablock is mounted to any slot on this object.   @param image ShapeBaseImageData datablock to query   @return true if the Image is mounted to any slot, false otherwise. )
/// </summary>
public  bool isImageMounted(string shapebase, string image){


return m_ts.fnShapeBase_isImageMounted(shapebase, image);
}
/// <summary>
///  ),   @brief Mount a new Image.   @param image the Image to mount   @param slot Image slot to mount into (valid range is 0 - 3)   @param loaded initial loaded state for the Image   @param skinTag tagged string to reskin the mounted Image   @return true if successful, false if failed   @tsexample   %player.mountImage( PistolImage, 1 );   %player.mountImage( CrossbowImage, 0, false );   %player.mountImage( RocketLauncherImage, 0, true, 'blue' );   @endtsexample      @see unmountImage()   @see getMountedImage()   @see getPendingImage()   @see isImageMounted())
/// </summary>
public  bool mountImage(string shapebase, string image, int slot, bool loaded = true, string skinTag = ""){


return m_ts.fnShapeBase_mountImage(shapebase, image, slot, loaded, skinTag);
}
/// <summary>
/// @brief Pause an animation thread.      If restarted using playThread, the animation    will resume from the paused position.   @param slot thread slot to stop   @return true if successful, false if failed      @see playThread )
/// </summary>
public  bool pauseThread(string shapebase, int slot){


return m_ts.fnShapeBase_pauseThread(shapebase, slot);
}
/// <summary>
/// @brief Attach a sound to this shape and start playing it.   @param slot Audio slot index for the sound (valid range is 0 - 3)    @param track SFXTrack to play   @return true if the sound was attached successfully, false if failed      @see stopAudio())
/// </summary>
public  bool playAudio(string shapebase, int slot, string track){


return m_ts.fnShapeBase_playAudio(shapebase, slot, track);
}
/// <summary>
///  ),   @brief Start a new animation thread, or restart one that has been paused or    stopped.   @param slot thread slot to play. Valid range is 0 - 3)     @param name name of the animation sequence to play in this slot. If not    specified, the paused or stopped thread in this slot will be resumed.   @return true if successful, false if failed   @tsexample   %obj.playThread( 0, \"ambient\" );      // Play the ambient sequence in slot 0   %obj.setThreadTimeScale( 0, 0.5 );    // Play at half-speed   %obj.pauseThread( 0 );                // Pause the sequence   %obj.playThread( 0 );                 // Resume playback   %obj.playThread( 0, \"spin\" );         // Replace the sequence in slot 0   @endtsexample      @see pauseThread()   @see stopThread()   @see setThreadDir()   @see setThreadTimeScale()   @see destroyThread())
/// </summary>
public  bool playThread(string shapebase, int slot, string name = ""){


return m_ts.fnShapeBase_playThread(shapebase, slot, name);
}
/// <summary>
/// @brief Set the hidden state on all the shape meshes.   This allows you to hide all meshes in the shape, for example, and then only    enable a few.   @param hide new hidden state for all meshes )
/// </summary>
public  void setAllMeshesHidden(string shapebase, bool hide){


m_ts.fnShapeBase_setAllMeshesHidden(shapebase, hide);
}
/// <summary>
/// @brief Set the vertical field of view in degrees for this object if used as a camera.   @param fov new FOV value )
/// </summary>
public  void setCameraFov(string shapebase, float fov){


m_ts.fnShapeBase_setCameraFov(shapebase, fov);
}
/// <summary>
/// @brief Set the cloaked state of this object.   When an object is cloaked it is not rendered.   @param cloak true to cloak the object, false to uncloak      @see isCloaked())
/// </summary>
public  void setCloaked(string shapebase, bool cloak){


m_ts.fnShapeBase_setCloaked(shapebase, cloak);
}
/// <summary>
/// @brief Set the damage flash level.   Damage flash may be used as a postfx effect to flash the screen when the    client is damaged.   @note Relies on the flash postFx.   @param level flash level (0-1)      @see getDamageFlash())
/// </summary>
public  void setDamageFlash(string shapebase, float level){


m_ts.fnShapeBase_setDamageFlash(shapebase, level);
}
/// <summary>
/// @brief Set the object's current damage level.   @param level new damage level      @see getDamageLevel()   @see getDamagePercent())
/// </summary>
public  void setDamageLevel(string shapebase, float level){


m_ts.fnShapeBase_setDamageLevel(shapebase, level);
}
/// <summary>
/// @brief Set the object's damage state.   @param state should be one of \"Enabled\", \"Disabled\", \"Destroyed\"   @return true if successful, false if failed      @see getDamageState())
/// </summary>
public  bool setDamageState(string shapebase, string state){


return m_ts.fnShapeBase_setDamageState(shapebase, state);
}
/// <summary>
/// @brief Set the damage direction vector.   Currently this is only used to initialise the explosion if this object    is blown up.   @param vec damage direction vector   @tsexample   %obj.setDamageVector( \"0 0 1\" );   @endtsexample )
/// </summary>
public  void setDamageVector(string shapebase, Point3F vec){


m_ts.fnShapeBase_setDamageVector(shapebase, vec.AsString());
}
/// <summary>
/// @brief Set this object's current energy level.   @param level new energy level      @see getEnergyLevel()   @see getEnergyPercent())
/// </summary>
public  void setEnergyLevel(string shapebase, float level){


m_ts.fnShapeBase_setEnergyLevel(shapebase, level);
}
/// <summary>
/// @brief Add or remove this object from the scene.   When removed from the scene, the object will not be processed or rendered.   @param show False to hide the object, true to re-show it )
/// </summary>
public  void setHidden(string shapebase, bool show){


m_ts.fnShapeBase_setHidden(shapebase, show);
}
/// <summary>
/// @brief Set the alt trigger state of the Image mounted in the specified slot.   @param slot Image slot to modify   @param state new alt trigger state for the Image   @return the Image's new alt trigger state )
/// </summary>
public  bool setImageAltTrigger(string shapebase, int slot, bool state){


return m_ts.fnShapeBase_setImageAltTrigger(shapebase, slot, state);
}
/// <summary>
/// @brief Set the ammo state of the Image mounted in the specified slot.   @param slot Image slot to modify   @param state new ammo state for the Image   @return the Image's new ammo state )
/// </summary>
public  bool setImageAmmo(string shapebase, int slot, bool state){


return m_ts.fnShapeBase_setImageAmmo(shapebase, slot, state);
}
/// <summary>
/// @brief Set the generic trigger state of the Image mounted in the specified slot.   @param slot Image slot to modify   @param trigger Generic trigger number   @param state new generic trigger state for the Image   @return the Image's new generic trigger state or -1 if there was a problem. )
/// </summary>
public  int setImageGenericTrigger(string shapebase, int slot, int trigger, bool state){


return m_ts.fnShapeBase_setImageGenericTrigger(shapebase, slot, trigger, state);
}
/// <summary>
/// @brief Set the loaded state of the Image mounted in the specified slot.   @param slot Image slot to modify   @param state new loaded state for the Image   @return the Image's new loaded state )
/// </summary>
public  bool setImageLoaded(string shapebase, int slot, bool state){


return m_ts.fnShapeBase_setImageLoaded(shapebase, slot, state);
}
/// <summary>
/// @brief Set the script animation prefix for the Image mounted in the specified slot.   This is used to further modify the prefix used when deciding which animation sequence to    play while this image is mounted.   @param slot Image slot to modify   @param prefix The prefix applied to the image )
/// </summary>
public  void setImageScriptAnimPrefix(string shapebase, int slot, string prefix){


m_ts.fnShapeBase_setImageScriptAnimPrefix(shapebase, slot, prefix);
}
/// <summary>
/// @brief Set the target state of the Image mounted in the specified slot.   @param slot Image slot to modify   @param state new target state for the Image   @return the Image's new target state )
/// </summary>
public  bool setImageTarget(string shapebase, int slot, bool state){


return m_ts.fnShapeBase_setImageTarget(shapebase, slot, state);
}
/// <summary>
/// @brief Set the trigger state of the Image mounted in the specified slot.   @param slot Image slot to modify   @param state new trigger state for the Image   @return the Image's new trigger state )
/// </summary>
public  bool setImageTrigger(string shapebase, int slot, bool state){


return m_ts.fnShapeBase_setImageTrigger(shapebase, slot, state);
}
/// <summary>
/// @brief Setup the invincible effect.   This effect is used for HUD feedback to the user that they are invincible.   @note Currently not implemented   @param time duration in seconds for the invincible effect   @param speed speed at which the invincible effect progresses )
/// </summary>
public  void setInvincibleMode(string shapebase, float time, float speed){


m_ts.fnShapeBase_setInvincibleMode(shapebase, time, speed);
}
/// <summary>
/// @brief Set the hidden state on the named shape mesh.   @param name name of the mesh to hide/show   @param hide new hidden state for the mesh )
/// </summary>
public  void setMeshHidden(string shapebase, string name, bool hide){


m_ts.fnShapeBase_setMeshHidden(shapebase, name, hide);
}
/// <summary>
/// @brief Set the recharge rate.   The recharge rate is added to the object's current energy level each tick,    up to the maxEnergy level set in the ShapeBaseData datablock.      @param rate the recharge rate (per tick)      @see getRechargeRate())
/// </summary>
public  void setRechargeRate(string shapebase, float rate){


m_ts.fnShapeBase_setRechargeRate(shapebase, rate);
}
/// <summary>
/// @brief Set amount to repair damage by each tick.   Note that this value is separate to the repairRate field in ShapeBaseData.    This value will be subtracted from the damage level each tick, whereas the    ShapeBaseData field limits how much of the applyRepair value is subtracted    each tick. Both repair types can be active at the same time.      @param rate value to subtract from damage level each tick (must be > 0)      @see getRepairRate())
/// </summary>
public  void setRepairRate(string shapebase, float rate){


m_ts.fnShapeBase_setRepairRate(shapebase, rate);
}
/// <summary>
/// @brief Set the name of this shape.   @note This is the name of the shape object that is sent to the client,    not the DTS or DAE model filename.   @param name new name for the shape      @see getShapeName())
/// </summary>
public  void setShapeName(string shapebase, string name){


m_ts.fnShapeBase_setShapeName(shapebase, name);
}
/// <summary>
/// @brief Apply a new skin to this shape.   'Skinning' the shape effectively renames the material targets, allowing    different materials to be used on different instances of the same model.   @param name name of the skin to apply   @see skin   @see getSkinName())
/// </summary>
public  void setSkinName(string shapebase, string name){


m_ts.fnShapeBase_setSkinName(shapebase, name);
}
/// <summary>
/// @brief Set the playback direction of an animation thread.   @param slot thread slot to modify   @param fwd true to play the animation forwards, false to play backwards   @return true if successful, false if failed      @see playThread() )
/// </summary>
public  bool setThreadDir(string shapebase, int slot, bool fwd){


return m_ts.fnShapeBase_setThreadDir(shapebase, slot, fwd);
}
/// <summary>
/// @brief Set the position within an animation thread.   @param slot thread slot to modify   @param pos position within thread   @return true if successful, false if failed      @see playThread )
/// </summary>
public  bool setThreadPosition(string shapebase, int slot, float pos){


return m_ts.fnShapeBase_setThreadPosition(shapebase, slot, pos);
}
/// <summary>
/// @brief Set the playback time scale of an animation thread.   @param slot thread slot to modify   @param scale new thread time scale (1=normal speed, 0.5=half speed etc)   @return true if successful, false if failed      @see playThread )
/// </summary>
public  bool setThreadTimeScale(string shapebase, int slot, float scale){


return m_ts.fnShapeBase_setThreadTimeScale(shapebase, slot, scale);
}
/// <summary>
/// @brief Set the object's velocity.   @param vel new velocity for the object   @return true )
/// </summary>
public  bool setVelocity(string shapebase, Point3F vel){


return m_ts.fnShapeBase_setVelocity(shapebase, vel.AsString());
}
/// <summary>
/// @brief Set the white-out level.   White-out may be used as a postfx effect to brighten the screen in response    to a game event.   @note Relies on the flash postFx.   @param level flash level (0-1)      @see getWhiteOut())
/// </summary>
public  void setWhiteOut(string shapebase, float level){


m_ts.fnShapeBase_setWhiteOut(shapebase, level);
}
/// <summary>
/// @brief Fade the object in or out without removing it from the scene.   A faded out object is still in the scene and can still be collided with,    so if you want to disable collisions for this shape after it fades out    use setHidden to temporarily remove this shape from the scene.     @note Items have the ability to light their surroundings. When an Item with    an active light is fading out, the light it emits is correspondingly    reduced until it goes out. Likewise, when the item fades in, the light is    turned-up till it reaches it's normal brightntess.   @param time duration of the fade effect in ms   @param delay delay in ms before the fade effect begins   @param fadeOut true to fade-out to invisible, false to fade-in to full visibility )
/// </summary>
public  void startFade(string shapebase, int time, int delay, bool fadeOut){


m_ts.fnShapeBase_startFade(shapebase, time, delay, fadeOut);
}
/// <summary>
/// @brief Stop a sound started with playAudio.   @param slot audio slot index (started with playAudio)   @return true if the sound was stopped successfully, false if failed      @see playAudio())
/// </summary>
public  bool stopAudio(string shapebase, int slot){


return m_ts.fnShapeBase_stopAudio(shapebase, slot);
}
/// <summary>
/// @brief Stop an animation thread.   If restarted using playThread, the animation    will start from the beginning again.   @param slot thread slot to stop   @return true if successful, false if failed      @see playThread )
/// </summary>
public  bool stopThread(string shapebase, int slot){


return m_ts.fnShapeBase_stopThread(shapebase, slot);
}
/// <summary>
/// @brief Unmount the mounted Image in the specified slot.   @param slot Image slot to unmount   @return true if successful, false if failed      @see mountImage())
/// </summary>
public  bool unmountImage(string shapebase, int slot){


return m_ts.fnShapeBase_unmountImage(shapebase, slot);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ShapeBaseDataObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ShapeBaseDataObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Check if there is the space at the given transform is free to spawn into.   The shape's bounding box volume is used to check for collisions at the given world    transform.  Only interior and static objects are checked for collision.   @param txfm Deploy transform to check   @return True if the space is free, false if there is already something in    the way.   @note This is a server side only check, and is not actually limited to spawning.)
/// </summary>
public  bool checkDeployPos(string shapebasedata, TransformF txfm){


return m_ts.fnShapeBaseData_checkDeployPos(shapebasedata, txfm.AsString());
}
/// <summary>
/// @brief Helper method to get a transform from a position and vector (suitable for use with setTransform).   @param pos Desired transform position   @param normal Vector of desired direction   @return The deploy transform )
/// </summary>
public  TransformF getDeployTransform(string shapebasedata, Point3F pos, Point3F normal){


return new TransformF ( m_ts.fnShapeBaseData_getDeployTransform(shapebasedata, pos.AsString(), normal.AsString()));
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SimComponentObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SimComponentObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// (idx) Get the component corresponding to the given index.			  @param idx An integer index value corresponding to the desired component.			  @return The id of the component at the given index as an integer)
/// </summary>
public  int SimComponent_getComponent(string simcomponent, int idx){


return m_ts.fn_SimComponent_getComponent(simcomponent, idx);
}
/// <summary>
/// () Get the current component count			  @return The number of components in the list as an integer)
/// </summary>
public  int SimComponent_getComponentCount(string simcomponent){


return m_ts.fn_SimComponent_getComponentCount(simcomponent);
}
/// <summary>
/// () Check whether SimComponent is currently a template			  @return true if is a template and false if not)
/// </summary>
public  bool SimComponent_getIsTemplate(string simcomponent){


return m_ts.fn_SimComponent_getIsTemplate(simcomponent);
}
/// <summary>
/// () Check whether SimComponent is currently enabled			  @return true if enabled and false if not)
/// </summary>
public  bool SimComponent_isEnabled(string simcomponent){


return m_ts.fn_SimComponent_isEnabled(simcomponent);
}
/// <summary>
/// (enabled) Sets or unsets the enabled flag			  @param enabled Boolean value			  @return No return value)
/// </summary>
public  void SimComponent_setEnabled(string simcomponent, bool enabled){


m_ts.fn_SimComponent_setEnabled(simcomponent, enabled);
}
/// <summary>
/// (template) Sets or unsets the template flag			  @param template Boolean value			  @return No return value)
/// </summary>
public  void SimComponent_setIsTemplate(string simcomponent, bool templateFlag){


m_ts.fn_SimComponent_setIsTemplate(simcomponent, templateFlag);
}
/// <summary>
/// ( SimComponent, addComponents, bool, 3, 64, %obj.addComponents( %compObjName, %compObjName2, ... );			  Adds additional components to current list.			  @param Up to 62 component names			  @return Returns true on success, false otherwise.)
/// </summary>
public  bool addComponents(string simcomponent, string a2= "", string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= "", string a20= "", string a21= "", string a22= "", string a23= "", string a24= "", string a25= "", string a26= "", string a27= "", string a28= "", string a29= "", string a30= "", string a31= "", string a32= "", string a33= "", string a34= "", string a35= "", string a36= "", string a37= "", string a38= "", string a39= "", string a40= "", string a41= "", string a42= "", string a43= "", string a44= "", string a45= "", string a46= "", string a47= "", string a48= "", string a49= "", string a50= "", string a51= "", string a52= "", string a53= "", string a54= "", string a55= "", string a56= "", string a57= "", string a58= "", string a59= "", string a60= "", string a61= "", string a62= "", string a63= ""){


return m_ts.fnSimComponent_addComponents(simcomponent, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a51, a52, a53, a54, a55, a56, a57, a58, a59, a60, a61, a62, a63);
}
/// <summary>
/// ( SimComponent, removeComponents, bool, 3, 64, %obj.removeComponents( %compObjName, %compObjName2, ... );			  Removes components by name from current list.			  @param objNamex Up to 62 component names			  @return Returns true on success, false otherwise.)
/// </summary>
public  bool removeComponents(string simcomponent, string a2= "", string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= "", string a20= "", string a21= "", string a22= "", string a23= "", string a24= "", string a25= "", string a26= "", string a27= "", string a28= "", string a29= "", string a30= "", string a31= "", string a32= "", string a33= "", string a34= "", string a35= "", string a36= "", string a37= "", string a38= "", string a39= "", string a40= "", string a41= "", string a42= "", string a43= "", string a44= "", string a45= "", string a46= "", string a47= "", string a48= "", string a49= "", string a50= "", string a51= "", string a52= "", string a53= "", string a54= "", string a55= "", string a56= "", string a57= "", string a58= "", string a59= "", string a60= "", string a61= "", string a62= "", string a63= ""){


return m_ts.fnSimComponent_removeComponents(simcomponent, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a51, a52, a53, a54, a55, a56, a57, a58, a59, a60, a61, a62, a63);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SimDataBlockObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SimDataBlockObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Reload the datablock.  This can only be used with a local client configuration. )
/// </summary>
public  void SimDataBlock_reloadOnLocalClient(string simdatablock){


m_ts.fn_SimDataBlock_reloadOnLocalClient(simdatablock);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SimObjectObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SimObjectObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Copy fields from another object onto this one.  The objects must 
///    be of same type. Everything from the object will overwrite what's 
///    in this object; extra fields in this object will remain. This 
///    includes dynamic fields.
///    @param fromObject The object from which to copy fields. )
/// 
/// </summary>
public  void SimObject_assignFieldsFrom(string simobject, string fromObject){


m_ts.fn_SimObject_assignFieldsFrom(simobject, fromObject);
}
/// <summary>
/// Delete and remove the object. )
/// 
/// </summary>
public  void SimObject_delete(string simobject){


m_ts.fn_SimObject_delete(simobject);
}
/// <summary>
/// Dump the native C++ class hierarchy of this object's C++ class to the console. )
/// 
/// </summary>
public  void SimObject_dumpClassHierarchy(string simobject){


m_ts.fn_SimObject_dumpClassHierarchy(simobject);
}
/// <summary>
/// List the methods defined on this object.
///    Each description is a newline-separated vector with the following elements:
///    - Minimum number of arguments.
///    - Maximum number of arguments.
///    - Prototype string.
///    - Full script file path (if script method).
///    - Line number of method definition in script (if script method).
///    - Documentation string (not including prototype).  This takes up the remainder of the vector.
///    @return An ArrayObject populated with (name,description) pairs of all methods defined on the object. )
/// 
/// </summary>
public  string SimObject_dumpMethods(string simobject){


return m_ts.fn_SimObject_dumpMethods(simobject);
}
/// <summary>
/// Get whether the object will be included in saves.
///    @return True if the object will be saved; false otherwise. )
/// 
/// </summary>
public  bool SimObject_getCanSave(string simobject){


return m_ts.fn_SimObject_getCanSave(simobject);
}
/// <summary>
/// Get the name of the C++ class which the object is an instance of.
///    @return The name of the C++ class of the object. )
/// 
/// </summary>
public  string SimObject_getClassName(string simobject){


return m_ts.fn_SimObject_getClassName(simobject);
}
/// <summary>
/// Get the name of the class namespace assigned to this object.
///    @return The name of the 'class' namespace. )
/// 
/// </summary>
public  string SimObject_getClassNamespace(string simobject){


return m_ts.fn_SimObject_getClassNamespace(simobject);
}
/// <summary>
/// Get the line number at which the object is defined in its file.
///    @return The line number of the object's definition in script.
///    @see getFilename())
/// 
/// </summary>
public  int SimObject_getDeclarationLine(string simobject){


return m_ts.fn_SimObject_getDeclarationLine(simobject);
}
/// <summary>
/// Get a value of a dynamic field by index.
///    @param index The index of the dynamic field.
///    @return The value of the dynamic field at the given index or \"\". )
/// 
/// </summary>
public  string SimObject_getDynamicField(string simobject, int index){


return m_ts.fn_SimObject_getDynamicField(simobject, index);
}
/// <summary>
/// Get the number of dynamic fields defined on the object.
///    @return The number of dynamic fields defined on the object. )
/// 
/// </summary>
public  int SimObject_getDynamicFieldCount(string simobject){


return m_ts.fn_SimObject_getDynamicFieldCount(simobject);
}
/// <summary>
/// Retrieve the value of a static field by index.
///    @param index The index of the static field.
///    @return The value of the static field with the given index or \"\". )
/// 
/// </summary>
public  string SimObject_getField(string simobject, int index){


return m_ts.fn_SimObject_getField(simobject, index);
}
/// <summary>
/// Get the number of static fields on the object.
///    @return The number of static fields defined on the object. )
/// 
/// </summary>
public  int SimObject_getFieldCount(string simobject){


return m_ts.fn_SimObject_getFieldCount(simobject);
}
/// <summary>
/// Get the console type code of the given field.
///    @return The numeric type code for the underlying console type of the given field. )
/// 
/// </summary>
public  string SimObject_getFieldType(string simobject, string fieldName){


return m_ts.fn_SimObject_getFieldType(simobject, fieldName);
}
/// <summary>
/// Return the value of the given field on this object.
///    @param fieldName The name of the field.  If it includes a field index, the index is parsed out.
///    @param index Optional parameter to specify the index of an array field separately.
///    @return The value of the given field or \"\" if undefined. )
/// 
/// </summary>
public  string SimObject_getFieldValue(string simobject, string fieldName, int index = -1){


return m_ts.fn_SimObject_getFieldValue(simobject, fieldName, index);
}
/// <summary>
/// Returns the filename the object is attached to.
///    @return The name of the file the object is associated with; usually the file the object was loaded from. )
/// 
/// </summary>
public  string SimObject_getFilename(string simobject){


return m_ts.fn_SimObject_getFilename(simobject);
}
/// <summary>
/// Get the name of the superclass namespace assigned to this object.
///    @return The name of the 'superClass' namespace. )
/// 
/// </summary>
public  string SimObject_getSuperClassNamespace(string simobject){


return m_ts.fn_SimObject_getSuperClassNamespace(simobject);
}
/// <summary>
/// ())
/// 
/// </summary>
public  bool SimObject_isEnabled(string simobject){


return m_ts.fn_SimObject_isEnabled(simobject);
}
/// <summary>
/// Get whether the object has been marked as expanded. (in editor)
///    @return True if the object is marked expanded. )
/// 
/// </summary>
public  bool SimObject_isExpanded(string simobject){


return m_ts.fn_SimObject_isExpanded(simobject);
}
/// <summary>
/// Test whether the given field is defined on this object.
///    @param fieldName The name of the field.
///    @return True if the object implements the given field. )
/// 
/// </summary>
public  bool SimObject_isField(string simobject, string fieldName){


return m_ts.fn_SimObject_isField(simobject, fieldName);
}
/// <summary>
/// Test whether the namespace of this object is a direct or indirect child to the given namespace.
///    @param name The name of a namespace.
///    @return True if the given namespace name is within the namespace hierarchy of this object. )
/// 
/// </summary>
public  bool SimObject_isInNamespaceHierarchy(string simobject, string name){


return m_ts.fn_SimObject_isInNamespaceHierarchy(simobject, name);
}
/// <summary>
/// Test whether this object is a member of the specified class.
///    @param className Name of a native C++ class.
///    @return True if this object is an instance of the given C++ class or any of its super classes. )
/// 
/// </summary>
public  bool SimObject_isMemberOfClass(string simobject, string className){


return m_ts.fn_SimObject_isMemberOfClass(simobject, className);
}
/// <summary>
/// Test whether the given method is defined on this object.
///    @param The name of the method.
///    @return True if the object implements the given method. )
/// 
/// </summary>
public  bool SimObject_isMethod(string simobject, string methodName){


return m_ts.fn_SimObject_isMethod(simobject, methodName);
}
/// <summary>
///  ),
///    Save out the object to the given file.
///    @param fileName The name of the file to save to.
///    @param selectedOnly If true, only objects marked as selected will be saved out.
///    @param preAppendString Text which will be preprended directly to the object serialization.
///    @param True on success, false on failure. )
/// 
/// </summary>
public  bool SimObject_save(string simobject, string fileName, bool selectedOnly = false, string preAppendString = ""){


return m_ts.fn_SimObject_save(simobject, fileName, selectedOnly, preAppendString);
}
/// <summary>
/// Retrieve the value of a static field by index.
///    @param index The index of the static field.
///    @return The value of the static field with the given index or \"\". )
/// 
/// </summary>
public  bool SimObject_saveToXML(string simobject, string profileName, string fileName){


return m_ts.fn_SimObject_saveToXML(simobject, profileName, fileName);
}
/// <summary>
/// Set whether the object will be included in saves.
///    @param value If true, the object will be included in saves; if false, it will be excluded. )
/// 
/// </summary>
public  void SimObject_setCanSave(string simobject, bool value = true){


m_ts.fn_SimObject_setCanSave(simobject, value);
}
/// <summary>
/// Assign a class namespace to this object.
///    @param name The name of the 'class' namespace for this object. )
/// 
/// </summary>
public  void SimObject_setClassNamespace(string simobject, string name){


m_ts.fn_SimObject_setClassNamespace(simobject, name);
}
/// <summary>
/// (enabled))
/// 
/// </summary>
public  void SimObject_setEnabled(string simobject, bool enabled){


m_ts.fn_SimObject_setEnabled(simobject, enabled);
}
/// <summary>
/// Set the console type code for the given field.
///    @param fieldName The name of the dynamic field to change to type for.
///    @param type The name of the console type.
///    @note This only works for dynamic fields.  Types of static fields cannot be changed. )
/// 
/// </summary>
public  void SimObject_setFieldType(string simobject, string fieldName, string type){


m_ts.fn_SimObject_setFieldType(simobject, fieldName, type);
}
/// <summary>
/// Set the value of the given field on this object.
///    @param fieldName The name of the field to assign to.  If it includes an array index, the index will be parsed out.
///    @param value The new value to assign to the field.
///    @param index Optional argument to specify an index for an array field.
///    @return True. )
/// 
/// </summary>
public  bool SimObject_setFieldValue(string simobject, string fieldName, string value, int index = -1){


return m_ts.fn_SimObject_setFieldValue(simobject, fieldName, value, index);
}
/// <summary>
/// Sets the object's file name and path
///    @param fileName The name of the file to associate this object with. )
/// 
/// </summary>
public  void SimObject_setFilename(string simobject, string fileName){


m_ts.fn_SimObject_setFilename(simobject, fileName);
}
/// <summary>
/// Set whether the object has been marked as expanded. (in editor)
///    @param state True if the object is to be marked expanded; false if not. )
/// 
/// </summary>
public  void SimObject_setIsExpanded(string simobject, bool state = true){


m_ts.fn_SimObject_setIsExpanded(simobject, state);
}
/// <summary>
/// Assign a superclass namespace to this object.
///    @param name The name of the 'superClass' namespace for this object. )
/// 
/// </summary>
public  void SimObject_setSuperClassNamespace(string simobject, string name){


m_ts.fn_SimObject_setSuperClassNamespace(simobject, name);
}
/// <summary>
/// Assign a persistent ID to the object if it does not already have one. )
/// 
/// </summary>
public  void assignPersistentId(string simobject){


m_ts.fnSimObject_assignPersistentId(simobject);
}
/// <summary>
/// ( SimObject, call, const char*, 3, 0, ( string method, string args... ) Dynamically call a method on an object.
///    @param method Name of method to call.
///    @param args Zero or more arguments for the method.
///    @return The result of the method call. )
/// 
/// </summary>
public  string call(string simobject, string a2= "", string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){


return m_ts.fnSimObject_call(simobject, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}
/// <summary>
/// Create a copy of this object.
///    @return An exact duplicate of this object. )
/// 
/// </summary>
public  string clone(string simobject){


return m_ts.fnSimObject_clone(simobject);
}
/// <summary>
/// Create a copy of this object and all its subobjects.
///    @return An exact duplicate of this object and all objects it references. )
/// 
/// </summary>
public  string deepClone(string simobject){


return m_ts.fnSimObject_deepClone(simobject);
}
/// <summary>
/// Dump a description of all fields and methods defined on this object to the console.
///    @param detailed Whether to print detailed information about members. )
/// 
/// </summary>
public  void dump(string simobject, bool detailed = false){


m_ts.fnSimObject_dump(simobject, detailed);
}
/// <summary>
/// Dump the hierarchy of this object up to RootGroup to the console. )
/// 
/// </summary>
public  void dumpGroupHierarchy(string simobject){


m_ts.fnSimObject_dumpGroupHierarchy(simobject);
}
/// <summary>
/// Return some behind-the-scenes information on the object.
///    @return An ArrayObject filled with internal information about the object. )
/// 
/// </summary>
public  string getDebugInfo(string simobject){


return m_ts.fnSimObject_getDebugInfo(simobject);
}
/// <summary>
/// Get the group that this object is contained in.
///    @note If not assigned to particular SimGroup, an object belongs to RootGroup.
///    @return The SimGroup object to which the object belongs. )
/// 
/// </summary>
public  string getGroup(string simobject){


return m_ts.fnSimObject_getGroup(simobject);
}
/// <summary>
/// Get the underlying unique numeric ID of the object.
///    @note Object IDs are unique only during single engine runs.
///    @return The unique numeric ID of the object. )
/// 
/// </summary>
public  int getId(string simobject){


return m_ts.fnSimObject_getId(simobject);
}
/// <summary>
/// Get the internal name of the object.
///    @return The internal name of the object. )
/// 
/// </summary>
public  string getInternalName(string simobject){


return m_ts.fnSimObject_getInternalName(simobject);
}
/// <summary>
/// Get the global name of the object.
///    @return The global name assigned to the object. )
/// 
/// </summary>
public  string getName(string simobject){


return m_ts.fnSimObject_getName(simobject);
}
/// <summary>
/// Test whether the object belongs directly or indirectly to the given group.
///    @param group The SimGroup object.
///    @return True if the object is a child of the given group or a child of a group that the given group is directly or indirectly a child to. )
/// 
/// </summary>
public  bool isChildOfGroup(string simobject, string group){


return m_ts.fnSimObject_isChildOfGroup(simobject, group);
}
/// <summary>
/// Editable/Non-editable object in the game.
///    @return If the object is editable or not. )
/// 
/// </summary>
public  bool isEditable(string simobject){


return m_ts.fnSimObject_isEditable(simobject);
}
/// <summary>
/// Return true if the object is only used by the editor.
///    @return True if this object exists only for the sake of editing. )
/// 
/// </summary>
public  bool isEditorOnly(string simobject){


return m_ts.fnSimObject_isEditorOnly(simobject);
}
/// <summary>
/// Get whether this object may be renamed.
///    @return True if this object can be renamed; false otherwise. )
/// 
/// </summary>
public  bool isNameChangeAllowed(string simobject){


return m_ts.fnSimObject_isNameChangeAllowed(simobject);
}
/// <summary>
/// Get whether the object has been marked as selected. (in editor)
///    @return True if the object is currently selected. )
/// 
/// </summary>
public  bool isSelected(string simobject){


return m_ts.fnSimObject_isSelected(simobject);
}
/// <summary>
/// ( SimObject,schedule, S32, 4, 0, ( float time, string method, string args... ) Delay an invocation of a method.
///    @param time The number of milliseconds after which to invoke the method.  This is a soft limit.
///    @param method The method to call.
///    @param args The arguments with which to call the method.
///    @return The numeric ID of the created schedule.  Can be used to cancel the call. )
/// 
/// </summary>
public  int schedule(string simobject, string a2, string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){


return m_ts.fnSimObject_schedule(simobject, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}
/// <summary>
/// Editable/Non-editable object in the game.
///    @param value If true, the object will be editable; if false, the object will not be editable. )
/// 
/// </summary>
public  void setEditable(string simobject, bool value = true){


m_ts.fnSimObject_setEditable(simobject, value);
}
/// <summary>
/// Set/clear the editor-only flag on this object.
///    @param value If true, the object is marked as existing only for the editor. )
/// 
/// </summary>
public  void setEditorOnly(string simobject, bool value = true){


m_ts.fnSimObject_setEditorOnly(simobject, value);
}
/// <summary>
/// Hide/unhide the object.
///    @param value If true, the object will be hidden; if false, the object will be unhidden. )
/// 
/// </summary>
public  void setHidden(string simobject, bool value = true){


m_ts.fnSimObject_setHidden(simobject, value);
}
/// <summary>
/// Set the internal name of the object.
///    @param newInternalName The new internal name for the object. )
/// 
/// </summary>
public  void setInternalName(string simobject, string newInternalName){


m_ts.fnSimObject_setInternalName(simobject, newInternalName);
}
/// <summary>
/// Set whether the object has been marked as selected. (in editor)
///    @param state True if object is to be marked selected; false if not. )
/// 
/// </summary>
public  void setIsSelected(string simobject, bool state = true){


m_ts.fnSimObject_setIsSelected(simobject, state);
}
/// <summary>
/// Lock/unlock the object in the editor.
///    @param value If true, the object will be locked; if false, the object will be unlocked. )
/// 
/// </summary>
public  void setLocked(string simobject, bool value = true){


m_ts.fnSimObject_setLocked(simobject, value);
}
/// <summary>
/// Set the global name of the object.
///    @param newName The new global name to assign to the object.
///    @note If name changing is disallowed on the object, the method will fail with a console error. )
/// 
/// </summary>
public  void setName(string simobject, string newName){


m_ts.fnSimObject_setName(simobject, newName);
}
/// <summary>
/// Set whether this object can be renamed from its first name.
///    @param value If true, renaming is allowed for this object; if false, trying to change the name of the object will generate a console error. )
/// 
/// </summary>
public  void setNameChangeAllowed(string simobject, bool value = true){


m_ts.fnSimObject_setNameChangeAllowed(simobject, value);
}
/// <summary>
/// (SimObject, signal, void, 3, 4, evaluates strings stored in dynamic fields take a string as parameter)
/// 
/// </summary>
public  void signal(string simobject, string a2= "", string a3= ""){


m_ts.fnSimObject_signal(simobject, a2, a3);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SimPersistSetObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SimPersistSetObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// () - Try to bind unresolved persistent IDs in the set. )
/// </summary>
public  void SimPersistSet_resolvePersistentIds(string simpersistset){


m_ts.fn_SimPersistSet_resolvePersistentIds(simpersistset);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SimpleNetObjectObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SimpleNetObjectObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Sets the internal message variable.   SimpleNetObject is set up to automatically transmit this new message to    all connected clients.  It will appear in the clients' console.   @param msg The new message to send      @tsexample      // On the server, create a new SimpleNetObject.  This is a ghost always      // object so it will be immediately ghosted to all connected clients.      $s = new SimpleNetObject();      // All connected clients will see the following in their console:      //       // Got message: Hello World!      // Now again on the server, change the message.  This will cause it to      // be sent to all connected clients.      $s.setMessage(\"A new message from me!\");      // All connected clients will now see in their console:      //       // Go message: A new message from me!   @endtsexample   )
/// </summary>
public  void setMessage(string simplenetobject, string msg){


m_ts.fnSimpleNetObject_setMessage(simplenetobject, msg);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SimResponseCurveObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SimResponseCurveObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// addPoint( F32 value, F32 time ) )
/// </summary>
public  void SimResponseCurve_addPoint(string simresponsecurve, float value, float time){


m_ts.fn_SimResponseCurve_addPoint(simresponsecurve, value, time);
}
/// <summary>
/// clear() )
/// </summary>
public  void SimResponseCurve_clear(string simresponsecurve){


m_ts.fn_SimResponseCurve_clear(simresponsecurve);
}
/// <summary>
/// getValue( F32 time ) )
/// </summary>
public  float SimResponseCurve_getValue(string simresponsecurve, float time){


return m_ts.fn_SimResponseCurve_getValue(simresponsecurve, time);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SimSetObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SimSetObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// () Delete all objects in the set. )
/// </summary>
public  void SimSet_deleteAllObjects(string simset){


m_ts.fn_SimSet_deleteAllObjects(simset);
}
/// <summary>
/// () Get the number of direct and indirect child objects contained in the set.   @return The number of objects contained in the set as well as in other sets contained directly or indirectly in the set. )
/// </summary>
public  int SimSet_getFullCount(string simset){


return m_ts.fn_SimSet_getFullCount(simset);
}
/// <summary>
/// ( string callbackFunction ) Sort the objects in the set using the given comparison function.   @param callbackFunction Name of a function that takes two object arguments A and B and returns -1 if A is less, 1 if B is less, and 0 if both are equal. )
/// </summary>
public  void SimSet_sort(string simset, string callbackFunction){


m_ts.fn_SimSet_sort(simset, callbackFunction);
}
/// <summary>
/// Test whether the given object may be added to the set.   @param obj The object to test for potential membership.   @return True if the object may be added to the set, false otherwise. )
/// </summary>
public  bool acceptsAsChild(string simset, string obj){


return m_ts.fnSimSet_acceptsAsChild(simset, obj);
}
/// <summary>
/// ( SimSet, add, void, 3, 0,   ( SimObject objects... ) Add the given objects to the set.   @param objects The objects to add to the set. )
/// </summary>
public  void add(string simset, string a2= "", string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){


m_ts.fnSimSet_add(simset, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}
/// <summary>
/// Make the given object the first object in the set.   @param obj The object to bring to the frontmost position.  Must be contained in the set. )
/// </summary>
public  void bringToFront(string simset, string obj){


m_ts.fnSimSet_bringToFront(simset, obj);
}
/// <summary>
/// ( SimSet, callOnChildren, void, 3, 0,   ( string method, string args... ) Call a method on all objects contained in the set.   @param method The name of the method to call.   @param args The arguments to the method.   @note This method recurses into all SimSets that are children to the set.   @see callOnChildrenNoRecurse )
/// </summary>
public  void callOnChildren(string simset, string a2= "", string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){


m_ts.fnSimSet_callOnChildren(simset, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}
/// <summary>
/// ( SimSet, callOnChildrenNoRecurse, void, 3, 0,   ( string method, string args... ) Call a method on all objects contained in the set.   @param method The name of the method to call.   @param args The arguments to the method.   @note This method does not recurse into child SimSets.   @see callOnChildren )
/// </summary>
public  void callOnChildrenNoRecurse(string simset, string a2= "", string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){


m_ts.fnSimSet_callOnChildrenNoRecurse(simset, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}
/// <summary>
/// Remove all objects from the set. )
/// </summary>
public  void clear(string simset){


m_ts.fnSimSet_clear(simset);
}
/// <summary>
/// Find an object in the set by its internal name.   @param internalName The internal name of the object to look for.   @param searchChildren If true, SimSets contained in the set will be recursively searched for the object.   @return The object with the given internal name or 0 if no match was found. )
/// </summary>
public  string findObjectByInternalName(string simset, string internalName, bool searchChildren = false){


return m_ts.fnSimSet_findObjectByInternalName(simset, internalName, searchChildren);
}
/// <summary>
/// Get the number of objects contained in the set.   @return The number of objects contained in the set. )
/// </summary>
public  int getCount(string simset){


return m_ts.fnSimSet_getCount(simset);
}
/// <summary>
/// Get the object at the given index.   @param index The object index.   @return The object at the given index or -1 if index is out of range. )
/// </summary>
public  string getObject(string simset, uint index){


return m_ts.fnSimSet_getObject(simset, index);
}
/// <summary>
/// Return the index of the given object in this set.   @param obj The object for which to return the index.  Must be contained in the set.   @return The index of the object or -1 if the object is not contained in the set. )
/// </summary>
public  int getObjectIndex(string simset, string obj){


return m_ts.fnSimSet_getObjectIndex(simset, obj);
}
/// <summary>
/// Return a random object from the set.   @return A randomly selected object from the set or -1 if the set is empty. )
/// </summary>
public  string getRandom(string simset){


return m_ts.fnSimSet_getRandom(simset);
}
/// <summary>
/// Test whether the given object belongs to the set.   @param obj The object.   @return True if the object is contained in the set; false otherwise. )
/// </summary>
public  bool isMember(string simset, string obj){


return m_ts.fnSimSet_isMember(simset, obj);
}
/// <summary>
/// Dump a list of all objects contained in the set to the console. )
/// </summary>
public  void listObjects(string simset){


m_ts.fnSimSet_listObjects(simset);
}
/// <summary>
/// Make the given object the last object in the set.   @param obj The object to bring to the last position.  Must be contained in the set. )
/// </summary>
public  void pushToBack(string simset, string obj){


m_ts.fnSimSet_pushToBack(simset, obj);
}
/// <summary>
/// ( SimSet, remove, void, 3, 0,   ( SimObject objects... ) Remove the given objects from the set.   @param objects The objects to remove from the set. )
/// </summary>
public  void remove(string simset, string a2= "", string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){


m_ts.fnSimSet_remove(simset, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}
/// <summary>
/// Make sure child1 is ordered right before child2 in the set.   @param child1 The first child.  The object must already be contained in the set.   @param child2 The second child.  The object must already be contained in the set. )
/// </summary>
public  void reorderChild(string simset, string child1, string child2){


m_ts.fnSimSet_reorderChild(simset, child1, child2);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SimXMLDocumentObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SimXMLDocumentObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// (string attributeName)   @brief Get float attribute from the current Element on the stack.   @param attributeName Name of attribute to retrieve.   @return The value of the given attribute in the form of a float.   @deprecated Use attribute().)
/// </summary>
public  float SimXMLDocument_attributeF32(string simxmldocument, string attributeName){


return m_ts.fn_SimXMLDocument_attributeF32(simxmldocument, attributeName);
}
/// <summary>
/// (string attributeName)   @brief Get int attribute from the current Element on the stack.   @param attributeName Name of attribute to retrieve.   @return The value of the given attribute in the form of an integer.   @deprecated Use attribute().)
/// </summary>
public  int SimXMLDocument_attributeS32(string simxmldocument, string attributeName){


return m_ts.fn_SimXMLDocument_attributeS32(simxmldocument, attributeName);
}
/// <summary>
/// @brief Add the given comment as a child of the document.  @param comment String containing the comment.   @tsexample   // Create a new XML document with a header, a comment and single element.   %x = new SimXMLDocument();   %x.addHeader();   %x.addComment(\"This is a test comment\");   %x.addNewElement(\"NewElement\");   %x.saveFile(\"test.xml\");   // Produces the following file:   // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>   // !--This is a test comment-->   // NewElement />   @endtsexample      @see readComment())
/// </summary>
public  void addComment(string simxmldocument, string comment){


m_ts.fnSimXMLDocument_addComment(simxmldocument, comment);
}
/// <summary>
/// @brief Add the given text as a child of current Element.   Use getData() to retrieve any text from the current Element.   addData() and addText() may be used interchangeably.  As there is no    difference between data and text, you may also use removeText() to clear    any data from the current Element.   @param text String containing the text.   @tsexample   // Create a new XML document with a header and single element   // with some added data.   %x = new SimXMLDocument();   %x.addHeader();   %x.addNewElement(\"NewElement\");   %x.addData(\"Some text\");   %x.saveFile(\"test.xml\");   // Produces the following file:   // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>   // NewElement>Some text/NewElement>   @endtsexample   @see getData()   @see addText()   @see getText()   @see removeText())
/// </summary>
public  void addData(string simxmldocument, string text){


m_ts.fnSimXMLDocument_addData(simxmldocument, text);
}
/// <summary>
/// @brief Add a XML header to a document.   Sometimes called a declaration, you typically add a standard header to    the document before adding any elements.  SimXMLDocument always produces    the following header:   ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>     @tsexample   // Create a new XML document with just a header and single element.   %x = new SimXMLDocument();   %x.addHeader();   %x.addNewElement(\"NewElement\");   %x.saveFile(\"test.xml\");   // Produces the following file:   // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>   // NewElement />   @endtsexample)
/// </summary>
public  void addHeader(string simxmldocument){


m_ts.fnSimXMLDocument_addHeader(simxmldocument);
}
/// <summary>
/// @brief Create a new element with the given name as child of current Element's    parent and push it onto the Element stack making it the current one.   @note This differs from pushNewElement() in that it adds the new Element to the    current Element's parent (or document if there is no parent Element).  This makes    the new Element a sibling of the current one.   @param name XML tag for the new Element.      @see pushNewElement())
/// </summary>
public  void addNewElement(string simxmldocument, string name){


m_ts.fnSimXMLDocument_addNewElement(simxmldocument, name);
}
/// <summary>
/// @brief Add the given text as a child of current Element.   Use getText() to retrieve any text from the current Element and removeText()    to clear any text.   addText() and addData() may be used interchangeably.   @param text String containing the text.   @tsexample   // Create a new XML document with a header and single element   // with some added text.   %x = new SimXMLDocument();   %x.addHeader();   %x.addNewElement(\"NewElement\");   %x.addText(\"Some text\");   %x.saveFile(\"test.xml\");   // Produces the following file:   // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>   // NewElement>Some text/NewElement>   @endtsexample   @see getText()   @see removeText()   @see addData()   @see getData())
/// </summary>
public  void addText(string simxmldocument, string text){


m_ts.fnSimXMLDocument_addText(simxmldocument, text);
}
/// <summary>
/// @brief Get a string attribute from the current Element on the stack.   @param attributeName Name of attribute to retrieve.   @return The attribute string if found.  Otherwise returns an empty string.)
/// </summary>
public  string attribute(string simxmldocument, string attributeName){


return m_ts.fnSimXMLDocument_attribute(simxmldocument, attributeName);
}
/// <summary>
/// @brief Tests if the requested attribute exists.   @param attributeName Name of attribute being queried for.   @return True if the attribute exists.)
/// </summary>
public  bool attributeExists(string simxmldocument, string attributeName){


return m_ts.fnSimXMLDocument_attributeExists(simxmldocument, attributeName);
}
/// <summary>
/// @brief Set this document to its default state.      Clears all Elements from the documents.  Equivalent to using reset()      @see reset())
/// </summary>
public  void clear(string simxmldocument){


m_ts.fnSimXMLDocument_clear(simxmldocument);
}
/// <summary>
/// @brief Clear the last error description.)
/// </summary>
public  void clearError(string simxmldocument){


m_ts.fnSimXMLDocument_clearError(simxmldocument);
}
/// <summary>
/// @brief Get the Element's value if it exists.   Usually returns the text from the Element.   @return The value from the Element, or an empty string if none is found.)
/// </summary>
public  string elementValue(string simxmldocument){


return m_ts.fnSimXMLDocument_elementValue(simxmldocument);
}
/// <summary>
/// @brief Obtain the name of the current Element's first attribute.   @return String containing the first attribute's name, or an empty string if none is found.   @see nextAttribute()   @see lastAttribute()   @see prevAttribute())
/// </summary>
public  string firstAttribute(string simxmldocument){


return m_ts.fnSimXMLDocument_firstAttribute(simxmldocument);
}
/// <summary>
/// @brief Gets the text from the current Element.   Use addData() to add text to the current Element.   getData() and getText() may be used interchangeably.  As there is no    difference between data and text, you may also use removeText() to clear    any data from the current Element.   @return String containing the text in the current Element.   @tsexample   // Using the following test.xml file as an example:   // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>   // NewElement>Some data/NewElement>   // Load in the file   %x = new SimXMLDocument();   %x.loadFile(\"test.xml\");   // Make the first Element the current one   %x.pushFirstChildElement(\"NewElement\");   // Store the current Element's data ('Some data' in this example)   // into 'result'   %result = %x.getData();   echo( %result );   @endtsexample      @see addData()   @see addText()   @see getText()   @see removeText())
/// </summary>
public  string getData(string simxmldocument){


return m_ts.fnSimXMLDocument_getData(simxmldocument);
}
/// <summary>
/// @brief Get last error description.   @return A string of the last error message.)
/// </summary>
public  string getErrorDesc(string simxmldocument){


return m_ts.fnSimXMLDocument_getErrorDesc(simxmldocument);
}
/// <summary>
/// @brief Gets the text from the current Element.   Use addText() to add text to the current Element and removeText()    to clear any text.   getText() and getData() may be used interchangeably.   @return String containing the text in the current Element.   @tsexample   // Using the following test.xml file as an example:   // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>   // NewElement>Some text/NewElement>   // Load in the file   %x = new SimXMLDocument();   %x.loadFile(\"test.xml\");   // Make the first Element the current one   %x.pushFirstChildElement(\"NewElement\");   // Store the current Element's text ('Some text' in this example)   // into 'result'   %result = %x.getText();   echo( %result );   @endtsexample      @see addText()   @see removeText()   @see addData()   @see getData())
/// </summary>
public  string getText(string simxmldocument){


return m_ts.fnSimXMLDocument_getText(simxmldocument);
}
/// <summary>
/// @brief Obtain the name of the current Element's last attribute.   @return String containing the last attribute's name, or an empty string if none is found.   @see prevAttribute()   @see firstAttribute()   @see lastAttribute())
/// </summary>
public  string lastAttribute(string simxmldocument){


return m_ts.fnSimXMLDocument_lastAttribute(simxmldocument);
}
/// <summary>
/// @brief Load in given filename and prepare it for use.   @note Clears the current document's contents.   @param fileName Name and path of XML document   @return True if the file was loaded successfully.)
/// </summary>
public  bool loadFile(string simxmldocument, string fileName){


return m_ts.fnSimXMLDocument_loadFile(simxmldocument, fileName);
}
/// <summary>
/// @brief Get the name of the next attribute for the current Element after a call to firstAttribute().   @return String containing the next attribute's name, or an empty string if none is found.   @see firstAttribute()   @see lastAttribute()   @see prevAttribute())
/// </summary>
public  string nextAttribute(string simxmldocument){


return m_ts.fnSimXMLDocument_nextAttribute(simxmldocument);
}
/// <summary>
/// @brief Put the next sibling Element with the given name on the stack, making it the current one.   @param name String containing name of the next sibling.   @return True if the Element was found and made the current one.)
/// </summary>
public  bool nextSiblingElement(string simxmldocument, string name){


return m_ts.fnSimXMLDocument_nextSiblingElement(simxmldocument, name);
}
/// <summary>
/// @brief Create a document from a XML string.   @note Clears the current document's contents.   @param xmlString Valid XML to parse and store as a document.)
/// </summary>
public  void parse(string simxmldocument, string xmlString){


m_ts.fnSimXMLDocument_parse(simxmldocument, xmlString);
}
/// <summary>
/// @brief Pop the last Element off the stack.)
/// </summary>
public  void popElement(string simxmldocument){


m_ts.fnSimXMLDocument_popElement(simxmldocument);
}
/// <summary>
/// @brief Get the name of the previous attribute for the current Element after a call to lastAttribute().   @return String containing the previous attribute's name, or an empty string if none is found.   @see lastAttribute()   @see firstAttribute()   @see nextAttribute())
/// </summary>
public  string prevAttribute(string simxmldocument){


return m_ts.fnSimXMLDocument_prevAttribute(simxmldocument);
}
/// <summary>
/// @brief Push the child Element at the given index onto the stack, making it the current one.   @param index Numerical index of Element being pushed.   @return True if the Element was found and made the current one.)
/// </summary>
public  bool pushChildElement(string simxmldocument, int index){


return m_ts.fnSimXMLDocument_pushChildElement(simxmldocument, index);
}
/// <summary>
/// @brief Push the first child Element with the given name onto the stack, making it the current Element.   @param name String containing name of the child Element.   @return True if the Element was found and made the current one.   @tsexample   // Using the following test.xml file as an example:   // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>   // NewElement>Some text/NewElement>   // Load in the file   %x = new SimXMLDocument();   %x.loadFile(\"test.xml\");   // Make the first Element the current one   %x.pushFirstChildElement(\"NewElement\");   // Store the current Element's text ('Some text' in this example)   // into 'result'   %result = %x.getText();   echo( %result );   @endtsexample)
/// </summary>
public  bool pushFirstChildElement(string simxmldocument, string name){


return m_ts.fnSimXMLDocument_pushFirstChildElement(simxmldocument, name);
}
/// <summary>
/// @brief Create a new element with the given name as child of current Element    and push it onto the Element stack making it the current one.   @note This differs from addNewElement() in that it adds the new Element as a    child of the current Element (or a child of the document if no Element exists).   @param name XML tag for the new Element.   @see addNewElement())
/// </summary>
public  void pushNewElement(string simxmldocument, string name){


m_ts.fnSimXMLDocument_pushNewElement(simxmldocument, name);
}
/// <summary>
/// Gives the comment at the specified index, if any.   Unlike addComment() that only works at the document level, readComment() may read    comments from the document or any child Element.  The current Element (or document    if no Elements have been pushed to the stack) is the parent for any comments, and the    provided index is the number of comments in to read back.   @param index Comment index number to query from the current Element stack   @return String containing the comment, or an empty string if no comment is found.   @see addComment())
/// </summary>
public  string readComment(string simxmldocument, int index){


return m_ts.fnSimXMLDocument_readComment(simxmldocument, index);
}
/// <summary>
/// @brief Remove any text on the current Element.   Use getText() to retrieve any text from the current Element and addText()    to add text to the current Element.  As getData() and addData() are equivalent    to getText() and addText(), removeText() will also remove any data from the    current Element.      @see addText()   @see getText()   @see addData()   @see getData())
/// </summary>
public  void removeText(string simxmldocument){


m_ts.fnSimXMLDocument_removeText(simxmldocument);
}
/// <summary>
/// @brief Set this document to its default state.      Clears all Elements from the documents.  Equivalent to using clear()      @see clear())
/// </summary>
public  void reset(string simxmldocument){


m_ts.fnSimXMLDocument_reset(simxmldocument);
}
/// <summary>
/// @brief Save document to the given file name.   @param fileName Path and name of XML file to save to.   @return True if the file was successfully saved.)
/// </summary>
public  bool saveFile(string simxmldocument, string fileName){


return m_ts.fnSimXMLDocument_saveFile(simxmldocument, fileName);
}
/// <summary>
/// @brief Set the attribute of the current Element on the stack to the given value.   @param attributeName Name of attribute being changed   @param value New value to assign to the attribute)
/// </summary>
public  void setAttribute(string simxmldocument, string attributeName, string value){


m_ts.fnSimXMLDocument_setAttribute(simxmldocument, attributeName, value);
}
/// <summary>
/// @brief Add the given SimObject's fields as attributes of the current Element on the stack.   @param objectID ID of SimObject being copied.)
/// </summary>
public  void setObjectAttributes(string simxmldocument, string objectID){


m_ts.fnSimXMLDocument_setObjectAttributes(simxmldocument, objectID);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SkyBoxObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SkyBoxObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// )
/// </summary>
public  void SkyBox_postApply(string skybox){


m_ts.fn_SkyBox_postApply(skybox);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SpawnSphereObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SpawnSphereObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ([string additionalProps]) Spawns the object based on the SpawnSphere's    class, datablock, properties, and script settings. Allows you to pass in    extra properties.   @hide )
/// </summary>
public  int SpawnSphere_spawnObject(string spawnsphere, string additionalProps){


return m_ts.fn_SpawnSphere_spawnObject(spawnsphere, additionalProps);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class StaticShapeObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public StaticShapeObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @internal)
/// </summary>
public  bool StaticShape_getPoweredState(string staticshape){


return m_ts.fn_StaticShape_getPoweredState(staticshape);
}
/// <summary>
/// (bool isPowered)			  @internal)
/// </summary>
public  void StaticShape_setPoweredState(string staticshape, bool isPowered){


m_ts.fn_StaticShape_setPoweredState(staticshape, isPowered);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class StreamObjectObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public StreamObjectObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Copy from another StreamObject into this StreamObject   @param other The StreamObject to copy from.   @return True if the copy was successful.)
/// </summary>
public  bool copyFrom(string streamobject, string other){


return m_ts.fnStreamObject_copyFrom(streamobject, other);
}
/// <summary>
/// @brief Gets the position in the stream      The easiest way to visualize this is to think of a cursor in a text file. If you have moved the cursor by    five characters, the current position is 5. If you move ahead 10 more characters, the position is now 15.    For StreamObject, when you read in the line the position is increased by the number of characters parsed,    the null terminator, and a newline.      @tsexample   // Create a file stream object for reading   %fsObject = new FileStreamObject();   // Open a file for reading   // This file contains two lines of text repeated:   // Hello World   // Hello World   %fsObject.open(\"./test.txt\", \"read\");   // Read in the first line   %line = %fsObject.readLine();   // Get the position of the stream   %position = %fsObject.getPosition();   // Print the current position   // Should be 13, 10 for the words, 1 for the space, 1 for the null terminator, and 1 for the newline   echo(%position);   // Always remember to close a file stream when finished   %fsObject.close();   @endtsexample   @return Number of bytes which stream has parsed so far, null terminators and newlines are included      @see setPosition())
/// </summary>
public  int getPosition(string streamobject){


return m_ts.fnStreamObject_getPosition(streamobject);
}
/// <summary>
/// @brief Gets a printable string form of the stream's status      @tsexample   // Create a file stream object for reading   %fsObject = new FileStreamObject();   // Open a file for reading   %fsObject.open(\"./test.txt\", \"read\");   // Get the status and print it   %status = %fsObject.getStatus();   echo(%status);   // Always remember to close a file stream when finished   %fsObject.close();   @endtsexample   @return String containing status constant, one of the following:   	OK - Stream is active and no file errors   	IOError - Something went wrong during read or writing the stream   	EOS - End of Stream reached (mostly for reads)   	IllegalCall - An unsupported operation used.  Always w/ accompanied by AssertWarn     Closed - Tried to operate on a closed stream (or detached filter)   	UnknownError - Catch all for an error of some kind   	Invalid - Entire stream is invalid)
/// </summary>
public  string getStatus(string streamobject){


return m_ts.fnStreamObject_getStatus(streamobject);
}
/// <summary>
/// @brief Gets the size of the stream      The size is dependent on the type of stream being used. If it is a file stream, returned value will    be the size of the file. If it is a memory stream, it will be the size of the allocated buffer.         @tsexample   // Create a file stream object for reading   %fsObject = new FileStreamObject();   // Open a file for reading   // This file contains the following two lines:   // HelloWorld   // HelloWorld   %fsObject.open(\"./test.txt\", \"read\");   // Found out how large the file stream is   // Then print it to the console   // Should be 22   %streamSize = %fsObject.getStreamSize();   echo(%streamSize);   // Always remember to close a file stream when finished   %fsObject.close();   @endtsexample   @return Size of stream, in bytes)
/// </summary>
public  int getStreamSize(string streamobject){


return m_ts.fnStreamObject_getStreamSize(streamobject);
}
/// <summary>
/// @brief Tests if the stream has reached the end of the file      This is an alternative name for isEOS. Both functions are interchangeable. This simply exists    for those familiar with some C++ file I/O standards.      @tsexample   // Create a file stream object for reading   %fsObject = new FileStreamObject();   // Open a file for reading   %fsObject.open(\"./test.txt\", \"read\");   // Keep reading until we reach the end of the file   while( !%fsObject.isEOF() )   {      %line = %fsObject.readLine();      echo(%line);   }   // Made it to the end   echo(\"Finished reading file\");   // Always remember to close a file stream when finished   %fsObject.close();   @endtsexample   @return True if the parser has reached the end of the file, false otherwise      @see isEOS())
/// </summary>
public  bool isEOF(string streamobject){


return m_ts.fnStreamObject_isEOF(streamobject);
}
/// <summary>
/// @brief Tests if the stream has reached the end of the file      This is an alternative name for isEOF. Both functions are interchangeable. This simply exists    for those familiar with some C++ file I/O standards.   @tsexample   // Create a file stream object for reading   %fsObject = new FileStreamObject();   // Open a file for reading   %fsObject.open(\"./test.txt\", \"read\");   // Keep reading until we reach the end of the file   while( !%fsObject.isEOS() )   {      %line = %fsObject.readLine();      echo(%line);   }   // Made it to the end   echo(\"Finished reading file\");   // Always remember to close a file stream when finished   %fsObject.close();   @endtsexample   @return True if the parser has reached the end of the file, false otherwise   @see isEOF())
/// </summary>
public  bool isEOS(string streamobject){


return m_ts.fnStreamObject_isEOS(streamobject);
}
/// <summary>
/// @brief Read a line from the stream.      Emphasis on *line*, as in you cannot parse individual characters or chunks of data.    There is no limitation as to what kind of data you can read.      @tsexample   // Create a file stream object for reading   // This file contains the following two lines:   // HelloWorld   // HelloWorld   %fsObject = new FileStreamObject();   %fsObject.open(\"./test.txt\", \"read\");   // Read in the first line   %line = %fsObject.readLine();   // Print the line we just read   echo(%line);   // Always remember to close a file stream when finished   %fsObject.close();   @endtsexample   @return String containing the line of data that was just read      @see writeLine())
/// </summary>
public  string readLine(string streamobject){


return m_ts.fnStreamObject_readLine(streamobject);
}
/// <summary>
/// @brief Read in a string up to the given maximum number of characters.   @param maxLength The maximum number of characters to read in.   @return The string that was read from the stream.   @see writeLongString()      @note When working with these particular string reading and writing methods, the stream    begins with the length of the string followed by the string itself, and does not include    a NULL terminator.)
/// </summary>
public  string readLongString(string streamobject, int maxLength){


return m_ts.fnStreamObject_readLongString(streamobject, maxLength);
}
/// <summary>
/// @brief Read a string up to a maximum of 256 characters   @return The string that was read from the stream.   @see writeString()      @note When working with these particular string reading and writing methods, the stream    begins with the length of the string followed by the string itself, and does not include    a NULL terminator.)
/// </summary>
public  string readString(string streamobject){


return m_ts.fnStreamObject_readString(streamobject);
}
/// <summary>
/// @brief Read in a string and place it on the string table.   @param caseSensitive If false then case will not be taken into account when attempting    to match the read in string with what is already in the string table.   @return The string that was read from the stream.   @see writeString()      @note When working with these particular string reading and writing methods, the stream    begins with the length of the string followed by the string itself, and does not include    a NULL terminator.)
/// </summary>
public  string readSTString(string streamobject, bool caseSensitive = false){


return m_ts.fnStreamObject_readSTString(streamobject, caseSensitive);
}
/// <summary>
/// @brief Gets the position in the stream      The easiest way to visualize this is to think of a cursor in a text file. If you have moved the cursor by    five characters, the current position is 5. If you move ahead 10 more characters, the position is now 15.    For StreamObject, when you read in the line the position is increased by the number of characters parsed,    the null terminator, and a newline. Using setPosition allows you to skip to specific points of the file.      @tsexample   // Create a file stream object for reading   %fsObject = new FileStreamObject();   // Open a file for reading   // This file contains the following two lines:   // 11111111111   // Hello World   %fsObject.open(\"./test.txt\", \"read\");   // Skip ahead by 12, which will bypass the first line entirely   %fsObject.setPosition(12);   // Read in the next line   %line = %fsObject.readLine();   // Print the line just read in, should be \"Hello World\"   echo(%line);   // Always remember to close a file stream when finished   %fsObject.close();   @endtsexample   @return Number of bytes which stream has parsed so far, null terminators and newlines are included      @see getPosition())
/// </summary>
public  bool setPosition(string streamobject, int newPosition){


return m_ts.fnStreamObject_setPosition(streamobject, newPosition);
}
/// <summary>
/// @brief Write a line to the stream, if it was opened for writing.      There is no limit as to what kind of data you can write. Any format and data is allowable, not just text.    Be careful of what you write, as whitespace, current values, and literals will be preserved.   @param line The data we are writing out to file.      @tsexample   // Create a file stream   %fsObject = new FileStreamObject();   // Open the file for writing   // If it does not exist, it is created. If it does exist, the file is cleared   %fsObject.open(\"./test.txt\", \"write\");   // Write a line to the file   %fsObject.writeLine(\"Hello World\");   // Write another line to the file   %fsObject.writeLine(\"Documentation Rocks!\");   // Always remember to close a file stream when finished   %fsObject.close();   @endtsexample      @see readLine())
/// </summary>
public  void writeLine(string streamobject, string line){


m_ts.fnStreamObject_writeLine(streamobject, line);
}
/// <summary>
/// @brief Write out a string up to the maximum number of characters.   @param maxLength The maximum number of characters that will be written.   @param string The string to write out to the stream.   @see readLongString()      @note When working with these particular string reading and writing methods, the stream    begins with the length of the string followed by the string itself, and does not include    a NULL terminator.)
/// </summary>
public  void writeLongString(string streamobject, int maxLength, string stringx){


m_ts.fnStreamObject_writeLongString(streamobject, maxLength, stringx);
}
/// <summary>
/// @brief Write out a string with a default maximum length of 256 characters.   @param string The string to write out to the stream   @param maxLength The maximum string length to write out with a default of 256 characters.  This    value should not be larger than 256 as it is written to the stream as a single byte.   @see readString()      @note When working with these particular string reading and writing methods, the stream    begins with the length of the string followed by the string itself, and does not include    a NULL terminator.)
/// </summary>
public  void writeString(string streamobject, string stringx, int maxLength = 256){


m_ts.fnStreamObject_writeString(streamobject, stringx, maxLength);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class SunObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public SunObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// animate( F32 duration, F32 startAzimuth, F32 endAzimuth, F32 startElevation, F32 endElevation ))
/// </summary>
public  void Sun_animate(string sun, float duration, float startAzimuth, float endAzimuth, float startElevation, float endElevation){


m_ts.fn_Sun_animate(sun, duration, startAzimuth, endAzimuth, startElevation, endElevation);
}
/// <summary>
/// )
/// </summary>
public  void Sun_apply(string sun){


m_ts.fn_Sun_apply(sun);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class TCPObjectObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public TCPObjectObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Connect to the given address.   @param address Server address (including port) to connect to.   @tsexample      // Set the address.      %address = \"www.garagegames.com:80\";      // Inform this TCPObject to connect to the specified address.      %thisTCPObj.connect(%address);   @endtsexample)
/// </summary>
public  void connect(string tcpobject, string address){


m_ts.fnTCPObject_connect(tcpobject, address);
}
/// <summary>
/// @brief Disconnect from whatever this TCPObject is currently connected to, if anything.   @tsexample      // Inform this TCPObject to disconnect from anything it is currently connected to.      %thisTCPObj.disconnect();   @endtsexample)
/// </summary>
public  void disconnect(string tcpobject){


m_ts.fnTCPObject_disconnect(tcpobject);
}
/// <summary>
/// @brief Start listening on the specified port for connections.   This method starts a listener which looks for incoming TCP connections to a port.     You must overload the onConnectionRequest callback to create a new TCPObject to    read, write, or reject the new connection.   @param port Port for this TCPObject to start listening for connections on.   @tsexample    // Create a listener on port 8080.    new TCPObject( TCPListener );    TCPListener.listen( 8080 );    function TCPListener::onConnectionRequest( %this, %address, %id )    {       // Create a new object to manage the connection.       new TCPObject( TCPClient, %id );    }    function TCPClient::onLine( %this, %line )    {       // Print the line of text from client.       echo( %line );    }   @endtsexample)
/// </summary>
public  void listen(string tcpobject, int port){


m_ts.fnTCPObject_listen(tcpobject, port);
}
/// <summary>
/// @brief Transmits the data string to the connected computer.   This method is used to send text data to the connected computer regardless if we initiated the    connection using connect(), or listening to a port using listen().   @param data The data string to send.   @tsexample      // Set the command data      %data = \"GET \" @ $RSSFeed::serverURL @ \" HTTP/1.0\\r\\";      %data = %data @ \"Host: \" @ $RSSFeed::serverName @ \"\\r\\";      %data = %data @ \"User-Agent: \" @ $RSSFeed::userAgent @ \"\\r\\\r\\"      // Send the command to the connected server.      %thisTCPObj.send(%data);   @endtsexample)
/// </summary>
public  void send(string tcpobject, string data){


m_ts.fnTCPObject_send(tcpobject, data);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class TerrainBlockObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public TerrainBlockObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// png), (string filename, [string format]) - export the terrain block's heightmap to a bitmap file (default: png) )
/// </summary>
public  bool TerrainBlock_exportHeightMap(string terrainblock, string fileNameStr, string format = "png"){


return m_ts.fn_TerrainBlock_exportHeightMap(terrainblock, fileNameStr, format);
}
/// <summary>
/// png), (string filePrefix, [string format]) - export the terrain block's layer maps to bitmap files (default: png) )
/// </summary>
public  bool TerrainBlock_exportLayerMaps(string terrainblock, string filePrefixStr, string format = "png"){


return m_ts.fn_TerrainBlock_exportLayerMaps(terrainblock, filePrefixStr, format);
}
/// <summary>
/// @brief Saves the terrain block's terrain file to the specified file name.				   @param fileName Name and path of file to save terrain data to.				   @return True if file save was successful, false otherwise)
/// </summary>
public  bool save(string terrainblock, string fileName){


return m_ts.fnTerrainBlock_save(terrainblock, fileName);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class TerrainEditorObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public TerrainEditorObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( string matName )   Adds a new material. )
/// </summary>
public  int TerrainEditor_addMaterial(string terraineditor, string matName){


return m_ts.fn_TerrainEditor_addMaterial(terraineditor, matName);
}
/// <summary>
/// ), (TerrainBlock terrain))
/// </summary>
public  void TerrainEditor_attachTerrain(string terraineditor, string terrain = ""){


m_ts.fn_TerrainEditor_attachTerrain(terraineditor, terrain);
}
/// <summary>
/// (float minHeight, float maxHeight, float minSlope, float maxSlope))  
/// </summary>
public  void TerrainEditor_autoMaterialLayer(string terraineditor, float minHeight, float maxHeight, float minSlope, float maxSlope){


m_ts.fn_TerrainEditor_autoMaterialLayer(terraineditor, minHeight, maxHeight, minSlope, maxSlope);
}
/// <summary>
/// )
/// </summary>
public  void TerrainEditor_clearSelection(string terraineditor){


m_ts.fn_TerrainEditor_clearSelection(terraineditor);
}
/// <summary>
/// (int num))
/// </summary>
public  string TerrainEditor_getActionName(string terraineditor, uint index){


return m_ts.fn_TerrainEditor_getActionName(terraineditor, index);
}
/// <summary>
/// )
/// </summary>
public  int TerrainEditor_getActiveTerrain(string terraineditor){


return m_ts.fn_TerrainEditor_getActiveTerrain(terraineditor);
}
/// <summary>
/// Returns a Point2I.)
/// </summary>
public  string TerrainEditor_getBrushPos(string terraineditor){


return m_ts.fn_TerrainEditor_getBrushPos(terraineditor);
}
/// <summary>
/// ())
/// </summary>
public  float TerrainEditor_getBrushPressure(string terraineditor){


return m_ts.fn_TerrainEditor_getBrushPressure(terraineditor);
}
/// <summary>
/// ())
/// </summary>
public  string TerrainEditor_getBrushSize(string terraineditor){


return m_ts.fn_TerrainEditor_getBrushSize(terraineditor);
}
/// <summary>
/// ())
/// </summary>
public  float TerrainEditor_getBrushSoftness(string terraineditor){


return m_ts.fn_TerrainEditor_getBrushSoftness(terraineditor);
}
/// <summary>
/// ())
/// </summary>
public  string TerrainEditor_getBrushType(string terraineditor){


return m_ts.fn_TerrainEditor_getBrushType(terraineditor);
}
/// <summary>
/// )
/// </summary>
public  string TerrainEditor_getCurrentAction(string terraineditor){


return m_ts.fn_TerrainEditor_getCurrentAction(terraineditor);
}
/// <summary>
/// Returns the current material count. )
/// </summary>
public  int TerrainEditor_getMaterialCount(string terraineditor){


return m_ts.fn_TerrainEditor_getMaterialCount(terraineditor);
}
/// <summary>
/// ( string name ) - Returns the index of the material with the given name or -1. )
/// </summary>
public  int TerrainEditor_getMaterialIndex(string terraineditor, string name){


return m_ts.fn_TerrainEditor_getMaterialIndex(terraineditor, name);
}
/// <summary>
/// ( int index ) - Returns the name of the material at the given index. )
/// </summary>
public  string TerrainEditor_getMaterialName(string terraineditor, int index){


return m_ts.fn_TerrainEditor_getMaterialName(terraineditor, index);
}
/// <summary>
/// () gets the list of current terrain materials.)
/// </summary>
public  string TerrainEditor_getMaterials(string terraineditor){


return m_ts.fn_TerrainEditor_getMaterials(terraineditor);
}
/// <summary>
/// )
/// </summary>
public  int TerrainEditor_getNumActions(string terraineditor){


return m_ts.fn_TerrainEditor_getNumActions(terraineditor);
}
/// <summary>
/// )
/// </summary>
public  int TerrainEditor_getNumTextures(string terraineditor){


return m_ts.fn_TerrainEditor_getNumTextures(terraineditor);
}
/// <summary>
/// )
/// </summary>
public  float TerrainEditor_getSlopeLimitMaxAngle(string terraineditor){


return m_ts.fn_TerrainEditor_getSlopeLimitMaxAngle(terraineditor);
}
/// <summary>
/// )
/// </summary>
public  float TerrainEditor_getSlopeLimitMinAngle(string terraineditor){


return m_ts.fn_TerrainEditor_getSlopeLimitMinAngle(terraineditor);
}
/// <summary>
/// (S32 index))
/// </summary>
public  int TerrainEditor_getTerrainBlock(string terraineditor, int index){


return m_ts.fn_TerrainEditor_getTerrainBlock(terraineditor, index);
}
/// <summary>
/// ())
/// </summary>
public  int TerrainEditor_getTerrainBlockCount(string terraineditor){


return m_ts.fn_TerrainEditor_getTerrainBlockCount(terraineditor);
}
/// <summary>
/// () gets the list of current terrain materials for all terrain blocks.)
/// </summary>
public  string TerrainEditor_getTerrainBlocksMaterialList(string terraineditor){


return m_ts.fn_TerrainEditor_getTerrainBlocksMaterialList(terraineditor);
}
/// <summary>
/// , , ),                                                                            (x/y/z) Gets the terrain block that is located under the given world point.                                                                           @param x/y/z The world coordinates (floating point values) you wish to query at.                                                                             These can be formatted as either a string (\"x y z\") or separately as (x, y, z)                                                                           @return Returns the ID of the requested terrain block (0 if not found).)
/// </summary>
public  int TerrainEditor_getTerrainUnderWorldPoint(string terraineditor, string ptOrX = "", string Y = "", string Z = ""){


return m_ts.fn_TerrainEditor_getTerrainUnderWorldPoint(terraineditor, ptOrX, Y, Z);
}
/// <summary>
/// )
/// </summary>
public  void TerrainEditor_markEmptySquares(string terraineditor){


m_ts.fn_TerrainEditor_markEmptySquares(terraineditor);
}
/// <summary>
/// )
/// </summary>
public  void TerrainEditor_mirrorTerrain(string terraineditor, int mirrorIndex){


m_ts.fn_TerrainEditor_mirrorTerrain(terraineditor, mirrorIndex);
}
/// <summary>
/// ), (string action=NULL))
/// </summary>
public  void TerrainEditor_processAction(string terraineditor, string action = ""){


m_ts.fn_TerrainEditor_processAction(terraineditor, action);
}
/// <summary>
/// ( int index ) - Remove the material at the given index. )
/// </summary>
public  void TerrainEditor_removeMaterial(string terraineditor, int index){


m_ts.fn_TerrainEditor_removeMaterial(terraineditor, index);
}
/// <summary>
/// ( int index, int order )   - Reorder material at the given index to the new position, changing the order in which it is rendered / blended. )
/// </summary>
public  void TerrainEditor_reorderMaterial(string terraineditor, int index, int orderPos){


m_ts.fn_TerrainEditor_reorderMaterial(terraineditor, index, orderPos);
}
/// <summary>
/// (bool clear))
/// </summary>
public  void TerrainEditor_resetSelWeights(string terraineditor, bool clear){


m_ts.fn_TerrainEditor_resetSelWeights(terraineditor, clear);
}
/// <summary>
/// (string action_name))
/// </summary>
public  void TerrainEditor_setAction(string terraineditor, string action_name){


m_ts.fn_TerrainEditor_setAction(terraineditor, action_name);
}
/// <summary>
/// Location)
/// </summary>
public  void TerrainEditor_setBrushPos(string terraineditor, Point2I pos){


m_ts.fn_TerrainEditor_setBrushPos(terraineditor, pos.AsString());
}
/// <summary>
/// (float pressure))
/// </summary>
public  void TerrainEditor_setBrushPressure(string terraineditor, float pressure){


m_ts.fn_TerrainEditor_setBrushPressure(terraineditor, pressure);
}
/// <summary>
/// (int w [, int h]))
/// </summary>
public  void TerrainEditor_setBrushSize(string terraineditor, int w, int h = 0){


m_ts.fn_TerrainEditor_setBrushSize(terraineditor, w, h);
}
/// <summary>
/// (float softness))
/// </summary>
public  void TerrainEditor_setBrushSoftness(string terraineditor, float softness){


m_ts.fn_TerrainEditor_setBrushSoftness(terraineditor, softness);
}
/// <summary>
/// (string type)              One of box, ellipse, selection.)
/// </summary>
public  void TerrainEditor_setBrushType(string terraineditor, string type){


m_ts.fn_TerrainEditor_setBrushType(terraineditor, type);
}
/// <summary>
/// )
/// </summary>
public  float TerrainEditor_setSlopeLimitMaxAngle(string terraineditor, float angle){


return m_ts.fn_TerrainEditor_setSlopeLimitMaxAngle(terraineditor, angle);
}
/// <summary>
/// )
/// </summary>
public  float TerrainEditor_setSlopeLimitMinAngle(string terraineditor, float angle){


return m_ts.fn_TerrainEditor_setSlopeLimitMinAngle(terraineditor, angle);
}
/// <summary>
/// (bool overlayEnable) - sets the terraformer current heightmap to draw as an overlay over the current terrain.)
/// </summary>
public  void TerrainEditor_setTerraformOverlay(string terraineditor, bool overlayEnable){


m_ts.fn_TerrainEditor_setTerraformOverlay(terraineditor, overlayEnable);
}
/// <summary>
/// ( int index, string matName )   Changes the material name at the index. )
/// </summary>
public  bool TerrainEditor_updateMaterial(string terraineditor, uint index, string matName){


return m_ts.fn_TerrainEditor_updateMaterial(terraineditor, index, matName);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class TerrainSmoothActionObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public TerrainSmoothActionObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( TerrainBlock obj, F32 factor, U32 steps ))
/// </summary>
public  void TerrainSmoothAction_smooth(string terrainsmoothaction, string terrain, float factor, uint steps){


m_ts.fn_TerrainSmoothAction_smooth(terrainsmoothaction, terrain, factor, steps);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class TerrainSolderEdgesActionObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public TerrainSolderEdgesActionObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// () )
/// </summary>
public  void TerrainSolderEdgesAction_solder(string terrainsolderedgesaction){


m_ts.fn_TerrainSolderEdgesAction_solder(terrainsolderedgesaction);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class TheoraTextureObjectObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public TheoraTextureObjectObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Pause playback of the video. )
/// </summary>
public  void TheoraTextureObject_pause(string theoratextureobject){


m_ts.fn_TheoraTextureObject_pause(theoratextureobject);
}
/// <summary>
/// Start playback of the video. )
/// </summary>
public  void TheoraTextureObject_play(string theoratextureobject){


m_ts.fn_TheoraTextureObject_play(theoratextureobject);
}
/// <summary>
/// Stop playback of the video. )
/// </summary>
public  void TheoraTextureObject_stop(string theoratextureobject){


m_ts.fn_TheoraTextureObject_stop(theoratextureobject);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class TimeOfDayObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public TimeOfDayObject(ref Omni ts){m_ts = ts;}
/// <summary>
///  )
/// </summary>
public  void addTimeOfDayEvent(string timeofday, float elevation, string identifier){


m_ts.fnTimeOfDay_addTimeOfDayEvent(timeofday, elevation, identifier);
}
/// <summary>
/// )
/// </summary>
public  void animate(string timeofday, float elevation, float degreesPerSecond){


m_ts.fnTimeOfDay_animate(timeofday, elevation, degreesPerSecond);
}
/// <summary>
///  )
/// </summary>
public  void setDayLength(string timeofday, float seconds){


m_ts.fnTimeOfDay_setDayLength(timeofday, seconds);
}
/// <summary>
/// )
/// </summary>
public  void setPlay(string timeofday, bool enabled){


m_ts.fnTimeOfDay_setPlay(timeofday, enabled);
}
/// <summary>
///  )
/// </summary>
public  void setTimeOfDay(string timeofday, float time){


m_ts.fnTimeOfDay_setTimeOfDay(timeofday, time);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class TriggerObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public TriggerObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Get the number of objects that are within the Trigger's bounds.   @see getObject())
/// </summary>
public  int getNumObjects(string trigger){


return m_ts.fnTrigger_getNumObjects(trigger);
}
/// <summary>
/// @brief Retrieve the requested object that is within the Trigger's bounds.   @param index Index of the object to get (range is 0 to getNumObjects()-1)   @returns The SimObjectID of the object, or -1 if the requested index is invalid.   @see getNumObjects())
/// </summary>
public  int getObject(string trigger, int index){


return m_ts.fnTrigger_getObject(trigger, index);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class TSAttachableObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public TSAttachableObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Attaches an object to this one.      @param obj The scene object to attach to us      @return true if successful, false if failed. This function will fail if the object passed       is invalid or is not located directly above and within RayLength of this shape.)
/// </summary>
public  bool attachObject(string tsattachable, string obj){


return m_ts.fnTSAttachable_attachObject(tsattachable, obj);
}
/// <summary>
/// Detaches all attached objects. Note: if UseAutoAttach is true when this is called, all of       the objects may be re-attached on the next tick.      @tsexample         // Dump all riders         %attachableObj.UseAutoAttach = false         %attachableObj.detachAll(); = false      @endtsexample)
/// </summary>
public  void detachAll(string tsattachable){


m_ts.fnTSAttachable_detachAll(tsattachable);
}
/// <summary>
/// Detaches an object from this one.      @param obj The scene object to be detached      @return true if successful, false if failed. This function will fail if the object passed       is invalid or is not currently attached to this shape.)
/// </summary>
public  bool detachObject(string tsattachable, string obj){


return m_ts.fnTSAttachable_detachObject(tsattachable, obj);
}
/// <summary>
/// Returns the attachment at the passed index value.)
/// </summary>
public  string getAttachment(string tsattachable, int index = 0){


return m_ts.fnTSAttachable_getAttachment(tsattachable, index);
}
/// <summary>
/// Returns the number of objects that are currently attached.)
/// </summary>
public  int getNumAttachments(string tsattachable){


return m_ts.fnTSAttachable_getNumAttachments(tsattachable);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class TSDynamicObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public TSDynamicObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ,NULL,NULL),   @brief Change one of the materials on the shape.   This method changes materials per mapTo with others. The material that    is being replaced is mapped to unmapped_mat as a part of this transition.   @note Warning, right now this only sort of works. It doesn't do a live    update like it should.   @param mapTo the name of the material target to remap (from getTargetName)   @param oldMat the old Material that was mapped    @param newMat the new Material to map   @tsexample      // remap the first material in the shape      %mapTo = %obj.getTargetName( 0 );      %obj.changeMaterial( %mapTo, 0, MyMaterial );   @endtsexample )
/// </summary>
public  void changeMaterial(string tsdynamic, string mapTo = "", string oldMat = null , string newMat = null ){
if (oldMat== null) {oldMat = null;}
if (newMat== null) {newMat = null;}


m_ts.fnTSDynamic_changeMaterial(tsdynamic, mapTo, oldMat, newMat);
}
/// <summary>
/// @brief Get the model filename used by this shape.   @return the shape filename   @tsexample		// Acquire the model filename used on this shape.		%modelFilename = %obj.getModelFile();   @endtsexample   )
/// </summary>
public  string getModelFile(string tsdynamic){


return m_ts.fnTSDynamic_getModelFile(tsdynamic);
}
/// <summary>
/// Get the number of materials in the shape.   @return the number of materials in the shape.   @see getTargetName())
/// </summary>
public  int getTargetCount(string tsdynamic){


return m_ts.fnTSDynamic_getTargetCount(tsdynamic);
}
/// <summary>
/// Get the name of the indexed shape material.   @param index index of the material to get (valid range is 0 - getTargetCount()-1).   @return the name of the indexed material.   @see getTargetCount())
/// </summary>
public  string getTargetName(string tsdynamic, int index = 0){


return m_ts.fnTSDynamic_getTargetName(tsdynamic, index);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class TSPathShapeObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public TSPathShapeObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Returns the looping state for the shape.)
/// </summary>
public  bool getLooping(string tspathshape){


return m_ts.fnTSPathShape_getLooping(tspathshape);
}
/// <summary>
/// Returns the number of nodes on the shape's path.)
/// </summary>
public  int getNodeCount(string tspathshape){


return m_ts.fnTSPathShape_getNodeCount(tspathshape);
}
/// <summary>
/// Get the current position of the shape along the path (0.0 - lastNode - 1).)
/// </summary>
public  float getPathPosition(string tspathshape){


return m_ts.fnTSPathShape_getPathPosition(tspathshape);
}
/// <summary>
/// Removes the knot at the front of the shape's path.													@tsexample														// Remove the first knot in the shape's path.														%pathShape.popFront();													@endtsexample)
/// </summary>
public  void popFront(string tspathshape){


m_ts.fnTSPathShape_popFront(tspathshape);
}
/// <summary>
/// Normal, Linear), 											      @brief Adds a new knot to the back of a shape's path.													@param transform Transform for the new knot.  In the form of \"x y z ax ay az aa\" such as returned by SceneObject::getTransform()													@param speed Speed setting for this knot.													@param type Knot type (Normal, Position Only, Kink).													@param path %Path type (Linear, Spline).													@tsexample														// Transform vector for new knot. (Pos_X Pos_Y Pos_Z Rot_X Rot_Y Rot_Z Angle)														%transform = \"15.0 5.0 5.0 1.4 1.0 0.2 1.0\"														// Speed setting for knot.														%speed = \"1.0\"														// Knot type. (Normal, Position Only, Kink)														%type = \"Normal\";														// Path Type. (Linear, Spline)														%path = \"Linear\";														// Inform the shape to add a new knot to the back of its path														%pathShape.pushBack(%transform,%speed,%type,%path);													@endtsexample)
/// </summary>
public  void pushBack(string tspathshape, TransformF transform, float speed = 1.0f, string type = "Normal", string path = "Linear"){


m_ts.fnTSPathShape_pushBack(tspathshape, transform.AsString(), speed, type, path);
}
/// <summary>
/// Normal, Linear), 											      @brief Adds a new knot to the front of a path shape's path.													@param transform Transform for the new knot. In the form of \"x y z ax ay az aa\" such as returned by SceneObject::getTransform()													@param speed Speed setting for this knot.													@param type Knot type (Normal, Position Only, Kink).													@param path %Path type (Linear, Spline).													@tsexample														// Transform vector for new knot. (Pos_X,Pos_Y,Pos_Z,Rot_X,Rot_Y,Rot_Z,Angle)														%transform = \"15.0 5.0 5.0 1.4 1.0 0.2 1.0\"														// Speed setting for knot.														%speed = \"1.0\";														// Knot type. (Normal, Position Only, Kink)														%type = \"Normal\";														// Path Type. (Linear, Spline)														%path = \"Linear\";														// Inform the shape to add a new knot to the front of its path														%pathShape.pushFront(%transform, %speed, %type, %path);													@endtsexample)
/// </summary>
public  void pushFront(string tspathshape, TransformF transform, float speed = 1.0f, string type = "Normal", string path = "Linear"){


m_ts.fnTSPathShape_pushFront(tspathshape, transform.AsString(), speed, type, path);
}
/// <summary>
/// @brief Clear the shapes's path and optionally initializes the first node with the shapes current transform and speed.         The shapes movement is stopped and any current path is cleared. The target and position values are both reset to 0.          When makeFirstKnot is true a new knot is created and pushed onto the path.         @param speed Speed for the first knot if created.         @param makeFirstKnot Initialize a new path with the current shape transform.         @param initFromPath Initialize the knot type and smoothing values from the current path.)
/// </summary>
public  void reset(string tspathshape, float speed = 1.0f, bool makeFirstKnot = true, bool initFromPath = true){


m_ts.fnTSPathShape_reset(tspathshape, speed, makeFirstKnot, initFromPath);
}
/// <summary>
/// Sets whether the path should loop or stop at the last node.													@param isLooping New loop flag true/false.)
/// </summary>
public  void setLooping(string tspathshape, bool isLooping = true){


m_ts.fnTSPathShape_setLooping(tspathshape, isLooping);
}
/// <summary>
/// Set the movement state for this shape.													@param newState New movement state type for this shape. Forward, Backward or Stop.)
/// </summary>
public  void setMoveState(string tspathshape, TypePathShapeState newState = null ){
if (newState== null) {newState = TypePathShapeState.Forward;}


m_ts.fnTSPathShape_setMoveState(tspathshape, (int)newState );
}
/// <summary>
/// Set the current position of the shape along the path.													@param position Position along the path, from 0.0 (path start) - 1.0 (path end), to place the shape.)
/// </summary>
public  void setPathPosition(string tspathshape, float position = 0.0f){


m_ts.fnTSPathShape_setPathPosition(tspathshape, position);
}
/// <summary>
/// @brief Set the movement target for this shape along its path.                                       The shape will attempt to move along the path to the given target without going past the loop node.                                        Once the shape arrives at the target,the onTargetReached() callback will be triggered and the target                                        state will be cleared.													@param position Target position, between 0.0 (path start) and nodeCount - 1 (path end), for the                                        shape to move to along its path.)
/// </summary>
public  void setTarget(string tspathshape, float position = 1.0f){


m_ts.fnTSPathShape_setTarget(tspathshape, position);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class TSShapeConstructorObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public TSShapeConstructorObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Autofit a mesh primitive or set of convex hulls to the shape geometry. Hulls    may optionally be converted to boxes, spheres and/or capsules based on their    volume.   @param size size for this detail level   @param type one of: box, sphere, capsule, 10-dop x, 10-dop y, 10-dop z, 18-dop,       26-dop, convex hulls. See the Shape Editor documentation for more details       about these types.   @param target geometry to fit collision mesh(es) to; either \"bounds\" (for the       whole shape), or the name of an object in the shape   @param depth maximum split recursion depth (hulls only)   @param merge volume % threshold used to merge hulls together (hulls only)   @param concavity volume % threshold used to detect concavity (hulls only)   @param maxVerts maximum number of vertices per hull (hulls only)   @param boxMaxError max % volume difference for a hull to be converted to a       box (hulls only)   @param sphereMaxError max % volume difference for a hull to be converted to       a sphere (hulls only)   @param capsuleMaxError max % volume difference for a hull to be converted to       a capsule (hulls only)   @return true if successful, false otherwise   @tsexample   %this.addCollisionDetail( -1, \"box\", \"bounds\" );   %this.addCollisionDetail( -1, \"convex hulls\", \"bounds\", 4, 30, 30, 32, 0, 0, 0 );   %this.addCollisionDetail( -1, \"convex hulls\", \"bounds\", 4, 30, 30, 32, 50, 50, 50 );   @endtsexample )
/// </summary>
public  bool addCollisionDetail(string tsshapeconstructor, int size, string type, string target, int depth = 4, float merge = 30, float concavity = 30, int maxVerts = 32, float boxMaxError = 0, float sphereMaxError = 0, float capsuleMaxError = 0){


return m_ts.fnTSShapeConstructor_addCollisionDetail(tsshapeconstructor, size, type, target, depth, merge, concavity, maxVerts, boxMaxError, sphereMaxError, capsuleMaxError);
}
/// <summary>
/// Add (or edit) an imposter detail level to the shape.   If the shape already contains an imposter detail level, this command will    simply change the imposter settings   @param size size of the imposter detail level   @param equatorSteps defines the number of snapshots to take around the    equator. Imagine the object being rotated around the vertical axis, then    a snapshot taken at regularly spaced intervals.   @param polarSteps defines the number of snapshots taken between the poles    (top and bottom), at each equator step. eg. At each equator snapshot,    snapshots are taken at regular intervals between the poles.   @param dl the detail level to use when generating the snapshots. Note that    this is an array index rather than a detail size. So if an object has detail    sizes of: 200, 150, and 40, then setting @a dl to 1 will generate the snapshots    using detail size 150.   @param dim defines the size of the imposter images in pixels. The larger the    number, the more detailed the billboard will be.   @param includePoles flag indicating whether to include the \"pole\" snapshots.    ie. the views from the top and bottom of the object.   @param polar_angle if pole snapshots are active (@a includePoles is true), this    parameter defines the camera angle (in degrees) within which to render the    pole snapshot. eg. if polar_angle is set to 25 degrees, then the snapshot    taken at the pole (looking directly down or up at the object) will be rendered    when the camera is within 25 degrees of the pole.   @return true if successful, false otherwise   @tsexample   %this.addImposter( 2, 4, 0, 0, 64, false, 0 );   %this.addImposter( 2, 4, 2, 0, 64, true, 10 );   // this command would edit the existing imposter detail level   @endtsexample )
/// </summary>
public  int addImposter(string tsshapeconstructor, int size, int equatorSteps, int polarSteps, int dl, int dim, bool includePoles, float polarAngle){


return m_ts.fnTSShapeConstructor_addImposter(tsshapeconstructor, size, equatorSteps, polarSteps, dl, dim, includePoles, polarAngle);
}
/// <summary>
/// Add geometry from another DTS or DAE shape file into this shape.   Any materials required by the source mesh are also copied into this shape.br>   @param meshName full name (object name + detail size) of the new mesh. If       no detail size is present at the end of the name, a value of 2 is used.br>      An underscore before the number at the end of the name will be interpreted as       a negative sign. eg. \"MyMesh_4\" will be interpreted as \"MyMesh-4\".   @param srcShape name of a shape file (DTS or DAE) that contains the mesh   @param srcMesh the full name (object name + detail size) of the mesh to       copy from the DTS/DAE file into this shape/li>   @return true if successful, false otherwise   @tsexample   %this.addMesh( \"ColMesh-1\", \"./collision.dts\", \"ColMesh\", \"Col-1\" );   %this.addMesh( \"SimpleShape10\", \"./testShape.dae\", \"MyMesh2\",  );   @endtsexample )
/// </summary>
public  bool addMesh(string tsshapeconstructor, string meshName, string srcShape, string srcMesh){


return m_ts.fnTSShapeConstructor_addMesh(tsshapeconstructor, meshName, srcShape, srcMesh);
}
/// <summary>
/// Add a new node.   @param name name for the new node (must not already exist)   @param parentName name of an existing node to be the parent of the new node.    If empty (\"\"), the new node will be at the root level of the node hierarchy.   @param txfm (optional) transform string of the form: \"pos.x pos.y pos.z rot.x rot.y rot.z rot.angle\"   @param isworld (optional) flag to set the local-to-parent or the global    transform. If false, or not specified, the position and orientation are    treated as relative to the node's parent.   @return true if successful, false otherwise   @tsexample   %this.addNode( \"Nose\", \"Bip01 Head\", \"0 2 2 0 0 1 0\" );   %this.addNode( \"myRoot\", \"\", \"0 0 4 0 0 1 1.57\" );   %this.addNode( \"Nodes\", \"Bip01 Head\", \"0 2 0 0 0 1 0\", true );   @endtsexample )
/// </summary>
public  bool addNode(string tsshapeconstructor, string name, string parentName, TransformF txfm = null , bool isWorld = false){
if (txfm== null) {txfm = new TransformF(0,0,0,0,0,1,0);}


return m_ts.fnTSShapeConstructor_addNode(tsshapeconstructor, name, parentName, txfm.AsString(), isWorld);
}
/// <summary>
/// Add a new mesh primitive to the shape.   @param meshName full name (object name + detail size) of the new mesh. If       no detail size is present at the end of the name, a value of 2 is used.br>      An underscore before the number at the end of the name will be interpreted as       a negative sign. eg. \"MyMesh_4\" will be interpreted as \"MyMesh-4\".   @param type one of: \"box\", \"sphere\", \"capsule\"   @param params mesh primitive parameters:      ul>         li>for box: \"size_x size_y size_z\"/li>         li>for sphere: \"radius\"/li>         li>for capsule: \"height radius\"/li>      /ul>   /ul>   @param txfm local transform offset from the node for this mesh   @param nodeName name of the node to attach the new mesh to (will change the    object's node if adding a new mesh to an existing object)   @return true if successful, false otherwise   @tsexample   %this.addMesh( \"Box4\", \"box\", \"2 4 2\", \"0 2 0 0 0 1 0\", \"eye\" );   %this.addMesh( \"Sphere256\", \"sphere\", \"2\", \"0 0 0 0 0 1 0\", \"root\" );   %this.addMesh( \"MyCapsule-1\", \"capsule\", \"2 5\", \"0 0 2 0 0 1 0\", \"base01\" );   @endtsexample )
/// </summary>
public  bool addPrimitive(string tsshapeconstructor, string meshName, string type, string paramsx, TransformF txfm, string nodeName){


return m_ts.fnTSShapeConstructor_addPrimitive(tsshapeconstructor, meshName, type, paramsx, txfm.AsString(), nodeName);
}
/// <summary>
/// Add a new sequence to the shape.   @param source the name of an existing sequence, or the name of a DTS or DAE    shape or DSQ sequence file. When the shape file contains more than one    sequence, the desired sequence can be specified by appending the name to the    end of the shape file. eg. \"myShape.dts run\" would select the \"run\"    sequence from the \"myShape.dts\" file.   @param name name of the new sequence   @param start (optional) first frame to copy. Defaults to 0, the first frame in the sequence.   @param end (optional) last frame to copy. Defaults to -1, the last frame in the sequence.   @param padRot (optional) copy root-pose rotation keys for non-animated nodes. This is useful if    the source sequence data has a different root-pose to the target shape, such as if one character was    in the T pose, and the other had arms at the side. Normally only nodes that are actually rotated by    the source sequence have keyframes added, but setting this flag will also add keyframes for nodes    that are not animated, but have a different root-pose rotation to the target shape root pose.   @param padTrans (optional) copy root-pose translation keys for non-animated nodes.  This is useful if    the source sequence data has a different root-pose to the target shape, such as if one character was    in the T pose, and the other had arms at the side. Normally only nodes that are actually moved by    the source sequence have keyframes added, but setting this flag will also add keyframes for nodes    that are not animated, but have a different root-pose position to the target shape root pose.   @return true if successful, false otherwise   @tsexample   %this.addSequence( \"./testShape.dts ambient\", \"ambient\" );   %this.addSequence( \"./myPlayer.dae run\", \"run\" );   %this.addSequence( \"./player_look.dsq\", \"look\", 0, -1 );     // start to end   %this.addSequence( \"walk\", \"walk_shortA\", 0, 4 );            // start to frame 4   %this.addSequence( \"walk\", \"walk_shortB\", 4, -1 );           // frame 4 to end   @endtsexample )
/// </summary>
public  bool addSequence(string tsshapeconstructor, string source, string name, int start = 0, int end = -1, bool padRot = true, bool padTrans = false){


return m_ts.fnTSShapeConstructor_addSequence(tsshapeconstructor, source, name, start, end, padRot, padTrans);
}
/// <summary>
/// Add a new trigger to the sequence.   @param name name of the sequence to modify   @param keyframe keyframe of the new trigger   @param state of the new trigger   @return true if successful, false otherwise   @tsexample   %this.addTrigger( \"walk\", 3, 1 );   %this.addTrigger( \"walk\", 5, -1 );   @endtsexample )
/// </summary>
public  bool addTrigger(string tsshapeconstructor, string name, int keyframe, int state){


return m_ts.fnTSShapeConstructor_addTrigger(tsshapeconstructor, name, keyframe, state);
}
/// <summary>
/// Dump the shape hierarchy to the console or to a file. Useful for reviewing    the result of a series of construction commands.   @param filename Destination filename. If not specified, dump to console.   @tsexample   %this.dumpShape();               // dump to console   %this.dumpShape( \"./dump.txt\" ); // dump to file   @endtsexample )
/// </summary>
public  void dumpShape(string tsshapeconstructor, string filename = ""){


m_ts.fnTSShapeConstructor_dumpShape(tsshapeconstructor, filename);
}
/// <summary>
/// Get the bounding box for the shape.   @return Bounding box \"minX minY minZ maxX maxY maxZ\" )
/// </summary>
public  Box3F getBounds(string tsshapeconstructor){


return new Box3F ( m_ts.fnTSShapeConstructor_getBounds(tsshapeconstructor));
}
/// <summary>
/// Get the total number of detail levels in the shape.   @return the number of detail levels in the shape )
/// </summary>
public  int getDetailLevelCount(string tsshapeconstructor){


return m_ts.fnTSShapeConstructor_getDetailLevelCount(tsshapeconstructor);
}
/// <summary>
/// Get the index of the detail level with a given size.   @param size size of the detail level to lookup   @return index of the detail level with the desired size, or -1 if no such    detail exists   @tsexample   if ( %this.getDetailLevelSize( 32 ) == -1 )      echo( \"Error: This shape does not have a detail level at size 32\" );   @endtsexample )
/// </summary>
public  int getDetailLevelIndex(string tsshapeconstructor, int size){


return m_ts.fnTSShapeConstructor_getDetailLevelIndex(tsshapeconstructor, size);
}
/// <summary>
/// Get the name of the indexed detail level.   @param index detail level index (valid range is 0 - getDetailLevelCount()-1)   @return the detail level name   @tsexample   // print the names of all detail levels in the shape   %count = %this.getDetailLevelCount();   for ( %i = 0; %i  %count; %i++ )      echo( %i SPC %this.getDetailLevelName( %i ) );   @endtsexample )
/// </summary>
public  string getDetailLevelName(string tsshapeconstructor, int index){


return m_ts.fnTSShapeConstructor_getDetailLevelName(tsshapeconstructor, index);
}
/// <summary>
/// Get the size of the indexed detail level.   @param index detail level index (valid range is 0 - getDetailLevelCount()-1)   @return the detail level size   @tsexample   // print the sizes of all detail levels in the shape   %count = %this.getDetailLevelCount();   for ( %i = 0; %i  %count; %i++ )      echo( \"Detail\" @ %i @ \" has size \" @ %this.getDetailLevelSize( %i ) );   @endtsexample )
/// </summary>
public  int getDetailLevelSize(string tsshapeconstructor, int index){


return m_ts.fnTSShapeConstructor_getDetailLevelSize(tsshapeconstructor, index);
}
/// <summary>
/// Get the index of the imposter (auto-billboard) detail level (if any).   @return imposter detail level index, or -1 if the shape does not use    imposters. )
/// </summary>
public  int getImposterDetailLevel(string tsshapeconstructor){


return m_ts.fnTSShapeConstructor_getImposterDetailLevel(tsshapeconstructor);
}
/// <summary>
/// Get the settings used to generate imposters for the indexed detail level.   @param index index of the detail level to query (does not need to be an    imposter detail level   @return string of the form: \"valid eqSteps pSteps dl dim poles angle\", where:   dl>      dt>valid/dt>dd>1 if this detail level generates imposters, 0 otherwise/dd>      dt>eqSteps/dt>dd>number of steps around the equator/dd>      dt>pSteps/dt>dd>number of steps between the poles/dd>      dt>dl/dt>dd>index of the detail level used to generate imposters/dd>      dt>dim/dt>dd>size (in pixels) of each imposter image/dd>      dt>poles/dt>dd>1 to include pole images, 0 otherwise/dd>      dt>angle/dt>dd>angle at which to display pole images/dd>   /dl>   @tsexample   // print the imposter detail level settings   %index = %this.getImposterDetailLevel();   if ( %index != -1 )      echo( \"Imposter settings: \" @ %this.getImposterSettings( %index ) );   @endtsexample )
/// </summary>
public  string getImposterSettings(string tsshapeconstructor, int index){


return m_ts.fnTSShapeConstructor_getImposterSettings(tsshapeconstructor, index);
}
/// <summary>
/// Get the number of meshes (detail levels) for the specified object.   @param name name of the object to query   @return the number of meshes for this object.   @tsexample   %count = %this.getMeshCount( \"SimpleShape\" );   @endtsexample )
/// </summary>
public  int getMeshCount(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_getMeshCount(tsshapeconstructor, name);
}
/// <summary>
/// Get the name of the material attached to a mesh. Note that only the first    material used by the mesh is returned.   @param name full name (object name + detail size) of the mesh to query   @return name of the material attached to the mesh (suitable for use with the Material mapTo field)   @tsexample   echo( \"Mesh material is \" @ %this.sgetMeshMaterial( \"SimpleShape128\" ) );   @endtsexample )
/// </summary>
public  string getMeshMaterial(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_getMeshMaterial(tsshapeconstructor, name);
}
/// <summary>
/// Get the name of the indexed mesh (detail level) for the specified object.   @param name name of the object to query   @param index index of the mesh (valid range is 0 - getMeshCount()-1)   @return the mesh name.   @tsexample   // print the names of all meshes in the shape   %objCount = %this.getObjectCount();   for ( %i = 0; %i  %objCount; %i++ )   {      %objName = %this.getObjectName( %i );      %meshCount = %this.getMeshCount( %objName );      for ( %j = 0; %j  %meshCount; %j++ )         echo( %this.getMeshName( %objName, %j ) );   }   @endtsexample )
/// </summary>
public  string getMeshName(string tsshapeconstructor, string name, int index){


return m_ts.fnTSShapeConstructor_getMeshName(tsshapeconstructor, name, index);
}
/// <summary>
/// Get the detail level size of the indexed mesh for the specified object.   @param name name of the object to query   @param index index of the mesh (valid range is 0 - getMeshCount()-1)   @return the mesh detail level size.   @tsexample   // print sizes for all detail levels of this object   %objName = \"trunk\";   %count = %this.getMeshCount( %objName );   for ( %i = 0; %i  %count; %i++ )      echo( %this.getMeshSize( %objName, %i ) );   @endtsexample )
/// </summary>
public  int getMeshSize(string tsshapeconstructor, string name, int index){


return m_ts.fnTSShapeConstructor_getMeshSize(tsshapeconstructor, name, index);
}
/// <summary>
/// Get the display type of the mesh.   @param name name of the mesh to query   @return the string returned is one of:   dl>dt>normal/dt>dd>a normal 3D mesh/dd>   dt>billboard/dt>dd>a mesh that always faces the camera/dd>   dt>billboardzaxis/dt>dd>a mesh that always faces the camera in the Z-axis/dd>/dl>   @tsexample   echo( \"Mesh type is \" @ %this.getMeshType( \"SimpleShape128\" ) );   @endtsexample )
/// </summary>
public  string getMeshType(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_getMeshType(tsshapeconstructor, name);
}
/// <summary>
/// Get the number of children of this node.   @param name name of the node to query.   @return the number of child nodes.   @tsexample   %count = %this.getNodeChildCount( \"Bip01 Pelvis\" );   @endtsexample )
/// </summary>
public  int getNodeChildCount(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_getNodeChildCount(tsshapeconstructor, name);
}
/// <summary>
/// Get the name of the indexed child node.   @param name name of the parent node to query.   @param index index of the child node (valid range is 0 - getNodeChildName()-1).   @return the name of the indexed child node.   @tsexample   function dumpNode( %shape, %name, %indent )   {      echo( %indent @ %name );      %count = %shape.getNodeChildCount( %name );      for ( %i = 0; %i  %count; %i++ )         dumpNode( %shape, %shape.getNodeChildName( %name, %i ), %indent @ \"   \" );   }   function dumpShape( %shape )   {      // recursively dump node hierarchy      %count = %shape.getNodeCount();      for ( %i = 0; %i  %count; %i++ )      {         // dump top level nodes         %name = %shape.getNodeName( %i );         if ( %shape.getNodeParentName( %name ) $=  )            dumpNode( %shape, %name, \"\" );      }   }   @endtsexample )
/// </summary>
public  string getNodeChildName(string tsshapeconstructor, string name, int index){


return m_ts.fnTSShapeConstructor_getNodeChildName(tsshapeconstructor, name, index);
}
/// <summary>
/// Get the total number of nodes in the shape.   @return the number of nodes in the shape.   @tsexample   %count = %this.getNodeCount();   @endtsexample )
/// </summary>
public  int getNodeCount(string tsshapeconstructor){


return m_ts.fnTSShapeConstructor_getNodeCount(tsshapeconstructor);
}
/// <summary>
/// Get the index of the node.   @param name name of the node to lookup.   @return the index of the named node, or -1 if no such node exists.   @tsexample   // get the index of Bip01 Pelvis node in the shape   %index = %this.getNodeIndex( \"Bip01 Pelvis\" );   @endtsexample )
/// </summary>
public  int getNodeIndex(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_getNodeIndex(tsshapeconstructor, name);
}
/// <summary>
/// Get the name of the indexed node.   @param index index of the node to lookup (valid range is 0 - getNodeCount()-1).   @return the name of the indexed node, or \"\" if no such node exists.   @tsexample   // print the names of all the nodes in the shape   %count = %this.getNodeCount();   for (%i = 0; %i  %count; %i++)      echo(%i SPC %this.getNodeName(%i));   @endtsexample )
/// </summary>
public  string getNodeName(string tsshapeconstructor, int index){


return m_ts.fnTSShapeConstructor_getNodeName(tsshapeconstructor, index);
}
/// <summary>
/// Get the number of geometry objects attached to this node.   @param name name of the node to query.   @return the number of attached objects.   @tsexample   %count = %this.getNodeObjectCount( \"Bip01 Head\" );   @endtsexample )
/// </summary>
public  int getNodeObjectCount(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_getNodeObjectCount(tsshapeconstructor, name);
}
/// <summary>
/// Get the name of the indexed object.   @param name name of the node to query.   @param index index of the object (valid range is 0 - getNodeObjectCount()-1).   @return the name of the indexed object.   @tsexample   // print the names of all objects attached to the node   %count = %this.getNodeObjectCount( \"Bip01 Head\" );   for ( %i = 0; %i  %count; %i++ )      echo( %this.getNodeObjectName( \"Bip01 Head\", %i ) );   @endtsexample )
/// </summary>
public  string getNodeObjectName(string tsshapeconstructor, string name, int index){


return m_ts.fnTSShapeConstructor_getNodeObjectName(tsshapeconstructor, name, index);
}
/// <summary>
/// Get the name of the node's parent. If the node has no parent (ie. it is at    the root level), return an empty string.   @param name name of the node to query.   @return the name of the node's parent, or \"\" if the node is at the root level   @tsexample   echo( \"Bip01 Pelvis parent = \" @ %this.getNodeParentName( \"Bip01 Pelvis \") );   @endtsexample )
/// </summary>
public  string getNodeParentName(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_getNodeParentName(tsshapeconstructor, name);
}
/// <summary>
/// Get the base (ie. not animated) transform of a node.   @param name name of the node to query.   @param isWorld true to get the global transform, false (or omitted) to get    the local-to-parent transform.   @return the node transform in the form \"pos.x pos.y pos.z rot.x rot.y rot.z rot.angle\".   @tsexample   %ret = %this.getNodeTransform( \"mount0\" );   %this.setNodeTransform( \"mount4\", %ret );   @endtsexample )
/// </summary>
public  TransformF getNodeTransform(string tsshapeconstructor, string name, bool isWorld = false){


return new TransformF ( m_ts.fnTSShapeConstructor_getNodeTransform(tsshapeconstructor, name, isWorld));
}
/// <summary>
/// Get the total number of objects in the shape.   @return the number of objects in the shape.   @tsexample   %count = %this.getObjectCount();   @endtsexample )
/// </summary>
public  int getObjectCount(string tsshapeconstructor){


return m_ts.fnTSShapeConstructor_getObjectCount(tsshapeconstructor);
}
/// <summary>
/// Get the index of the first object with the given name.   @param name name of the object to get.   @return the index of the named object.   @tsexample   %index = %this.getObjectIndex( \"Head\" );   @endtsexample )
/// </summary>
public  int getObjectIndex(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_getObjectIndex(tsshapeconstructor, name);
}
/// <summary>
/// Get the name of the indexed object.   @param index index of the object to get (valid range is 0 - getObjectCount()-1).   @return the name of the indexed object.   @tsexample   // print the names of all objects in the shape   %count = %this.getObjectCount();   for ( %i = 0; %i  %count; %i++ )      echo( %i SPC %this.getObjectName( %i ) );   @endtsexample )
/// </summary>
public  string getObjectName(string tsshapeconstructor, int index){


return m_ts.fnTSShapeConstructor_getObjectName(tsshapeconstructor, index);
}
/// <summary>
/// Get the name of the node this object is attached to.   @param name name of the object to get.   @return the name of the attached node, or an empty string if this    object is not attached to a node (usually the case for skinned meshes).   @tsexample   echo( \"Hand is attached to \" @ %this.getObjectNode( \"Hand\" ) );   @endtsexample )
/// </summary>
public  string getObjectNode(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_getObjectNode(tsshapeconstructor, name);
}
/// <summary>
/// Get information about blended sequences.   @param name name of the sequence to query   @return TAB delimited string of the form: \"isBlend blendSeq blendFrame\", where:   dl>   dt>blend_flag/dt>dd>a boolean flag indicating whether this sequence is a blend/dd>   dt>blend_seq_name/dt>dd>the name of the sequence that contains the reference    frame (empty for blend sequences embedded in DTS files)/dd>   dt>blend_seq_frame/dt>dd>the blend reference frame (empty for blend sequences    embedded in DTS files)/dd>   /dl>   @note Note that only sequences set to be blends using the setSequenceBlend    command will contain the blendSeq and blendFrame information.   @tsexample   %blendData = %this.getSequenceBlend( \"look\" );   if ( getField( %blendData, 0 ) )      echo( \"look is a blend, reference: \" @ getField( %blendData, 1 ) );   @endtsexample )
/// </summary>
public  string getSequenceBlend(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_getSequenceBlend(tsshapeconstructor, name);
}
/// <summary>
/// Get the total number of sequences in the shape.   @return the number of sequences in the shape )
/// </summary>
public  int getSequenceCount(string tsshapeconstructor){


return m_ts.fnTSShapeConstructor_getSequenceCount(tsshapeconstructor);
}
/// <summary>
/// Check if this sequence is cyclic (looping).   @param name name of the sequence to query   @return true if this sequence is cyclic, false if not   @tsexample   if ( !%this.getSequenceCyclic( \"ambient\" ) )      error( \"ambient sequence is not cyclic!\" );   @endtsexample )
/// </summary>
public  bool getSequenceCyclic(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_getSequenceCyclic(tsshapeconstructor, name);
}
/// <summary>
/// Get the number of keyframes in the sequence.   @param name name of the sequence to query   @return number of keyframes in the sequence   @tsexample   echo( \"Run has \" @ %this.getSequenceFrameCount( \"run\" ) @ \" keyframes\" );   @endtsexample )
/// </summary>
public  int getSequenceFrameCount(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_getSequenceFrameCount(tsshapeconstructor, name);
}
/// <summary>
/// Get the ground speed of the sequence.   @note Note that only the first 2 ground frames of the sequence are    examined; the speed is assumed to be constant throughout the sequence.   @param name name of the sequence to query   @return string of the form: \"trans.x trans.y trans.z rot.x rot.y rot.z\"   @tsexample   %speed = VectorLen( getWords( %this.getSequenceGroundSpeed( \"run\" ), 0, 2 ) );      echo( \"Run moves at \" @ %speed @ \" units per frame\" );   @endtsexample )
/// </summary>
public  string getSequenceGroundSpeed(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_getSequenceGroundSpeed(tsshapeconstructor, name);
}
/// <summary>
/// Find the index of the sequence with the given name.   @param name name of the sequence to lookup   @return index of the sequence with matching name, or -1 if not found   @tsexample   // Check if a given sequence exists in the shape   if ( %this.getSequenceIndex( \"walk\" ) == -1 )      echo( \"Could not find 'walk' sequence\" );   @endtsexample )
/// </summary>
public  int getSequenceIndex(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_getSequenceIndex(tsshapeconstructor, name);
}
/// <summary>
/// Get the name of the indexed sequence.   @param index index of the sequence to query (valid range is 0 - getSequenceCount()-1)   @return the name of the sequence   @tsexample   // print the name of all sequences in the shape   %count = %this.getSequenceCount();   for ( %i = 0; %i  %count; %i++ )      echo( %i SPC %this.getSequenceName( %i ) );   @endtsexample )
/// </summary>
public  string getSequenceName(string tsshapeconstructor, int index){


return m_ts.fnTSShapeConstructor_getSequenceName(tsshapeconstructor, index);
}
/// <summary>
/// Get the priority setting of the sequence.   @param name name of the sequence to query   @return priority value of the sequence )
/// </summary>
public  float getSequencePriority(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_getSequencePriority(tsshapeconstructor, name);
}
/// <summary>
/// Get information about where the sequence data came from.   For example, whether it was loaded from an external DSQ file.   @param name name of the sequence to query   @return TAB delimited string of the form: \"from reserved start end total\", where:   dl>      dt>from/dt>dd>the source of the animation data, such as the path to       a DSQ file, or the name of an existing sequence in the shape. This field       will be empty for sequences already embedded in the DTS or DAE file./dd>      dt>reserved/dt>dd>reserved value/dd>      dt>start/dt>dd>the first frame in the source sequence used to create this sequence/dd>      dt>end/dt>dd>the last frame in the source sequence used to create this sequence/dd>      dt>total/dt>dd>the total number of frames in the source sequence/dd>   /dl>   @tsexample   // print the source for the walk animation   echo( \"walk source:\" SPC getField( %this.getSequenceSource( \"walk\" ), 0 ) );   @endtsexample )
/// </summary>
public  string getSequenceSource(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_getSequenceSource(tsshapeconstructor, name);
}
/// <summary>
/// Get the number of materials in the shape.   @return the number of materials in the shape.   @tsexample   %count = %this.getTargetCount();   @endtsexample )
/// </summary>
public  int getTargetCount(string tsshapeconstructor){


return m_ts.fnTSShapeConstructor_getTargetCount(tsshapeconstructor);
}
/// <summary>
/// Get the name of the indexed shape material.   @param index index of the material to get (valid range is 0 - getTargetCount()-1).   @return the name of the indexed material.   @tsexample   %count = %this.getTargetCount();   for ( %i = 0; %i  %count; %i++ )      echo( \"Target \" @ %i @ \": \" @ %this.getTargetName( %i ) );   @endtsexample )
/// </summary>
public  string getTargetName(string tsshapeconstructor, int index){


return m_ts.fnTSShapeConstructor_getTargetName(tsshapeconstructor, index);
}
/// <summary>
/// Get information about the indexed trigger   @param name name of the sequence to query   @param index index of the trigger (valid range is 0 - getTriggerCount()-1)   @return string of the form \"frame state\"   @tsexample   // print all triggers in the sequence   %count = %this.getTriggerCount( \"back\" );   for ( %i = 0; %i  %count; %i++ )      echo( %i SPC %this.getTrigger( \"back\", %i ) );   @endtsexample )
/// </summary>
public  string getTrigger(string tsshapeconstructor, string name, int index){


return m_ts.fnTSShapeConstructor_getTrigger(tsshapeconstructor, name, index);
}
/// <summary>
/// Get the number of triggers in the specified sequence.   @param name name of the sequence to query   @return number of triggers in the sequence )
/// </summary>
public  int getTriggerCount(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_getTriggerCount(tsshapeconstructor, name);
}
/// <summary>
/// Notify game objects that this shape file has changed, allowing them to update    internal data if needed. )
/// </summary>
public  void notifyShapeChanged(string tsshapeconstructor){


m_ts.fnTSShapeConstructor_notifyShapeChanged(tsshapeconstructor);
}
/// <summary>
/// Remove the detail level (including all meshes in the detail level)   @param size size of the detail level to remove   @return true if successful, false otherwise   @tsexample   %this.removeDetailLevel( 2 );   @endtsexample )
/// </summary>
public  bool removeDetailLevel(string tsshapeconstructor, int index){


return m_ts.fnTSShapeConstructor_removeDetailLevel(tsshapeconstructor, index);
}
/// <summary>
/// () Remove the imposter detail level (if any) from the shape.   @return true if successful, false otherwise )
/// </summary>
public  bool removeImposter(string tsshapeconstructor){


return m_ts.fnTSShapeConstructor_removeImposter(tsshapeconstructor);
}
/// <summary>
/// Remove a mesh from the shape.   If all geometry is removed from an object, the object is also removed.   @param name full name (object name + detail size) of the mesh to remove   @return true if successful, false otherwise   @tsexample   %this.removeMesh( \"SimpleShape128\" );   @endtsexample )
/// </summary>
public  bool removeMesh(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_removeMesh(tsshapeconstructor, name);
}
/// <summary>
/// Remove a node from the shape.   The named node is removed from the shape, including from any sequences that    use the node. Child nodes and objects attached to the node are re-assigned    to the node's parent.   @param name name of the node to remove.   @return true if successful, false otherwise.   @tsexample   %this.removeNode( \"Nose\" );   @endtsexample )
/// </summary>
public  bool removeNode(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_removeNode(tsshapeconstructor, name);
}
/// <summary>
/// Remove an object (including all meshes for that object) from the shape.   @param name name of the object to remove.   @return true if successful, false otherwise.   @tsexample   // clear all objects in the shape   %count = %this.getObjectCount();   for ( %i = %count-1; %i >= 0; %i-- )      %this.removeObject( %this.getObjectName(%i) );   @endtsexample )
/// </summary>
public  bool removeObject(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_removeObject(tsshapeconstructor, name);
}
/// <summary>
/// Remove the sequence from the shape.   @param name name of the sequence to remove   @return true if successful, false otherwise )
/// </summary>
public  bool removeSequence(string tsshapeconstructor, string name){


return m_ts.fnTSShapeConstructor_removeSequence(tsshapeconstructor, name);
}
/// <summary>
/// Remove a trigger from the sequence.   @param name name of the sequence to modify   @param keyframe keyframe of the trigger to remove   @param state of the trigger to remove   @return true if successful, false otherwise   @tsexample   %this.removeTrigger( \"walk\", 3, 1 );   @endtsexample )
/// </summary>
public  bool removeTrigger(string tsshapeconstructor, string name, int keyframe, int state){


return m_ts.fnTSShapeConstructor_removeTrigger(tsshapeconstructor, name, keyframe, state);
}
/// <summary>
/// Rename a detail level.   @note Note that detail level names must be unique, so this command will    fail if there is already a detail level with the desired name   @param oldName current name of the detail level   @param newName new name of the detail level   @return true if successful, false otherwise   @tsexample   %this.renameDetailLevel( \"detail-1\", \"collision-1\" );   @endtsexample )
/// </summary>
public  bool renameDetailLevel(string tsshapeconstructor, string oldName, string newName){


return m_ts.fnTSShapeConstructor_renameDetailLevel(tsshapeconstructor, oldName, newName);
}
/// <summary>
/// Rename a node.   @note Note that node names must be unique, so this command will fail if    there is already a node with the desired name   @param oldName current name of the node   @param newName new name of the node   @return true if successful, false otherwise   @tsexample   %this.renameNode( \"Bip01 L Hand\", \"mount5\" );   @endtsexample )
/// </summary>
public  bool renameNode(string tsshapeconstructor, string oldName, string newName){


return m_ts.fnTSShapeConstructor_renameNode(tsshapeconstructor, oldName, newName);
}
/// <summary>
/// Rename an object.   @note Note that object names must be unique, so this command will fail if    there is already an object with the desired name   @param oldName current name of the object   @param newName new name of the object   @return true if successful, false otherwise   @tsexample   %this.renameObject( \"MyBox\", \"Box\" );   @endtsexample )
/// </summary>
public  bool renameObject(string tsshapeconstructor, string oldName, string newName){


return m_ts.fnTSShapeConstructor_renameObject(tsshapeconstructor, oldName, newName);
}
/// <summary>
/// Rename a sequence.   @note Note that sequence names must be unique, so this command will fail    if there is already a sequence with the desired name   @param oldName current name of the sequence   @param newName new name of the sequence   @return true if successful, false otherwise   @tsexample   %this.renameSequence( \"walking\", \"walk\" );   @endtsexample )
/// </summary>
public  bool renameSequence(string tsshapeconstructor, string oldName, string newName){


return m_ts.fnTSShapeConstructor_renameSequence(tsshapeconstructor, oldName, newName);
}
/// <summary>
/// Save the shape (with all current changes) to a new DTS file.   @param filename Destination filename.   @tsexample   %this.saveShape( \"./myShape.dts\" );   @endtsexample )
/// </summary>
public  void saveShape(string tsshapeconstructor, string filename){


m_ts.fnTSShapeConstructor_saveShape(tsshapeconstructor, filename);
}
/// <summary>
/// Set the shape bounds to the given bounding box.   @param Bounding box \"minX minY minZ maxX maxY maxZ\"   @return true if successful, false otherwise )
/// </summary>
public  bool setBounds(string tsshapeconstructor, Box3F bbox){


return m_ts.fnTSShapeConstructor_setBounds(tsshapeconstructor, bbox.AsString());
}
/// <summary>
/// Change the size of a detail level.   @note Note that detail levels are always sorted in decreasing size order,    so this command may cause detail level indices to change.   @param index index of the detail level to modify   @param newSize new size for the detail level   @return new index for this detail level   @tsexample   %this.setDetailLevelSize( 2, 256 );   @endtsexample )
/// </summary>
public  int setDetailLevelSize(string tsshapeconstructor, int index, int newSize){


return m_ts.fnTSShapeConstructor_setDetailLevelSize(tsshapeconstructor, index, newSize);
}
/// <summary>
/// Set the name of the material attached to the mesh.   @param meshName full name (object name + detail size) of the mesh to modify   @param matName name of the material to attach. This could be the base name of    the diffuse texture (eg. \"test_mat\" for \"test_mat.jpg\"), or the name of a    Material object already defined in script.   @return true if successful, false otherwise   @tsexample   // set the mesh material   %this.setMeshMaterial( \"SimpleShape128\", \"test_mat\" );   @endtsexample )
/// </summary>
public  bool setMeshMaterial(string tsshapeconstructor, string meshName, string matName){


return m_ts.fnTSShapeConstructor_setMeshMaterial(tsshapeconstructor, meshName, matName);
}
/// <summary>
/// Change the detail level size of the named mesh.   @param name full name (object name + current size ) of the mesh to modify   @param size new detail level size   @return true if successful, false otherwise.   @tsexample   %this.setMeshSize( \"SimpleShape128\", 64 );   @endtsexample )
/// </summary>
public  bool setMeshSize(string tsshapeconstructor, string name, int size){


return m_ts.fnTSShapeConstructor_setMeshSize(tsshapeconstructor, name, size);
}
/// <summary>
/// Set the display type for the mesh.   @param name full name (object name + detail size) of the mesh to modify   @param type the new type for the mesh: \"normal\", \"billboard\" or \"billboardzaxis\"   @return true if successful, false otherwise   @tsexample   // set the mesh to be a billboard   %this.setMeshType( \"SimpleShape64\", \"billboard\" );   @endtsexample )
/// </summary>
public  bool setMeshType(string tsshapeconstructor, string name, string type){


return m_ts.fnTSShapeConstructor_setMeshType(tsshapeconstructor, name, type);
}
/// <summary>
/// Set the parent of a node.  @param name name of the node to modify  @param parentName name of the parent node to set (use \"\" to move the node to the root level)  @return true if successful, false if failed  @tsexample  %this.setNodeParent( \"Bip01 Pelvis\", \"start01\" );  @endtsexample )
/// </summary>
public  bool setNodeParent(string tsshapeconstructor, string name, string parentName){


return m_ts.fnTSShapeConstructor_setNodeParent(tsshapeconstructor, name, parentName);
}
/// <summary>
/// Set the base transform of a node. That is, the transform of the node when    in the root (not-animated) pose.   @param name name of the node to modify   @param txfm transform string of the form: \"pos.x pos.y pos.z rot.x rot.y rot.z rot.angle\"   @param isworld (optional) flag to set the local-to-parent or the global    transform. If false, or not specified, the position and orientation are    treated as relative to the node's parent.   @return true if successful, false otherwise   @tsexample   %this.setNodeTransform( \"mount0\", \"0 0 1 0 0 1 0\" );   %this.setNodeTransform( \"mount0\", \"0 0 0 0 0 1 1.57\" );   %this.setNodeTransform( \"mount0\", \"1 0 0 0 0 1 0\", true );   @endtsexample )
/// </summary>
public  bool setNodeTransform(string tsshapeconstructor, string name, TransformF txfm, bool isWorld = false){


return m_ts.fnTSShapeConstructor_setNodeTransform(tsshapeconstructor, name, txfm.AsString(), isWorld);
}
/// <summary>
/// Set the node an object is attached to.   When the shape is rendered, the object geometry is rendered at the node's    current transform.   @param objName name of the object to modify   @param nodeName name of the node to attach the object to   @return true if successful, false otherwise   @tsexample   %this.setObjectNode( \"Hand\", \"Bip01 LeftHand\" );   @endtsexample )
/// </summary>
public  bool setObjectNode(string tsshapeconstructor, string objName, string nodeName){


return m_ts.fnTSShapeConstructor_setObjectNode(tsshapeconstructor, objName, nodeName);
}
/// <summary>
/// Mark a sequence as a blend or non-blend.   A blend sequence is one that will be added on top of any other playing    sequences. This is done by storing the animated node transforms relative    to a reference frame, rather than as absolute transforms.   @param name name of the sequence to modify   @param blend true to make the sequence a blend, false for a non-blend   @param blendSeq the name of the sequence that contains the blend reference frame   @param blendFrame the reference frame in the blendSeq sequence   @return true if successful, false otherwise   @tsexample   %this.setSequenceBlend( \"look\", true, \"root\", 0 );   @endtsexample )
/// </summary>
public  bool setSequenceBlend(string tsshapeconstructor, string name, bool blend, string blendSeq, int blendFrame){


return m_ts.fnTSShapeConstructor_setSequenceBlend(tsshapeconstructor, name, blend, blendSeq, blendFrame);
}
/// <summary>
/// Mark a sequence as cyclic or non-cyclic.   @param name name of the sequence to modify   @param cyclic true to make the sequence cyclic, false for non-cyclic   @return true if successful, false otherwise   @tsexample   %this.setSequenceCyclic( \"ambient\", true );   %this.setSequenceCyclic( \"shoot\", false );   @endtsexample )
/// </summary>
public  bool setSequenceCyclic(string tsshapeconstructor, string name, bool cyclic){


return m_ts.fnTSShapeConstructor_setSequenceCyclic(tsshapeconstructor, name, cyclic);
}
/// <summary>
/// Set the translation and rotation ground speed of the sequence.   The ground speed of the sequence is set by generating ground transform    keyframes. The ground translational and rotational speed is assumed to    be constant for the duration of the sequence. Existing ground frames for    the sequence (if any) will be replaced.   @param name name of the sequence to modify   @param transSpeed translational speed (trans.x trans.y trans.z) in    Torque units per frame   @param rotSpeed (optional) rotational speed (rot.x rot.y rot.z) in    radians per frame. Default is \"0 0 0\"   @return true if successful, false otherwise   @tsexample   %this.setSequenceGroundSpeed( \"run\", \"5 0 0\" );   %this.setSequenceGroundSpeed( \"spin\", \"0 0 0\", \"4 0 0\" );   @endtsexample )
/// </summary>
public  bool setSequenceGroundSpeed(string tsshapeconstructor, string name, Point3F transSpeed, Point3F rotSpeed = null ){
if (rotSpeed== null) {rotSpeed = new Point3F(0.0f, 0.0f, 0.0f);}


return m_ts.fnTSShapeConstructor_setSequenceGroundSpeed(tsshapeconstructor, name, transSpeed.AsString(), rotSpeed.AsString());
}
/// <summary>
/// Set the sequence priority.   @param name name of the sequence to modify   @param priority new priority value   @return true if successful, false otherwise )
/// </summary>
public  bool setSequencePriority(string tsshapeconstructor, string name, float priority){


return m_ts.fnTSShapeConstructor_setSequencePriority(tsshapeconstructor, name, priority);
}
/// <summary>
/// Write the current change set to a TSShapeConstructor script file. The    name of the script file is the same as the model, but with .cs extension.    eg. myShape.cs for myShape.dts or myShape.dae. )
/// </summary>
public  void writeChangeSet(string tsshapeconstructor){


m_ts.fnTSShapeConstructor_writeChangeSet(tsshapeconstructor);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class TSStaticObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public TSStaticObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ,NULL,NULL),   @brief Change one of the materials on the shape.   This method changes materials per mapTo with others. The material that    is being replaced is mapped to unmapped_mat as a part of this transition.   @note Warning, right now this only sort of works. It doesn't do a live    update like it should.   @param mapTo the name of the material target to remap (from getTargetName)   @param oldMat the old Material that was mapped    @param newMat the new Material to map   @tsexample      // remap the first material in the shape      %mapTo = %obj.getTargetName( 0 );      %obj.changeMaterial( %mapTo, 0, MyMaterial );   @endtsexample )
/// </summary>
public  void changeMaterial(string tsstatic, string mapTo = "", string oldMat = null , string newMat = null ){
if (oldMat== null) {oldMat = null;}
if (newMat== null) {newMat = null;}


m_ts.fnTSStatic_changeMaterial(tsstatic, mapTo, oldMat, newMat);
}
/// <summary>
/// @brief Get the model filename used by this shape.   @return the shape filename   @tsexample		// Acquire the model filename used on this shape.		%modelFilename = %obj.getModelFile();   @endtsexample   )
/// </summary>
public  string getModelFile(string tsstatic){


return m_ts.fnTSStatic_getModelFile(tsstatic);
}
/// <summary>
/// Get the number of materials in the shape.   @return the number of materials in the shape.   @see getTargetName())
/// </summary>
public  int getTargetCount(string tsstatic){


return m_ts.fnTSStatic_getTargetCount(tsstatic);
}
/// <summary>
/// Get the name of the indexed shape material.   @param index index of the material to get (valid range is 0 - getTargetCount()-1).   @return the name of the indexed material.   @see getTargetCount())
/// </summary>
public  string getTargetName(string tsstatic, int index = 0){


return m_ts.fnTSStatic_getTargetName(tsstatic, index);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class TurretShapeObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public TurretShapeObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Does the turret respawn after it has been destroyed.   @returns True if the turret respawns.)
/// </summary>
public  bool doRespawn(string turretshape){


return m_ts.fnTurretShape_doRespawn(turretshape);
}
/// <summary>
/// @brief Get if the turret is allowed to fire through moves.   @return True if the turret is allowed to fire through moves. )
/// </summary>
public  bool getAllowManualFire(string turretshape){


return m_ts.fnTurretShape_getAllowManualFire(turretshape);
}
/// <summary>
/// @brief Get if the turret is allowed to rotate through moves.   @return True if the turret is allowed to rotate through moves. )
/// </summary>
public  bool getAllowManualRotation(string turretshape){


return m_ts.fnTurretShape_getAllowManualRotation(turretshape);
}
/// <summary>
/// @brief Get the name of the turret's current state.   The state is one of the following:ul>   li>Dead - The TurretShape is destroyed./li>   li>Mounted - The TurretShape is mounted to an object such as a vehicle./li>   li>Ready - The TurretShape is free to move.  The usual state./li>/ul>   @return The current state; one of: \"Dead\", \"Mounted\", \"Ready\" )
/// </summary>
public  string getState(string turretshape){


return m_ts.fnTurretShape_getState(turretshape);
}
/// <summary>
/// @brief Get Euler rotation of this turret's heading and pitch nodes.   @return the orientation of the turret's heading and pitch nodes in the    form of rotations around the X, Y and Z axes in degrees. )
/// </summary>
public  Point3F getTurretEulerRotation(string turretshape){


return new Point3F ( m_ts.fnTurretShape_getTurretEulerRotation(turretshape));
}
/// <summary>
/// @brief Set if the turret is allowed to fire through moves.   @param allow If true then the turret may be fired through moves.)
/// </summary>
public  void setAllowManualFire(string turretshape, bool allow){


m_ts.fnTurretShape_setAllowManualFire(turretshape, allow);
}
/// <summary>
/// @brief Set if the turret is allowed to rotate through moves.   @param allow If true then the turret may be rotated through moves.)
/// </summary>
public  void setAllowManualRotation(string turretshape, bool allow){


m_ts.fnTurretShape_setAllowManualRotation(turretshape, allow);
}
/// <summary>
/// @brief Set Euler rotation of this turret's heading and pitch nodes in degrees.   @param rot The rotation in degrees.  The pitch is the X component and the    heading is the Z component.  The Y component is ignored.)
/// </summary>
public  void setTurretEulerRotation(string turretshape, Point3F rot){


m_ts.fnTurretShape_setTurretEulerRotation(turretshape, rot.AsString());
}
}
   /// <summary>
        /// 
        /// </summary>
 public class UndoActionObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public UndoActionObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ), action.addToManager([undoManager]))
/// </summary>
public  void UndoAction_addToManager(string undoaction, string undoManager = ""){


m_ts.fn_UndoAction_addToManager(undoaction, undoManager);
}
/// <summary>
/// () - Reo action contained in undo. )
/// </summary>
public  void UndoAction_redo(string undoaction){


m_ts.fn_UndoAction_redo(undoaction);
}
/// <summary>
/// () - Undo action contained in undo. )
/// </summary>
public  void UndoAction_undo(string undoaction){


m_ts.fn_UndoAction_undo(undoaction);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class UndoManagerObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public UndoManagerObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Clears the undo manager.)
/// </summary>
public  void UndoManager_clearAll(string undomanager){


m_ts.fn_UndoManager_clearAll(undomanager);
}
/// <summary>
/// UndoManager.getNextRedoName();)
/// </summary>
public  string UndoManager_getNextRedoName(string undomanager){


return m_ts.fn_UndoManager_getNextRedoName(undomanager);
}
/// <summary>
/// UndoManager.getNextUndoName();)
/// </summary>
public  string UndoManager_getNextUndoName(string undomanager){


return m_ts.fn_UndoManager_getNextUndoName(undomanager);
}
/// <summary>
/// (index))
/// </summary>
public  int UndoManager_getRedoAction(string undomanager, int index){


return m_ts.fn_UndoManager_getRedoAction(undomanager, index);
}
/// <summary>
/// )
/// </summary>
public  int UndoManager_getRedoCount(string undomanager){


return m_ts.fn_UndoManager_getRedoCount(undomanager);
}
/// <summary>
/// (index))
/// </summary>
public  string UndoManager_getRedoName(string undomanager, int index){


return m_ts.fn_UndoManager_getRedoName(undomanager, index);
}
/// <summary>
/// (index))
/// </summary>
public  int UndoManager_getUndoAction(string undomanager, int index){


return m_ts.fn_UndoManager_getUndoAction(undomanager, index);
}
/// <summary>
/// )
/// </summary>
public  int UndoManager_getUndoCount(string undomanager){


return m_ts.fn_UndoManager_getUndoCount(undomanager);
}
/// <summary>
/// (index))
/// </summary>
public  string UndoManager_getUndoName(string undomanager, int index){


return m_ts.fn_UndoManager_getUndoName(undomanager, index);
}
/// <summary>
/// ( bool discard=false ) - Pop the current CompoundUndoAction off the stack. )
/// </summary>
public  void UndoManager_popCompound(string undomanager, bool discard = false){


m_ts.fn_UndoManager_popCompound(undomanager, discard);
}
/// <summary>
/// \"\"), ( string name=\"\" ) - Push a CompoundUndoAction onto the compound stack for assembly. )
/// </summary>
public  string UndoManager_pushCompound(string undomanager, string name = "\"\""){


return m_ts.fn_UndoManager_pushCompound(undomanager, name);
}
/// <summary>
/// UndoManager.redo();)
/// </summary>
public  void UndoManager_redo(string undomanager){


m_ts.fn_UndoManager_redo(undomanager);
}
/// <summary>
/// UndoManager.undo();)
/// </summary>
public  void UndoManager_undo(string undomanager){


m_ts.fn_UndoManager_undo(undomanager);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class VolumetricFogObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public VolumetricFogObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Changes the color of the fog.
/// 	@params new_color the new fog color (rgb 0-255, a is ignored.)
/// 
/// </summary>
public  void SetFogColor(string volumetricfog, ColorI new_color){


m_ts.fnVolumetricFog_SetFogColor(volumetricfog, new_color.AsString());
}
/// <summary>
/// @brief Changes the color of the fog.
/// 	@params new_color the new fog color (rgb 0.0 - 1.0, a is ignored.)
/// 
/// </summary>
public  void SetFogColorF(string volumetricfog, ColorF new_color){


m_ts.fnVolumetricFog_SetFogColorF(volumetricfog, new_color.AsString());
}
/// <summary>
/// @brief Changes the density of the fog.
/// 	@params new_density the new fog density.)
/// 
/// </summary>
public  void SetFogDensity(string volumetricfog, float new_density){


m_ts.fnVolumetricFog_SetFogDensity(volumetricfog, new_density);
}
/// <summary>
/// @brief Changes the modulation of the fog.
/// 	@params new_strenght the new strength of the modulation.
/// 	@params new_speed1 the new speed (x y) of the modulation layer 1.
/// 	@params new_speed2 the new speed (x y) of the modulation layer 2.)
/// 
/// </summary>
public  void SetFogModulation(string volumetricfog, float new_strenght, Point2F new_speed1, Point2F new_speed2){


m_ts.fnVolumetricFog_SetFogModulation(volumetricfog, new_strenght, new_speed1.AsString(), new_speed2.AsString());
}
}
   /// <summary>
        /// 
        /// </summary>
 public class WalkableShapeObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public WalkableShapeObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Attaches an object to this one.      @param obj The scene object to attach to us      @return true if successful, false if failed. This function will fail if the object passed       is invalid or is not located directly above and within RayLength of this shape.)
/// </summary>
public  bool attachObject(string walkableshape, string obj){


return m_ts.fnWalkableShape_attachObject(walkableshape, obj);
}
/// <summary>
/// Detaches all attached objects. Note: if UseAutoAttach is true when this is called, all of       the objects may be re-attached on the next tick.      @tsexample         // Dump all riders         %attachableObj.UseAutoAttach = false         %attachableObj.detachAll(); = false      @endtsexample)
/// </summary>
public  void detachAll(string walkableshape){


m_ts.fnWalkableShape_detachAll(walkableshape);
}
/// <summary>
/// Detaches an object from this one.      @param obj The scene object to be detached      @return true if successful, false if failed. This function will fail if the object passed       is invalid or is not currently attached to this shape.)
/// </summary>
public  bool detachObject(string walkableshape, string obj){


return m_ts.fnWalkableShape_detachObject(walkableshape, obj);
}
/// <summary>
/// Returns the attachment at the passed index value.)
/// </summary>
public  string getAttachment(string walkableshape, int index = 0){


return m_ts.fnWalkableShape_getAttachment(walkableshape, index);
}
/// <summary>
/// Returns the number of objects that are currently attached.)
/// </summary>
public  int getNumAttachments(string walkableshape){


return m_ts.fnWalkableShape_getNumAttachments(walkableshape);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class WheeledVehicleObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public WheeledVehicleObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Get the number of wheels on this vehicle.   @return the number of wheels (equal to the number of hub nodes defined in the model) )
/// </summary>
public  int getWheelCount(string wheeledvehicle){


return m_ts.fnWheeledVehicle_getWheelCount(wheeledvehicle);
}
/// <summary>
/// @brief Set whether the wheel is powered (has torque applied from the engine).   A rear wheel drive car for example would set the front wheels to false,    and the rear wheels to true.   @param wheel index of the wheel to set (hub node #)   @param powered flag indicating whether to power the wheel or not   @return true if successful, false if failed )
/// </summary>
public  bool setWheelPowered(string wheeledvehicle, int wheel, bool powered){


return m_ts.fnWheeledVehicle_setWheelPowered(wheeledvehicle, wheel, powered);
}
/// <summary>
/// @brief Set the WheeledVehicleSpring datablock for this wheel.   @param wheel index of the wheel to set (hub node #)   @param spring WheeledVehicleSpring datablock   @return true if successful, false if failed   @tsexample   %obj.setWheelSpring( 0, FrontSpring );   @endtsexample )
/// </summary>
public  bool setWheelSpring(string wheeledvehicle, int wheel, string spring){


return m_ts.fnWheeledVehicle_setWheelSpring(wheeledvehicle, wheel, spring);
}
/// <summary>
/// @brief Set how much the wheel is affected by steering.   The steering factor controls how much the wheel is rotated by the vehicle    steering. For example, most cars would have their front wheels set to 1.0,    and their rear wheels set to 0 since only the front wheels should turn.   Negative values will turn the wheel in the opposite direction to the steering    angle.   @param wheel index of the wheel to set (hub node #)   @param steering steering factor from -1 (full inverse) to 1 (full)   @return true if successful, false if failed )
/// </summary>
public  bool setWheelSteering(string wheeledvehicle, int wheel, float steering){


return m_ts.fnWheeledVehicle_setWheelSteering(wheeledvehicle, wheel, steering);
}
/// <summary>
/// @brief Set the WheeledVehicleTire datablock for this wheel.   @param wheel index of the wheel to set (hub node #)   @param tire WheeledVehicleTire datablock   @return true if successful, false if failed   @tsexample   %obj.setWheelTire( 0, FrontTire );   @endtsexample )
/// </summary>
public  bool setWheelTire(string wheeledvehicle, int wheel, string tire){


return m_ts.fnWheeledVehicle_setWheelTire(wheeledvehicle, wheel, tire);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class WorldEditorObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public WorldEditorObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// )
/// </summary>
public  void WorldEditor_addUndoState(string worldeditor){


m_ts.fn_WorldEditor_addUndoState(worldeditor);
}
/// <summary>
/// (int axis)              Align all selected objects along the given axis.)
/// </summary>
public  void WorldEditor_alignByAxis(string worldeditor, int boundsAxis){


m_ts.fn_WorldEditor_alignByAxis(worldeditor, boundsAxis);
}
/// <summary>
/// (int boundsAxis)              Align all selected objects against the given bounds axis.)
/// </summary>
public  void WorldEditor_alignByBounds(string worldeditor, int boundsAxis){


m_ts.fn_WorldEditor_alignByBounds(worldeditor, boundsAxis);
}
/// <summary>
/// )
/// </summary>
public  bool WorldEditor_canPasteSelection(string worldeditor){


return m_ts.fn_WorldEditor_canPasteSelection(worldeditor);
}
/// <summary>
/// )
/// </summary>
public  void WorldEditor_clearIgnoreList(string worldeditor){


m_ts.fn_WorldEditor_clearIgnoreList(worldeditor);
}
/// <summary>
/// )
/// </summary>
public  void WorldEditor_clearSelection(string worldeditor){


m_ts.fn_WorldEditor_clearSelection(worldeditor);
}
/// <summary>
/// ( String path ) - Export the combined geometry of all selected objects to the specified path in collada format. )
/// </summary>
public  void WorldEditor_colladaExportSelection(string worldeditor, string path){


m_ts.fn_WorldEditor_colladaExportSelection(worldeditor, path);
}
/// <summary>
/// )
/// </summary>
public  void WorldEditor_copySelection(string worldeditor){


m_ts.fn_WorldEditor_copySelection(worldeditor);
}
/// <summary>
/// )
/// </summary>
public  void WorldEditor_cutSelection(string worldeditor){


m_ts.fn_WorldEditor_cutSelection(worldeditor);
}
/// <summary>
/// ( bool skipUndo = false ))
/// </summary>
public  void WorldEditor_dropSelection(string worldeditor, bool skipUndo = false){


m_ts.fn_WorldEditor_dropSelection(worldeditor, skipUndo);
}
/// <summary>
/// () - Replace selected Prefab objects with a SimGroup containing all children objects defined in the .prefab. )
/// </summary>
public  void WorldEditor_explodeSelectedPrefab(string worldeditor){


m_ts.fn_WorldEditor_explodeSelectedPrefab(worldeditor);
}
/// <summary>
/// () - Return the currently active WorldEditorSelection object. )
/// </summary>
public  int WorldEditor_getActiveSelection(string worldeditor){


return m_ts.fn_WorldEditor_getActiveSelection(worldeditor);
}
/// <summary>
/// (int index))
/// </summary>
public  int WorldEditor_getSelectedObject(string worldeditor, int index){


return m_ts.fn_WorldEditor_getSelectedObject(worldeditor, index);
}
/// <summary>
/// )
/// </summary>
public  string WorldEditor_getSelectionCentroid(string worldeditor){


return m_ts.fn_WorldEditor_getSelectionCentroid(worldeditor);
}
/// <summary>
/// )
/// </summary>
public  Point3F WorldEditor_getSelectionExtent(string worldeditor){


return new Point3F ( m_ts.fn_WorldEditor_getSelectionExtent(worldeditor));
}
/// <summary>
/// )
/// </summary>
public  float WorldEditor_getSelectionRadius(string worldeditor){


return m_ts.fn_WorldEditor_getSelectionRadius(worldeditor);
}
/// <summary>
/// () - Return the number of objects currently selected in the editor.)
/// </summary>
public  int WorldEditor_getSelectionSize(string worldeditor){


return m_ts.fn_WorldEditor_getSelectionSize(worldeditor);
}
/// <summary>
/// getSoftSnap()              Is soft snapping always on?)
/// </summary>
public  bool WorldEditor_getSoftSnap(string worldeditor){


return m_ts.fn_WorldEditor_getSoftSnap(worldeditor);
}
/// <summary>
/// getSoftSnapBackfaceTolerance()              The fraction of the soft snap radius that backfaces may be included.)
/// </summary>
public  float WorldEditor_getSoftSnapBackfaceTolerance(string worldeditor){


return m_ts.fn_WorldEditor_getSoftSnapBackfaceTolerance(worldeditor);
}
/// <summary>
/// getSoftSnapSize()              Get the absolute size to trigger a soft snap.)
/// </summary>
public  float WorldEditor_getSoftSnapSize(string worldeditor){


return m_ts.fn_WorldEditor_getSoftSnapSize(worldeditor);
}
/// <summary>
/// (Object obj, bool hide))
/// </summary>
public  void WorldEditor_hideObject(string worldeditor, string obj, bool hide){


m_ts.fn_WorldEditor_hideObject(worldeditor, obj, hide);
}
/// <summary>
/// (bool hide))
/// </summary>
public  void WorldEditor_hideSelection(string worldeditor, bool hide){


m_ts.fn_WorldEditor_hideSelection(worldeditor, hide);
}
/// <summary>
/// )
/// </summary>
public  void WorldEditor_invalidateSelectionCentroid(string worldeditor){


m_ts.fn_WorldEditor_invalidateSelectionCentroid(worldeditor);
}
/// <summary>
/// (bool lock))
/// </summary>
public  void WorldEditor_lockSelection(string worldeditor, bool lockx){


m_ts.fn_WorldEditor_lockSelection(worldeditor, lockx);
}
/// <summary>
/// ( string filename ) - Save selected objects to a .prefab file and replace them in the level with a Prefab object. )
/// </summary>
public  void WorldEditor_makeSelectionPrefab(string worldeditor, string filename){


m_ts.fn_WorldEditor_makeSelectionPrefab(worldeditor, filename);
}
/// <summary>
/// ( Object A, Object B ) )
/// </summary>
public  void WorldEditor_mountRelative(string worldeditor, string objA, string objB){


m_ts.fn_WorldEditor_mountRelative(worldeditor, objA, objB);
}
/// <summary>
/// )
/// </summary>
public  void WorldEditor_pasteSelection(string worldeditor){


m_ts.fn_WorldEditor_pasteSelection(worldeditor);
}
/// <summary>
/// ( int objID ))
/// </summary>
public  void WorldEditor_redirectConsole(string worldeditor, int objID){


m_ts.fn_WorldEditor_redirectConsole(worldeditor, objID);
}
/// <summary>
/// )
/// </summary>
public  void WorldEditor_resetSelectedRotation(string worldeditor){


m_ts.fn_WorldEditor_resetSelectedRotation(worldeditor);
}
/// <summary>
/// )
/// </summary>
public  void WorldEditor_resetSelectedScale(string worldeditor){


m_ts.fn_WorldEditor_resetSelectedScale(worldeditor);
}
/// <summary>
/// (SimObject obj))
/// </summary>
public  void WorldEditor_selectObject(string worldeditor, string objName){


m_ts.fn_WorldEditor_selectObject(worldeditor, objName);
}
/// <summary>
/// ( id set ) - Set the currently active WorldEditorSelection object. )
/// </summary>
public  void WorldEditor_setActiveSelection(string worldeditor, string selection){


m_ts.fn_WorldEditor_setActiveSelection(worldeditor, selection);
}
/// <summary>
/// setSoftSnap(bool)              Allow soft snapping all of the time.)
/// </summary>
public  void WorldEditor_setSoftSnap(string worldeditor, bool enable){


m_ts.fn_WorldEditor_setSoftSnap(worldeditor, enable);
}
/// <summary>
/// setSoftSnapBackfaceTolerance(F32 with range of 0..1)              The fraction of the soft snap radius that backfaces may be included.)
/// </summary>
public  void WorldEditor_setSoftSnapBackfaceTolerance(string worldeditor, float range){


m_ts.fn_WorldEditor_setSoftSnapBackfaceTolerance(worldeditor, range);
}
/// <summary>
/// setSoftSnapSize(F32)              Set the absolute size to trigger a soft snap.)
/// </summary>
public  void WorldEditor_setSoftSnapSize(string worldeditor, float size){


m_ts.fn_WorldEditor_setSoftSnapSize(worldeditor, size);
}
/// <summary>
/// softSnapDebugRender(bool)              Toggle soft snapping debug rendering.)
/// </summary>
public  void WorldEditor_softSnapDebugRender(string worldeditor, bool enable){


m_ts.fn_WorldEditor_softSnapDebugRender(worldeditor, enable);
}
/// <summary>
/// softSnapRender(bool)              Render the soft snapping bounds.)
/// </summary>
public  void WorldEditor_softSnapRender(string worldeditor, bool enable){


m_ts.fn_WorldEditor_softSnapRender(worldeditor, enable);
}
/// <summary>
/// softSnapRenderTriangle(bool)              Render the soft snapped triangle.)
/// </summary>
public  void WorldEditor_softSnapRenderTriangle(string worldeditor, bool enable){


m_ts.fn_WorldEditor_softSnapRenderTriangle(worldeditor, enable);
}
/// <summary>
/// softSnapSizeByBounds(bool)              Use selection bounds size as soft snap bounds.)
/// </summary>
public  void WorldEditor_softSnapSizeByBounds(string worldeditor, bool enable){


m_ts.fn_WorldEditor_softSnapSizeByBounds(worldeditor, enable);
}
/// <summary>
/// transformSelection(...)              Transform selection by given parameters.)
/// </summary>
public  void WorldEditor_transformSelection(string worldeditor, bool position, Point3F point, bool relativePos, bool rotate, Point3F rotation, bool relativeRot, bool rotLocal, int scaleType, Point3F scale, bool sRelative, bool sLocal){


m_ts.fn_WorldEditor_transformSelection(worldeditor, position, point.AsString(), relativePos, rotate, rotation.AsString(), relativeRot, rotLocal, scaleType, scale.AsString(), sRelative, sLocal);
}
/// <summary>
/// (SimObject obj))
/// </summary>
public  void WorldEditor_unselectObject(string worldeditor, string objName){


m_ts.fn_WorldEditor_unselectObject(worldeditor, objName);
}
/// <summary>
/// Create a ConvexShape from the given polyhedral object. )
/// </summary>
public  string createConvexShapeFrom(string worldeditor, string polyObject){


return m_ts.fnWorldEditor_createConvexShapeFrom(worldeditor, polyObject);
}
/// <summary>
/// Grab the geometry from @a geometryProvider, create a @a className object, and assign it the extracted geometry. )
/// </summary>
public  string createPolyhedralObject(string worldeditor, string className, string geometryProvider){


return m_ts.fnWorldEditor_createPolyhedralObject(worldeditor, className, geometryProvider);
}
/// <summary>
/// Get the soft snap alignment. )
/// </summary>
public  TypeWorldEditorAlignmentType getSoftSnapAlignment(string worldeditor){


return (TypeWorldEditorAlignmentType)( m_ts.fnWorldEditor_getSoftSnapAlignment(worldeditor));
}
/// <summary>
/// Get the terrain snap alignment.  )
/// </summary>
public  TypeWorldEditorAlignmentType getTerrainSnapAlignment(string worldeditor){


return (TypeWorldEditorAlignmentType)( m_ts.fnWorldEditor_getTerrainSnapAlignment(worldeditor));
}
/// <summary>
/// ( WorldEditor, ignoreObjClass, void, 3, 0, (string class_name, ...))
/// </summary>
public  void ignoreObjClass(string worldeditor, string a2= "", string a3= "", string a4= "", string a5= "", string a6= "", string a7= "", string a8= "", string a9= "", string a10= "", string a11= "", string a12= "", string a13= "", string a14= "", string a15= "", string a16= "", string a17= "", string a18= "", string a19= ""){


m_ts.fnWorldEditor_ignoreObjClass(worldeditor, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
}
/// <summary>
/// Set the soft snap alignment. )
/// </summary>
public  void setSoftSnapAlignment(string worldeditor, TypeWorldEditorAlignmentType type){


m_ts.fnWorldEditor_setSoftSnapAlignment(worldeditor, (int)type );
}
/// <summary>
/// Set the terrain snap alignment. )
/// </summary>
public  void setTerrainSnapAlignment(string worldeditor, TypeWorldEditorAlignmentType alignment){


m_ts.fnWorldEditor_setTerrainSnapAlignment(worldeditor, (int)alignment );
}
}
   /// <summary>
        /// 
        /// </summary>
 public class WorldEditorSelectionObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public WorldEditorSelectionObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// ( WorldEditorSelection, containsGlobalBounds, bool, 2, 2, () - True if an object with global bounds is contained in the selection. )
/// </summary>
public  bool containsGlobalBounds(string worldeditorselection= ""){


return m_ts.fnWorldEditorSelection_containsGlobalBounds(worldeditorselection);
}
/// <summary>
/// ( WorldEditorSelection, getBoxCentroid, const char*, 2, 2, () - Return the center of the bounding box around the selection. )
/// </summary>
public  string getBoxCentroid(string worldeditorselection= ""){


return m_ts.fnWorldEditorSelection_getBoxCentroid(worldeditorselection);
}
/// <summary>
/// ( WorldEditorSelection, getCentroid, const char*, 2, 2, () - Return the median of all object positions in the selection. )
/// </summary>
public  string getCentroid(string worldeditorselection= ""){


return m_ts.fnWorldEditorSelection_getCentroid(worldeditorselection);
}
/// <summary>
/// ( WorldEditorSelection, offset, void, 3, 4, ( vector delta, float gridSnap=0 ) - Move all objects in the selection by the given delta. )
/// </summary>
public  void offset(string worldeditorselection, string a2= "", string a3= ""){


m_ts.fnWorldEditorSelection_offset(worldeditorselection, a2, a3);
}
/// <summary>
/// ( WorldEditorSelection, subtract, void, 3, 3, ( SimSet ) - Remove all objects in the given set from this selection. )
/// </summary>
public  void subtract(string worldeditorselection, string a2= ""){


m_ts.fnWorldEditorSelection_subtract(worldeditorselection, a2);
}
/// <summary>
/// ( WorldEditorSelection, union, void, 3, 3, ( SimSet set ) - Add all objects in the given set to this selection. )
/// </summary>
public  void union(string worldeditorselection, string a2= ""){


m_ts.fnWorldEditorSelection_union(worldeditorselection, a2);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ZipObjectObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ZipObjectObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// @brief Add a file to the zip archive      @param filename The path and name of the file to add to the zip archive.   @param pathInZip The path and name to be given to the file within the zip archive.   @param replace If a file already exists within the zip archive at the same location as this    new file, this parameter indicates if it should be replaced.  By default, it will be replaced.   @return True if the file was successfully added to the zip archive.)
/// </summary>
public  bool addFile(string zipobject, string filename, string pathInZip, bool replace = true){


return m_ts.fnZipObject_addFile(zipobject, filename, pathInZip, replace);
}
/// <summary>
/// @brief Close an already opened zip archive.   @see openArchive())
/// </summary>
public  void closeArchive(string zipobject){


m_ts.fnZipObject_closeArchive(zipobject);
}
/// <summary>
/// @brief Close a previously opened file within the zip archive.   @param stream The StreamObject of a previously opened file within the zip archive.   @see openFileForRead()   @see openFileForWrite())
/// </summary>
public  void closeFile(string zipobject, string stream){


m_ts.fnZipObject_closeFile(zipobject, stream);
}
/// <summary>
/// @brief Deleted the given file from the zip archive   @param pathInZip The path and name of the file to be deleted from the zip archive.   @return True of the file was successfully deleted.   @note Files that have been deleted from the archive will still show up with a    getFileEntryCount() until you close the archive.  If you need to have the file    count up to date with only valid files within the archive, you could close and then    open the archive again.   @see getFileEntryCount()   @see closeArchive()   @see openArchive())
/// </summary>
public  bool deleteFile(string zipobject, string pathInZip){


return m_ts.fnZipObject_deleteFile(zipobject, pathInZip);
}
/// <summary>
/// @brief Extact a file from the zip archive and save it to the requested location.   @param pathInZip The path and name of the file to be extracted within the zip archive.   @param filename The path and name to give the extracted file.   @return True if the file was successfully extracted.)
/// </summary>
public  bool extractFile(string zipobject, string pathInZip, string filename){


return m_ts.fnZipObject_extractFile(zipobject, pathInZip, filename);
}
/// <summary>
/// @brief Get information on the requested file within the zip archive.   This methods provides five different pieces of information for the requested file:   ul>li>filename - The path and name of the file within the zip archive/li>   li>uncompressed size/li>   li>compressed size/li>   li>compression method/li>   li>CRC32/li>/ul>   Use getFileEntryCount() to obtain the total number of files within the archive.   @param index The index of the file within the zip archive.  Use getFileEntryCount() to determine the number of files.   @return A tab delimited list of information on the requested file, or an empty string if the file could not be found.   @see getFileEntryCount())
/// </summary>
public  string getFileEntry(string zipobject, int index){


return m_ts.fnZipObject_getFileEntry(zipobject, index);
}
/// <summary>
/// @brief Get the number of files within the zip archive.   Use getFileEntry() to retrive information on each file within the archive.   @return The number of files within the zip archive.   @note The returned count will include any files that have been deleted from    the archive using deleteFile().  To clear out all deleted files, you could    close and then open the archive again.   @see getFileEntry()   @see closeArchive()   @see openArchive())
/// </summary>
public  int getFileEntryCount(string zipobject){


return m_ts.fnZipObject_getFileEntryCount(zipobject);
}
/// <summary>
/// read ),   @brief Open a zip archive for manipulation.   Once a zip archive is opened use the various ZipObject methods for    working with the files within the archive.  Be sure to close the archive when    you are done with it.   @param filename The path and file name of the zip archive to open.   @param accessMode One of read, write or readwrite   @return True is the archive was successfully opened.      @note If you wish to make any changes to the archive, be sure to open it    with a write or readwrite access mode.   @see closeArchive())
/// </summary>
public  bool openArchive(string zipobject, string filename, string accessMode = "read"){


return m_ts.fnZipObject_openArchive(zipobject, filename, accessMode);
}
/// <summary>
/// @brief Open a file within the zip archive for reading.   Be sure to close the file when you are done with it.   @param filename The path and name of the file to open within the zip archive.   @return A standard StreamObject is returned for working with the file.   @note You must first open the zip archive before working with files within it.   @see closeFile()   @see openArchive())
/// </summary>
public  string openFileForRead(string zipobject, string filename){


return m_ts.fnZipObject_openFileForRead(zipobject, filename);
}
/// <summary>
/// @brief Open a file within the zip archive for writing to.      Be sure to close the file when you are done with it.   @param filename The path and name of the file to open within the zip archive.   @return A standard StreamObject is returned for working with the file.   @note You must first open the zip archive before working with files within it.   @see closeFile()   @see openArchive())
/// </summary>
public  string openFileForWrite(string zipobject, string filename){


return m_ts.fnZipObject_openFileForWrite(zipobject, filename);
}
}
   /// <summary>
        /// 
        /// </summary>
 public class ZoneObject
{
private Omni m_ts;
     /// <summary>
     /// 
     /// </summary>
     /// <param name="ts"></param> 
public ZoneObject(ref Omni ts){m_ts = ts;}
/// <summary>
/// Dump a list of all objects assigned to the zone to the console as well as a list    of all connected zone spaces.   @param updateFirst Whether to update the contents of the zone before dumping.  Since zoning states of       objects are updated on demand, the zone contents can be outdated. )
/// </summary>
public  void dumpZoneState(string zone, bool updateFirst = true){


m_ts.fnZone_dumpZoneState(zone, updateFirst);
}
/// <summary>
/// Get the unique numeric ID of the zone in its scene.   @return The ID of the zone. )
/// </summary>
public  int getZoneId(string zone){


return m_ts.fnZone_getZoneId(zone);
}
}

        }
    }