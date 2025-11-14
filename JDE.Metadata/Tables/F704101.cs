using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F704101 - .
/// </summary>
public class F704101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IMITM.
        /// </summary>
        public const string IMITM = "IMITM";

        /// <summary>
        /// IMLCTR.
        /// </summary>
        public const string IMLCTR = "IMLCTR";

        /// <summary>
        /// IMG70CC01.
        /// </summary>
        public const string IMG70CC01 = "IMG70CC01";

        /// <summary>
        /// IMG70CC02.
        /// </summary>
        public const string IMG70CC02 = "IMG70CC02";

        /// <summary>
        /// IMG70CC03.
        /// </summary>
        public const string IMG70CC03 = "IMG70CC03";

        /// <summary>
        /// IMG70CC04.
        /// </summary>
        public const string IMG70CC04 = "IMG70CC04";

        /// <summary>
        /// IMG70CC05.
        /// </summary>
        public const string IMG70CC05 = "IMG70CC05";

        /// <summary>
        /// IMG70CC06.
        /// </summary>
        public const string IMG70CC06 = "IMG70CC06";

        /// <summary>
        /// IMG70CC07.
        /// </summary>
        public const string IMG70CC07 = "IMG70CC07";

        /// <summary>
        /// IMG70CC08.
        /// </summary>
        public const string IMG70CC08 = "IMG70CC08";

        /// <summary>
        /// IMG70CC09.
        /// </summary>
        public const string IMG70CC09 = "IMG70CC09";

        /// <summary>
        /// IMG70CC10.
        /// </summary>
        public const string IMG70CC10 = "IMG70CC10";

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
        /// IMUPMT.
        /// </summary>
        public const string IMUPMT = "IMUPMT";

        /// <summary>
        /// IMUPMJ.
        /// </summary>
        public const string IMUPMJ = "IMUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F704101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IMITM", "IMITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IMLCTR", "IMLCTR", JdeDataType.String, 6, true, true),
        new JdeField("IMG70CC01", "IMG70CC01", JdeDataType.String, 20),
        new JdeField("IMG70CC02", "IMG70CC02", JdeDataType.String, 20),
        new JdeField("IMG70CC03", "IMG70CC03", JdeDataType.String, 20),
        new JdeField("IMG70CC04", "IMG70CC04", JdeDataType.String, 20),
        new JdeField("IMG70CC05", "IMG70CC05", JdeDataType.String, 20),
        new JdeField("IMG70CC06", "IMG70CC06", JdeDataType.String, 20),
        new JdeField("IMG70CC07", "IMG70CC07", JdeDataType.String, 20),
        new JdeField("IMG70CC08", "IMG70CC08", JdeDataType.String, 20),
        new JdeField("IMG70CC09", "IMG70CC09", JdeDataType.String, 20),
        new JdeField("IMG70CC10", "IMG70CC10", JdeDataType.String, 20),
        new JdeField("IMURCD", "IMURCD", JdeDataType.String, 4),
        new JdeField("IMURDT", "IMURDT", JdeDataType.Numeric),
        new JdeField("IMURAT", "IMURAT", JdeDataType.Numeric),
        new JdeField("IMURAB", "IMURAB", JdeDataType.Numeric),
        new JdeField("IMURRF", "IMURRF", JdeDataType.String, 30),
        new JdeField("IMUSER", "IMUSER", JdeDataType.String, 20),
        new JdeField("IMPID", "IMPID", JdeDataType.String, 20),
        new JdeField("IMJOBN", "IMJOBN", JdeDataType.String, 20),
        new JdeField("IMUPMT", "IMUPMT", JdeDataType.Numeric),
        new JdeField("IMUPMJ", "IMUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F704101_0", "Primary Key on IMLCTR, IMITM", new[] { "IMLCTR", "IMITM" }, isUnique: true, isPrimaryKey: true)
    };
}
