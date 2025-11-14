using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D255 - .
/// </summary>
public class F80D255 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OPPRDJ.
        /// </summary>
        public const string OPPRDJ = "OPPRDJ";

        /// <summary>
        /// OPMCU.
        /// </summary>
        public const string OPMCU = "OPMCU";

        /// <summary>
        /// OPAAOV.
        /// </summary>
        public const string OPAAOV = "OPAAOV";

        /// <summary>
        /// OPAAOVPD.
        /// </summary>
        public const string OPAAOVPD = "OPAAOVPD";

        /// <summary>
        /// OPACOV.
        /// </summary>
        public const string OPACOV = "OPACOV";

        /// <summary>
        /// OPACOVPD.
        /// </summary>
        public const string OPACOVPD = "OPACOVPD";

        /// <summary>
        /// OPUSER.
        /// </summary>
        public const string OPUSER = "OPUSER";

        /// <summary>
        /// OPPID.
        /// </summary>
        public const string OPPID = "OPPID";

        /// <summary>
        /// OPMKEY.
        /// </summary>
        public const string OPMKEY = "OPMKEY";

        /// <summary>
        /// OPUTIME.
        /// </summary>
        public const string OPUTIME = "OPUTIME";

        /// <summary>
        /// OPURCD.
        /// </summary>
        public const string OPURCD = "OPURCD";

        /// <summary>
        /// OPURDT.
        /// </summary>
        public const string OPURDT = "OPURDT";

        /// <summary>
        /// OPURAT.
        /// </summary>
        public const string OPURAT = "OPURAT";

        /// <summary>
        /// OPURAB.
        /// </summary>
        public const string OPURAB = "OPURAB";

        /// <summary>
        /// OPURRF.
        /// </summary>
        public const string OPURRF = "OPURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D255";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OPPRDJ", "OPPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("OPMCU", "OPMCU", JdeDataType.String, 24, true, true),
        new JdeField("OPAAOV", "OPAAOV", JdeDataType.Numeric),
        new JdeField("OPAAOVPD", "OPAAOVPD", JdeDataType.Numeric),
        new JdeField("OPACOV", "OPACOV", JdeDataType.Numeric),
        new JdeField("OPACOVPD", "OPACOVPD", JdeDataType.Numeric),
        new JdeField("OPUSER", "OPUSER", JdeDataType.String, 20),
        new JdeField("OPPID", "OPPID", JdeDataType.String, 20),
        new JdeField("OPMKEY", "OPMKEY", JdeDataType.String, 30),
        new JdeField("OPUTIME", "OPUTIME", JdeDataType.Date),
        new JdeField("OPURCD", "OPURCD", JdeDataType.String, 4),
        new JdeField("OPURDT", "OPURDT", JdeDataType.Numeric),
        new JdeField("OPURAT", "OPURAT", JdeDataType.Numeric),
        new JdeField("OPURAB", "OPURAB", JdeDataType.Numeric),
        new JdeField("OPURRF", "OPURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D255_0", "Primary Key on OPPRDJ, OPMCU", new[] { "OPPRDJ", "OPMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
