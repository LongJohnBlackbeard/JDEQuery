using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F060146 - .
/// </summary>
public class F060146 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JIAN8.
        /// </summary>
        public const string JIAN8 = "JIAN8";

        /// <summary>
        /// JIMCU.
        /// </summary>
        public const string JIMCU = "JIMCU";

        /// <summary>
        /// JIUN.
        /// </summary>
        public const string JIUN = "JIUN";

        /// <summary>
        /// JIJBCD.
        /// </summary>
        public const string JIJBCD = "JIJBCD";

        /// <summary>
        /// JIJBST.
        /// </summary>
        public const string JIJBST = "JIJBST";

        /// <summary>
        /// JIPHRT.
        /// </summary>
        public const string JIPHRT = "JIPHRT";

        /// <summary>
        /// JILOBJ.
        /// </summary>
        public const string JILOBJ = "JILOBJ";

        /// <summary>
        /// JIEFTB.
        /// </summary>
        public const string JIEFTB = "JIEFTB";

        /// <summary>
        /// JIEFTE.
        /// </summary>
        public const string JIEFTE = "JIEFTE";

        /// <summary>
        /// JIPBRT.
        /// </summary>
        public const string JIPBRT = "JIPBRT";

        /// <summary>
        /// JIPPRT.
        /// </summary>
        public const string JIPPRT = "JIPPRT";

        /// <summary>
        /// JIBDRT.
        /// </summary>
        public const string JIBDRT = "JIBDRT";

        /// <summary>
        /// JIB2RT.
        /// </summary>
        public const string JIB2RT = "JIB2RT";
    }

    /// <inheritdoc />
    public override string TableName => "F060146";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JIAN8", "JIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JIMCU", "JIMCU", JdeDataType.String, 24, true, true),
        new JdeField("JIUN", "JIUN", JdeDataType.String, 12, true, true),
        new JdeField("JIJBCD", "JIJBCD", JdeDataType.String, 12, true, true),
        new JdeField("JIJBST", "JIJBST", JdeDataType.String, 8, true, true),
        new JdeField("JIPHRT", "JIPHRT", JdeDataType.Numeric),
        new JdeField("JILOBJ", "JILOBJ", JdeDataType.String, 12),
        new JdeField("JIEFTB", "JIEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("JIEFTE", "JIEFTE", JdeDataType.Numeric),
        new JdeField("JIPBRT", "JIPBRT", JdeDataType.Numeric),
        new JdeField("JIPPRT", "JIPPRT", JdeDataType.Numeric),
        new JdeField("JIBDRT", "JIBDRT", JdeDataType.Numeric),
        new JdeField("JIB2RT", "JIB2RT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F060146_0", "Primary Key on JIAN8, JIMCU, JIUN, JIEFTB, JIJBCD, JIJBST", new[] { "JIAN8", "JIMCU", "JIUN", "JIEFTB", "JIJBCD", "JIJBST" }, isUnique: true, isPrimaryKey: true)
    };
}
