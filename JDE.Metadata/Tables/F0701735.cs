using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0701735 - .
/// </summary>
public class F0701735 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YCTARA.
        /// </summary>
        public const string YCTARA = "YCTARA";

        /// <summary>
        /// YCPTAX.
        /// </summary>
        public const string YCPTAX = "YCPTAX";

        /// <summary>
        /// YCPRTX.
        /// </summary>
        public const string YCPRTX = "YCPRTX";

        /// <summary>
        /// YCEV01.
        /// </summary>
        public const string YCEV01 = "YCEV01";

        /// <summary>
        /// YCINT01.
        /// </summary>
        public const string YCINT01 = "YCINT01";

        /// <summary>
        /// YCINT02.
        /// </summary>
        public const string YCINT02 = "YCINT02";

        /// <summary>
        /// YCDESC.
        /// </summary>
        public const string YCDESC = "YCDESC";

        /// <summary>
        /// YCEV02.
        /// </summary>
        public const string YCEV02 = "YCEV02";

        /// <summary>
        /// YCINT03.
        /// </summary>
        public const string YCINT03 = "YCINT03";

        /// <summary>
        /// YCP01.
        /// </summary>
        public const string YCP01 = "YCP01";

        /// <summary>
        /// YCDESC3.
        /// </summary>
        public const string YCDESC3 = "YCDESC3";

        /// <summary>
        /// YCMATH01.
        /// </summary>
        public const string YCMATH01 = "YCMATH01";

        /// <summary>
        /// YCMATH02.
        /// </summary>
        public const string YCMATH02 = "YCMATH02";

        /// <summary>
        /// YCUSER.
        /// </summary>
        public const string YCUSER = "YCUSER";

        /// <summary>
        /// YCPID.
        /// </summary>
        public const string YCPID = "YCPID";

        /// <summary>
        /// YCUPMJ.
        /// </summary>
        public const string YCUPMJ = "YCUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F0701735";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YCTARA", "YCTARA", JdeDataType.String, 20, true, true),
        new JdeField("YCPTAX", "YCPTAX", JdeDataType.String, 4, true, true),
        new JdeField("YCPRTX", "YCPRTX", JdeDataType.String, 6, true, true),
        new JdeField("YCEV01", "YCEV01", JdeDataType.String, 2, true, true),
        new JdeField("YCINT01", "YCINT01", JdeDataType.Numeric),
        new JdeField("YCINT02", "YCINT02", JdeDataType.Numeric),
        new JdeField("YCDESC", "YCDESC", JdeDataType.String, 60),
        new JdeField("YCEV02", "YCEV02", JdeDataType.String, 2),
        new JdeField("YCINT03", "YCINT03", JdeDataType.Numeric),
        new JdeField("YCP01", "YCP01", JdeDataType.String, 6),
        new JdeField("YCDESC3", "YCDESC3", JdeDataType.String, 60),
        new JdeField("YCMATH01", "YCMATH01", JdeDataType.Numeric),
        new JdeField("YCMATH02", "YCMATH02", JdeDataType.Numeric),
        new JdeField("YCUSER", "YCUSER", JdeDataType.String, 20),
        new JdeField("YCPID", "YCPID", JdeDataType.String, 20),
        new JdeField("YCUPMJ", "YCUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0701735_0", "Primary Key on YCTARA, YCPTAX, YCPRTX, YCEV01", new[] { "YCTARA", "YCPTAX", "YCPRTX", "YCEV01" }, isUnique: true, isPrimaryKey: true)
    };
}
