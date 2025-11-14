using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J70 - .
/// </summary>
public class F09J70 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JHJVNAME.
        /// </summary>
        public const string JHJVNAME = "JHJVNAME";

        /// <summary>
        /// JHJVBUSTS.
        /// </summary>
        public const string JHJVBUSTS = "JHJVBUSTS";

        /// <summary>
        /// JHEFTB.
        /// </summary>
        public const string JHEFTB = "JHEFTB";

        /// <summary>
        /// JHUSER.
        /// </summary>
        public const string JHUSER = "JHUSER";

        /// <summary>
        /// JHUPMJ.
        /// </summary>
        public const string JHUPMJ = "JHUPMJ";

        /// <summary>
        /// JHUPMT.
        /// </summary>
        public const string JHUPMT = "JHUPMT";

        /// <summary>
        /// JHPID.
        /// </summary>
        public const string JHPID = "JHPID";

        /// <summary>
        /// JHMKEY.
        /// </summary>
        public const string JHMKEY = "JHMKEY";

        /// <summary>
        /// JHURRFJS01.
        /// </summary>
        public const string JHURRFJS01 = "JHURRFJS01";

        /// <summary>
        /// JHURRFJS02.
        /// </summary>
        public const string JHURRFJS02 = "JHURRFJS02";

        /// <summary>
        /// JHURRFJS03.
        /// </summary>
        public const string JHURRFJS03 = "JHURRFJS03";

        /// <summary>
        /// JHURRFJS04.
        /// </summary>
        public const string JHURRFJS04 = "JHURRFJS04";

        /// <summary>
        /// JHURRFJS05.
        /// </summary>
        public const string JHURRFJS05 = "JHURRFJS05";

        /// <summary>
        /// JHURCDJS01.
        /// </summary>
        public const string JHURCDJS01 = "JHURCDJS01";

        /// <summary>
        /// JHURCDJS02.
        /// </summary>
        public const string JHURCDJS02 = "JHURCDJS02";

        /// <summary>
        /// JHURCDJS03.
        /// </summary>
        public const string JHURCDJS03 = "JHURCDJS03";

        /// <summary>
        /// JHURCDJS04.
        /// </summary>
        public const string JHURCDJS04 = "JHURCDJS04";

        /// <summary>
        /// JHURCDJS05.
        /// </summary>
        public const string JHURCDJS05 = "JHURCDJS05";

        /// <summary>
        /// JHURNUMS01.
        /// </summary>
        public const string JHURNUMS01 = "JHURNUMS01";

        /// <summary>
        /// JHURNUMS02.
        /// </summary>
        public const string JHURNUMS02 = "JHURNUMS02";

        /// <summary>
        /// JHURNUMS03.
        /// </summary>
        public const string JHURNUMS03 = "JHURNUMS03";

        /// <summary>
        /// JHURNUMS04.
        /// </summary>
        public const string JHURNUMS04 = "JHURNUMS04";

        /// <summary>
        /// JHURNUMS05.
        /// </summary>
        public const string JHURNUMS05 = "JHURNUMS05";

        /// <summary>
        /// JHURATJS01.
        /// </summary>
        public const string JHURATJS01 = "JHURATJS01";

        /// <summary>
        /// JHURATJS02.
        /// </summary>
        public const string JHURATJS02 = "JHURATJS02";

        /// <summary>
        /// JHURATJS03.
        /// </summary>
        public const string JHURATJS03 = "JHURATJS03";

        /// <summary>
        /// JHURATJS04.
        /// </summary>
        public const string JHURATJS04 = "JHURATJS04";

        /// <summary>
        /// JHURATJS05.
        /// </summary>
        public const string JHURATJS05 = "JHURATJS05";

        /// <summary>
        /// JHURDTJS01.
        /// </summary>
        public const string JHURDTJS01 = "JHURDTJS01";

        /// <summary>
        /// JHURDTJS02.
        /// </summary>
        public const string JHURDTJS02 = "JHURDTJS02";

        /// <summary>
        /// JHURDTJS03.
        /// </summary>
        public const string JHURDTJS03 = "JHURDTJS03";

        /// <summary>
        /// JHURDTJS04.
        /// </summary>
        public const string JHURDTJS04 = "JHURDTJS04";

        /// <summary>
        /// JHURDTJS05.
        /// </summary>
        public const string JHURDTJS05 = "JHURDTJS05";

        /// <summary>
        /// JHURSTJS01.
        /// </summary>
        public const string JHURSTJS01 = "JHURSTJS01";

        /// <summary>
        /// JHURSTJS02.
        /// </summary>
        public const string JHURSTJS02 = "JHURSTJS02";

        /// <summary>
        /// JHURSTJS03.
        /// </summary>
        public const string JHURSTJS03 = "JHURSTJS03";

        /// <summary>
        /// JHURSTJS04.
        /// </summary>
        public const string JHURSTJS04 = "JHURSTJS04";

        /// <summary>
        /// JHURSTJS05.
        /// </summary>
        public const string JHURSTJS05 = "JHURSTJS05";

        /// <summary>
        /// JHJVJSCH1.
        /// </summary>
        public const string JHJVJSCH1 = "JHJVJSCH1";

        /// <summary>
        /// JHJVJSCH2.
        /// </summary>
        public const string JHJVJSCH2 = "JHJVJSCH2";

        /// <summary>
        /// JHJVJSCH3.
        /// </summary>
        public const string JHJVJSCH3 = "JHJVJSCH3";

        /// <summary>
        /// JHJVJSDT1.
        /// </summary>
        public const string JHJVJSDT1 = "JHJVJSDT1";

        /// <summary>
        /// JHJVJSDT2.
        /// </summary>
        public const string JHJVJSDT2 = "JHJVJSDT2";

        /// <summary>
        /// JHJVJSDT3.
        /// </summary>
        public const string JHJVJSDT3 = "JHJVJSDT3";

        /// <summary>
        /// JHJVJSNU1.
        /// </summary>
        public const string JHJVJSNU1 = "JHJVJSNU1";

        /// <summary>
        /// JHJVJSNU2.
        /// </summary>
        public const string JHJVJSNU2 = "JHJVJSNU2";

        /// <summary>
        /// JHJVJSNU3.
        /// </summary>
        public const string JHJVJSNU3 = "JHJVJSNU3";

        /// <summary>
        /// JHJVJSST1.
        /// </summary>
        public const string JHJVJSST1 = "JHJVJSST1";

        /// <summary>
        /// JHJVJSST2.
        /// </summary>
        public const string JHJVJSST2 = "JHJVJSST2";

        /// <summary>
        /// JHJVJSST3.
        /// </summary>
        public const string JHJVJSST3 = "JHJVJSST3";
    }

    /// <inheritdoc />
    public override string TableName => "F09J70";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JHJVNAME", "JHJVNAME", JdeDataType.String, 40, true, true),
        new JdeField("JHJVBUSTS", "JHJVBUSTS", JdeDataType.String, 6, true, true),
        new JdeField("JHEFTB", "JHEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("JHUSER", "JHUSER", JdeDataType.String, 20),
        new JdeField("JHUPMJ", "JHUPMJ", JdeDataType.Numeric),
        new JdeField("JHUPMT", "JHUPMT", JdeDataType.Numeric),
        new JdeField("JHPID", "JHPID", JdeDataType.String, 20),
        new JdeField("JHMKEY", "JHMKEY", JdeDataType.String, 30),
        new JdeField("JHURRFJS01", "JHURRFJS01", JdeDataType.String, 30),
        new JdeField("JHURRFJS02", "JHURRFJS02", JdeDataType.String, 30),
        new JdeField("JHURRFJS03", "JHURRFJS03", JdeDataType.String, 30),
        new JdeField("JHURRFJS04", "JHURRFJS04", JdeDataType.String, 30),
        new JdeField("JHURRFJS05", "JHURRFJS05", JdeDataType.String, 30),
        new JdeField("JHURCDJS01", "JHURCDJS01", JdeDataType.String, 4),
        new JdeField("JHURCDJS02", "JHURCDJS02", JdeDataType.String, 4),
        new JdeField("JHURCDJS03", "JHURCDJS03", JdeDataType.String, 4),
        new JdeField("JHURCDJS04", "JHURCDJS04", JdeDataType.String, 4),
        new JdeField("JHURCDJS05", "JHURCDJS05", JdeDataType.String, 4),
        new JdeField("JHURNUMS01", "JHURNUMS01", JdeDataType.Numeric),
        new JdeField("JHURNUMS02", "JHURNUMS02", JdeDataType.Numeric),
        new JdeField("JHURNUMS03", "JHURNUMS03", JdeDataType.Numeric),
        new JdeField("JHURNUMS04", "JHURNUMS04", JdeDataType.Numeric),
        new JdeField("JHURNUMS05", "JHURNUMS05", JdeDataType.Numeric),
        new JdeField("JHURATJS01", "JHURATJS01", JdeDataType.Numeric),
        new JdeField("JHURATJS02", "JHURATJS02", JdeDataType.Numeric),
        new JdeField("JHURATJS03", "JHURATJS03", JdeDataType.Numeric),
        new JdeField("JHURATJS04", "JHURATJS04", JdeDataType.Numeric),
        new JdeField("JHURATJS05", "JHURATJS05", JdeDataType.Numeric),
        new JdeField("JHURDTJS01", "JHURDTJS01", JdeDataType.Numeric),
        new JdeField("JHURDTJS02", "JHURDTJS02", JdeDataType.Numeric),
        new JdeField("JHURDTJS03", "JHURDTJS03", JdeDataType.Numeric),
        new JdeField("JHURDTJS04", "JHURDTJS04", JdeDataType.Numeric),
        new JdeField("JHURDTJS05", "JHURDTJS05", JdeDataType.Numeric),
        new JdeField("JHURSTJS01", "JHURSTJS01", JdeDataType.String, 160),
        new JdeField("JHURSTJS02", "JHURSTJS02", JdeDataType.String, 160),
        new JdeField("JHURSTJS03", "JHURSTJS03", JdeDataType.String, 160),
        new JdeField("JHURSTJS04", "JHURSTJS04", JdeDataType.String, 160),
        new JdeField("JHURSTJS05", "JHURSTJS05", JdeDataType.String, 160),
        new JdeField("JHJVJSCH1", "JHJVJSCH1", JdeDataType.String, 2),
        new JdeField("JHJVJSCH2", "JHJVJSCH2", JdeDataType.String, 2),
        new JdeField("JHJVJSCH3", "JHJVJSCH3", JdeDataType.String, 2),
        new JdeField("JHJVJSDT1", "JHJVJSDT1", JdeDataType.Numeric),
        new JdeField("JHJVJSDT2", "JHJVJSDT2", JdeDataType.Numeric),
        new JdeField("JHJVJSDT3", "JHJVJSDT3", JdeDataType.Numeric),
        new JdeField("JHJVJSNU1", "JHJVJSNU1", JdeDataType.Numeric),
        new JdeField("JHJVJSNU2", "JHJVJSNU2", JdeDataType.Numeric),
        new JdeField("JHJVJSNU3", "JHJVJSNU3", JdeDataType.Numeric),
        new JdeField("JHJVJSST1", "JHJVJSST1", JdeDataType.String, 160),
        new JdeField("JHJVJSST2", "JHJVJSST2", JdeDataType.String, 160),
        new JdeField("JHJVJSST3", "JHJVJSST3", JdeDataType.String, 160)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J70_0", "Primary Key on JHJVNAME, JHJVBUSTS, JHEFTB", new[] { "JHJVNAME", "JHJVBUSTS", "JHEFTB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09J70_4", "Index on JHJVNAME, SYS_NC00051$", new[] { "JHJVNAME", "SYS_NC00051$" }),
        new JdeIndex("F09J70_5", "Index on JHJVNAME", new[] { "JHJVNAME" }),
        new JdeIndex("F09J70_6", "Index on JHJVNAME, JHEFTB", new[] { "JHJVNAME", "JHEFTB" })
    };
}
