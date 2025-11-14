using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F986020 - .
/// </summary>
public class F986020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TAOBNM.
        /// </summary>
        public const string TAOBNM = "TAOBNM";

        /// <summary>
        /// TASBFATNM.
        /// </summary>
        public const string TASBFATNM = "TASBFATNM";

        /// <summary>
        /// TASBFATPTH.
        /// </summary>
        public const string TASBFATPTH = "TASBFATPTH";

        /// <summary>
        /// TASBFATSTS.
        /// </summary>
        public const string TASBFATSTS = "TASBFATSTS";

        /// <summary>
        /// TAFUTANON1.
        /// </summary>
        public const string TAFUTANON1 = "TAFUTANON1";

        /// <summary>
        /// TAFUTANON2.
        /// </summary>
        public const string TAFUTANON2 = "TAFUTANON2";

        /// <summary>
        /// TAFUTANON10.
        /// </summary>
        public const string TAFUTANON10 = "TAFUTANON10";

        /// <summary>
        /// TAFUTANON11.
        /// </summary>
        public const string TAFUTANON11 = "TAFUTANON11";

        /// <summary>
        /// TAFUTANON12.
        /// </summary>
        public const string TAFUTANON12 = "TAFUTANON12";
    }

    /// <inheritdoc />
    public override string TableName => "F986020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TAOBNM", "TAOBNM", JdeDataType.String, 20, true, true),
        new JdeField("TASBFATNM", "TASBFATNM", JdeDataType.String, 254, true, true),
        new JdeField("TASBFATPTH", "TASBFATPTH", JdeDataType.String, 2048, true, true),
        new JdeField("TASBFATSTS", "TASBFATSTS", JdeDataType.String, 6),
        new JdeField("TAFUTANON1", "TAFUTANON1", JdeDataType.String, 2),
        new JdeField("TAFUTANON2", "TAFUTANON2", JdeDataType.String, 2),
        new JdeField("TAFUTANON10", "TAFUTANON10", JdeDataType.String, 2),
        new JdeField("TAFUTANON11", "TAFUTANON11", JdeDataType.String, 2),
        new JdeField("TAFUTANON12", "TAFUTANON12", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F986020_0", "Primary Key on TAOBNM, TASBFATNM, TASBFATPTH", new[] { "TAOBNM", "TASBFATNM", "TASBFATPTH" }, isUnique: true, isPrimaryKey: true)
    };
}
