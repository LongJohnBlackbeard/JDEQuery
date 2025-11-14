using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06936 - .
/// </summary>
public class F06936 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JAAN8.
        /// </summary>
        public const string JAAN8 = "JAAN8";

        /// <summary>
        /// JAUN.
        /// </summary>
        public const string JAUN = "JAUN";

        /// <summary>
        /// JAMCU.
        /// </summary>
        public const string JAMCU = "JAMCU";

        /// <summary>
        /// JAPDBA.
        /// </summary>
        public const string JAPDBA = "JAPDBA";

        /// <summary>
        /// JASHFT.
        /// </summary>
        public const string JASHFT = "JASHFT";

        /// <summary>
        /// JAJBCD.
        /// </summary>
        public const string JAJBCD = "JAJBCD";

        /// <summary>
        /// JAJBST.
        /// </summary>
        public const string JAJBST = "JAJBST";

        /// <summary>
        /// JAEFTB.
        /// </summary>
        public const string JAEFTB = "JAEFTB";

        /// <summary>
        /// JAEFTE.
        /// </summary>
        public const string JAEFTE = "JAEFTE";

        /// <summary>
        /// JARTCN.
        /// </summary>
        public const string JARTCN = "JARTCN";

        /// <summary>
        /// JARTAM.
        /// </summary>
        public const string JARTAM = "JARTAM";

        /// <summary>
        /// JADEDM.
        /// </summary>
        public const string JADEDM = "JADEDM";

        /// <summary>
        /// JAPAYM.
        /// </summary>
        public const string JAPAYM = "JAPAYM";

        /// <summary>
        /// JAPHRT.
        /// </summary>
        public const string JAPHRT = "JAPHRT";

        /// <summary>
        /// JAPBRT.
        /// </summary>
        public const string JAPBRT = "JAPBRT";

        /// <summary>
        /// JAPPRT.
        /// </summary>
        public const string JAPPRT = "JAPPRT";

        /// <summary>
        /// JAUSER.
        /// </summary>
        public const string JAUSER = "JAUSER";

        /// <summary>
        /// JAPID.
        /// </summary>
        public const string JAPID = "JAPID";

        /// <summary>
        /// JAUPMJ.
        /// </summary>
        public const string JAUPMJ = "JAUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F06936";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JAAN8", "JAAN8", JdeDataType.Numeric),
        new JdeField("JAUN", "JAUN", JdeDataType.String, 12, true, true),
        new JdeField("JAMCU", "JAMCU", JdeDataType.String, 24),
        new JdeField("JAPDBA", "JAPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("JASHFT", "JASHFT", JdeDataType.String, 2),
        new JdeField("JAJBCD", "JAJBCD", JdeDataType.String, 12, true, true),
        new JdeField("JAJBST", "JAJBST", JdeDataType.String, 8, true, true),
        new JdeField("JAEFTB", "JAEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("JAEFTE", "JAEFTE", JdeDataType.Numeric),
        new JdeField("JARTCN", "JARTCN", JdeDataType.String, 2),
        new JdeField("JARTAM", "JARTAM", JdeDataType.Numeric),
        new JdeField("JADEDM", "JADEDM", JdeDataType.String, 2),
        new JdeField("JAPAYM", "JAPAYM", JdeDataType.Numeric),
        new JdeField("JAPHRT", "JAPHRT", JdeDataType.Numeric),
        new JdeField("JAPBRT", "JAPBRT", JdeDataType.Numeric),
        new JdeField("JAPPRT", "JAPPRT", JdeDataType.Numeric),
        new JdeField("JAUSER", "JAUSER", JdeDataType.String, 20),
        new JdeField("JAPID", "JAPID", JdeDataType.String, 20),
        new JdeField("JAUPMJ", "JAUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06936_0", "Primary Key on JAUN, JAJBCD, JAJBST, JAEFTB, JAPDBA", new[] { "JAUN", "JAJBCD", "JAJBST", "JAEFTB", "JAPDBA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06936_4", "Index on JAUN, JAEFTB, JAJBCD, JAJBST", new[] { "JAUN", "JAEFTB", "JAJBCD", "JAJBST" }),
        new JdeIndex("F06936_5", "Index on JAUN, JAJBCD, JAJBST, JAEFTB, JAAN8", new[] { "JAUN", "JAJBCD", "JAJBST", "JAEFTB", "JAAN8" }),
        new JdeIndex("F06936_6", "Index on JAUN, JAJBCD, JAJBST, JAEFTE", new[] { "JAUN", "JAJBCD", "JAJBST", "JAEFTE" }),
        new JdeIndex("F06936_7", "Index on JAUN, JAAN8, JAJBCD, JAJBST, JAEFTE", new[] { "JAUN", "JAAN8", "JAJBCD", "JAJBST", "JAEFTE" }),
        new JdeIndex("F06936_8", "Index on JAUN, JAPDBA, JAJBCD, JAJBST, JAEFTE", new[] { "JAUN", "JAPDBA", "JAJBCD", "JAJBST", "JAEFTE" }),
        new JdeIndex("F06936_9", "Index on JAUN, JAMCU, JASHFT, JAEFTB, JAJBCD, JAJBST", new[] { "JAUN", "JAMCU", "JASHFT", "JAEFTB", "JAJBCD", "JAJBST" })
    };
}
