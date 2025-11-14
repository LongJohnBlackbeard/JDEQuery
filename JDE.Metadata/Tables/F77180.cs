using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F77180 - .
/// </summary>
public class F77180 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J1FORMSID.
        /// </summary>
        public const string J1FORMSID = "J1FORMSID";

        /// <summary>
        /// J1FORMD.
        /// </summary>
        public const string J1FORMD = "J1FORMD";

        /// <summary>
        /// J1BOXN.
        /// </summary>
        public const string J1BOXN = "J1BOXN";

        /// <summary>
        /// J1BOXD.
        /// </summary>
        public const string J1BOXD = "J1BOXD";

        /// <summary>
        /// J1UPMJ.
        /// </summary>
        public const string J1UPMJ = "J1UPMJ";

        /// <summary>
        /// J1UPMT.
        /// </summary>
        public const string J1UPMT = "J1UPMT";

        /// <summary>
        /// J1PID.
        /// </summary>
        public const string J1PID = "J1PID";

        /// <summary>
        /// J1JOBN.
        /// </summary>
        public const string J1JOBN = "J1JOBN";

        /// <summary>
        /// J1USER.
        /// </summary>
        public const string J1USER = "J1USER";
    }

    /// <inheritdoc />
    public override string TableName => "F77180";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J1FORMSID", "J1FORMSID", JdeDataType.Numeric, null, true, true),
        new JdeField("J1FORMD", "J1FORMD", JdeDataType.String, 80),
        new JdeField("J1BOXN", "J1BOXN", JdeDataType.String, 20, true, true),
        new JdeField("J1BOXD", "J1BOXD", JdeDataType.String, 80),
        new JdeField("J1UPMJ", "J1UPMJ", JdeDataType.Numeric),
        new JdeField("J1UPMT", "J1UPMT", JdeDataType.Numeric),
        new JdeField("J1PID", "J1PID", JdeDataType.String, 20),
        new JdeField("J1JOBN", "J1JOBN", JdeDataType.String, 20),
        new JdeField("J1USER", "J1USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F77180_0", "Primary Key on J1FORMSID, J1BOXN", new[] { "J1FORMSID", "J1BOXN" }, isUnique: true, isPrimaryKey: true)
    };
}
