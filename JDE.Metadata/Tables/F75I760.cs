using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I760 - .
/// </summary>
public class F75I760 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ABAN8.
        /// </summary>
        public const string ABAN8 = "ABAN8";

        /// <summary>
        /// ABFYR.
        /// </summary>
        public const string ABFYR = "ABFYR";

        /// <summary>
        /// ABMT.
        /// </summary>
        public const string ABMT = "ABMT";

        /// <summary>
        /// ABI75PC.
        /// </summary>
        public const string ABI75PC = "ABI75PC";

        /// <summary>
        /// ABBGBL.
        /// </summary>
        public const string ABBGBL = "ABBGBL";

        /// <summary>
        /// ABENBL.
        /// </summary>
        public const string ABENBL = "ABENBL";

        /// <summary>
        /// ABI75CAMT.
        /// </summary>
        public const string ABI75CAMT = "ABI75CAMT";

        /// <summary>
        /// ABI75CAID.
        /// </summary>
        public const string ABI75CAID = "ABI75CAID";

        /// <summary>
        /// ABI75CACF.
        /// </summary>
        public const string ABI75CACF = "ABI75CACF";

        /// <summary>
        /// ABI75CASG.
        /// </summary>
        public const string ABI75CASG = "ABI75CASG";

        /// <summary>
        /// ABI75CASGL.
        /// </summary>
        public const string ABI75CASGL = "ABI75CASGL";

        /// <summary>
        /// ABI75CAUST.
        /// </summary>
        public const string ABI75CAUST = "ABI75CAUST";

        /// <summary>
        /// ABI75CAUCS.
        /// </summary>
        public const string ABI75CAUCS = "ABI75CAUCS";

        /// <summary>
        /// ABI75CAUHC.
        /// </summary>
        public const string ABI75CAUHC = "ABI75CAUHC";

        /// <summary>
        /// ABI75NAMT.
        /// </summary>
        public const string ABI75NAMT = "ABI75NAMT";

        /// <summary>
        /// ABI75CHNO.
        /// </summary>
        public const string ABI75CHNO = "ABI75CHNO";

        /// <summary>
        /// ABI75CHDT.
        /// </summary>
        public const string ABI75CHDT = "ABI75CHDT";

        /// <summary>
        /// ABAN8BK.
        /// </summary>
        public const string ABAN8BK = "ABAN8BK";

        /// <summary>
        /// ABUSER.
        /// </summary>
        public const string ABUSER = "ABUSER";

        /// <summary>
        /// ABPID.
        /// </summary>
        public const string ABPID = "ABPID";

        /// <summary>
        /// ABJOBN.
        /// </summary>
        public const string ABJOBN = "ABJOBN";

        /// <summary>
        /// ABUPMJ.
        /// </summary>
        public const string ABUPMJ = "ABUPMJ";

        /// <summary>
        /// ABUPMT.
        /// </summary>
        public const string ABUPMT = "ABUPMT";

        /// <summary>
        /// ABMATH01.
        /// </summary>
        public const string ABMATH01 = "ABMATH01";

        /// <summary>
        /// ABYS05.
        /// </summary>
        public const string ABYS05 = "ABYS05";

        /// <summary>
        /// ABEV01.
        /// </summary>
        public const string ABEV01 = "ABEV01";

        /// <summary>
        /// ABI75CAUSB.
        /// </summary>
        public const string ABI75CAUSB = "ABI75CAUSB";

        /// <summary>
        /// ABI75CAUKK.
        /// </summary>
        public const string ABI75CAUKK = "ABI75CAUKK";
    }

    /// <inheritdoc />
    public override string TableName => "F75I760";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ABAN8", "ABAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ABFYR", "ABFYR", JdeDataType.Numeric, null, true, true),
        new JdeField("ABMT", "ABMT", JdeDataType.Numeric, null, true, true),
        new JdeField("ABI75PC", "ABI75PC", JdeDataType.String, 2),
        new JdeField("ABBGBL", "ABBGBL", JdeDataType.Numeric),
        new JdeField("ABENBL", "ABENBL", JdeDataType.Numeric),
        new JdeField("ABI75CAMT", "ABI75CAMT", JdeDataType.Numeric),
        new JdeField("ABI75CAID", "ABI75CAID", JdeDataType.String, 16),
        new JdeField("ABI75CACF", "ABI75CACF", JdeDataType.Numeric),
        new JdeField("ABI75CASG", "ABI75CASG", JdeDataType.Numeric),
        new JdeField("ABI75CASGL", "ABI75CASGL", JdeDataType.Numeric),
        new JdeField("ABI75CAUST", "ABI75CAUST", JdeDataType.Numeric),
        new JdeField("ABI75CAUCS", "ABI75CAUCS", JdeDataType.Numeric),
        new JdeField("ABI75CAUHC", "ABI75CAUHC", JdeDataType.Numeric),
        new JdeField("ABI75NAMT", "ABI75NAMT", JdeDataType.Numeric),
        new JdeField("ABI75CHNO", "ABI75CHNO", JdeDataType.String, 120),
        new JdeField("ABI75CHDT", "ABI75CHDT", JdeDataType.Numeric),
        new JdeField("ABAN8BK", "ABAN8BK", JdeDataType.Numeric),
        new JdeField("ABUSER", "ABUSER", JdeDataType.String, 20),
        new JdeField("ABPID", "ABPID", JdeDataType.String, 20),
        new JdeField("ABJOBN", "ABJOBN", JdeDataType.String, 20),
        new JdeField("ABUPMJ", "ABUPMJ", JdeDataType.Numeric),
        new JdeField("ABUPMT", "ABUPMT", JdeDataType.Numeric),
        new JdeField("ABMATH01", "ABMATH01", JdeDataType.Numeric),
        new JdeField("ABYS05", "ABYS05", JdeDataType.String, 40),
        new JdeField("ABEV01", "ABEV01", JdeDataType.String, 2),
        new JdeField("ABI75CAUSB", "ABI75CAUSB", JdeDataType.Numeric),
        new JdeField("ABI75CAUKK", "ABI75CAUKK", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I760_0", "Primary Key on ABAN8, ABFYR, ABMT", new[] { "ABAN8", "ABFYR", "ABMT" }, isUnique: true, isPrimaryKey: true)
    };
}
