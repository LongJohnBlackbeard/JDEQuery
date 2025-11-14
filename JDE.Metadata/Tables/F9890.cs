using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F9890 - .
/// </summary>
public class F9890 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VFJDEVERS.
        /// </summary>
        public const string VFJDEVERS = "VFJDEVERS";

        /// <summary>
        /// VFDL01.
        /// </summary>
        public const string VFDL01 = "VFDL01";

        /// <summary>
        /// VFCO.
        /// </summary>
        public const string VFCO = "VFCO";

        /// <summary>
        /// VFVRS1.
        /// </summary>
        public const string VFVRS1 = "VFVRS1";

        /// <summary>
        /// VFVRS2.
        /// </summary>
        public const string VFVRS2 = "VFVRS2";

        /// <summary>
        /// VFVRS3.
        /// </summary>
        public const string VFVRS3 = "VFVRS3";

        /// <summary>
        /// VFVRS4.
        /// </summary>
        public const string VFVRS4 = "VFVRS4";

        /// <summary>
        /// VFVRS5.
        /// </summary>
        public const string VFVRS5 = "VFVRS5";
    }

    /// <inheritdoc />
    public override string TableName => "F9890";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VFJDEVERS", "VFJDEVERS", JdeDataType.String, 20, true, true),
        new JdeField("VFDL01", "VFDL01", JdeDataType.String, 60),
        new JdeField("VFCO", "VFCO", JdeDataType.String, 10),
        new JdeField("VFVRS1", "VFVRS1", JdeDataType.String, 6),
        new JdeField("VFVRS2", "VFVRS2", JdeDataType.String, 6),
        new JdeField("VFVRS3", "VFVRS3", JdeDataType.String, 6),
        new JdeField("VFVRS4", "VFVRS4", JdeDataType.String, 6),
        new JdeField("VFVRS5", "VFVRS5", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F9890_0", "Primary Key on VFJDEVERS", new[] { "VFJDEVERS" }, isUnique: true, isPrimaryKey: true)
    };
}
