using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1304 - .
/// </summary>
public class F1304 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FNTRNN.
        /// </summary>
        public const string FNTRNN = "FNTRNN";

        /// <summary>
        /// FNNNBR.
        /// </summary>
        public const string FNNNBR = "FNNNBR";

        /// <summary>
        /// FNICU.
        /// </summary>
        public const string FNICU = "FNICU";

        /// <summary>
        /// FNNUMB.
        /// </summary>
        public const string FNNUMB = "FNNUMB";

        /// <summary>
        /// FNLOC.
        /// </summary>
        public const string FNLOC = "FNLOC";

        /// <summary>
        /// FNMCU.
        /// </summary>
        public const string FNMCU = "FNMCU";

        /// <summary>
        /// FNOBJ.
        /// </summary>
        public const string FNOBJ = "FNOBJ";

        /// <summary>
        /// FNSUB.
        /// </summary>
        public const string FNSUB = "FNSUB";

        /// <summary>
        /// FNSBL.
        /// </summary>
        public const string FNSBL = "FNSBL";

        /// <summary>
        /// FNSBLT.
        /// </summary>
        public const string FNSBLT = "FNSBLT";

        /// <summary>
        /// FNRTPE.
        /// </summary>
        public const string FNRTPE = "FNRTPE";

        /// <summary>
        /// FNERC.
        /// </summary>
        public const string FNERC = "FNERC";

        /// <summary>
        /// FNEBRT.
        /// </summary>
        public const string FNEBRT = "FNEBRT";

        /// <summary>
        /// FNPRO.
        /// </summary>
        public const string FNPRO = "FNPRO";

        /// <summary>
        /// FNQTY.
        /// </summary>
        public const string FNQTY = "FNQTY";

        /// <summary>
        /// FNHRBL.
        /// </summary>
        public const string FNHRBL = "FNHRBL";

        /// <summary>
        /// FNDYBL.
        /// </summary>
        public const string FNDYBL = "FNDYBL";

        /// <summary>
        /// FNWKBL.
        /// </summary>
        public const string FNWKBL = "FNWKBL";

        /// <summary>
        /// FNMNBL.
        /// </summary>
        public const string FNMNBL = "FNMNBL";

        /// <summary>
        /// FNDBTT.
        /// </summary>
        public const string FNDBTT = "FNDBTT";

        /// <summary>
        /// FNDDTE.
        /// </summary>
        public const string FNDDTE = "FNDDTE";

        /// <summary>
        /// FNCBDT.
        /// </summary>
        public const string FNCBDT = "FNCBDT";

        /// <summary>
        /// FNCBAM.
        /// </summary>
        public const string FNCBAM = "FNCBAM";

        /// <summary>
        /// FNTTBL.
        /// </summary>
        public const string FNTTBL = "FNTTBL";

        /// <summary>
        /// FNLCT.
        /// </summary>
        public const string FNLCT = "FNLCT";

        /// <summary>
        /// FNUSER.
        /// </summary>
        public const string FNUSER = "FNUSER";

        /// <summary>
        /// FNPID.
        /// </summary>
        public const string FNPID = "FNPID";

        /// <summary>
        /// FNJOBN.
        /// </summary>
        public const string FNJOBN = "FNJOBN";

        /// <summary>
        /// FNUPMT.
        /// </summary>
        public const string FNUPMT = "FNUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1304";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FNTRNN", "FNTRNN", JdeDataType.String, 24, true, true),
        new JdeField("FNNNBR", "FNNNBR", JdeDataType.Numeric, null, true, true),
        new JdeField("FNICU", "FNICU", JdeDataType.Numeric),
        new JdeField("FNNUMB", "FNNUMB", JdeDataType.Numeric),
        new JdeField("FNLOC", "FNLOC", JdeDataType.String, 24),
        new JdeField("FNMCU", "FNMCU", JdeDataType.String, 24),
        new JdeField("FNOBJ", "FNOBJ", JdeDataType.String, 12),
        new JdeField("FNSUB", "FNSUB", JdeDataType.String, 16),
        new JdeField("FNSBL", "FNSBL", JdeDataType.String, 16),
        new JdeField("FNSBLT", "FNSBLT", JdeDataType.String, 2),
        new JdeField("FNRTPE", "FNRTPE", JdeDataType.String, 2),
        new JdeField("FNERC", "FNERC", JdeDataType.String, 4),
        new JdeField("FNEBRT", "FNEBRT", JdeDataType.Numeric),
        new JdeField("FNPRO", "FNPRO", JdeDataType.String, 2),
        new JdeField("FNQTY", "FNQTY", JdeDataType.Numeric),
        new JdeField("FNHRBL", "FNHRBL", JdeDataType.Numeric),
        new JdeField("FNDYBL", "FNDYBL", JdeDataType.Numeric),
        new JdeField("FNWKBL", "FNWKBL", JdeDataType.Numeric),
        new JdeField("FNMNBL", "FNMNBL", JdeDataType.Numeric),
        new JdeField("FNDBTT", "FNDBTT", JdeDataType.Numeric),
        new JdeField("FNDDTE", "FNDDTE", JdeDataType.Numeric),
        new JdeField("FNCBDT", "FNCBDT", JdeDataType.Numeric, null, true, true),
        new JdeField("FNCBAM", "FNCBAM", JdeDataType.Numeric),
        new JdeField("FNTTBL", "FNTTBL", JdeDataType.Numeric),
        new JdeField("FNLCT", "FNLCT", JdeDataType.Numeric),
        new JdeField("FNUSER", "FNUSER", JdeDataType.String, 20),
        new JdeField("FNPID", "FNPID", JdeDataType.String, 20),
        new JdeField("FNJOBN", "FNJOBN", JdeDataType.String, 20),
        new JdeField("FNUPMT", "FNUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1304_0", "Primary Key on FNTRNN, FNNNBR, FNCBDT", new[] { "FNTRNN", "FNNNBR", "FNCBDT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1304_2", "Index on FNICU", new[] { "FNICU" }),
        new JdeIndex("F1304_3", "Index on FNLOC", new[] { "FNLOC" }),
        new JdeIndex("F1304_4", "Index on FNUSER", new[] { "FNUSER" })
    };
}
