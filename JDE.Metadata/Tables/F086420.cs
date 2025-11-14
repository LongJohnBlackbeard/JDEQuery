using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F086420 - .
/// </summary>
public class F086420 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EIESTB.
        /// </summary>
        public const string EIESTB = "EIESTB";

        /// <summary>
        /// EIESTTYP.
        /// </summary>
        public const string EIESTTYP = "EIESTTYP";

        /// <summary>
        /// EICO.
        /// </summary>
        public const string EICO = "EICO";

        /// <summary>
        /// EIOSHAC2.
        /// </summary>
        public const string EIOSHAC2 = "EIOSHAC2";

        /// <summary>
        /// EIOSHADT2.
        /// </summary>
        public const string EIOSHADT2 = "EIOSHADT2";

        /// <summary>
        /// EIOSHAMN2.
        /// </summary>
        public const string EIOSHAMN2 = "EIOSHAMN2";

        /// <summary>
        /// EIOSHASTR3.
        /// </summary>
        public const string EIOSHASTR3 = "EIOSHASTR3";

        /// <summary>
        /// EIOSHASTR4.
        /// </summary>
        public const string EIOSHASTR4 = "EIOSHASTR4";

        /// <summary>
        /// EIOSHAUC2.
        /// </summary>
        public const string EIOSHAUC2 = "EIOSHAUC2";

        /// <summary>
        /// EIOSHAUDT2.
        /// </summary>
        public const string EIOSHAUDT2 = "EIOSHAUDT2";

        /// <summary>
        /// EIOSHAUMN2.
        /// </summary>
        public const string EIOSHAUMN2 = "EIOSHAUMN2";

        /// <summary>
        /// EIOSHAUSTR3.
        /// </summary>
        public const string EIOSHAUSTR3 = "EIOSHAUSTR3";

        /// <summary>
        /// EIOSHAUSTR4.
        /// </summary>
        public const string EIOSHAUSTR4 = "EIOSHAUSTR4";

        /// <summary>
        /// EIJOBN.
        /// </summary>
        public const string EIJOBN = "EIJOBN";

        /// <summary>
        /// EIUPMJ.
        /// </summary>
        public const string EIUPMJ = "EIUPMJ";

        /// <summary>
        /// EIUPMT.
        /// </summary>
        public const string EIUPMT = "EIUPMT";

        /// <summary>
        /// EIUSER.
        /// </summary>
        public const string EIUSER = "EIUSER";

        /// <summary>
        /// EIPID.
        /// </summary>
        public const string EIPID = "EIPID";
    }

    /// <inheritdoc />
    public override string TableName => "F086420";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EIESTB", "EIESTB", JdeDataType.Numeric, null, true, true),
        new JdeField("EIESTTYP", "EIESTTYP", JdeDataType.String, 2),
        new JdeField("EICO", "EICO", JdeDataType.String, 10),
        new JdeField("EIOSHAC2", "EIOSHAC2", JdeDataType.String, 2),
        new JdeField("EIOSHADT2", "EIOSHADT2", JdeDataType.Numeric),
        new JdeField("EIOSHAMN2", "EIOSHAMN2", JdeDataType.Numeric),
        new JdeField("EIOSHASTR3", "EIOSHASTR3", JdeDataType.String, 60),
        new JdeField("EIOSHASTR4", "EIOSHASTR4", JdeDataType.String, 60),
        new JdeField("EIOSHAUC2", "EIOSHAUC2", JdeDataType.String, 2),
        new JdeField("EIOSHAUDT2", "EIOSHAUDT2", JdeDataType.Numeric),
        new JdeField("EIOSHAUMN2", "EIOSHAUMN2", JdeDataType.Numeric),
        new JdeField("EIOSHAUSTR3", "EIOSHAUSTR3", JdeDataType.String, 60),
        new JdeField("EIOSHAUSTR4", "EIOSHAUSTR4", JdeDataType.String, 60),
        new JdeField("EIJOBN", "EIJOBN", JdeDataType.String, 20),
        new JdeField("EIUPMJ", "EIUPMJ", JdeDataType.Numeric),
        new JdeField("EIUPMT", "EIUPMT", JdeDataType.Numeric),
        new JdeField("EIUSER", "EIUSER", JdeDataType.String, 20),
        new JdeField("EIPID", "EIPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F086420_0", "Primary Key on EIESTB", new[] { "EIESTB" }, isUnique: true, isPrimaryKey: true)
    };
}
