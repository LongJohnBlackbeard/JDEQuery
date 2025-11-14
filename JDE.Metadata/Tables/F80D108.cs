using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D108 - .
/// </summary>
public class F80D108 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GKMETRIC.
        /// </summary>
        public const string GKMETRIC = "GKMETRIC";

        /// <summary>
        /// GKGDD1.
        /// </summary>
        public const string GKGDD1 = "GKGDD1";

        /// <summary>
        /// GKGDD2.
        /// </summary>
        public const string GKGDD2 = "GKGDD2";

        /// <summary>
        /// GKGDD3.
        /// </summary>
        public const string GKGDD3 = "GKGDD3";

        /// <summary>
        /// GKGDD4.
        /// </summary>
        public const string GKGDD4 = "GKGDD4";

        /// <summary>
        /// GKGDD5.
        /// </summary>
        public const string GKGDD5 = "GKGDD5";

        /// <summary>
        /// GKGDD6.
        /// </summary>
        public const string GKGDD6 = "GKGDD6";

        /// <summary>
        /// GKUSER.
        /// </summary>
        public const string GKUSER = "GKUSER";

        /// <summary>
        /// GKPID.
        /// </summary>
        public const string GKPID = "GKPID";

        /// <summary>
        /// GKMKEY.
        /// </summary>
        public const string GKMKEY = "GKMKEY";

        /// <summary>
        /// GKUUPMJ.
        /// </summary>
        public const string GKUUPMJ = "GKUUPMJ";

        /// <summary>
        /// GKURCD.
        /// </summary>
        public const string GKURCD = "GKURCD";

        /// <summary>
        /// GKURDT.
        /// </summary>
        public const string GKURDT = "GKURDT";

        /// <summary>
        /// GKURAT.
        /// </summary>
        public const string GKURAT = "GKURAT";

        /// <summary>
        /// GKURAB.
        /// </summary>
        public const string GKURAB = "GKURAB";

        /// <summary>
        /// GKURRF.
        /// </summary>
        public const string GKURRF = "GKURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D108";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GKMETRIC", "GKMETRIC", JdeDataType.Numeric, null, true, true),
        new JdeField("GKGDD1", "GKGDD1", JdeDataType.String, 30),
        new JdeField("GKGDD2", "GKGDD2", JdeDataType.String, 30),
        new JdeField("GKGDD3", "GKGDD3", JdeDataType.String, 30),
        new JdeField("GKGDD4", "GKGDD4", JdeDataType.String, 30),
        new JdeField("GKGDD5", "GKGDD5", JdeDataType.String, 30),
        new JdeField("GKGDD6", "GKGDD6", JdeDataType.String, 30),
        new JdeField("GKUSER", "GKUSER", JdeDataType.String, 20),
        new JdeField("GKPID", "GKPID", JdeDataType.String, 20),
        new JdeField("GKMKEY", "GKMKEY", JdeDataType.String, 30),
        new JdeField("GKUUPMJ", "GKUUPMJ", JdeDataType.Date),
        new JdeField("GKURCD", "GKURCD", JdeDataType.String, 4),
        new JdeField("GKURDT", "GKURDT", JdeDataType.Numeric),
        new JdeField("GKURAT", "GKURAT", JdeDataType.Numeric),
        new JdeField("GKURAB", "GKURAB", JdeDataType.Numeric),
        new JdeField("GKURRF", "GKURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D108_0", "Primary Key on GKMETRIC", new[] { "GKMETRIC" }, isUnique: true, isPrimaryKey: true)
    };
}
