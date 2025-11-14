using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F490052 - .
/// </summary>
public class F490052 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YGCARS.
        /// </summary>
        public const string YGCARS = "YGCARS";

        /// <summary>
        /// YGVMCU.
        /// </summary>
        public const string YGVMCU = "YGVMCU";

        /// <summary>
        /// YGDCCD.
        /// </summary>
        public const string YGDCCD = "YGDCCD";

        /// <summary>
        /// YGEFTJ.
        /// </summary>
        public const string YGEFTJ = "YGEFTJ";

        /// <summary>
        /// YGEXDJ.
        /// </summary>
        public const string YGEXDJ = "YGEXDJ";

        /// <summary>
        /// YGTNN1.
        /// </summary>
        public const string YGTNN1 = "YGTNN1";

        /// <summary>
        /// YGTNN2.
        /// </summary>
        public const string YGTNN2 = "YGTNN2";

        /// <summary>
        /// YGTNN3.
        /// </summary>
        public const string YGTNN3 = "YGTNN3";

        /// <summary>
        /// YGURCD.
        /// </summary>
        public const string YGURCD = "YGURCD";

        /// <summary>
        /// YGURDT.
        /// </summary>
        public const string YGURDT = "YGURDT";

        /// <summary>
        /// YGURAT.
        /// </summary>
        public const string YGURAT = "YGURAT";

        /// <summary>
        /// YGURAB.
        /// </summary>
        public const string YGURAB = "YGURAB";

        /// <summary>
        /// YGURRF.
        /// </summary>
        public const string YGURRF = "YGURRF";

        /// <summary>
        /// YGUSER.
        /// </summary>
        public const string YGUSER = "YGUSER";

        /// <summary>
        /// YGPID.
        /// </summary>
        public const string YGPID = "YGPID";

        /// <summary>
        /// YGJOBN.
        /// </summary>
        public const string YGJOBN = "YGJOBN";

        /// <summary>
        /// YGUPMJ.
        /// </summary>
        public const string YGUPMJ = "YGUPMJ";

        /// <summary>
        /// YGTDAY.
        /// </summary>
        public const string YGTDAY = "YGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F490052";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YGCARS", "YGCARS", JdeDataType.Numeric, null, true, true),
        new JdeField("YGVMCU", "YGVMCU", JdeDataType.String, 24, true, true),
        new JdeField("YGDCCD", "YGDCCD", JdeDataType.String, 8, true, true),
        new JdeField("YGEFTJ", "YGEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("YGEXDJ", "YGEXDJ", JdeDataType.Numeric),
        new JdeField("YGTNN1", "YGTNN1", JdeDataType.Numeric),
        new JdeField("YGTNN2", "YGTNN2", JdeDataType.Numeric),
        new JdeField("YGTNN3", "YGTNN3", JdeDataType.Numeric),
        new JdeField("YGURCD", "YGURCD", JdeDataType.String, 4),
        new JdeField("YGURDT", "YGURDT", JdeDataType.Numeric),
        new JdeField("YGURAT", "YGURAT", JdeDataType.Numeric),
        new JdeField("YGURAB", "YGURAB", JdeDataType.Numeric),
        new JdeField("YGURRF", "YGURRF", JdeDataType.String, 30),
        new JdeField("YGUSER", "YGUSER", JdeDataType.String, 20),
        new JdeField("YGPID", "YGPID", JdeDataType.String, 20),
        new JdeField("YGJOBN", "YGJOBN", JdeDataType.String, 20),
        new JdeField("YGUPMJ", "YGUPMJ", JdeDataType.Numeric),
        new JdeField("YGTDAY", "YGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F490052_0", "Primary Key on YGCARS, YGVMCU, YGDCCD, YGEFTJ", new[] { "YGCARS", "YGVMCU", "YGDCCD", "YGEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
