using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4801Z11 - .
/// </summary>
public class F4801Z11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SYDOCO.
        /// </summary>
        public const string SYDOCO = "SYDOCO";

        /// <summary>
        /// SYTSKTP.
        /// </summary>
        public const string SYTSKTP = "SYTSKTP";

        /// <summary>
        /// SYBILLA.
        /// </summary>
        public const string SYBILLA = "SYBILLA";

        /// <summary>
        /// SYLODL.
        /// </summary>
        public const string SYLODL = "SYLODL";

        /// <summary>
        /// SYBILLC.
        /// </summary>
        public const string SYBILLC = "SYBILLC";

        /// <summary>
        /// SYEDUS.
        /// </summary>
        public const string SYEDUS = "SYEDUS";

        /// <summary>
        /// SYEDBT.
        /// </summary>
        public const string SYEDBT = "SYEDBT";

        /// <summary>
        /// SYEDTN.
        /// </summary>
        public const string SYEDTN = "SYEDTN";

        /// <summary>
        /// SYEDLN.
        /// </summary>
        public const string SYEDLN = "SYEDLN";
    }

    /// <inheritdoc />
    public override string TableName => "F4801Z11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SYDOCO", "SYDOCO", JdeDataType.Numeric),
        new JdeField("SYTSKTP", "SYTSKTP", JdeDataType.String, 2),
        new JdeField("SYBILLA", "SYBILLA", JdeDataType.String, 2),
        new JdeField("SYLODL", "SYLODL", JdeDataType.String, 2),
        new JdeField("SYBILLC", "SYBILLC", JdeDataType.Numeric),
        new JdeField("SYEDUS", "SYEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SYEDBT", "SYEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SYEDTN", "SYEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SYEDLN", "SYEDLN", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4801Z11_0", "Primary Key on SYEDUS, SYEDBT, SYEDTN, SYEDLN", new[] { "SYEDUS", "SYEDBT", "SYEDTN", "SYEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4801Z11_3", "Index on SYDOCO", new[] { "SYDOCO" })
    };
}
