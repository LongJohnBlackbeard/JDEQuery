using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09E120 - .
/// </summary>
public class F09E120 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EXWRKSTNID.
        /// </summary>
        public const string EXWRKSTNID = "EXWRKSTNID";

        /// <summary>
        /// EXEXRPTTYP.
        /// </summary>
        public const string EXEXRPTTYP = "EXEXRPTTYP";

        /// <summary>
        /// EXEXRPTNUM.
        /// </summary>
        public const string EXEXRPTNUM = "EXEXRPTNUM";

        /// <summary>
        /// EXEMPLOYID.
        /// </summary>
        public const string EXEMPLOYID = "EXEMPLOYID";

        /// <summary>
        /// EXJOBN.
        /// </summary>
        public const string EXJOBN = "EXJOBN";

        /// <summary>
        /// EXDTECRT.
        /// </summary>
        public const string EXDTECRT = "EXDTECRT";

        /// <summary>
        /// EXEXRPTSTA.
        /// </summary>
        public const string EXEXRPTSTA = "EXEXRPTSTA";

        /// <summary>
        /// EXUPMJ.
        /// </summary>
        public const string EXUPMJ = "EXUPMJ";

        /// <summary>
        /// EXUSER.
        /// </summary>
        public const string EXUSER = "EXUSER";

        /// <summary>
        /// EXPID.
        /// </summary>
        public const string EXPID = "EXPID";

        /// <summary>
        /// EXUPMT.
        /// </summary>
        public const string EXUPMT = "EXUPMT";

        /// <summary>
        /// EXFROMSTA.
        /// </summary>
        public const string EXFROMSTA = "EXFROMSTA";

        /// <summary>
        /// EXLNID.
        /// </summary>
        public const string EXLNID = "EXLNID";
    }

    /// <inheritdoc />
    public override string TableName => "F09E120";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EXWRKSTNID", "EXWRKSTNID", JdeDataType.String, 20, true, true),
        new JdeField("EXEXRPTTYP", "EXEXRPTTYP", JdeDataType.String, 2, true, true),
        new JdeField("EXEXRPTNUM", "EXEXRPTNUM", JdeDataType.String, 20, true, true),
        new JdeField("EXEMPLOYID", "EXEMPLOYID", JdeDataType.Numeric, null, true, true),
        new JdeField("EXJOBN", "EXJOBN", JdeDataType.String, 20),
        new JdeField("EXDTECRT", "EXDTECRT", JdeDataType.Numeric, null, true, true),
        new JdeField("EXEXRPTSTA", "EXEXRPTSTA", JdeDataType.String, 6),
        new JdeField("EXUPMJ", "EXUPMJ", JdeDataType.Numeric),
        new JdeField("EXUSER", "EXUSER", JdeDataType.String, 20),
        new JdeField("EXPID", "EXPID", JdeDataType.String, 20),
        new JdeField("EXUPMT", "EXUPMT", JdeDataType.Numeric),
        new JdeField("EXFROMSTA", "EXFROMSTA", JdeDataType.String, 6),
        new JdeField("EXLNID", "EXLNID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09E120_0", "Primary Key on EXEXRPTTYP, EXEXRPTNUM, EXEMPLOYID, EXLNID, EXDTECRT, EXWRKSTNID", new[] { "EXEXRPTTYP", "EXEXRPTNUM", "EXEMPLOYID", "EXLNID", "EXDTECRT", "EXWRKSTNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09E120_2", "Index on EXWRKSTNID, EXEXRPTTYP, EXEXRPTNUM, EXEMPLOYID, SYS_NC00014$, EXDTECRT", new[] { "EXWRKSTNID", "EXEXRPTTYP", "EXEXRPTNUM", "EXEMPLOYID", "SYS_NC00014$", "EXDTECRT" })
    };
}
