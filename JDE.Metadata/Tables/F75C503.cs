using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C503 - .
/// </summary>
public class F75C503 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EPAN8.
        /// </summary>
        public const string EPAN8 = "EPAN8";

        /// <summary>
        /// EPPPY.
        /// </summary>
        public const string EPPPY = "EPPPY";

        /// <summary>
        /// EPPPM.
        /// </summary>
        public const string EPPPM = "EPPPM";

        /// <summary>
        /// EPC75PEID.
        /// </summary>
        public const string EPC75PEID = "EPC75PEID";

        /// <summary>
        /// EPC75PCID.
        /// </summary>
        public const string EPC75PCID = "EPC75PCID";

        /// <summary>
        /// EPC75CUR.
        /// </summary>
        public const string EPC75CUR = "EPC75CUR";

        /// <summary>
        /// EPC75AMT.
        /// </summary>
        public const string EPC75AMT = "EPC75AMT";

        /// <summary>
        /// EPFUTMATH1.
        /// </summary>
        public const string EPFUTMATH1 = "EPFUTMATH1";

        /// <summary>
        /// EPFUTSTR1.
        /// </summary>
        public const string EPFUTSTR1 = "EPFUTSTR1";

        /// <summary>
        /// EPFUTSTR2.
        /// </summary>
        public const string EPFUTSTR2 = "EPFUTSTR2";

        /// <summary>
        /// EPFUTDATE1.
        /// </summary>
        public const string EPFUTDATE1 = "EPFUTDATE1";

        /// <summary>
        /// EPFUTUO1.
        /// </summary>
        public const string EPFUTUO1 = "EPFUTUO1";

        /// <summary>
        /// EPUSER.
        /// </summary>
        public const string EPUSER = "EPUSER";

        /// <summary>
        /// EPPID.
        /// </summary>
        public const string EPPID = "EPPID";

        /// <summary>
        /// EPJOBN.
        /// </summary>
        public const string EPJOBN = "EPJOBN";

        /// <summary>
        /// EPUPMJ.
        /// </summary>
        public const string EPUPMJ = "EPUPMJ";

        /// <summary>
        /// EPUPMT.
        /// </summary>
        public const string EPUPMT = "EPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C503";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EPAN8", "EPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EPPPY", "EPPPY", JdeDataType.Numeric, null, true, true),
        new JdeField("EPPPM", "EPPPM", JdeDataType.Numeric, null, true, true),
        new JdeField("EPC75PEID", "EPC75PEID", JdeDataType.String, 120, true, true),
        new JdeField("EPC75PCID", "EPC75PCID", JdeDataType.Numeric, null, true, true),
        new JdeField("EPC75CUR", "EPC75CUR", JdeDataType.String, 20),
        new JdeField("EPC75AMT", "EPC75AMT", JdeDataType.Numeric),
        new JdeField("EPFUTMATH1", "EPFUTMATH1", JdeDataType.Numeric),
        new JdeField("EPFUTSTR1", "EPFUTSTR1", JdeDataType.String, 100),
        new JdeField("EPFUTSTR2", "EPFUTSTR2", JdeDataType.String, 100),
        new JdeField("EPFUTDATE1", "EPFUTDATE1", JdeDataType.Numeric),
        new JdeField("EPFUTUO1", "EPFUTUO1", JdeDataType.String, 2),
        new JdeField("EPUSER", "EPUSER", JdeDataType.String, 20),
        new JdeField("EPPID", "EPPID", JdeDataType.String, 20),
        new JdeField("EPJOBN", "EPJOBN", JdeDataType.String, 20),
        new JdeField("EPUPMJ", "EPUPMJ", JdeDataType.Numeric),
        new JdeField("EPUPMT", "EPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C503_0", "Primary Key on EPAN8, EPPPY, EPPPM, EPC75PCID, EPC75PEID", new[] { "EPAN8", "EPPPY", "EPPPM", "EPC75PCID", "EPC75PEID" }, isUnique: true, isPrimaryKey: true)
    };
}
