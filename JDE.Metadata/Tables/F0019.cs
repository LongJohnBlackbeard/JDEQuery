using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0019 - .
/// </summary>
public class F0019 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CGSY.
        /// </summary>
        public const string CGSY = "CGSY";

        /// <summary>
        /// CGRT.
        /// </summary>
        public const string CGRT = "CGRT";

        /// <summary>
        /// CGDL01.
        /// </summary>
        public const string CGDL01 = "CGDL01";

        /// <summary>
        /// CGCDL.
        /// </summary>
        public const string CGCDL = "CGCDL";

        /// <summary>
        /// CGLN2.
        /// </summary>
        public const string CGLN2 = "CGLN2";

        /// <summary>
        /// CGCNUM.
        /// </summary>
        public const string CGCNUM = "CGCNUM";
    }

    /// <inheritdoc />
    public override string TableName => "F0019";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CGSY", "CGSY", JdeDataType.String, 8, true, true),
        new JdeField("CGRT", "CGRT", JdeDataType.String, 4, true, true),
        new JdeField("CGDL01", "CGDL01", JdeDataType.String, 60),
        new JdeField("CGCDL", "CGCDL", JdeDataType.Numeric),
        new JdeField("CGLN2", "CGLN2", JdeDataType.String, 2),
        new JdeField("CGCNUM", "CGCNUM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0019_0", "Primary Key on CGSY, CGRT", new[] { "CGSY", "CGRT" }, isUnique: true, isPrimaryKey: true)
    };
}
