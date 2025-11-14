using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1538B2 - .
/// </summary>
public class F1538B2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDICU.
        /// </summary>
        public const string RDICU = "RDICU";

        /// <summary>
        /// RDAID.
        /// </summary>
        public const string RDAID = "RDAID";

        /// <summary>
        /// RDMCU.
        /// </summary>
        public const string RDMCU = "RDMCU";

        /// <summary>
        /// RDOBJ.
        /// </summary>
        public const string RDOBJ = "RDOBJ";

        /// <summary>
        /// RDSUB.
        /// </summary>
        public const string RDSUB = "RDSUB";

        /// <summary>
        /// RDBASEX.
        /// </summary>
        public const string RDBASEX = "RDBASEX";

        /// <summary>
        /// RDEXCAREA.
        /// </summary>
        public const string RDEXCAREA = "RDEXCAREA";

        /// <summary>
        /// RDADEX.
        /// </summary>
        public const string RDADEX = "RDADEX";

        /// <summary>
        /// RDEXCLADJ.
        /// </summary>
        public const string RDEXCLADJ = "RDEXCLADJ";

        /// <summary>
        /// RDDOCO.
        /// </summary>
        public const string RDDOCO = "RDDOCO";

        /// <summary>
        /// RDLSVR.
        /// </summary>
        public const string RDLSVR = "RDLSVR";

        /// <summary>
        /// RDEPCL.
        /// </summary>
        public const string RDEPCL = "RDEPCL";

        /// <summary>
        /// RDBCI.
        /// </summary>
        public const string RDBCI = "RDBCI";

        /// <summary>
        /// RDUSEA.
        /// </summary>
        public const string RDUSEA = "RDUSEA";

        /// <summary>
        /// RDCRCD.
        /// </summary>
        public const string RDCRCD = "RDCRCD";

        /// <summary>
        /// RDOCAD.
        /// </summary>
        public const string RDOCAD = "RDOCAD";

        /// <summary>
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDMKEY.
        /// </summary>
        public const string RDMKEY = "RDMKEY";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDUPMT.
        /// </summary>
        public const string RDUPMT = "RDUPMT";

        /// <summary>
        /// RDTORG.
        /// </summary>
        public const string RDTORG = "RDTORG";

        /// <summary>
        /// RDENTJ.
        /// </summary>
        public const string RDENTJ = "RDENTJ";

        /// <summary>
        /// RDREPTS.
        /// </summary>
        public const string RDREPTS = "RDREPTS";

        /// <summary>
        /// RDELRD.
        /// </summary>
        public const string RDELRD = "RDELRD";

        /// <summary>
        /// RDSHFC.
        /// </summary>
        public const string RDSHFC = "RDSHFC";

        /// <summary>
        /// RDACTX.
        /// </summary>
        public const string RDACTX = "RDACTX";
    }

    /// <inheritdoc />
    public override string TableName => "F1538B2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDICU", "RDICU", JdeDataType.Numeric, null, true, true),
        new JdeField("RDAID", "RDAID", JdeDataType.String, 16, true, true),
        new JdeField("RDMCU", "RDMCU", JdeDataType.String, 24),
        new JdeField("RDOBJ", "RDOBJ", JdeDataType.String, 12),
        new JdeField("RDSUB", "RDSUB", JdeDataType.String, 16),
        new JdeField("RDBASEX", "RDBASEX", JdeDataType.Numeric),
        new JdeField("RDEXCAREA", "RDEXCAREA", JdeDataType.Numeric),
        new JdeField("RDADEX", "RDADEX", JdeDataType.Numeric),
        new JdeField("RDEXCLADJ", "RDEXCLADJ", JdeDataType.Numeric),
        new JdeField("RDDOCO", "RDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RDLSVR", "RDLSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("RDEPCL", "RDEPCL", JdeDataType.String, 8, true, true),
        new JdeField("RDBCI", "RDBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("RDUSEA", "RDUSEA", JdeDataType.Numeric),
        new JdeField("RDCRCD", "RDCRCD", JdeDataType.String, 6),
        new JdeField("RDOCAD", "RDOCAD", JdeDataType.Numeric),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDMKEY", "RDMKEY", JdeDataType.String, 30),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDUPMT", "RDUPMT", JdeDataType.Numeric),
        new JdeField("RDTORG", "RDTORG", JdeDataType.String, 20),
        new JdeField("RDENTJ", "RDENTJ", JdeDataType.Numeric),
        new JdeField("RDREPTS", "RDREPTS", JdeDataType.Numeric),
        new JdeField("RDELRD", "RDELRD", JdeDataType.String, 2, true, true),
        new JdeField("RDSHFC", "RDSHFC", JdeDataType.Numeric),
        new JdeField("RDACTX", "RDACTX", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1538B2_0", "Primary Key on RDICU, RDDOCO, RDLSVR, RDEPCL, RDAID, RDBCI, RDELRD", new[] { "RDICU", "RDDOCO", "RDLSVR", "RDEPCL", "RDAID", "RDBCI", "RDELRD" }, isUnique: true, isPrimaryKey: true)
    };
}
