using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30161 - .
/// </summary>
public class F30161 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KDKID1.
        /// </summary>
        public const string KDKID1 = "KDKID1";

        /// <summary>
        /// KDCDN.
        /// </summary>
        public const string KDCDN = "KDCDN";

        /// <summary>
        /// KDKBST.
        /// </summary>
        public const string KDKBST = "KDKBST";

        /// <summary>
        /// KDURCD.
        /// </summary>
        public const string KDURCD = "KDURCD";

        /// <summary>
        /// KDURDT.
        /// </summary>
        public const string KDURDT = "KDURDT";

        /// <summary>
        /// KDURAT.
        /// </summary>
        public const string KDURAT = "KDURAT";

        /// <summary>
        /// KDURAB.
        /// </summary>
        public const string KDURAB = "KDURAB";

        /// <summary>
        /// KDURRF.
        /// </summary>
        public const string KDURRF = "KDURRF";

        /// <summary>
        /// KDTRQT.
        /// </summary>
        public const string KDTRQT = "KDTRQT";

        /// <summary>
        /// KDUSER.
        /// </summary>
        public const string KDUSER = "KDUSER";

        /// <summary>
        /// KDPID.
        /// </summary>
        public const string KDPID = "KDPID";

        /// <summary>
        /// KDJOBN.
        /// </summary>
        public const string KDJOBN = "KDJOBN";

        /// <summary>
        /// KDUPMJ.
        /// </summary>
        public const string KDUPMJ = "KDUPMJ";

        /// <summary>
        /// KDTDAY.
        /// </summary>
        public const string KDTDAY = "KDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F30161";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KDKID1", "KDKID1", JdeDataType.Numeric, null, true, true),
        new JdeField("KDCDN", "KDCDN", JdeDataType.Numeric, null, true, true),
        new JdeField("KDKBST", "KDKBST", JdeDataType.String, 2),
        new JdeField("KDURCD", "KDURCD", JdeDataType.String, 4),
        new JdeField("KDURDT", "KDURDT", JdeDataType.Numeric),
        new JdeField("KDURAT", "KDURAT", JdeDataType.Numeric),
        new JdeField("KDURAB", "KDURAB", JdeDataType.Numeric),
        new JdeField("KDURRF", "KDURRF", JdeDataType.String, 30),
        new JdeField("KDTRQT", "KDTRQT", JdeDataType.Numeric),
        new JdeField("KDUSER", "KDUSER", JdeDataType.String, 20),
        new JdeField("KDPID", "KDPID", JdeDataType.String, 20),
        new JdeField("KDJOBN", "KDJOBN", JdeDataType.String, 20),
        new JdeField("KDUPMJ", "KDUPMJ", JdeDataType.Numeric),
        new JdeField("KDTDAY", "KDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30161_0", "Primary Key on KDKID1, KDCDN", new[] { "KDKID1", "KDCDN" }, isUnique: true, isPrimaryKey: true)
    };
}
