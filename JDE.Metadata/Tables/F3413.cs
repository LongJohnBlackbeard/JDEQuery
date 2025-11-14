using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3413 - .
/// </summary>
public class F3413 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MRITM.
        /// </summary>
        public const string MRITM = "MRITM";

        /// <summary>
        /// MRMCU.
        /// </summary>
        public const string MRMCU = "MRMCU";

        /// <summary>
        /// MRQT.
        /// </summary>
        public const string MRQT = "MRQT";

        /// <summary>
        /// MRSTRT.
        /// </summary>
        public const string MRSTRT = "MRSTRT";

        /// <summary>
        /// MRTRQT.
        /// </summary>
        public const string MRTRQT = "MRTRQT";
    }

    /// <inheritdoc />
    public override string TableName => "F3413";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MRITM", "MRITM", JdeDataType.Numeric, null, true, true),
        new JdeField("MRMCU", "MRMCU", JdeDataType.String, 24, true, true),
        new JdeField("MRQT", "MRQT", JdeDataType.String, 4, true, true),
        new JdeField("MRSTRT", "MRSTRT", JdeDataType.Numeric, null, true, true),
        new JdeField("MRTRQT", "MRTRQT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3413_0", "Primary Key on MRITM, MRMCU, MRQT, MRSTRT", new[] { "MRITM", "MRMCU", "MRQT", "MRSTRT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3413_2", "Index on MRMCU", new[] { "MRMCU" })
    };
}
