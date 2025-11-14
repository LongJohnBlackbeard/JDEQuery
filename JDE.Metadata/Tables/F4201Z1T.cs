using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4201Z1T - .
/// </summary>
public class F4201Z1T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HYEDUS.
        /// </summary>
        public const string HYEDUS = "HYEDUS";

        /// <summary>
        /// HYEDBT.
        /// </summary>
        public const string HYEDBT = "HYEDBT";

        /// <summary>
        /// HYEDTN.
        /// </summary>
        public const string HYEDTN = "HYEDTN";

        /// <summary>
        /// HYEDLN.
        /// </summary>
        public const string HYEDLN = "HYEDLN";

        /// <summary>
        /// HYUTP.
        /// </summary>
        public const string HYUTP = "HYUTP";

        /// <summary>
        /// HYUSER.
        /// </summary>
        public const string HYUSER = "HYUSER";

        /// <summary>
        /// HYPID.
        /// </summary>
        public const string HYPID = "HYPID";

        /// <summary>
        /// HYJOBN.
        /// </summary>
        public const string HYJOBN = "HYJOBN";

        /// <summary>
        /// HYUPMJ.
        /// </summary>
        public const string HYUPMJ = "HYUPMJ";

        /// <summary>
        /// HYUPMT.
        /// </summary>
        public const string HYUPMT = "HYUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F4201Z1T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HYEDUS", "HYEDUS", JdeDataType.String, 20, true, true),
        new JdeField("HYEDBT", "HYEDBT", JdeDataType.String, 30, true, true),
        new JdeField("HYEDTN", "HYEDTN", JdeDataType.String, 44, true, true),
        new JdeField("HYEDLN", "HYEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("HYUTP", "HYUTP", JdeDataType.String, 2),
        new JdeField("HYUSER", "HYUSER", JdeDataType.String, 20),
        new JdeField("HYPID", "HYPID", JdeDataType.String, 20),
        new JdeField("HYJOBN", "HYJOBN", JdeDataType.String, 20),
        new JdeField("HYUPMJ", "HYUPMJ", JdeDataType.Numeric),
        new JdeField("HYUPMT", "HYUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4201Z1T_0", "Primary Key on HYEDUS, HYEDBT, HYEDTN, HYEDLN", new[] { "HYEDUS", "HYEDBT", "HYEDTN", "HYEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
