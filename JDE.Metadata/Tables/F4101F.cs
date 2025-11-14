using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4101F - .
/// </summary>
public class F4101F : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IMMCU.
        /// </summary>
        public const string IMMCU = "IMMCU";

        /// <summary>
        /// IMITM.
        /// </summary>
        public const string IMITM = "IMITM";

        /// <summary>
        /// IMSTAW.
        /// </summary>
        public const string IMSTAW = "IMSTAW";

        /// <summary>
        /// IMEFFT.
        /// </summary>
        public const string IMEFFT = "IMEFFT";

        /// <summary>
        /// IMDOC.
        /// </summary>
        public const string IMDOC = "IMDOC";

        /// <summary>
        /// IMDCT.
        /// </summary>
        public const string IMDCT = "IMDCT";

        /// <summary>
        /// IMEFFF.
        /// </summary>
        public const string IMEFFF = "IMEFFF";

        /// <summary>
        /// IMSERK.
        /// </summary>
        public const string IMSERK = "IMSERK";

        /// <summary>
        /// IMITBR.
        /// </summary>
        public const string IMITBR = "IMITBR";

        /// <summary>
        /// IMPRODM.
        /// </summary>
        public const string IMPRODM = "IMPRODM";

        /// <summary>
        /// IMPRODF.
        /// </summary>
        public const string IMPRODF = "IMPRODF";

        /// <summary>
        /// IMMCUZ.
        /// </summary>
        public const string IMMCUZ = "IMMCUZ";

        /// <summary>
        /// IMDCD1.
        /// </summary>
        public const string IMDCD1 = "IMDCD1";

        /// <summary>
        /// IMDCD2.
        /// </summary>
        public const string IMDCD2 = "IMDCD2";

        /// <summary>
        /// IMDCD3.
        /// </summary>
        public const string IMDCD3 = "IMDCD3";

        /// <summary>
        /// IMDCD4.
        /// </summary>
        public const string IMDCD4 = "IMDCD4";

        /// <summary>
        /// IMDCD5.
        /// </summary>
        public const string IMDCD5 = "IMDCD5";

        /// <summary>
        /// IMCRTU.
        /// </summary>
        public const string IMCRTU = "IMCRTU";

        /// <summary>
        /// IMRPRBL.
        /// </summary>
        public const string IMRPRBL = "IMRPRBL";

        /// <summary>
        /// IMRTRND.
        /// </summary>
        public const string IMRTRND = "IMRTRND";

        /// <summary>
        /// IMCCOST.
        /// </summary>
        public const string IMCCOST = "IMCCOST";

        /// <summary>
        /// IMUSER.
        /// </summary>
        public const string IMUSER = "IMUSER";

        /// <summary>
        /// IMPID.
        /// </summary>
        public const string IMPID = "IMPID";

        /// <summary>
        /// IMJOBN.
        /// </summary>
        public const string IMJOBN = "IMJOBN";

        /// <summary>
        /// IMUPMJ.
        /// </summary>
        public const string IMUPMJ = "IMUPMJ";

        /// <summary>
        /// IMTDAY.
        /// </summary>
        public const string IMTDAY = "IMTDAY";

        /// <summary>
        /// IMRETPOL.
        /// </summary>
        public const string IMRETPOL = "IMRETPOL";

        /// <summary>
        /// IMSRYN.
        /// </summary>
        public const string IMSRYN = "IMSRYN";

        /// <summary>
        /// IMIBYN.
        /// </summary>
        public const string IMIBYN = "IMIBYN";
    }

    /// <inheritdoc />
    public override string TableName => "F4101F";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IMMCU", "IMMCU", JdeDataType.String, 24, true, true),
        new JdeField("IMITM", "IMITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IMSTAW", "IMSTAW", JdeDataType.String, 2, true, true),
        new JdeField("IMEFFT", "IMEFFT", JdeDataType.Numeric, null, true, true),
        new JdeField("IMDOC", "IMDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("IMDCT", "IMDCT", JdeDataType.String, 4, true, true),
        new JdeField("IMEFFF", "IMEFFF", JdeDataType.Numeric),
        new JdeField("IMSERK", "IMSERK", JdeDataType.Numeric),
        new JdeField("IMITBR", "IMITBR", JdeDataType.String, 2),
        new JdeField("IMPRODM", "IMPRODM", JdeDataType.String, 16),
        new JdeField("IMPRODF", "IMPRODF", JdeDataType.String, 16),
        new JdeField("IMMCUZ", "IMMCUZ", JdeDataType.String, 24),
        new JdeField("IMDCD1", "IMDCD1", JdeDataType.String, 6),
        new JdeField("IMDCD2", "IMDCD2", JdeDataType.String, 6),
        new JdeField("IMDCD3", "IMDCD3", JdeDataType.String, 6),
        new JdeField("IMDCD4", "IMDCD4", JdeDataType.String, 6),
        new JdeField("IMDCD5", "IMDCD5", JdeDataType.String, 6),
        new JdeField("IMCRTU", "IMCRTU", JdeDataType.String, 20),
        new JdeField("IMRPRBL", "IMRPRBL", JdeDataType.String, 2),
        new JdeField("IMRTRND", "IMRTRND", JdeDataType.String, 2),
        new JdeField("IMCCOST", "IMCCOST", JdeDataType.String, 6),
        new JdeField("IMUSER", "IMUSER", JdeDataType.String, 20),
        new JdeField("IMPID", "IMPID", JdeDataType.String, 20),
        new JdeField("IMJOBN", "IMJOBN", JdeDataType.String, 20),
        new JdeField("IMUPMJ", "IMUPMJ", JdeDataType.Numeric),
        new JdeField("IMTDAY", "IMTDAY", JdeDataType.Numeric),
        new JdeField("IMRETPOL", "IMRETPOL", JdeDataType.String, 2),
        new JdeField("IMSRYN", "IMSRYN", JdeDataType.String, 2),
        new JdeField("IMIBYN", "IMIBYN", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4101F_0", "Primary Key on IMMCU, IMITM, IMSTAW, IMEFFT, IMDOC, IMDCT", new[] { "IMMCU", "IMITM", "IMSTAW", "IMEFFT", "IMDOC", "IMDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
