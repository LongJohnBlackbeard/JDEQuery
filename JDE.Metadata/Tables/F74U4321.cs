using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U4321 - .
/// </summary>
public class F74U4321 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RADOCO.
        /// </summary>
        public const string RADOCO = "RADOCO";

        /// <summary>
        /// RAKCOO.
        /// </summary>
        public const string RAKCOO = "RAKCOO";

        /// <summary>
        /// RADCTO.
        /// </summary>
        public const string RADCTO = "RADCTO";

        /// <summary>
        /// RA74U43AK1.
        /// </summary>
        public const string RA74U43AK1 = "RA74U43AK1";

        /// <summary>
        /// RA74U43SQ1.
        /// </summary>
        public const string RA74U43SQ1 = "RA74U43SQ1";

        /// <summary>
        /// RA74U43TV1.
        /// </summary>
        public const string RA74U43TV1 = "RA74U43TV1";

        /// <summary>
        /// RAAN81.
        /// </summary>
        public const string RAAN81 = "RAAN81";

        /// <summary>
        /// RAEFTS.
        /// </summary>
        public const string RAEFTS = "RAEFTS";

        /// <summary>
        /// RAEFFT.
        /// </summary>
        public const string RAEFFT = "RAEFFT";

        /// <summary>
        /// RA74U43RQ1.
        /// </summary>
        public const string RA74U43RQ1 = "RA74U43RQ1";

        /// <summary>
        /// RA74U43RA1.
        /// </summary>
        public const string RA74U43RA1 = "RA74U43RA1";

        /// <summary>
        /// RAUSER.
        /// </summary>
        public const string RAUSER = "RAUSER";

        /// <summary>
        /// RAPID.
        /// </summary>
        public const string RAPID = "RAPID";

        /// <summary>
        /// RAJOBN.
        /// </summary>
        public const string RAJOBN = "RAJOBN";

        /// <summary>
        /// RAUPMJ.
        /// </summary>
        public const string RAUPMJ = "RAUPMJ";

        /// <summary>
        /// RAUPMT.
        /// </summary>
        public const string RAUPMT = "RAUPMT";

        /// <summary>
        /// RAAN82.
        /// </summary>
        public const string RAAN82 = "RAAN82";

        /// <summary>
        /// RADATE01.
        /// </summary>
        public const string RADATE01 = "RADATE01";

        /// <summary>
        /// RADATE02.
        /// </summary>
        public const string RADATE02 = "RADATE02";

        /// <summary>
        /// RANA1.
        /// </summary>
        public const string RANA1 = "RANA1";

        /// <summary>
        /// RANA2.
        /// </summary>
        public const string RANA2 = "RANA2";

        /// <summary>
        /// RANA3.
        /// </summary>
        public const string RANA3 = "RANA3";
    }

    /// <inheritdoc />
    public override string TableName => "F74U4321";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RADOCO", "RADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RAKCOO", "RAKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RADCTO", "RADCTO", JdeDataType.String, 4, true, true),
        new JdeField("RA74U43AK1", "RA74U43AK1", JdeDataType.String, 20, true, true),
        new JdeField("RA74U43SQ1", "RA74U43SQ1", JdeDataType.Numeric),
        new JdeField("RA74U43TV1", "RA74U43TV1", JdeDataType.String, 20),
        new JdeField("RAAN81", "RAAN81", JdeDataType.Numeric),
        new JdeField("RAEFTS", "RAEFTS", JdeDataType.Numeric),
        new JdeField("RAEFFT", "RAEFFT", JdeDataType.Numeric),
        new JdeField("RA74U43RQ1", "RA74U43RQ1", JdeDataType.String, 480),
        new JdeField("RA74U43RA1", "RA74U43RA1", JdeDataType.String, 480),
        new JdeField("RAUSER", "RAUSER", JdeDataType.String, 20),
        new JdeField("RAPID", "RAPID", JdeDataType.String, 20),
        new JdeField("RAJOBN", "RAJOBN", JdeDataType.String, 20),
        new JdeField("RAUPMJ", "RAUPMJ", JdeDataType.Numeric),
        new JdeField("RAUPMT", "RAUPMT", JdeDataType.Numeric),
        new JdeField("RAAN82", "RAAN82", JdeDataType.Numeric),
        new JdeField("RADATE01", "RADATE01", JdeDataType.Numeric),
        new JdeField("RADATE02", "RADATE02", JdeDataType.Numeric),
        new JdeField("RANA1", "RANA1", JdeDataType.Numeric),
        new JdeField("RANA2", "RANA2", JdeDataType.Numeric),
        new JdeField("RANA3", "RANA3", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U4321_0", "Primary Key on RADOCO, RAKCOO, RADCTO, RA74U43AK1", new[] { "RADOCO", "RAKCOO", "RADCTO", "RA74U43AK1" }, isUnique: true, isPrimaryKey: true)
    };
}
