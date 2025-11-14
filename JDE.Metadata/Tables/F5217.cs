using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5217 - .
/// </summary>
public class F5217 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A7DOCO.
        /// </summary>
        public const string A7DOCO = "A7DOCO";

        /// <summary>
        /// A7DCTO.
        /// </summary>
        public const string A7DCTO = "A7DCTO";

        /// <summary>
        /// A7KCOO.
        /// </summary>
        public const string A7KCOO = "A7KCOO";

        /// <summary>
        /// A7COCH.
        /// </summary>
        public const string A7COCH = "A7COCH";

        /// <summary>
        /// A7LNID.
        /// </summary>
        public const string A7LNID = "A7LNID";

        /// <summary>
        /// A7COCX.
        /// </summary>
        public const string A7COCX = "A7COCX";

        /// <summary>
        /// A7LNIX.
        /// </summary>
        public const string A7LNIX = "A7LNIX";

        /// <summary>
        /// A7PRTP.
        /// </summary>
        public const string A7PRTP = "A7PRTP";

        /// <summary>
        /// A7ICUJ.
        /// </summary>
        public const string A7ICUJ = "A7ICUJ";

        /// <summary>
        /// A7USER.
        /// </summary>
        public const string A7USER = "A7USER";

        /// <summary>
        /// A7JOBN.
        /// </summary>
        public const string A7JOBN = "A7JOBN";

        /// <summary>
        /// A7PID.
        /// </summary>
        public const string A7PID = "A7PID";

        /// <summary>
        /// A7UPMJ.
        /// </summary>
        public const string A7UPMJ = "A7UPMJ";

        /// <summary>
        /// A7UPMT.
        /// </summary>
        public const string A7UPMT = "A7UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F5217";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A7DOCO", "A7DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("A7DCTO", "A7DCTO", JdeDataType.String, 4, true, true),
        new JdeField("A7KCOO", "A7KCOO", JdeDataType.String, 10, true, true),
        new JdeField("A7COCH", "A7COCH", JdeDataType.String, 6, true, true),
        new JdeField("A7LNID", "A7LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("A7COCX", "A7COCX", JdeDataType.String, 6, true, true),
        new JdeField("A7LNIX", "A7LNIX", JdeDataType.Numeric, null, true, true),
        new JdeField("A7PRTP", "A7PRTP", JdeDataType.String, 2),
        new JdeField("A7ICUJ", "A7ICUJ", JdeDataType.Numeric),
        new JdeField("A7USER", "A7USER", JdeDataType.String, 20),
        new JdeField("A7JOBN", "A7JOBN", JdeDataType.String, 20),
        new JdeField("A7PID", "A7PID", JdeDataType.String, 20),
        new JdeField("A7UPMJ", "A7UPMJ", JdeDataType.Numeric),
        new JdeField("A7UPMT", "A7UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5217_0", "Primary Key on A7DOCO, A7DCTO, A7KCOO, A7COCH, A7LNID, A7COCX, A7LNIX", new[] { "A7DOCO", "A7DCTO", "A7KCOO", "A7COCH", "A7LNID", "A7COCX", "A7LNIX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F5217_2", "Index on A7DOCO, A7DCTO, A7KCOO, A7COCX, A7LNIX", new[] { "A7DOCO", "A7DCTO", "A7KCOO", "A7COCX", "A7LNIX" }),
        new JdeIndex("F5217_3", "Index on A7DOCO, A7DCTO, A7KCOO, A7COCH, A7LNID", new[] { "A7DOCO", "A7DCTO", "A7KCOO", "A7COCH", "A7LNID" })
    };
}
