using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15110B - .
/// </summary>
public class F15110B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OBICU.
        /// </summary>
        public const string OBICU = "OBICU";

        /// <summary>
        /// OBEPCL.
        /// </summary>
        public const string OBEPCL = "OBEPCL";

        /// <summary>
        /// OBAID.
        /// </summary>
        public const string OBAID = "OBAID";

        /// <summary>
        /// OBEFTB.
        /// </summary>
        public const string OBEFTB = "OBEFTB";

        /// <summary>
        /// OBEFTE.
        /// </summary>
        public const string OBEFTE = "OBEFTE";

        /// <summary>
        /// OBMCU.
        /// </summary>
        public const string OBMCU = "OBMCU";

        /// <summary>
        /// OBOBJ.
        /// </summary>
        public const string OBOBJ = "OBOBJ";

        /// <summary>
        /// OBSUB.
        /// </summary>
        public const string OBSUB = "OBSUB";

        /// <summary>
        /// OBDL01.
        /// </summary>
        public const string OBDL01 = "OBDL01";

        /// <summary>
        /// OBUSER.
        /// </summary>
        public const string OBUSER = "OBUSER";

        /// <summary>
        /// OBUPMJ.
        /// </summary>
        public const string OBUPMJ = "OBUPMJ";

        /// <summary>
        /// OBPID.
        /// </summary>
        public const string OBPID = "OBPID";

        /// <summary>
        /// OBJOBN.
        /// </summary>
        public const string OBJOBN = "OBJOBN";

        /// <summary>
        /// OBUPMT.
        /// </summary>
        public const string OBUPMT = "OBUPMT";

        /// <summary>
        /// OBDUP.
        /// </summary>
        public const string OBDUP = "OBDUP";

        /// <summary>
        /// OBSEQ.
        /// </summary>
        public const string OBSEQ = "OBSEQ";

        /// <summary>
        /// OBMCU2.
        /// </summary>
        public const string OBMCU2 = "OBMCU2";

        /// <summary>
        /// OBCRCD.
        /// </summary>
        public const string OBCRCD = "OBCRCD";
    }

    /// <inheritdoc />
    public override string TableName => "F15110B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OBICU", "OBICU", JdeDataType.Numeric, null, true, true),
        new JdeField("OBEPCL", "OBEPCL", JdeDataType.String, 8, true, true),
        new JdeField("OBAID", "OBAID", JdeDataType.String, 16, true, true),
        new JdeField("OBEFTB", "OBEFTB", JdeDataType.Numeric),
        new JdeField("OBEFTE", "OBEFTE", JdeDataType.Numeric),
        new JdeField("OBMCU", "OBMCU", JdeDataType.String, 24, true, true),
        new JdeField("OBOBJ", "OBOBJ", JdeDataType.String, 12),
        new JdeField("OBSUB", "OBSUB", JdeDataType.String, 16),
        new JdeField("OBDL01", "OBDL01", JdeDataType.String, 60),
        new JdeField("OBUSER", "OBUSER", JdeDataType.String, 20),
        new JdeField("OBUPMJ", "OBUPMJ", JdeDataType.Numeric),
        new JdeField("OBPID", "OBPID", JdeDataType.String, 20),
        new JdeField("OBJOBN", "OBJOBN", JdeDataType.String, 20),
        new JdeField("OBUPMT", "OBUPMT", JdeDataType.Numeric),
        new JdeField("OBDUP", "OBDUP", JdeDataType.String, 2),
        new JdeField("OBSEQ", "OBSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("OBMCU2", "OBMCU2", JdeDataType.String, 24, true, true),
        new JdeField("OBCRCD", "OBCRCD", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15110B_0", "Primary Key on OBICU, OBEPCL, OBMCU, OBAID, OBMCU2, OBSEQ", new[] { "OBICU", "OBEPCL", "OBMCU", "OBAID", "OBMCU2", "OBSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15110B_2", "Index on OBICU, OBEPCL, OBMCU, OBOBJ, OBSUB", new[] { "OBICU", "OBEPCL", "OBMCU", "OBOBJ", "OBSUB" }),
        new JdeIndex("F15110B_3", "Index on OBICU, OBEPCL, OBMCU2", new[] { "OBICU", "OBEPCL", "OBMCU2" })
    };
}
