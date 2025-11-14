using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B77BW - .
/// </summary>
public class F31B77BW : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WSWFSSID.
        /// </summary>
        public const string WSWFSSID = "WSWFSSID";

        /// <summary>
        /// WSLVLBRKID.
        /// </summary>
        public const string WSLVLBRKID = "WSLVLBRKID";

        /// <summary>
        /// WSSITEC.
        /// </summary>
        public const string WSSITEC = "WSSITEC";

        /// <summary>
        /// WSCNTRTID.
        /// </summary>
        public const string WSCNTRTID = "WSCNTRTID";

        /// <summary>
        /// WSEURSCD.
        /// </summary>
        public const string WSEURSCD = "WSEURSCD";

        /// <summary>
        /// WSBLSCD2.
        /// </summary>
        public const string WSBLSCD2 = "WSBLSCD2";

        /// <summary>
        /// WSVARCODE.
        /// </summary>
        public const string WSVARCODE = "WSVARCODE";

        /// <summary>
        /// WSWTNUM.
        /// </summary>
        public const string WSWTNUM = "WSWTNUM";

        /// <summary>
        /// WSHARPER.
        /// </summary>
        public const string WSHARPER = "WSHARPER";

        /// <summary>
        /// WSHARSFX.
        /// </summary>
        public const string WSHARSFX = "WSHARSFX";

        /// <summary>
        /// WSCNTRTCD.
        /// </summary>
        public const string WSCNTRTCD = "WSCNTRTCD";

        /// <summary>
        /// WSCNTRTDF.
        /// </summary>
        public const string WSCNTRTDF = "WSCNTRTDF";

        /// <summary>
        /// WSGDISTR.
        /// </summary>
        public const string WSGDISTR = "WSGDISTR";

        /// <summary>
        /// WSAPPLLAT.
        /// </summary>
        public const string WSAPPLLAT = "WSAPPLLAT";

        /// <summary>
        /// WSGREGION.
        /// </summary>
        public const string WSGREGION = "WSGREGION";

        /// <summary>
        /// WSCOUN.
        /// </summary>
        public const string WSCOUN = "WSCOUN";

        /// <summary>
        /// WSEURID.
        /// </summary>
        public const string WSEURID = "WSEURID";

        /// <summary>
        /// WSBFLG.
        /// </summary>
        public const string WSBFLG = "WSBFLG";

        /// <summary>
        /// WSQTRC.
        /// </summary>
        public const string WSQTRC = "WSQTRC";

        /// <summary>
        /// WSALTWGT.
        /// </summary>
        public const string WSALTWGT = "WSALTWGT";

        /// <summary>
        /// WSGRSWTIN.
        /// </summary>
        public const string WSGRSWTIN = "WSGRSWTIN";

        /// <summary>
        /// WSTRWTOUT.
        /// </summary>
        public const string WSTRWTOUT = "WSTRWTOUT";

        /// <summary>
        /// WSRSVAL1.
        /// </summary>
        public const string WSRSVAL1 = "WSRSVAL1";

        /// <summary>
        /// WSRSVAL2.
        /// </summary>
        public const string WSRSVAL2 = "WSRSVAL2";

        /// <summary>
        /// WSRSVAL3.
        /// </summary>
        public const string WSRSVAL3 = "WSRSVAL3";

        /// <summary>
        /// WSRSVAL4.
        /// </summary>
        public const string WSRSVAL4 = "WSRSVAL4";

        /// <summary>
        /// WSQTRCEUR.
        /// </summary>
        public const string WSQTRCEUR = "WSQTRCEUR";

        /// <summary>
        /// WSALTWTEUR.
        /// </summary>
        public const string WSALTWTEUR = "WSALTWTEUR";

        /// <summary>
        /// WSNETWGT.
        /// </summary>
        public const string WSNETWGT = "WSNETWGT";

        /// <summary>
        /// WSWASDT.
        /// </summary>
        public const string WSWASDT = "WSWASDT";

        /// <summary>
        /// WSWVUM.
        /// </summary>
        public const string WSWVUM = "WSWVUM";

        /// <summary>
        /// WSALTWVUM.
        /// </summary>
        public const string WSALTWVUM = "WSALTWVUM";

        /// <summary>
        /// WSUMWG1.
        /// </summary>
        public const string WSUMWG1 = "WSUMWG1";

        /// <summary>
        /// WSMCU.
        /// </summary>
        public const string WSMCU = "WSMCU";

        /// <summary>
        /// WSITM.
        /// </summary>
        public const string WSITM = "WSITM";
    }

    /// <inheritdoc />
    public override string TableName => "F31B77BW";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WSWFSSID", "WSWFSSID", JdeDataType.String, 64, true, true),
        new JdeField("WSLVLBRKID", "WSLVLBRKID", JdeDataType.Numeric),
        new JdeField("WSSITEC", "WSSITEC", JdeDataType.String, 24),
        new JdeField("WSCNTRTID", "WSCNTRTID", JdeDataType.Numeric),
        new JdeField("WSEURSCD", "WSEURSCD", JdeDataType.String, 20),
        new JdeField("WSBLSCD2", "WSBLSCD2", JdeDataType.String, 20),
        new JdeField("WSVARCODE", "WSVARCODE", JdeDataType.String, 10),
        new JdeField("WSWTNUM", "WSWTNUM", JdeDataType.String, 60, true, true),
        new JdeField("WSHARPER", "WSHARPER", JdeDataType.String, 12),
        new JdeField("WSHARSFX", "WSHARSFX", JdeDataType.String, 20),
        new JdeField("WSCNTRTCD", "WSCNTRTCD", JdeDataType.String, 24),
        new JdeField("WSCNTRTDF", "WSCNTRTDF", JdeDataType.String, 6),
        new JdeField("WSGDISTR", "WSGDISTR", JdeDataType.String, 20),
        new JdeField("WSAPPLLAT", "WSAPPLLAT", JdeDataType.String, 16),
        new JdeField("WSGREGION", "WSGREGION", JdeDataType.String, 20),
        new JdeField("WSCOUN", "WSCOUN", JdeDataType.String, 50),
        new JdeField("WSEURID", "WSEURID", JdeDataType.Numeric, null, true, true),
        new JdeField("WSBFLG", "WSBFLG", JdeDataType.String, 2),
        new JdeField("WSQTRC", "WSQTRC", JdeDataType.Numeric),
        new JdeField("WSALTWGT", "WSALTWGT", JdeDataType.Numeric),
        new JdeField("WSGRSWTIN", "WSGRSWTIN", JdeDataType.Numeric),
        new JdeField("WSTRWTOUT", "WSTRWTOUT", JdeDataType.Numeric),
        new JdeField("WSRSVAL1", "WSRSVAL1", JdeDataType.String, 30),
        new JdeField("WSRSVAL2", "WSRSVAL2", JdeDataType.String, 30),
        new JdeField("WSRSVAL3", "WSRSVAL3", JdeDataType.String, 30),
        new JdeField("WSRSVAL4", "WSRSVAL4", JdeDataType.String, 30),
        new JdeField("WSQTRCEUR", "WSQTRCEUR", JdeDataType.Numeric),
        new JdeField("WSALTWTEUR", "WSALTWTEUR", JdeDataType.Numeric),
        new JdeField("WSNETWGT", "WSNETWGT", JdeDataType.Numeric),
        new JdeField("WSWASDT", "WSWASDT", JdeDataType.Date),
        new JdeField("WSWVUM", "WSWVUM", JdeDataType.String, 6),
        new JdeField("WSALTWVUM", "WSALTWVUM", JdeDataType.String, 6),
        new JdeField("WSUMWG1", "WSUMWG1", JdeDataType.String, 4),
        new JdeField("WSMCU", "WSMCU", JdeDataType.String, 24),
        new JdeField("WSITM", "WSITM", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B77BW_0", "Primary Key on WSWFSSID, WSWTNUM, WSEURID", new[] { "WSWFSSID", "WSWTNUM", "WSEURID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B77BW_2", "Index on WSWFSSID, WSLVLBRKID, WSWTNUM, SYS_NC00036$", new[] { "WSWFSSID", "WSLVLBRKID", "WSWTNUM", "SYS_NC00036$" })
    };
}
