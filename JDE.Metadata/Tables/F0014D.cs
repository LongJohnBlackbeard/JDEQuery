using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0014D - .
/// </summary>
public class F0014D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PAPTC.
        /// </summary>
        public const string PAPTC = "PAPTC";

        /// <summary>
        /// PAPTD.
        /// </summary>
        public const string PAPTD = "PAPTD";

        /// <summary>
        /// PALNGP.
        /// </summary>
        public const string PALNGP = "PALNGP";

        /// <summary>
        /// PAUSER.
        /// </summary>
        public const string PAUSER = "PAUSER";

        /// <summary>
        /// PAUPMJ.
        /// </summary>
        public const string PAUPMJ = "PAUPMJ";

        /// <summary>
        /// PAUPMT.
        /// </summary>
        public const string PAUPMT = "PAUPMT";

        /// <summary>
        /// PAJOBN.
        /// </summary>
        public const string PAJOBN = "PAJOBN";

        /// <summary>
        /// PAPID.
        /// </summary>
        public const string PAPID = "PAPID";

        /// <summary>
        /// PAFUMATH1.
        /// </summary>
        public const string PAFUMATH1 = "PAFUMATH1";

        /// <summary>
        /// PAFUDATE1.
        /// </summary>
        public const string PAFUDATE1 = "PAFUDATE1";

        /// <summary>
        /// PAFTCHAR1.
        /// </summary>
        public const string PAFTCHAR1 = "PAFTCHAR1";

        /// <summary>
        /// PAFUTUSTR1.
        /// </summary>
        public const string PAFUTUSTR1 = "PAFUTUSTR1";
    }

    /// <inheritdoc />
    public override string TableName => "F0014D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PAPTC", "PAPTC", JdeDataType.String, 6, true, true),
        new JdeField("PAPTD", "PAPTD", JdeDataType.String, 60),
        new JdeField("PALNGP", "PALNGP", JdeDataType.String, 4, true, true),
        new JdeField("PAUSER", "PAUSER", JdeDataType.String, 20),
        new JdeField("PAUPMJ", "PAUPMJ", JdeDataType.Numeric),
        new JdeField("PAUPMT", "PAUPMT", JdeDataType.Numeric),
        new JdeField("PAJOBN", "PAJOBN", JdeDataType.String, 20),
        new JdeField("PAPID", "PAPID", JdeDataType.String, 20),
        new JdeField("PAFUMATH1", "PAFUMATH1", JdeDataType.Numeric),
        new JdeField("PAFUDATE1", "PAFUDATE1", JdeDataType.Numeric),
        new JdeField("PAFTCHAR1", "PAFTCHAR1", JdeDataType.String, 2),
        new JdeField("PAFUTUSTR1", "PAFUTUSTR1", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0014D_0", "Primary Key on PAPTC, PALNGP", new[] { "PAPTC", "PALNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
