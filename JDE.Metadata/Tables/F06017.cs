using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06017 - .
/// </summary>
public class F06017 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YAAN8.
        /// </summary>
        public const string YAAN8 = "YAAN8";

        /// <summary>
        /// YASC01.
        /// </summary>
        public const string YASC01 = "YASC01";

        /// <summary>
        /// YAXC01.
        /// </summary>
        public const string YAXC01 = "YAXC01";

        /// <summary>
        /// YACX01.
        /// </summary>
        public const string YACX01 = "YACX01";

        /// <summary>
        /// YAAW01.
        /// </summary>
        public const string YAAW01 = "YAAW01";

        /// <summary>
        /// YAFT01.
        /// </summary>
        public const string YAFT01 = "YAFT01";

        /// <summary>
        /// YANCCD.
        /// </summary>
        public const string YANCCD = "YANCCD";

        /// <summary>
        /// YAPTAX.
        /// </summary>
        public const string YAPTAX = "YAPTAX";

        /// <summary>
        /// YATARO.
        /// </summary>
        public const string YATARO = "YATARO";

        /// <summary>
        /// YASCDC.
        /// </summary>
        public const string YASCDC = "YASCDC";

        /// <summary>
        /// YAW4MLJBFL.
        /// </summary>
        public const string YAW4MLJBFL = "YAW4MLJBFL";

        /// <summary>
        /// YAW4CLMDP1.
        /// </summary>
        public const string YAW4CLMDP1 = "YAW4CLMDP1";

        /// <summary>
        /// YAW4CLMDP2.
        /// </summary>
        public const string YAW4CLMDP2 = "YAW4CLMDP2";

        /// <summary>
        /// YAW4TLCLDP.
        /// </summary>
        public const string YAW4TLCLDP = "YAW4TLCLDP";

        /// <summary>
        /// YAW4OTHINC.
        /// </summary>
        public const string YAW4OTHINC = "YAW4OTHINC";

        /// <summary>
        /// YAW4DEDS.
        /// </summary>
        public const string YAW4DEDS = "YAW4DEDS";

        /// <summary>
        /// YAW4REVYR.
        /// </summary>
        public const string YAW4REVYR = "YAW4REVYR";
    }

    /// <inheritdoc />
    public override string TableName => "F06017";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YAAN8", "YAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YASC01", "YASC01", JdeDataType.String, 6, true, true),
        new JdeField("YAXC01", "YAXC01", JdeDataType.Numeric),
        new JdeField("YACX01", "YACX01", JdeDataType.Numeric),
        new JdeField("YAAW01", "YAAW01", JdeDataType.Numeric),
        new JdeField("YAFT01", "YAFT01", JdeDataType.String, 2),
        new JdeField("YANCCD", "YANCCD", JdeDataType.String, 2),
        new JdeField("YAPTAX", "YAPTAX", JdeDataType.String, 4, true, true),
        new JdeField("YATARO", "YATARO", JdeDataType.String, 20, true, true),
        new JdeField("YASCDC", "YASCDC", JdeDataType.Numeric),
        new JdeField("YAW4MLJBFL", "YAW4MLJBFL", JdeDataType.String, 2),
        new JdeField("YAW4CLMDP1", "YAW4CLMDP1", JdeDataType.Numeric),
        new JdeField("YAW4CLMDP2", "YAW4CLMDP2", JdeDataType.Numeric),
        new JdeField("YAW4TLCLDP", "YAW4TLCLDP", JdeDataType.Numeric),
        new JdeField("YAW4OTHINC", "YAW4OTHINC", JdeDataType.Numeric),
        new JdeField("YAW4DEDS", "YAW4DEDS", JdeDataType.Numeric),
        new JdeField("YAW4REVYR", "YAW4REVYR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06017_0", "Primary Key on YAAN8, YASC01, YATARO, YAPTAX", new[] { "YAAN8", "YASC01", "YATARO", "YAPTAX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06017_2", "Index on YAAN8, YATARO, YAPTAX, YASC01", new[] { "YAAN8", "YATARO", "YAPTAX", "YASC01" })
    };
}
