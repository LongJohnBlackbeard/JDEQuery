using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49T70 - .
/// </summary>
public class F49T70 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSPA8.
        /// </summary>
        public const string CSPA8 = "CSPA8";

        /// <summary>
        /// CSAN8.
        /// </summary>
        public const string CSAN8 = "CSAN8";

        /// <summary>
        /// CSOTLOCNM.
        /// </summary>
        public const string CSOTLOCNM = "CSOTLOCNM";

        /// <summary>
        /// CSOTLOCNM2.
        /// </summary>
        public const string CSOTLOCNM2 = "CSOTLOCNM2";

        /// <summary>
        /// CSOTLOCROL.
        /// </summary>
        public const string CSOTLOCROL = "CSOTLOCROL";

        /// <summary>
        /// CSOTADD1.
        /// </summary>
        public const string CSOTADD1 = "CSOTADD1";

        /// <summary>
        /// CSOTADD2.
        /// </summary>
        public const string CSOTADD2 = "CSOTADD2";

        /// <summary>
        /// CSOTADD3.
        /// </summary>
        public const string CSOTADD3 = "CSOTADD3";

        /// <summary>
        /// CSOTADD4.
        /// </summary>
        public const string CSOTADD4 = "CSOTADD4";

        /// <summary>
        /// CSOTCTY1.
        /// </summary>
        public const string CSOTCTY1 = "CSOTCTY1";

        /// <summary>
        /// CSCOUN.
        /// </summary>
        public const string CSCOUN = "CSCOUN";

        /// <summary>
        /// CSOTSTATE.
        /// </summary>
        public const string CSOTSTATE = "CSOTSTATE";

        /// <summary>
        /// CSOTZIP.
        /// </summary>
        public const string CSOTZIP = "CSOTZIP";

        /// <summary>
        /// CSOTCTR.
        /// </summary>
        public const string CSOTCTR = "CSOTCTR";

        /// <summary>
        /// CSOTTRNCOD.
        /// </summary>
        public const string CSOTTRNCOD = "CSOTTRNCOD";

        /// <summary>
        /// CSOTDOMAIN.
        /// </summary>
        public const string CSOTDOMAIN = "CSOTDOMAIN";

        /// <summary>
        /// CSOTBATID.
        /// </summary>
        public const string CSOTBATID = "CSOTBATID";

        /// <summary>
        /// CSURCD.
        /// </summary>
        public const string CSURCD = "CSURCD";

        /// <summary>
        /// CSURDT.
        /// </summary>
        public const string CSURDT = "CSURDT";

        /// <summary>
        /// CSURRF.
        /// </summary>
        public const string CSURRF = "CSURRF";

        /// <summary>
        /// CSURAT.
        /// </summary>
        public const string CSURAT = "CSURAT";

        /// <summary>
        /// CSURAB.
        /// </summary>
        public const string CSURAB = "CSURAB";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSTORG.
        /// </summary>
        public const string CSTORG = "CSTORG";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSJOBN.
        /// </summary>
        public const string CSJOBN = "CSJOBN";

        /// <summary>
        /// CSUUPMJ.
        /// </summary>
        public const string CSUUPMJ = "CSUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F49T70";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSPA8", "CSPA8", JdeDataType.Numeric, null, true, true),
        new JdeField("CSAN8", "CSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CSOTLOCNM", "CSOTLOCNM", JdeDataType.String, 240),
        new JdeField("CSOTLOCNM2", "CSOTLOCNM2", JdeDataType.String, 240),
        new JdeField("CSOTLOCROL", "CSOTLOCROL", JdeDataType.String, 100),
        new JdeField("CSOTADD1", "CSOTADD1", JdeDataType.String, 80),
        new JdeField("CSOTADD2", "CSOTADD2", JdeDataType.String, 80),
        new JdeField("CSOTADD3", "CSOTADD3", JdeDataType.String, 80),
        new JdeField("CSOTADD4", "CSOTADD4", JdeDataType.String, 80),
        new JdeField("CSOTCTY1", "CSOTCTY1", JdeDataType.String, 50),
        new JdeField("CSCOUN", "CSCOUN", JdeDataType.String, 50),
        new JdeField("CSOTSTATE", "CSOTSTATE", JdeDataType.String, 4),
        new JdeField("CSOTZIP", "CSOTZIP", JdeDataType.String, 24),
        new JdeField("CSOTCTR", "CSOTCTR", JdeDataType.String, 6),
        new JdeField("CSOTTRNCOD", "CSOTTRNCOD", JdeDataType.String, 4),
        new JdeField("CSOTDOMAIN", "CSOTDOMAIN", JdeDataType.String, 100),
        new JdeField("CSOTBATID", "CSOTBATID", JdeDataType.Numeric),
        new JdeField("CSURCD", "CSURCD", JdeDataType.String, 4),
        new JdeField("CSURDT", "CSURDT", JdeDataType.Numeric),
        new JdeField("CSURRF", "CSURRF", JdeDataType.String, 30),
        new JdeField("CSURAT", "CSURAT", JdeDataType.Numeric),
        new JdeField("CSURAB", "CSURAB", JdeDataType.Numeric),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSTORG", "CSTORG", JdeDataType.String, 20),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20),
        new JdeField("CSUUPMJ", "CSUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49T70_0", "Primary Key on CSPA8, CSAN8", new[] { "CSPA8", "CSAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49T70_2", "Index on CSOTBATID", new[] { "CSOTBATID" })
    };
}
