namespace Paschoalotto.PagouFacil.InterfaceSistema1.C305.Model.Remote.SorocredRemote
{

    // OBSERVAÇÃO: o código gerado pode exigir pelo menos .NET Framework 4.5 ou .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class BoletoModel
    {

        private byte rETORNOField;

        private string rETORNOTEXTOField;

        private byte cODCREDORField;

        private ulong dESREGISField;

        private byte vALORDESCONTOField;

        private byte vALORJUROSField;

        private byte vALORMULTAField;

        private string vALORPRINCIPALField;

        private string vALORPAGOField;

        private byte vALORTXADMField;

        private byte vALORRECEITAField;

        private string vALORREPASSEField;

        private byte cETField;

        private BoletoModelDADOBOLETO dADOBOLETOField;

        private BoletoModelPRESTACOES pRESTACOESField;

        private BoletoModelPRESTACOESNEGOCIADAS pRESTACOESNEGOCIADASField;

        /// <remarks/>
        public byte RETORNO
        {
            get
            {
                return this.rETORNOField;
            }
            set
            {
                this.rETORNOField = value;
            }
        }

        /// <remarks/>
        public string RETORNOTEXTO
        {
            get
            {
                return this.rETORNOTEXTOField;
            }
            set
            {
                this.rETORNOTEXTOField = value;
            }
        }

        /// <remarks/>
        public byte CODCREDOR
        {
            get
            {
                return this.cODCREDORField;
            }
            set
            {
                this.cODCREDORField = value;
            }
        }

        /// <remarks/>
        public ulong DESREGIS
        {
            get
            {
                return this.dESREGISField;
            }
            set
            {
                this.dESREGISField = value;
            }
        }

        /// <remarks/>
        public byte VALORDESCONTO
        {
            get
            {
                return this.vALORDESCONTOField;
            }
            set
            {
                this.vALORDESCONTOField = value;
            }
        }

        /// <remarks/>
        public byte VALORJUROS
        {
            get
            {
                return this.vALORJUROSField;
            }
            set
            {
                this.vALORJUROSField = value;
            }
        }

        /// <remarks/>
        public byte VALORMULTA
        {
            get
            {
                return this.vALORMULTAField;
            }
            set
            {
                this.vALORMULTAField = value;
            }
        }

        /// <remarks/>
        public string VALORPRINCIPAL
        {
            get
            {
                return this.vALORPRINCIPALField;
            }
            set
            {
                this.vALORPRINCIPALField = value;
            }
        }

        /// <remarks/>
        public string VALORPAGO
        {
            get
            {
                return this.vALORPAGOField;
            }
            set
            {
                this.vALORPAGOField = value;
            }
        }

        /// <remarks/>
        public byte VALORTXADM
        {
            get
            {
                return this.vALORTXADMField;
            }
            set
            {
                this.vALORTXADMField = value;
            }
        }

        /// <remarks/>
        public byte VALORRECEITA
        {
            get
            {
                return this.vALORRECEITAField;
            }
            set
            {
                this.vALORRECEITAField = value;
            }
        }

        /// <remarks/>
        public string VALORREPASSE
        {
            get
            {
                return this.vALORREPASSEField;
            }
            set
            {
                this.vALORREPASSEField = value;
            }
        }

        /// <remarks/>
        public byte CET
        {
            get
            {
                return this.cETField;
            }
            set
            {
                this.cETField = value;
            }
        }

        /// <remarks/>
        public BoletoModelDADOBOLETO DADOBOLETO
        {
            get
            {
                return this.dADOBOLETOField;
            }
            set
            {
                this.dADOBOLETOField = value;
            }
        }

        /// <remarks/>
        public BoletoModelPRESTACOES PRESTACOES
        {
            get
            {
                return this.pRESTACOESField;
            }
            set
            {
                this.pRESTACOESField = value;
            }
        }

        /// <remarks/>
        public BoletoModelPRESTACOESNEGOCIADAS PRESTACOESNEGOCIADAS
        {
            get
            {
                return this.pRESTACOESNEGOCIADASField;
            }
            set
            {
                this.pRESTACOESNEGOCIADASField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BoletoModelDADOBOLETO
    {

        private byte cODBANCOField;

        private ushort dESAGENCField;

        private ushort dESCONTAField;

        private byte dESBANCODVField;

        private byte dESAGENCDVField;

        private byte dESCONTADVField;

        private string dESESPECDOCField;

        private string iNDACEITField;

        private string dESCARTEBANCOField;

        private string dESESPECField;

        private string dESLOCAL1Field;

        private object dESLOCAL2Field;

        private string dESCEDENField;

        private string dESINSTR1Field;

        private string dESINSTR2Field;

        private object dESINSTR3Field;

        private object dESINSTR4Field;

        private object dESINSTR5Field;

        private object dESINSTR6Field;

        private object dESINSTR7Field;

        private object dESINSTR8Field;

        private object dESINSTR9Field;

        private string nOMBANCOField;

        private string vALBOLETField;

        private System.DateTime dATVENCIField;

        private string vALPAGOField;

        private string vALDESCOField;

        private ulong dESCPFField;

        private string nOMCLIENField;

        private string dESENDERField;

        private ushort dESNUMERField;

        private object dESCOMPLField;

        private string dESBAIRRField;

        private string dESCIDADField;

        private string dESESTADField;

        private uint dESCEPField;

        private uint dESCODCEDENField;

        private string nOSSONUMEROField;

        private string lINHADIGITAVELField;

        private string cODIGOBARRAField;

        private string aGENCIACONTAField;

        private string iNSTRUCAOField;

        private object dESUSOBANCOField;

        private string cONTRATOSField;

        private uint dESNUMDOCField;

        private string dESFONEBOLETField;

        private object cOMPOSICAO1Field;

        private object cOMPOSICAO2Field;

        private byte vALTXADMField;

        private string vALORTOTALField;

        /// <remarks/>
        public byte CODBANCO
        {
            get
            {
                return this.cODBANCOField;
            }
            set
            {
                this.cODBANCOField = value;
            }
        }

        /// <remarks/>
        public ushort DESAGENC
        {
            get
            {
                return this.dESAGENCField;
            }
            set
            {
                this.dESAGENCField = value;
            }
        }

        /// <remarks/>
        public ushort DESCONTA
        {
            get
            {
                return this.dESCONTAField;
            }
            set
            {
                this.dESCONTAField = value;
            }
        }

        /// <remarks/>
        public byte DESBANCODV
        {
            get
            {
                return this.dESBANCODVField;
            }
            set
            {
                this.dESBANCODVField = value;
            }
        }

        /// <remarks/>
        public byte DESAGENCDV
        {
            get
            {
                return this.dESAGENCDVField;
            }
            set
            {
                this.dESAGENCDVField = value;
            }
        }

        /// <remarks/>
        public byte DESCONTADV
        {
            get
            {
                return this.dESCONTADVField;
            }
            set
            {
                this.dESCONTADVField = value;
            }
        }

        /// <remarks/>
        public string DESESPECDOC
        {
            get
            {
                return this.dESESPECDOCField;
            }
            set
            {
                this.dESESPECDOCField = value;
            }
        }

        /// <remarks/>
        public string INDACEIT
        {
            get
            {
                return this.iNDACEITField;
            }
            set
            {
                this.iNDACEITField = value;
            }
        }

        /// <remarks/>
        public string DESCARTEBANCO
        {
            get
            {
                return this.dESCARTEBANCOField;
            }
            set
            {
                this.dESCARTEBANCOField = value;
            }
        }

        /// <remarks/>
        public string DESESPEC
        {
            get
            {
                return this.dESESPECField;
            }
            set
            {
                this.dESESPECField = value;
            }
        }

        /// <remarks/>
        public string DESLOCAL1
        {
            get
            {
                return this.dESLOCAL1Field;
            }
            set
            {
                this.dESLOCAL1Field = value;
            }
        }

        /// <remarks/>
        public object DESLOCAL2
        {
            get
            {
                return this.dESLOCAL2Field;
            }
            set
            {
                this.dESLOCAL2Field = value;
            }
        }

        /// <remarks/>
        public string DESCEDEN
        {
            get
            {
                return this.dESCEDENField;
            }
            set
            {
                this.dESCEDENField = value;
            }
        }

        /// <remarks/>
        public string DESINSTR1
        {
            get
            {
                return this.dESINSTR1Field;
            }
            set
            {
                this.dESINSTR1Field = value;
            }
        }

        /// <remarks/>
        public string DESINSTR2
        {
            get
            {
                return this.dESINSTR2Field;
            }
            set
            {
                this.dESINSTR2Field = value;
            }
        }

        /// <remarks/>
        public object DESINSTR3
        {
            get
            {
                return this.dESINSTR3Field;
            }
            set
            {
                this.dESINSTR3Field = value;
            }
        }

        /// <remarks/>
        public object DESINSTR4
        {
            get
            {
                return this.dESINSTR4Field;
            }
            set
            {
                this.dESINSTR4Field = value;
            }
        }

        /// <remarks/>
        public object DESINSTR5
        {
            get
            {
                return this.dESINSTR5Field;
            }
            set
            {
                this.dESINSTR5Field = value;
            }
        }

        /// <remarks/>
        public object DESINSTR6
        {
            get
            {
                return this.dESINSTR6Field;
            }
            set
            {
                this.dESINSTR6Field = value;
            }
        }

        /// <remarks/>
        public object DESINSTR7
        {
            get
            {
                return this.dESINSTR7Field;
            }
            set
            {
                this.dESINSTR7Field = value;
            }
        }

        /// <remarks/>
        public object DESINSTR8
        {
            get
            {
                return this.dESINSTR8Field;
            }
            set
            {
                this.dESINSTR8Field = value;
            }
        }

        /// <remarks/>
        public object DESINSTR9
        {
            get
            {
                return this.dESINSTR9Field;
            }
            set
            {
                this.dESINSTR9Field = value;
            }
        }

        /// <remarks/>
        public string NOMBANCO
        {
            get
            {
                return this.nOMBANCOField;
            }
            set
            {
                this.nOMBANCOField = value;
            }
        }

        /// <remarks/>
        public string VALBOLET
        {
            get
            {
                return this.vALBOLETField;
            }
            set
            {
                this.vALBOLETField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DATVENCI
        {
            get
            {
                return this.dATVENCIField;
            }
            set
            {
                this.dATVENCIField = value;
            }
        }

        /// <remarks/>
        public string VALPAGO
        {
            get
            {
                return this.vALPAGOField;
            }
            set
            {
                this.vALPAGOField = value;
            }
        }

        /// <remarks/>
        public string VALDESCO
        {
            get
            {
                return this.vALDESCOField;
            }
            set
            {
                this.vALDESCOField = value;
            }
        }

        /// <remarks/>
        public ulong DESCPF
        {
            get
            {
                return this.dESCPFField;
            }
            set
            {
                this.dESCPFField = value;
            }
        }

        /// <remarks/>
        public string NOMCLIEN
        {
            get
            {
                return this.nOMCLIENField;
            }
            set
            {
                this.nOMCLIENField = value;
            }
        }

        /// <remarks/>
        public string DESENDER
        {
            get
            {
                return this.dESENDERField;
            }
            set
            {
                this.dESENDERField = value;
            }
        }

        /// <remarks/>
        public ushort DESNUMER
        {
            get
            {
                return this.dESNUMERField;
            }
            set
            {
                this.dESNUMERField = value;
            }
        }

        /// <remarks/>
        public object DESCOMPL
        {
            get
            {
                return this.dESCOMPLField;
            }
            set
            {
                this.dESCOMPLField = value;
            }
        }

        /// <remarks/>
        public string DESBAIRR
        {
            get
            {
                return this.dESBAIRRField;
            }
            set
            {
                this.dESBAIRRField = value;
            }
        }

        /// <remarks/>
        public string DESCIDAD
        {
            get
            {
                return this.dESCIDADField;
            }
            set
            {
                this.dESCIDADField = value;
            }
        }

        /// <remarks/>
        public string DESESTAD
        {
            get
            {
                return this.dESESTADField;
            }
            set
            {
                this.dESESTADField = value;
            }
        }

        /// <remarks/>
        public uint DESCEP
        {
            get
            {
                return this.dESCEPField;
            }
            set
            {
                this.dESCEPField = value;
            }
        }

        /// <remarks/>
        public uint DESCODCEDEN
        {
            get
            {
                return this.dESCODCEDENField;
            }
            set
            {
                this.dESCODCEDENField = value;
            }
        }

        /// <remarks/>
        public string NOSSONUMERO
        {
            get
            {
                return this.nOSSONUMEROField;
            }
            set
            {
                this.nOSSONUMEROField = value;
            }
        }

        /// <remarks/>
        public string LINHADIGITAVEL
        {
            get
            {
                return this.lINHADIGITAVELField;
            }
            set
            {
                this.lINHADIGITAVELField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string CODIGOBARRA
        {
            get
            {
                return this.cODIGOBARRAField;
            }
            set
            {
                this.cODIGOBARRAField = value;
            }
        }

        /// <remarks/>
        public string AGENCIACONTA
        {
            get
            {
                return this.aGENCIACONTAField;
            }
            set
            {
                this.aGENCIACONTAField = value;
            }
        }

        /// <remarks/>
        public string INSTRUCAO
        {
            get
            {
                return this.iNSTRUCAOField;
            }
            set
            {
                this.iNSTRUCAOField = value;
            }
        }

        /// <remarks/>
        public object DESUSOBANCO
        {
            get
            {
                return this.dESUSOBANCOField;
            }
            set
            {
                this.dESUSOBANCOField = value;
            }
        }

        /// <remarks/>
        public string CONTRATOS
        {
            get
            {
                return this.cONTRATOSField;
            }
            set
            {
                this.cONTRATOSField = value;
            }
        }

        /// <remarks/>
        public uint DESNUMDOC
        {
            get
            {
                return this.dESNUMDOCField;
            }
            set
            {
                this.dESNUMDOCField = value;
            }
        }

        /// <remarks/>
        public string DESFONEBOLET
        {
            get
            {
                return this.dESFONEBOLETField;
            }
            set
            {
                this.dESFONEBOLETField = value;
            }
        }

        /// <remarks/>
        public object COMPOSICAO1
        {
            get
            {
                return this.cOMPOSICAO1Field;
            }
            set
            {
                this.cOMPOSICAO1Field = value;
            }
        }

        /// <remarks/>
        public object COMPOSICAO2
        {
            get
            {
                return this.cOMPOSICAO2Field;
            }
            set
            {
                this.cOMPOSICAO2Field = value;
            }
        }

        /// <remarks/>
        public byte VALTXADM
        {
            get
            {
                return this.vALTXADMField;
            }
            set
            {
                this.vALTXADMField = value;
            }
        }

        /// <remarks/>
        public string VALORTOTAL
        {
            get
            {
                return this.vALORTOTALField;
            }
            set
            {
                this.vALORTOTALField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BoletoModelPRESTACOES
    {

        private BoletoModelPRESTACOESPREST pRESTField;

        /// <remarks/>
        public BoletoModelPRESTACOESPREST PREST
        {
            get
            {
                return this.pRESTField;
            }
            set
            {
                this.pRESTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BoletoModelPRESTACOESPREST
    {

        private string cODPRODUTField;

        private uint dESCONTRField;

        private System.DateTime dATVENCIField;

        private string tXADMField;

        private string jUROSField;

        private string mULTAField;

        private string rECEITAField;

        private string rEPASSEField;

        private string vALPAGOField;

        private uint iDPRESTACAOField;

        /// <remarks/>
        public string CODPRODUT
        {
            get
            {
                return this.cODPRODUTField;
            }
            set
            {
                this.cODPRODUTField = value;
            }
        }

        /// <remarks/>
        public uint DESCONTR
        {
            get
            {
                return this.dESCONTRField;
            }
            set
            {
                this.dESCONTRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DATVENCI
        {
            get
            {
                return this.dATVENCIField;
            }
            set
            {
                this.dATVENCIField = value;
            }
        }

        /// <remarks/>
        public string TXADM
        {
            get
            {
                return this.tXADMField;
            }
            set
            {
                this.tXADMField = value;
            }
        }

        /// <remarks/>
        public string JUROS
        {
            get
            {
                return this.jUROSField;
            }
            set
            {
                this.jUROSField = value;
            }
        }

        /// <remarks/>
        public string MULTA
        {
            get
            {
                return this.mULTAField;
            }
            set
            {
                this.mULTAField = value;
            }
        }

        /// <remarks/>
        public string RECEITA
        {
            get
            {
                return this.rECEITAField;
            }
            set
            {
                this.rECEITAField = value;
            }
        }

        /// <remarks/>
        public string REPASSE
        {
            get
            {
                return this.rEPASSEField;
            }
            set
            {
                this.rEPASSEField = value;
            }
        }

        /// <remarks/>
        public string VALPAGO
        {
            get
            {
                return this.vALPAGOField;
            }
            set
            {
                this.vALPAGOField = value;
            }
        }

        /// <remarks/>
        public uint IDPRESTACAO
        {
            get
            {
                return this.iDPRESTACAOField;
            }
            set
            {
                this.iDPRESTACAOField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BoletoModelPRESTACOESNEGOCIADAS
    {

        private BoletoModelPRESTACOESNEGOCIADASPRESTNEGOC pRESTNEGOCField;

        /// <remarks/>
        public BoletoModelPRESTACOESNEGOCIADASPRESTNEGOC PRESTNEGOC
        {
            get
            {
                return this.pRESTNEGOCField;
            }
            set
            {
                this.pRESTNEGOCField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BoletoModelPRESTACOESNEGOCIADASPRESTNEGOC
    {

        private byte cODPRODUTNEGOCField;

        private string dESCONTRNEGOCField;

        private string dATVENCINEGOCField;

        private string pRINCIPALNEGOCField;

        private string jUROSNEGOCField;

        private string mULTANEGOCField;

        private string rECEITANEGOCField;

        private string rEPASSENEGOCField;

        private string dESCONTONEGOCField;

        private string vALPAGONEGOCField;

        private uint iDPRESTACAONEGOCField;

        /// <remarks/>
        public byte CODPRODUTNEGOC
        {
            get
            {
                return this.cODPRODUTNEGOCField;
            }
            set
            {
                this.cODPRODUTNEGOCField = value;
            }
        }

        /// <remarks/>
        public string DESCONTRNEGOC
        {
            get
            {
                return this.dESCONTRNEGOCField;
            }
            set
            {
                this.dESCONTRNEGOCField = value;
            }
        }

        /// <remarks/>
        public string DATVENCINEGOC
        {
            get
            {
                return this.dATVENCINEGOCField;
            }
            set
            {
                this.dATVENCINEGOCField = value;
            }
        }

        /// <remarks/>
        public string PRINCIPALNEGOC
        {
            get
            {
                return this.pRINCIPALNEGOCField;
            }
            set
            {
                this.pRINCIPALNEGOCField = value;
            }
        }

        /// <remarks/>
        public string JUROSNEGOC
        {
            get
            {
                return this.jUROSNEGOCField;
            }
            set
            {
                this.jUROSNEGOCField = value;
            }
        }

        /// <remarks/>
        public string MULTANEGOC
        {
            get
            {
                return this.mULTANEGOCField;
            }
            set
            {
                this.mULTANEGOCField = value;
            }
        }

        /// <remarks/>
        public string RECEITANEGOC
        {
            get
            {
                return this.rECEITANEGOCField;
            }
            set
            {
                this.rECEITANEGOCField = value;
            }
        }

        /// <remarks/>
        public string REPASSENEGOC
        {
            get
            {
                return this.rEPASSENEGOCField;
            }
            set
            {
                this.rEPASSENEGOCField = value;
            }
        }

        /// <remarks/>
        public string DESCONTONEGOC
        {
            get
            {
                return this.dESCONTONEGOCField;
            }
            set
            {
                this.dESCONTONEGOCField = value;
            }
        }

        /// <remarks/>
        public string VALPAGONEGOC
        {
            get
            {
                return this.vALPAGONEGOCField;
            }
            set
            {
                this.vALPAGONEGOCField = value;
            }
        }

        /// <remarks/>
        public uint IDPRESTACAONEGOC
        {
            get
            {
                return this.iDPRESTACAONEGOCField;
            }
            set
            {
                this.iDPRESTACAONEGOCField = value;
            }
        }
    }


}

