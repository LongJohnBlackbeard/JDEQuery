using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI91 - .
/// </summary>
public class F75IUI91 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

        /// <summary>
        /// WFKCOO.
        /// </summary>
        public const string WFKCOO = "WFKCOO";

        /// <summary>
        /// WFDCTO.
        /// </summary>
        public const string WFDCTO = "WFDCTO";

        /// <summary>
        /// WFDOCO.
        /// </summary>
        public const string WFDOCO = "WFDOCO";

        /// <summary>
        /// WFLNID.
        /// </summary>
        public const string WFLNID = "WFLNID";

        /// <summary>
        /// WFASN.
        /// </summary>
        public const string WFASN = "WFASN";

        /// <summary>
        /// WFAST.
        /// </summary>
        public const string WFAST = "WFAST";

        /// <summary>
        /// WFANI.
        /// </summary>
        public const string WFANI = "WFANI";

        /// <summary>
        /// WFUSER.
        /// </summary>
        public const string WFUSER = "WFUSER";

        /// <summary>
        /// WFPID.
        /// </summary>
        public const string WFPID = "WFPID";

        /// <summary>
        /// WFJOBN.
        /// </summary>
        public const string WFJOBN = "WFJOBN";

        /// <summary>
        /// WFUPMJ.
        /// </summary>
        public const string WFUPMJ = "WFUPMJ";

        /// <summary>
        /// WFUPMT.
        /// </summary>
        public const string WFUPMT = "WFUPMT";

        /// <summary>
        /// WFYFUTDT1.
        /// </summary>
        public const string WFYFUTDT1 = "WFYFUTDT1";

        /// <summary>
        /// WFFUT6.
        /// </summary>
        public const string WFFUT6 = "WFFUT6";

        /// <summary>
        /// WFYT04.
        /// </summary>
        public const string WFYT04 = "WFYT04";

        /// <summary>
        /// WFYFLAG.
        /// </summary>
        public const string WFYFLAG = "WFYFLAG";

        /// <summary>
        /// WFYNUM1.
        /// </summary>
        public const string WFYNUM1 = "WFYNUM1";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI91";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WFKCOO", "WFKCOO", JdeDataType.String, 10, true, true),
        new JdeField("WFDCTO", "WFDCTO", JdeDataType.String, 4, true, true),
        new JdeField("WFDOCO", "WFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WFLNID", "WFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("WFASN", "WFASN", JdeDataType.String, 16, true, true),
        new JdeField("WFAST", "WFAST", JdeDataType.String, 16, true, true),
        new JdeField("WFANI", "WFANI", JdeDataType.String, 58),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFJOBN", "WFJOBN", JdeDataType.String, 20),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric),
        new JdeField("WFYFUTDT1", "WFYFUTDT1", JdeDataType.Numeric),
        new JdeField("WFFUT6", "WFFUT6", JdeDataType.String, 60),
        new JdeField("WFYT04", "WFYT04", JdeDataType.String, 2),
        new JdeField("WFYFLAG", "WFYFLAG", JdeDataType.String, 2),
        new JdeField("WFYNUM1", "WFYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI91_0", "Primary Key on WFJOBS, WFKCOO, WFDCTO, WFDOCO, WFLNID, WFASN, WFAST", new[] { "WFJOBS", "WFKCOO", "WFDCTO", "WFDOCO", "WFLNID", "WFASN", "WFAST" }, isUnique: true, isPrimaryKey: true)
    };
}
