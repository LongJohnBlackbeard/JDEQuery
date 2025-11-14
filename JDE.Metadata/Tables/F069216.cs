using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069216 - .
/// </summary>
public class F069216 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YBCO.
        /// </summary>
        public const string YBCO = "YBCO";

        /// <summary>
        /// YBTARA.
        /// </summary>
        public const string YBTARA = "YBTARA";

        /// <summary>
        /// YBEFTB.
        /// </summary>
        public const string YBEFTB = "YBEFTB";

        /// <summary>
        /// YBEFTE.
        /// </summary>
        public const string YBEFTE = "YBEFTE";

        /// <summary>
        /// YBWCPL.
        /// </summary>
        public const string YBWCPL = "YBWCPL";

        /// <summary>
        /// YBDEDM.
        /// </summary>
        public const string YBDEDM = "YBDEDM";

        /// <summary>
        /// YBWCMP.
        /// </summary>
        public const string YBWCMP = "YBWCMP";

        /// <summary>
        /// YBWCRT.
        /// </summary>
        public const string YBWCRT = "YBWCRT";

        /// <summary>
        /// YBWCLM.
        /// </summary>
        public const string YBWCLM = "YBWCLM";

        /// <summary>
        /// YBWCRG.
        /// </summary>
        public const string YBWCRG = "YBWCRG";

        /// <summary>
        /// YBWCLG.
        /// </summary>
        public const string YBWCLG = "YBWCLG";

        /// <summary>
        /// YBTBEX.
        /// </summary>
        public const string YBTBEX = "YBTBEX";

        /// <summary>
        /// YBUSER.
        /// </summary>
        public const string YBUSER = "YBUSER";

        /// <summary>
        /// YBPID.
        /// </summary>
        public const string YBPID = "YBPID";

        /// <summary>
        /// YBUPMJ.
        /// </summary>
        public const string YBUPMJ = "YBUPMJ";

        /// <summary>
        /// YBMCU.
        /// </summary>
        public const string YBMCU = "YBMCU";

        /// <summary>
        /// YBERW.
        /// </summary>
        public const string YBERW = "YBERW";

        /// <summary>
        /// YBWET.
        /// </summary>
        public const string YBWET = "YBWET";

        /// <summary>
        /// YBTRCC.
        /// </summary>
        public const string YBTRCC = "YBTRCC";
    }

    /// <inheritdoc />
    public override string TableName => "F069216";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YBCO", "YBCO", JdeDataType.String, 10, true, true),
        new JdeField("YBTARA", "YBTARA", JdeDataType.String, 20, true, true),
        new JdeField("YBEFTB", "YBEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("YBEFTE", "YBEFTE", JdeDataType.Numeric),
        new JdeField("YBWCPL", "YBWCPL", JdeDataType.String, 40),
        new JdeField("YBDEDM", "YBDEDM", JdeDataType.String, 2),
        new JdeField("YBWCMP", "YBWCMP", JdeDataType.String, 8, true, true),
        new JdeField("YBWCRT", "YBWCRT", JdeDataType.Numeric),
        new JdeField("YBWCLM", "YBWCLM", JdeDataType.Numeric),
        new JdeField("YBWCRG", "YBWCRG", JdeDataType.Numeric),
        new JdeField("YBWCLG", "YBWCLG", JdeDataType.Numeric),
        new JdeField("YBTBEX", "YBTBEX", JdeDataType.String, 6),
        new JdeField("YBUSER", "YBUSER", JdeDataType.String, 20),
        new JdeField("YBPID", "YBPID", JdeDataType.String, 20),
        new JdeField("YBUPMJ", "YBUPMJ", JdeDataType.Numeric),
        new JdeField("YBMCU", "YBMCU", JdeDataType.String, 24, true, true),
        new JdeField("YBERW", "YBERW", JdeDataType.Numeric),
        new JdeField("YBWET", "YBWET", JdeDataType.String, 2, true, true),
        new JdeField("YBTRCC", "YBTRCC", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069216_0", "Primary Key on YBTARA, YBCO, YBMCU, YBEFTB, YBWCMP, YBWET, YBTRCC", new[] { "YBTARA", "YBCO", "YBMCU", "YBEFTB", "YBWCMP", "YBWET", "YBTRCC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F069216_3", "Index on YBTARA, YBCO, YBMCU, YBWCMP, YBWET, YBEFTE, YBTRCC", new[] { "YBTARA", "YBCO", "YBMCU", "YBWCMP", "YBWET", "YBEFTE", "YBTRCC" })
    };
}
