using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43126 - .
/// </summary>
public class F43126 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P4MATC.
        /// </summary>
        public const string P4MATC = "P4MATC";

        /// <summary>
        /// P4KCOO.
        /// </summary>
        public const string P4KCOO = "P4KCOO";

        /// <summary>
        /// P4DOCO.
        /// </summary>
        public const string P4DOCO = "P4DOCO";

        /// <summary>
        /// P4DCTO.
        /// </summary>
        public const string P4DCTO = "P4DCTO";

        /// <summary>
        /// P4SFXO.
        /// </summary>
        public const string P4SFXO = "P4SFXO";

        /// <summary>
        /// P4LNID.
        /// </summary>
        public const string P4LNID = "P4LNID";

        /// <summary>
        /// P4NLIN.
        /// </summary>
        public const string P4NLIN = "P4NLIN";

        /// <summary>
        /// P4DLNID.
        /// </summary>
        public const string P4DLNID = "P4DLNID";

        /// <summary>
        /// P4AID.
        /// </summary>
        public const string P4AID = "P4AID";

        /// <summary>
        /// P4ANI.
        /// </summary>
        public const string P4ANI = "P4ANI";

        /// <summary>
        /// P4OMCU.
        /// </summary>
        public const string P4OMCU = "P4OMCU";

        /// <summary>
        /// P4OBJ.
        /// </summary>
        public const string P4OBJ = "P4OBJ";

        /// <summary>
        /// P4SUB.
        /// </summary>
        public const string P4SUB = "P4SUB";

        /// <summary>
        /// P4SBL.
        /// </summary>
        public const string P4SBL = "P4SBL";

        /// <summary>
        /// P4SBLT.
        /// </summary>
        public const string P4SBLT = "P4SBLT";

        /// <summary>
        /// P4MAST.
        /// </summary>
        public const string P4MAST = "P4MAST";

        /// <summary>
        /// P4MASP.
        /// </summary>
        public const string P4MASP = "P4MASP";

        /// <summary>
        /// P4MASA.
        /// </summary>
        public const string P4MASA = "P4MASA";

        /// <summary>
        /// P4MASU.
        /// </summary>
        public const string P4MASU = "P4MASU";

        /// <summary>
        /// P4MASF.
        /// </summary>
        public const string P4MASF = "P4MASF";

        /// <summary>
        /// P4UOVR.
        /// </summary>
        public const string P4UOVR = "P4UOVR";

        /// <summary>
        /// P4DOC.
        /// </summary>
        public const string P4DOC = "P4DOC";

        /// <summary>
        /// P4DCT.
        /// </summary>
        public const string P4DCT = "P4DCT";

        /// <summary>
        /// P4KCO.
        /// </summary>
        public const string P4KCO = "P4KCO";

        /// <summary>
        /// P4SFX.
        /// </summary>
        public const string P4SFX = "P4SFX";

        /// <summary>
        /// P4JELN.
        /// </summary>
        public const string P4JELN = "P4JELN";

        /// <summary>
        /// P4VANI.
        /// </summary>
        public const string P4VANI = "P4VANI";

        /// <summary>
        /// P4UORG.
        /// </summary>
        public const string P4UORG = "P4UORG";

        /// <summary>
        /// P4UPTD.
        /// </summary>
        public const string P4UPTD = "P4UPTD";

        /// <summary>
        /// P4UOPN.
        /// </summary>
        public const string P4UOPN = "P4UOPN";

        /// <summary>
        /// P4UREC.
        /// </summary>
        public const string P4UREC = "P4UREC";

        /// <summary>
        /// P4UCLO.
        /// </summary>
        public const string P4UCLO = "P4UCLO";

        /// <summary>
        /// P4ECST.
        /// </summary>
        public const string P4ECST = "P4ECST";

        /// <summary>
        /// P4APTD.
        /// </summary>
        public const string P4APTD = "P4APTD";

        /// <summary>
        /// P4AOPN.
        /// </summary>
        public const string P4AOPN = "P4AOPN";

        /// <summary>
        /// P4AREC.
        /// </summary>
        public const string P4AREC = "P4AREC";

        /// <summary>
        /// P4ACLO.
        /// </summary>
        public const string P4ACLO = "P4ACLO";

        /// <summary>
        /// P4CRCD.
        /// </summary>
        public const string P4CRCD = "P4CRCD";

        /// <summary>
        /// P4FEC.
        /// </summary>
        public const string P4FEC = "P4FEC";

        /// <summary>
        /// P4FAP.
        /// </summary>
        public const string P4FAP = "P4FAP";

        /// <summary>
        /// P4FAPT.
        /// </summary>
        public const string P4FAPT = "P4FAPT";

        /// <summary>
        /// P4FREC.
        /// </summary>
        public const string P4FREC = "P4FREC";

        /// <summary>
        /// P4FCLO.
        /// </summary>
        public const string P4FCLO = "P4FCLO";

        /// <summary>
        /// P4STAM.
        /// </summary>
        public const string P4STAM = "P4STAM";

        /// <summary>
        /// P4CTAM.
        /// </summary>
        public const string P4CTAM = "P4CTAM";

        /// <summary>
        /// P4URCD.
        /// </summary>
        public const string P4URCD = "P4URCD";

        /// <summary>
        /// P4URDT.
        /// </summary>
        public const string P4URDT = "P4URDT";

        /// <summary>
        /// P4URAT.
        /// </summary>
        public const string P4URAT = "P4URAT";

        /// <summary>
        /// P4URAB.
        /// </summary>
        public const string P4URAB = "P4URAB";

        /// <summary>
        /// P4URRF.
        /// </summary>
        public const string P4URRF = "P4URRF";

        /// <summary>
        /// P4USER.
        /// </summary>
        public const string P4USER = "P4USER";

        /// <summary>
        /// P4PID.
        /// </summary>
        public const string P4PID = "P4PID";

        /// <summary>
        /// P4JOBN.
        /// </summary>
        public const string P4JOBN = "P4JOBN";

        /// <summary>
        /// P4TERM.
        /// </summary>
        public const string P4TERM = "P4TERM";

        /// <summary>
        /// P4UPMJ.
        /// </summary>
        public const string P4UPMJ = "P4UPMJ";

        /// <summary>
        /// P4TDAY.
        /// </summary>
        public const string P4TDAY = "P4TDAY";

        /// <summary>
        /// P4SRQTY.
        /// </summary>
        public const string P4SRQTY = "P4SRQTY";

        /// <summary>
        /// P4JBCD.
        /// </summary>
        public const string P4JBCD = "P4JBCD";
    }

    /// <inheritdoc />
    public override string TableName => "F43126";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P4MATC", "P4MATC", JdeDataType.String, 2, true, true),
        new JdeField("P4KCOO", "P4KCOO", JdeDataType.String, 10, true, true),
        new JdeField("P4DOCO", "P4DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("P4DCTO", "P4DCTO", JdeDataType.String, 4, true, true),
        new JdeField("P4SFXO", "P4SFXO", JdeDataType.String, 6, true, true),
        new JdeField("P4LNID", "P4LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("P4NLIN", "P4NLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("P4DLNID", "P4DLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("P4AID", "P4AID", JdeDataType.String, 16),
        new JdeField("P4ANI", "P4ANI", JdeDataType.String, 58),
        new JdeField("P4OMCU", "P4OMCU", JdeDataType.String, 24),
        new JdeField("P4OBJ", "P4OBJ", JdeDataType.String, 12),
        new JdeField("P4SUB", "P4SUB", JdeDataType.String, 16),
        new JdeField("P4SBL", "P4SBL", JdeDataType.String, 16),
        new JdeField("P4SBLT", "P4SBLT", JdeDataType.String, 2),
        new JdeField("P4MAST", "P4MAST", JdeDataType.String, 2),
        new JdeField("P4MASP", "P4MASP", JdeDataType.Numeric),
        new JdeField("P4MASA", "P4MASA", JdeDataType.Numeric),
        new JdeField("P4MASU", "P4MASU", JdeDataType.Numeric),
        new JdeField("P4MASF", "P4MASF", JdeDataType.Numeric),
        new JdeField("P4UOVR", "P4UOVR", JdeDataType.String, 2),
        new JdeField("P4DOC", "P4DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("P4DCT", "P4DCT", JdeDataType.String, 4),
        new JdeField("P4KCO", "P4KCO", JdeDataType.String, 10),
        new JdeField("P4SFX", "P4SFX", JdeDataType.String, 6),
        new JdeField("P4JELN", "P4JELN", JdeDataType.Numeric),
        new JdeField("P4VANI", "P4VANI", JdeDataType.String, 58),
        new JdeField("P4UORG", "P4UORG", JdeDataType.Numeric),
        new JdeField("P4UPTD", "P4UPTD", JdeDataType.Numeric),
        new JdeField("P4UOPN", "P4UOPN", JdeDataType.Numeric),
        new JdeField("P4UREC", "P4UREC", JdeDataType.Numeric),
        new JdeField("P4UCLO", "P4UCLO", JdeDataType.Numeric),
        new JdeField("P4ECST", "P4ECST", JdeDataType.Numeric),
        new JdeField("P4APTD", "P4APTD", JdeDataType.Numeric),
        new JdeField("P4AOPN", "P4AOPN", JdeDataType.Numeric),
        new JdeField("P4AREC", "P4AREC", JdeDataType.Numeric),
        new JdeField("P4ACLO", "P4ACLO", JdeDataType.Numeric),
        new JdeField("P4CRCD", "P4CRCD", JdeDataType.String, 6),
        new JdeField("P4FEC", "P4FEC", JdeDataType.Numeric),
        new JdeField("P4FAP", "P4FAP", JdeDataType.Numeric),
        new JdeField("P4FAPT", "P4FAPT", JdeDataType.Numeric),
        new JdeField("P4FREC", "P4FREC", JdeDataType.Numeric),
        new JdeField("P4FCLO", "P4FCLO", JdeDataType.Numeric),
        new JdeField("P4STAM", "P4STAM", JdeDataType.Numeric),
        new JdeField("P4CTAM", "P4CTAM", JdeDataType.Numeric),
        new JdeField("P4URCD", "P4URCD", JdeDataType.String, 4),
        new JdeField("P4URDT", "P4URDT", JdeDataType.Numeric),
        new JdeField("P4URAT", "P4URAT", JdeDataType.Numeric),
        new JdeField("P4URAB", "P4URAB", JdeDataType.Numeric),
        new JdeField("P4URRF", "P4URRF", JdeDataType.String, 30),
        new JdeField("P4USER", "P4USER", JdeDataType.String, 20),
        new JdeField("P4PID", "P4PID", JdeDataType.String, 20),
        new JdeField("P4JOBN", "P4JOBN", JdeDataType.String, 20),
        new JdeField("P4TERM", "P4TERM", JdeDataType.String, 20),
        new JdeField("P4UPMJ", "P4UPMJ", JdeDataType.Numeric),
        new JdeField("P4TDAY", "P4TDAY", JdeDataType.Numeric),
        new JdeField("P4SRQTY", "P4SRQTY", JdeDataType.Numeric),
        new JdeField("P4JBCD", "P4JBCD", JdeDataType.String, 12)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43126_0", "Primary Key on P4MATC, P4DOCO, P4DCTO, P4KCOO, P4SFXO, P4LNID, P4NLIN, P4DLNID, P4DOC", new[] { "P4MATC", "P4DOCO", "P4DCTO", "P4KCOO", "P4SFXO", "P4LNID", "P4NLIN", "P4DLNID", "P4DOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43126_2", "Index on P4DOCO, P4DCTO, P4KCOO, P4SFXO, P4LNID, P4DLNID", new[] { "P4DOCO", "P4DCTO", "P4KCOO", "P4SFXO", "P4LNID", "P4DLNID" }),
        new JdeIndex("F43126_3", "Index on P4DOC, P4DCT, P4KCO", new[] { "P4DOC", "P4DCT", "P4KCO" }),
        new JdeIndex("F43126_4", "Index on P4MATC, P4DOCO, P4DCTO, P4KCOO, P4SFXO, P4LNID, P4DLNID", new[] { "P4MATC", "P4DOCO", "P4DCTO", "P4KCOO", "P4SFXO", "P4LNID", "P4DLNID" }),
        new JdeIndex("F43126_5", "Index on P4MATC, P4DOC, P4DCT, P4KCO, P4DOCO, P4DCTO, P4KCOO, P4SFXO, P4LNID, P4NLIN", new[] { "P4MATC", "P4DOC", "P4DCT", "P4KCO", "P4DOCO", "P4DCTO", "P4KCOO", "P4SFXO", "P4LNID", "P4NLIN" })
    };
}
