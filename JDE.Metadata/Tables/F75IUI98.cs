using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI98 - .
/// </summary>
public class F75IUI98 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GEJOBS.
        /// </summary>
        public const string GEJOBS = "GEJOBS";

        /// <summary>
        /// GEUKID.
        /// </summary>
        public const string GEUKID = "GEUKID";

        /// <summary>
        /// GEI75INVNO.
        /// </summary>
        public const string GEI75INVNO = "GEI75INVNO";

        /// <summary>
        /// GEDOC.
        /// </summary>
        public const string GEDOC = "GEDOC";

        /// <summary>
        /// GEDCT.
        /// </summary>
        public const string GEDCT = "GEDCT";

        /// <summary>
        /// GEKCO.
        /// </summary>
        public const string GEKCO = "GEKCO";

        /// <summary>
        /// GEDOCO.
        /// </summary>
        public const string GEDOCO = "GEDOCO";

        /// <summary>
        /// GEDCTO.
        /// </summary>
        public const string GEDCTO = "GEDCTO";

        /// <summary>
        /// GEKCOO.
        /// </summary>
        public const string GEKCOO = "GEKCOO";

        /// <summary>
        /// GEEMID.
        /// </summary>
        public const string GEEMID = "GEEMID";

        /// <summary>
        /// GEUSER.
        /// </summary>
        public const string GEUSER = "GEUSER";

        /// <summary>
        /// GEPID.
        /// </summary>
        public const string GEPID = "GEPID";

        /// <summary>
        /// GEJOBN.
        /// </summary>
        public const string GEJOBN = "GEJOBN";

        /// <summary>
        /// GEUPMJ.
        /// </summary>
        public const string GEUPMJ = "GEUPMJ";

        /// <summary>
        /// GEUPMT.
        /// </summary>
        public const string GEUPMT = "GEUPMT";

        /// <summary>
        /// GEYFUTDT1.
        /// </summary>
        public const string GEYFUTDT1 = "GEYFUTDT1";

        /// <summary>
        /// GEFUT6.
        /// </summary>
        public const string GEFUT6 = "GEFUT6";

        /// <summary>
        /// GEYT04.
        /// </summary>
        public const string GEYT04 = "GEYT04";

        /// <summary>
        /// GEYFLAG.
        /// </summary>
        public const string GEYFLAG = "GEYFLAG";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI98";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GEJOBS", "GEJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("GEUKID", "GEUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("GEI75INVNO", "GEI75INVNO", JdeDataType.String, 50),
        new JdeField("GEDOC", "GEDOC", JdeDataType.Numeric),
        new JdeField("GEDCT", "GEDCT", JdeDataType.String, 4),
        new JdeField("GEKCO", "GEKCO", JdeDataType.String, 10),
        new JdeField("GEDOCO", "GEDOCO", JdeDataType.Numeric),
        new JdeField("GEDCTO", "GEDCTO", JdeDataType.String, 4),
        new JdeField("GEKCOO", "GEKCOO", JdeDataType.String, 10),
        new JdeField("GEEMID", "GEEMID", JdeDataType.String, 20),
        new JdeField("GEUSER", "GEUSER", JdeDataType.String, 20),
        new JdeField("GEPID", "GEPID", JdeDataType.String, 20),
        new JdeField("GEJOBN", "GEJOBN", JdeDataType.String, 20),
        new JdeField("GEUPMJ", "GEUPMJ", JdeDataType.Numeric),
        new JdeField("GEUPMT", "GEUPMT", JdeDataType.Numeric),
        new JdeField("GEYFUTDT1", "GEYFUTDT1", JdeDataType.Numeric),
        new JdeField("GEFUT6", "GEFUT6", JdeDataType.String, 60),
        new JdeField("GEYT04", "GEYT04", JdeDataType.String, 2),
        new JdeField("GEYFLAG", "GEYFLAG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI98_0", "Primary Key on GEJOBS, GEUKID", new[] { "GEJOBS", "GEUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
