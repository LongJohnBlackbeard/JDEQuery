using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4101W - .
/// </summary>
public class F4101W : JdeTable
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
        /// IMMLIT.
        /// </summary>
        public const string IMMLIT = "IMMLIT";

        /// <summary>
        /// IMMLOT.
        /// </summary>
        public const string IMMLOT = "IMMLOT";

        /// <summary>
        /// IMSPLP.
        /// </summary>
        public const string IMSPLP = "IMSPLP";

        /// <summary>
        /// IMPTPH.
        /// </summary>
        public const string IMPTPH = "IMPTPH";

        /// <summary>
        /// IMPKPH.
        /// </summary>
        public const string IMPKPH = "IMPKPH";

        /// <summary>
        /// IMRPPH.
        /// </summary>
        public const string IMRPPH = "IMRPPH";

        /// <summary>
        /// IMDEFI.
        /// </summary>
        public const string IMDEFI = "IMDEFI";

        /// <summary>
        /// IMLCOD.
        /// </summary>
        public const string IMLCOD = "IMLCOD";

        /// <summary>
        /// IMDLTN.
        /// </summary>
        public const string IMDLTN = "IMDLTN";

        /// <summary>
        /// IMVLOC.
        /// </summary>
        public const string IMVLOC = "IMVLOC";

        /// <summary>
        /// IMHLOC.
        /// </summary>
        public const string IMHLOC = "IMHLOC";

        /// <summary>
        /// IMPPUT.
        /// </summary>
        public const string IMPPUT = "IMPPUT";

        /// <summary>
        /// IMPPIK.
        /// </summary>
        public const string IMPPIK = "IMPPIK";

        /// <summary>
        /// IMPRLC.
        /// </summary>
        public const string IMPRLC = "IMPRLC";

        /// <summary>
        /// IMMPTL.
        /// </summary>
        public const string IMMPTL = "IMMPTL";

        /// <summary>
        /// IMMUMS.
        /// </summary>
        public const string IMMUMS = "IMMUMS";

        /// <summary>
        /// IMFIFR.
        /// </summary>
        public const string IMFIFR = "IMFIFR";

        /// <summary>
        /// IMURCD.
        /// </summary>
        public const string IMURCD = "IMURCD";

        /// <summary>
        /// IMURDT.
        /// </summary>
        public const string IMURDT = "IMURDT";

        /// <summary>
        /// IMURAT.
        /// </summary>
        public const string IMURAT = "IMURAT";

        /// <summary>
        /// IMURAB.
        /// </summary>
        public const string IMURAB = "IMURAB";

        /// <summary>
        /// IMURRF.
        /// </summary>
        public const string IMURRF = "IMURRF";

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
    }

    /// <inheritdoc />
    public override string TableName => "F4101W";

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
        new JdeField("IMMLIT", "IMMLIT", JdeDataType.String, 2),
        new JdeField("IMMLOT", "IMMLOT", JdeDataType.String, 2),
        new JdeField("IMSPLP", "IMSPLP", JdeDataType.String, 2),
        new JdeField("IMPTPH", "IMPTPH", JdeDataType.String, 2),
        new JdeField("IMPKPH", "IMPKPH", JdeDataType.String, 2),
        new JdeField("IMRPPH", "IMRPPH", JdeDataType.String, 2),
        new JdeField("IMDEFI", "IMDEFI", JdeDataType.String, 20),
        new JdeField("IMLCOD", "IMLCOD", JdeDataType.String, 4),
        new JdeField("IMDLTN", "IMDLTN", JdeDataType.String, 40),
        new JdeField("IMVLOC", "IMVLOC", JdeDataType.String, 40),
        new JdeField("IMHLOC", "IMHLOC", JdeDataType.String, 40),
        new JdeField("IMPPUT", "IMPPUT", JdeDataType.String, 40),
        new JdeField("IMPPIK", "IMPPIK", JdeDataType.String, 40),
        new JdeField("IMPRLC", "IMPRLC", JdeDataType.String, 40),
        new JdeField("IMMPTL", "IMMPTL", JdeDataType.String, 2),
        new JdeField("IMMUMS", "IMMUMS", JdeDataType.String, 2),
        new JdeField("IMFIFR", "IMFIFR", JdeDataType.String, 2),
        new JdeField("IMURCD", "IMURCD", JdeDataType.String, 4),
        new JdeField("IMURDT", "IMURDT", JdeDataType.Numeric),
        new JdeField("IMURAT", "IMURAT", JdeDataType.Numeric),
        new JdeField("IMURAB", "IMURAB", JdeDataType.Numeric),
        new JdeField("IMURRF", "IMURRF", JdeDataType.String, 30),
        new JdeField("IMUSER", "IMUSER", JdeDataType.String, 20),
        new JdeField("IMPID", "IMPID", JdeDataType.String, 20),
        new JdeField("IMJOBN", "IMJOBN", JdeDataType.String, 20),
        new JdeField("IMUPMJ", "IMUPMJ", JdeDataType.Numeric),
        new JdeField("IMTDAY", "IMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4101W_0", "Primary Key on IMMCU, IMITM, IMSTAW, IMEFFT, IMDOC, IMDCT", new[] { "IMMCU", "IMITM", "IMSTAW", "IMEFFT", "IMDOC", "IMDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
