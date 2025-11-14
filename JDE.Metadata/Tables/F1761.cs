using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1761 - .
/// </summary>
public class F1761 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZAISNO.
        /// </summary>
        public const string ZAISNO = "ZAISNO";

        /// <summary>
        /// ZAANC.
        /// </summary>
        public const string ZAANC = "ZAANC";

        /// <summary>
        /// ZAAN8CT1.
        /// </summary>
        public const string ZAAN8CT1 = "ZAAN8CT1";

        /// <summary>
        /// ZAWHO1.
        /// </summary>
        public const string ZAWHO1 = "ZAWHO1";

        /// <summary>
        /// ZAAR2.
        /// </summary>
        public const string ZAAR2 = "ZAAR2";

        /// <summary>
        /// ZACPHC1.
        /// </summary>
        public const string ZACPHC1 = "ZACPHC1";

        /// <summary>
        /// ZACEML1.
        /// </summary>
        public const string ZACEML1 = "ZACEML1";

        /// <summary>
        /// ZAEFTB.
        /// </summary>
        public const string ZAEFTB = "ZAEFTB";

        /// <summary>
        /// ZAPBTM.
        /// </summary>
        public const string ZAPBTM = "ZAPBTM";

        /// <summary>
        /// ZAISSUE.
        /// </summary>
        public const string ZAISSUE = "ZAISSUE";

        /// <summary>
        /// ZAINRT.
        /// </summary>
        public const string ZAINRT = "ZAINRT";

        /// <summary>
        /// ZADX.
        /// </summary>
        public const string ZADX = "ZADX";

        /// <summary>
        /// ZAEND.
        /// </summary>
        public const string ZAEND = "ZAEND";

        /// <summary>
        /// ZAPETM.
        /// </summary>
        public const string ZAPETM = "ZAPETM";

        /// <summary>
        /// ZAWHO2.
        /// </summary>
        public const string ZAWHO2 = "ZAWHO2";

        /// <summary>
        /// ZAWHO3.
        /// </summary>
        public const string ZAWHO3 = "ZAWHO3";

        /// <summary>
        /// ZAPH1.
        /// </summary>
        public const string ZAPH1 = "ZAPH1";

        /// <summary>
        /// ZAREM1.
        /// </summary>
        public const string ZAREM1 = "ZAREM1";

        /// <summary>
        /// ZAAR1.
        /// </summary>
        public const string ZAAR1 = "ZAAR1";

        /// <summary>
        /// ZAPRIOR.
        /// </summary>
        public const string ZAPRIOR = "ZAPRIOR";

        /// <summary>
        /// ZACALLRN.
        /// </summary>
        public const string ZACALLRN = "ZACALLRN";

        /// <summary>
        /// ZAPRODF.
        /// </summary>
        public const string ZAPRODF = "ZAPRODF";

        /// <summary>
        /// ZAPRODM.
        /// </summary>
        public const string ZAPRODM = "ZAPRODM";

        /// <summary>
        /// ZASERK.
        /// </summary>
        public const string ZASERK = "ZASERK";
    }

    /// <inheritdoc />
    public override string TableName => "F1761";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZAISNO", "ZAISNO", JdeDataType.Numeric, null, true, true),
        new JdeField("ZAANC", "ZAANC", JdeDataType.Numeric),
        new JdeField("ZAAN8CT1", "ZAAN8CT1", JdeDataType.Numeric),
        new JdeField("ZAWHO1", "ZAWHO1", JdeDataType.String, 80),
        new JdeField("ZAAR2", "ZAAR2", JdeDataType.String, 12),
        new JdeField("ZACPHC1", "ZACPHC1", JdeDataType.String, 40),
        new JdeField("ZACEML1", "ZACEML1", JdeDataType.String, 80),
        new JdeField("ZAEFTB", "ZAEFTB", JdeDataType.Numeric),
        new JdeField("ZAPBTM", "ZAPBTM", JdeDataType.Numeric),
        new JdeField("ZAISSUE", "ZAISSUE", JdeDataType.String, 160),
        new JdeField("ZAINRT", "ZAINRT", JdeDataType.Numeric),
        new JdeField("ZADX", "ZADX", JdeDataType.Numeric),
        new JdeField("ZAEND", "ZAEND", JdeDataType.Numeric),
        new JdeField("ZAPETM", "ZAPETM", JdeDataType.Numeric),
        new JdeField("ZAWHO2", "ZAWHO2", JdeDataType.String, 80),
        new JdeField("ZAWHO3", "ZAWHO3", JdeDataType.String, 80),
        new JdeField("ZAPH1", "ZAPH1", JdeDataType.String, 40),
        new JdeField("ZAREM1", "ZAREM1", JdeDataType.String, 80),
        new JdeField("ZAAR1", "ZAAR1", JdeDataType.String, 12),
        new JdeField("ZAPRIOR", "ZAPRIOR", JdeDataType.String, 4),
        new JdeField("ZACALLRN", "ZACALLRN", JdeDataType.String, 6),
        new JdeField("ZAPRODF", "ZAPRODF", JdeDataType.String, 16),
        new JdeField("ZAPRODM", "ZAPRODM", JdeDataType.String, 16),
        new JdeField("ZASERK", "ZASERK", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1761_0", "Primary Key on ZAISNO", new[] { "ZAISNO" }, isUnique: true, isPrimaryKey: true)
    };
}
