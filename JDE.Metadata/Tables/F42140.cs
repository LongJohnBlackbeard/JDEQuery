using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42140 - .
/// </summary>
public class F42140 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMAN8.
        /// </summary>
        public const string CMAN8 = "CMAN8";

        /// <summary>
        /// CMCO.
        /// </summary>
        public const string CMCO = "CMCO";

        /// <summary>
        /// CMCMLN.
        /// </summary>
        public const string CMCMLN = "CMCMLN";

        /// <summary>
        /// CMSLSM.
        /// </summary>
        public const string CMSLSM = "CMSLSM";

        /// <summary>
        /// CMSLCM.
        /// </summary>
        public const string CMSLCM = "CMSLCM";

        /// <summary>
        /// CMFCA.
        /// </summary>
        public const string CMFCA = "CMFCA";

        /// <summary>
        /// CMAPUN.
        /// </summary>
        public const string CMAPUN = "CMAPUN";

        /// <summary>
        /// CMCCTY.
        /// </summary>
        public const string CMCCTY = "CMCCTY";

        /// <summary>
        /// CMOWNFLG.
        /// </summary>
        public const string CMOWNFLG = "CMOWNFLG";

        /// <summary>
        /// CMRTYPE.
        /// </summary>
        public const string CMRTYPE = "CMRTYPE";

        /// <summary>
        /// CMSTMBDT.
        /// </summary>
        public const string CMSTMBDT = "CMSTMBDT";

        /// <summary>
        /// CMSTMEDT.
        /// </summary>
        public const string CMSTMEDT = "CMSTMEDT";

        /// <summary>
        /// CMCOMMYN.
        /// </summary>
        public const string CMCOMMYN = "CMCOMMYN";

        /// <summary>
        /// CMUSER.
        /// </summary>
        public const string CMUSER = "CMUSER";

        /// <summary>
        /// CMJOBN.
        /// </summary>
        public const string CMJOBN = "CMJOBN";

        /// <summary>
        /// CMMKEY.
        /// </summary>
        public const string CMMKEY = "CMMKEY";

        /// <summary>
        /// CMENTDBY.
        /// </summary>
        public const string CMENTDBY = "CMENTDBY";

        /// <summary>
        /// CMEDATE.
        /// </summary>
        public const string CMEDATE = "CMEDATE";

        /// <summary>
        /// CMUDTTM.
        /// </summary>
        public const string CMUDTTM = "CMUDTTM";

        /// <summary>
        /// CMPID.
        /// </summary>
        public const string CMPID = "CMPID";

        /// <summary>
        /// CMVID.
        /// </summary>
        public const string CMVID = "CMVID";

        /// <summary>
        /// CMEFFS.
        /// </summary>
        public const string CMEFFS = "CMEFFS";
    }

    /// <inheritdoc />
    public override string TableName => "F42140";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMAN8", "CMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CMCO", "CMCO", JdeDataType.String, 10, true, true),
        new JdeField("CMCMLN", "CMCMLN", JdeDataType.Numeric, null, true, true),
        new JdeField("CMSLSM", "CMSLSM", JdeDataType.Numeric, null, true, true),
        new JdeField("CMSLCM", "CMSLCM", JdeDataType.Numeric),
        new JdeField("CMFCA", "CMFCA", JdeDataType.Numeric),
        new JdeField("CMAPUN", "CMAPUN", JdeDataType.Numeric),
        new JdeField("CMCCTY", "CMCCTY", JdeDataType.String, 2),
        new JdeField("CMOWNFLG", "CMOWNFLG", JdeDataType.String, 2),
        new JdeField("CMRTYPE", "CMRTYPE", JdeDataType.String, 10),
        new JdeField("CMSTMBDT", "CMSTMBDT", JdeDataType.Date),
        new JdeField("CMSTMEDT", "CMSTMEDT", JdeDataType.Date),
        new JdeField("CMCOMMYN", "CMCOMMYN", JdeDataType.String, 2),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMJOBN", "CMJOBN", JdeDataType.String, 20),
        new JdeField("CMMKEY", "CMMKEY", JdeDataType.String, 30),
        new JdeField("CMENTDBY", "CMENTDBY", JdeDataType.Numeric),
        new JdeField("CMEDATE", "CMEDATE", JdeDataType.Date),
        new JdeField("CMUDTTM", "CMUDTTM", JdeDataType.Date),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMVID", "CMVID", JdeDataType.String, 20),
        new JdeField("CMEFFS", "CMEFFS", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42140_0", "Primary Key on CMAN8, CMCO, CMSLSM, CMCMLN", new[] { "CMAN8", "CMCO", "CMSLSM", "CMCMLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42140_2", "Index on CMAN8, CMCO, SYS_NC00023$", new[] { "CMAN8", "CMCO", "SYS_NC00023$" }),
        new JdeIndex("F42140_3", "Index on CMAN8, CMCO", new[] { "CMAN8", "CMCO" })
    };
}
