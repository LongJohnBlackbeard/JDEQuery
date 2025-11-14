using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F490051 - .
/// </summary>
public class F490051 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XGCARS.
        /// </summary>
        public const string XGCARS = "XGCARS";

        /// <summary>
        /// XGMOT.
        /// </summary>
        public const string XGMOT = "XGMOT";

        /// <summary>
        /// XGDCCD.
        /// </summary>
        public const string XGDCCD = "XGDCCD";

        /// <summary>
        /// XGOSEQ.
        /// </summary>
        public const string XGOSEQ = "XGOSEQ";

        /// <summary>
        /// XGTSGT.
        /// </summary>
        public const string XGTSGT = "XGTSGT";

        /// <summary>
        /// XGTSGL.
        /// </summary>
        public const string XGTSGL = "XGTSGL";

        /// <summary>
        /// XGHCV.
        /// </summary>
        public const string XGHCV = "XGHCV";

        /// <summary>
        /// XGLUT3.
        /// </summary>
        public const string XGLUT3 = "XGLUT3";

        /// <summary>
        /// XGSY.
        /// </summary>
        public const string XGSY = "XGSY";

        /// <summary>
        /// XGRT.
        /// </summary>
        public const string XGRT = "XGRT";

        /// <summary>
        /// XGCMOT.
        /// </summary>
        public const string XGCMOT = "XGCMOT";

        /// <summary>
        /// XGCDBF.
        /// </summary>
        public const string XGCDBF = "XGCDBF";

        /// <summary>
        /// XGTNBF.
        /// </summary>
        public const string XGTNBF = "XGTNBF";

        /// <summary>
        /// XGURCD.
        /// </summary>
        public const string XGURCD = "XGURCD";

        /// <summary>
        /// XGURDT.
        /// </summary>
        public const string XGURDT = "XGURDT";

        /// <summary>
        /// XGURAT.
        /// </summary>
        public const string XGURAT = "XGURAT";

        /// <summary>
        /// XGURAB.
        /// </summary>
        public const string XGURAB = "XGURAB";

        /// <summary>
        /// XGURRF.
        /// </summary>
        public const string XGURRF = "XGURRF";

        /// <summary>
        /// XGUSER.
        /// </summary>
        public const string XGUSER = "XGUSER";

        /// <summary>
        /// XGPID.
        /// </summary>
        public const string XGPID = "XGPID";

        /// <summary>
        /// XGJOBN.
        /// </summary>
        public const string XGJOBN = "XGJOBN";

        /// <summary>
        /// XGUPMJ.
        /// </summary>
        public const string XGUPMJ = "XGUPMJ";

        /// <summary>
        /// XGTDAY.
        /// </summary>
        public const string XGTDAY = "XGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F490051";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XGCARS", "XGCARS", JdeDataType.Numeric, null, true, true),
        new JdeField("XGMOT", "XGMOT", JdeDataType.String, 6, true, true),
        new JdeField("XGDCCD", "XGDCCD", JdeDataType.String, 8, true, true),
        new JdeField("XGOSEQ", "XGOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("XGTSGT", "XGTSGT", JdeDataType.String, 2),
        new JdeField("XGTSGL", "XGTSGL", JdeDataType.Numeric),
        new JdeField("XGHCV", "XGHCV", JdeDataType.String, 60),
        new JdeField("XGLUT3", "XGLUT3", JdeDataType.String, 2),
        new JdeField("XGSY", "XGSY", JdeDataType.String, 8),
        new JdeField("XGRT", "XGRT", JdeDataType.String, 4),
        new JdeField("XGCMOT", "XGCMOT", JdeDataType.String, 2),
        new JdeField("XGCDBF", "XGCDBF", JdeDataType.String, 64),
        new JdeField("XGTNBF", "XGTNBF", JdeDataType.String, 64),
        new JdeField("XGURCD", "XGURCD", JdeDataType.String, 4),
        new JdeField("XGURDT", "XGURDT", JdeDataType.Numeric),
        new JdeField("XGURAT", "XGURAT", JdeDataType.Numeric),
        new JdeField("XGURAB", "XGURAB", JdeDataType.Numeric),
        new JdeField("XGURRF", "XGURRF", JdeDataType.String, 30),
        new JdeField("XGUSER", "XGUSER", JdeDataType.String, 20),
        new JdeField("XGPID", "XGPID", JdeDataType.String, 20),
        new JdeField("XGJOBN", "XGJOBN", JdeDataType.String, 20),
        new JdeField("XGUPMJ", "XGUPMJ", JdeDataType.Numeric),
        new JdeField("XGTDAY", "XGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F490051_0", "Primary Key on XGCARS, XGMOT, XGDCCD, XGOSEQ", new[] { "XGCARS", "XGMOT", "XGDCCD", "XGOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
