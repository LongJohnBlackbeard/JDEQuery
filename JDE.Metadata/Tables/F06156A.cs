using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06156A - .
/// </summary>
public class F06156A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YUAN8.
        /// </summary>
        public const string YUAN8 = "YUAN8";

        /// <summary>
        /// YUCKCN.
        /// </summary>
        public const string YUCKCN = "YUCKCN";

        /// <summary>
        /// YUICC.
        /// </summary>
        public const string YUICC = "YUICC";

        /// <summary>
        /// YUSCKC.
        /// </summary>
        public const string YUSCKC = "YUSCKC";

        /// <summary>
        /// YUEFTB.
        /// </summary>
        public const string YUEFTB = "YUEFTB";

        /// <summary>
        /// YUEFTE.
        /// </summary>
        public const string YUEFTE = "YUEFTE";

        /// <summary>
        /// YUSPARES1.
        /// </summary>
        public const string YUSPARES1 = "YUSPARES1";

        /// <summary>
        /// YUSPARES2.
        /// </summary>
        public const string YUSPARES2 = "YUSPARES2";

        /// <summary>
        /// YUSPARES3.
        /// </summary>
        public const string YUSPARES3 = "YUSPARES3";

        /// <summary>
        /// YUSPARES4.
        /// </summary>
        public const string YUSPARES4 = "YUSPARES4";

        /// <summary>
        /// YUSPAREC1.
        /// </summary>
        public const string YUSPAREC1 = "YUSPAREC1";

        /// <summary>
        /// YUSPAREC2.
        /// </summary>
        public const string YUSPAREC2 = "YUSPAREC2";

        /// <summary>
        /// YUSPAREC3.
        /// </summary>
        public const string YUSPAREC3 = "YUSPAREC3";

        /// <summary>
        /// YUSPAREC4.
        /// </summary>
        public const string YUSPAREC4 = "YUSPAREC4";

        /// <summary>
        /// YUSPAREN1.
        /// </summary>
        public const string YUSPAREN1 = "YUSPAREN1";

        /// <summary>
        /// YUSPAREN2.
        /// </summary>
        public const string YUSPAREN2 = "YUSPAREN2";

        /// <summary>
        /// YUSPAREN3.
        /// </summary>
        public const string YUSPAREN3 = "YUSPAREN3";

        /// <summary>
        /// YUSPAREN4.
        /// </summary>
        public const string YUSPAREN4 = "YUSPAREN4";

        /// <summary>
        /// YUSPARED1.
        /// </summary>
        public const string YUSPARED1 = "YUSPARED1";

        /// <summary>
        /// YUSPARED2.
        /// </summary>
        public const string YUSPARED2 = "YUSPARED2";

        /// <summary>
        /// YUSPARED3.
        /// </summary>
        public const string YUSPARED3 = "YUSPARED3";

        /// <summary>
        /// YUSPARED4.
        /// </summary>
        public const string YUSPARED4 = "YUSPARED4";

        /// <summary>
        /// YUPID.
        /// </summary>
        public const string YUPID = "YUPID";

        /// <summary>
        /// YUUSER.
        /// </summary>
        public const string YUUSER = "YUUSER";

        /// <summary>
        /// YUJOBN.
        /// </summary>
        public const string YUJOBN = "YUJOBN";

        /// <summary>
        /// YUUPMJ.
        /// </summary>
        public const string YUUPMJ = "YUUPMJ";

        /// <summary>
        /// YUUPMT.
        /// </summary>
        public const string YUUPMT = "YUUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F06156A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YUAN8", "YUAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YUCKCN", "YUCKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("YUICC", "YUICC", JdeDataType.String, 2, true, true),
        new JdeField("YUSCKC", "YUSCKC", JdeDataType.Numeric, null, true, true),
        new JdeField("YUEFTB", "YUEFTB", JdeDataType.Numeric),
        new JdeField("YUEFTE", "YUEFTE", JdeDataType.Numeric),
        new JdeField("YUSPARES1", "YUSPARES1", JdeDataType.String, 60),
        new JdeField("YUSPARES2", "YUSPARES2", JdeDataType.String, 60),
        new JdeField("YUSPARES3", "YUSPARES3", JdeDataType.String, 60),
        new JdeField("YUSPARES4", "YUSPARES4", JdeDataType.String, 60),
        new JdeField("YUSPAREC1", "YUSPAREC1", JdeDataType.String, 2),
        new JdeField("YUSPAREC2", "YUSPAREC2", JdeDataType.String, 2),
        new JdeField("YUSPAREC3", "YUSPAREC3", JdeDataType.String, 2),
        new JdeField("YUSPAREC4", "YUSPAREC4", JdeDataType.String, 2),
        new JdeField("YUSPAREN1", "YUSPAREN1", JdeDataType.Numeric),
        new JdeField("YUSPAREN2", "YUSPAREN2", JdeDataType.Numeric),
        new JdeField("YUSPAREN3", "YUSPAREN3", JdeDataType.Numeric),
        new JdeField("YUSPAREN4", "YUSPAREN4", JdeDataType.Numeric),
        new JdeField("YUSPARED1", "YUSPARED1", JdeDataType.Numeric),
        new JdeField("YUSPARED2", "YUSPARED2", JdeDataType.Numeric),
        new JdeField("YUSPARED3", "YUSPARED3", JdeDataType.Numeric),
        new JdeField("YUSPARED4", "YUSPARED4", JdeDataType.Numeric),
        new JdeField("YUPID", "YUPID", JdeDataType.String, 20),
        new JdeField("YUUSER", "YUUSER", JdeDataType.String, 20),
        new JdeField("YUJOBN", "YUJOBN", JdeDataType.String, 20),
        new JdeField("YUUPMJ", "YUUPMJ", JdeDataType.Numeric),
        new JdeField("YUUPMT", "YUUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06156A_0", "Primary Key on YUAN8, YUCKCN, YUICC, YUSCKC", new[] { "YUAN8", "YUCKCN", "YUICC", "YUSCKC" }, isUnique: true, isPrimaryKey: true)
    };
}
