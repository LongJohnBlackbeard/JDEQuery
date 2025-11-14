using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4211URZ - .
/// </summary>
public class F4211URZ : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UREDUS.
        /// </summary>
        public const string UREDUS = "UREDUS";

        /// <summary>
        /// UREDBT.
        /// </summary>
        public const string UREDBT = "UREDBT";

        /// <summary>
        /// UREDTN.
        /// </summary>
        public const string UREDTN = "UREDTN";

        /// <summary>
        /// UREDLN.
        /// </summary>
        public const string UREDLN = "UREDLN";

        /// <summary>
        /// UREDCT.
        /// </summary>
        public const string UREDCT = "UREDCT";

        /// <summary>
        /// UREDFT.
        /// </summary>
        public const string UREDFT = "UREDFT";

        /// <summary>
        /// UREDDT.
        /// </summary>
        public const string UREDDT = "UREDDT";

        /// <summary>
        /// UREDDL.
        /// </summary>
        public const string UREDDL = "UREDDL";

        /// <summary>
        /// UREDSP.
        /// </summary>
        public const string UREDSP = "UREDSP";

        /// <summary>
        /// URDOCO.
        /// </summary>
        public const string URDOCO = "URDOCO";

        /// <summary>
        /// URDCTO.
        /// </summary>
        public const string URDCTO = "URDCTO";

        /// <summary>
        /// URKCOO.
        /// </summary>
        public const string URKCOO = "URKCOO";

        /// <summary>
        /// URLNID.
        /// </summary>
        public const string URLNID = "URLNID";

        /// <summary>
        /// UREXVAR0.
        /// </summary>
        public const string UREXVAR0 = "UREXVAR0";

        /// <summary>
        /// UREXVAR1.
        /// </summary>
        public const string UREXVAR1 = "UREXVAR1";

        /// <summary>
        /// UREXVAR2.
        /// </summary>
        public const string UREXVAR2 = "UREXVAR2";

        /// <summary>
        /// UREXVAR3.
        /// </summary>
        public const string UREXVAR3 = "UREXVAR3";

        /// <summary>
        /// UREXVAR4.
        /// </summary>
        public const string UREXVAR4 = "UREXVAR4";

        /// <summary>
        /// UREXVAR5.
        /// </summary>
        public const string UREXVAR5 = "UREXVAR5";

        /// <summary>
        /// UREXVAR6.
        /// </summary>
        public const string UREXVAR6 = "UREXVAR6";

        /// <summary>
        /// UREXVAR7.
        /// </summary>
        public const string UREXVAR7 = "UREXVAR7";

        /// <summary>
        /// UREXVAR8.
        /// </summary>
        public const string UREXVAR8 = "UREXVAR8";

        /// <summary>
        /// UREXVAR9.
        /// </summary>
        public const string UREXVAR9 = "UREXVAR9";

        /// <summary>
        /// UREXVAR10.
        /// </summary>
        public const string UREXVAR10 = "UREXVAR10";

        /// <summary>
        /// UREXVAR11.
        /// </summary>
        public const string UREXVAR11 = "UREXVAR11";

        /// <summary>
        /// UREXVAR12.
        /// </summary>
        public const string UREXVAR12 = "UREXVAR12";

        /// <summary>
        /// UREXVAR13.
        /// </summary>
        public const string UREXVAR13 = "UREXVAR13";

        /// <summary>
        /// UREXVAR14.
        /// </summary>
        public const string UREXVAR14 = "UREXVAR14";

        /// <summary>
        /// UREXNM0.
        /// </summary>
        public const string UREXNM0 = "UREXNM0";

        /// <summary>
        /// UREXNM1.
        /// </summary>
        public const string UREXNM1 = "UREXNM1";

        /// <summary>
        /// UREXNM2.
        /// </summary>
        public const string UREXNM2 = "UREXNM2";

        /// <summary>
        /// UREXNM3.
        /// </summary>
        public const string UREXNM3 = "UREXNM3";

        /// <summary>
        /// UREXNM4.
        /// </summary>
        public const string UREXNM4 = "UREXNM4";

        /// <summary>
        /// UREXNMP0.
        /// </summary>
        public const string UREXNMP0 = "UREXNMP0";

        /// <summary>
        /// UREXNMP1.
        /// </summary>
        public const string UREXNMP1 = "UREXNMP1";

        /// <summary>
        /// UREXNMP2.
        /// </summary>
        public const string UREXNMP2 = "UREXNMP2";

        /// <summary>
        /// UREXNMP3.
        /// </summary>
        public const string UREXNMP3 = "UREXNMP3";

        /// <summary>
        /// UREXNMP4.
        /// </summary>
        public const string UREXNMP4 = "UREXNMP4";

        /// <summary>
        /// UREXDT0.
        /// </summary>
        public const string UREXDT0 = "UREXDT0";

        /// <summary>
        /// UREXDT1.
        /// </summary>
        public const string UREXDT1 = "UREXDT1";

        /// <summary>
        /// UREXDT2.
        /// </summary>
        public const string UREXDT2 = "UREXDT2";

        /// <summary>
        /// UREXDT3.
        /// </summary>
        public const string UREXDT3 = "UREXDT3";

        /// <summary>
        /// UREXDT4.
        /// </summary>
        public const string UREXDT4 = "UREXDT4";
    }

    /// <inheritdoc />
    public override string TableName => "F4211URZ";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UREDUS", "UREDUS", JdeDataType.String, 20, true, true),
        new JdeField("UREDBT", "UREDBT", JdeDataType.String, 30, true, true),
        new JdeField("UREDTN", "UREDTN", JdeDataType.String, 44, true, true),
        new JdeField("UREDLN", "UREDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("UREDCT", "UREDCT", JdeDataType.String, 4),
        new JdeField("UREDFT", "UREDFT", JdeDataType.String, 20),
        new JdeField("UREDDT", "UREDDT", JdeDataType.Numeric),
        new JdeField("UREDDL", "UREDDL", JdeDataType.Numeric),
        new JdeField("UREDSP", "UREDSP", JdeDataType.String, 2),
        new JdeField("URDOCO", "URDOCO", JdeDataType.Numeric),
        new JdeField("URDCTO", "URDCTO", JdeDataType.String, 4),
        new JdeField("URKCOO", "URKCOO", JdeDataType.String, 10),
        new JdeField("URLNID", "URLNID", JdeDataType.Numeric),
        new JdeField("UREXVAR0", "UREXVAR0", JdeDataType.String, 510),
        new JdeField("UREXVAR1", "UREXVAR1", JdeDataType.String, 510),
        new JdeField("UREXVAR2", "UREXVAR2", JdeDataType.String, 510),
        new JdeField("UREXVAR3", "UREXVAR3", JdeDataType.String, 510),
        new JdeField("UREXVAR4", "UREXVAR4", JdeDataType.String, 100),
        new JdeField("UREXVAR5", "UREXVAR5", JdeDataType.String, 100),
        new JdeField("UREXVAR6", "UREXVAR6", JdeDataType.String, 100),
        new JdeField("UREXVAR7", "UREXVAR7", JdeDataType.String, 100),
        new JdeField("UREXVAR8", "UREXVAR8", JdeDataType.String, 100),
        new JdeField("UREXVAR9", "UREXVAR9", JdeDataType.String, 100),
        new JdeField("UREXVAR10", "UREXVAR10", JdeDataType.String, 100),
        new JdeField("UREXVAR11", "UREXVAR11", JdeDataType.String, 100),
        new JdeField("UREXVAR12", "UREXVAR12", JdeDataType.String, 50),
        new JdeField("UREXVAR13", "UREXVAR13", JdeDataType.String, 50),
        new JdeField("UREXVAR14", "UREXVAR14", JdeDataType.String, 50),
        new JdeField("UREXNM0", "UREXNM0", JdeDataType.Numeric),
        new JdeField("UREXNM1", "UREXNM1", JdeDataType.Numeric),
        new JdeField("UREXNM2", "UREXNM2", JdeDataType.Numeric),
        new JdeField("UREXNM3", "UREXNM3", JdeDataType.Numeric),
        new JdeField("UREXNM4", "UREXNM4", JdeDataType.Numeric),
        new JdeField("UREXNMP0", "UREXNMP0", JdeDataType.Numeric),
        new JdeField("UREXNMP1", "UREXNMP1", JdeDataType.Numeric),
        new JdeField("UREXNMP2", "UREXNMP2", JdeDataType.Numeric),
        new JdeField("UREXNMP3", "UREXNMP3", JdeDataType.Numeric),
        new JdeField("UREXNMP4", "UREXNMP4", JdeDataType.Numeric),
        new JdeField("UREXDT0", "UREXDT0", JdeDataType.Date),
        new JdeField("UREXDT1", "UREXDT1", JdeDataType.Date),
        new JdeField("UREXDT2", "UREXDT2", JdeDataType.Date),
        new JdeField("UREXDT3", "UREXDT3", JdeDataType.Date),
        new JdeField("UREXDT4", "UREXDT4", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4211URZ_0", "Primary Key on UREDUS, UREDBT, UREDTN, UREDLN", new[] { "UREDUS", "UREDBT", "UREDTN", "UREDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4211URZ_2", "Index on URDOCO, URDCTO, URKCOO, UREDUS, URLNID", new[] { "URDOCO", "URDCTO", "URKCOO", "UREDUS", "URLNID" }),
        new JdeIndex("F4211URZ_3", "Index on URDOCO, URDCTO, URKCOO, URLNID, UREDUS", new[] { "URDOCO", "URDCTO", "URKCOO", "URLNID", "UREDUS" })
    };
}
