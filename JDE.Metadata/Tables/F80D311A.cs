using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D311A - .
/// </summary>
public class F80D311A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AJALERTINS.
        /// </summary>
        public const string AJALERTINS = "AJALERTINS";

        /// <summary>
        /// AJALERTDTE.
        /// </summary>
        public const string AJALERTDTE = "AJALERTDTE";

        /// <summary>
        /// AJSUBAN8.
        /// </summary>
        public const string AJSUBAN8 = "AJSUBAN8";

        /// <summary>
        /// AJALERTDET.
        /// </summary>
        public const string AJALERTDET = "AJALERTDET";

        /// <summary>
        /// AJURCD.
        /// </summary>
        public const string AJURCD = "AJURCD";

        /// <summary>
        /// AJURDT.
        /// </summary>
        public const string AJURDT = "AJURDT";

        /// <summary>
        /// AJURAT.
        /// </summary>
        public const string AJURAT = "AJURAT";

        /// <summary>
        /// AJURAB.
        /// </summary>
        public const string AJURAB = "AJURAB";

        /// <summary>
        /// AJURRF.
        /// </summary>
        public const string AJURRF = "AJURRF";

        /// <summary>
        /// AJUSER.
        /// </summary>
        public const string AJUSER = "AJUSER";

        /// <summary>
        /// AJMKEY.
        /// </summary>
        public const string AJMKEY = "AJMKEY";

        /// <summary>
        /// AJPID.
        /// </summary>
        public const string AJPID = "AJPID";

        /// <summary>
        /// AJUUPMJ.
        /// </summary>
        public const string AJUUPMJ = "AJUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D311A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AJALERTINS", "AJALERTINS", JdeDataType.Numeric, null, true, true),
        new JdeField("AJALERTDTE", "AJALERTDTE", JdeDataType.Numeric),
        new JdeField("AJSUBAN8", "AJSUBAN8", JdeDataType.Numeric),
        new JdeField("AJALERTDET", "AJALERTDET", JdeDataType.Numeric),
        new JdeField("AJURCD", "AJURCD", JdeDataType.String, 4),
        new JdeField("AJURDT", "AJURDT", JdeDataType.Numeric),
        new JdeField("AJURAT", "AJURAT", JdeDataType.Numeric),
        new JdeField("AJURAB", "AJURAB", JdeDataType.Numeric),
        new JdeField("AJURRF", "AJURRF", JdeDataType.String, 30),
        new JdeField("AJUSER", "AJUSER", JdeDataType.String, 20),
        new JdeField("AJMKEY", "AJMKEY", JdeDataType.String, 30),
        new JdeField("AJPID", "AJPID", JdeDataType.String, 20),
        new JdeField("AJUUPMJ", "AJUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D311A_0", "Primary Key on AJALERTINS", new[] { "AJALERTINS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F80D311A_2", "Index on AJALERTDET, AJALERTINS", new[] { "AJALERTDET", "AJALERTINS" })
    };
}
