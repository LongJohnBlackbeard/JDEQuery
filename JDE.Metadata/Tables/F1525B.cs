using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1525B - .
/// </summary>
public class F1525B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NMFETP.
        /// </summary>
        public const string NMFETP = "NMFETP";

        /// <summary>
        /// NMDOCO.
        /// </summary>
        public const string NMDOCO = "NMDOCO";

        /// <summary>
        /// NMAN8.
        /// </summary>
        public const string NMAN8 = "NMAN8";

        /// <summary>
        /// NMMCU.
        /// </summary>
        public const string NMMCU = "NMMCU";

        /// <summary>
        /// NMGLC.
        /// </summary>
        public const string NMGLC = "NMGLC";

        /// <summary>
        /// NMLNID.
        /// </summary>
        public const string NMLNID = "NMLNID";

        /// <summary>
        /// NMAGSN.
        /// </summary>
        public const string NMAGSN = "NMAGSN";

        /// <summary>
        /// NMFFC.
        /// </summary>
        public const string NMFFC = "NMFFC";

        /// <summary>
        /// NMAG.
        /// </summary>
        public const string NMAG = "NMAG";

        /// <summary>
        /// NMFERT.
        /// </summary>
        public const string NMFERT = "NMFERT";

        /// <summary>
        /// NMRTSC.
        /// </summary>
        public const string NMRTSC = "NMRTSC";

        /// <summary>
        /// NMAAPF.
        /// </summary>
        public const string NMAAPF = "NMAAPF";

        /// <summary>
        /// NMBRCD.
        /// </summary>
        public const string NMBRCD = "NMBRCD";

        /// <summary>
        /// NMFISD.
        /// </summary>
        public const string NMFISD = "NMFISD";

        /// <summary>
        /// NMNGP.
        /// </summary>
        public const string NMNGP = "NMNGP";

        /// <summary>
        /// NMGPT.
        /// </summary>
        public const string NMGPT = "NMGPT";

        /// <summary>
        /// NMRSDC.
        /// </summary>
        public const string NMRSDC = "NMRSDC";

        /// <summary>
        /// NMMXP.
        /// </summary>
        public const string NMMXP = "NMMXP";

        /// <summary>
        /// NMMPT.
        /// </summary>
        public const string NMMPT = "NMMPT";

        /// <summary>
        /// NMCMXA.
        /// </summary>
        public const string NMCMXA = "NMCMXA";

        /// <summary>
        /// NMCMXP.
        /// </summary>
        public const string NMCMXP = "NMCMXP";

        /// <summary>
        /// NMHMXA.
        /// </summary>
        public const string NMHMXA = "NMHMXA";

        /// <summary>
        /// NMHMXP.
        /// </summary>
        public const string NMHMXP = "NMHMXP";

        /// <summary>
        /// NMCOPF.
        /// </summary>
        public const string NMCOPF = "NMCOPF";

        /// <summary>
        /// NMEFTB.
        /// </summary>
        public const string NMEFTB = "NMEFTB";

        /// <summary>
        /// NMEFTE.
        /// </summary>
        public const string NMEFTE = "NMEFTE";

        /// <summary>
        /// NMBCI.
        /// </summary>
        public const string NMBCI = "NMBCI";

        /// <summary>
        /// NMRAIF.
        /// </summary>
        public const string NMRAIF = "NMRAIF";

        /// <summary>
        /// NMPPCF.
        /// </summary>
        public const string NMPPCF = "NMPPCF";

        /// <summary>
        /// NMSLEV.
        /// </summary>
        public const string NMSLEV = "NMSLEV";

        /// <summary>
        /// NMPTC.
        /// </summary>
        public const string NMPTC = "NMPTC";

        /// <summary>
        /// NMTXA1.
        /// </summary>
        public const string NMTXA1 = "NMTXA1";

        /// <summary>
        /// NMEXR1.
        /// </summary>
        public const string NMEXR1 = "NMEXR1";

        /// <summary>
        /// NMURCD.
        /// </summary>
        public const string NMURCD = "NMURCD";

        /// <summary>
        /// NMURDT.
        /// </summary>
        public const string NMURDT = "NMURDT";

        /// <summary>
        /// NMURAT.
        /// </summary>
        public const string NMURAT = "NMURAT";

        /// <summary>
        /// NMURAB.
        /// </summary>
        public const string NMURAB = "NMURAB";

        /// <summary>
        /// NMURRF.
        /// </summary>
        public const string NMURRF = "NMURRF";

        /// <summary>
        /// NMUSER.
        /// </summary>
        public const string NMUSER = "NMUSER";

        /// <summary>
        /// NMPID.
        /// </summary>
        public const string NMPID = "NMPID";

        /// <summary>
        /// NMUPMJ.
        /// </summary>
        public const string NMUPMJ = "NMUPMJ";

        /// <summary>
        /// NMUPMT.
        /// </summary>
        public const string NMUPMT = "NMUPMT";

        /// <summary>
        /// NMJOBN.
        /// </summary>
        public const string NMJOBN = "NMJOBN";

        /// <summary>
        /// NMCRCD.
        /// </summary>
        public const string NMCRCD = "NMCRCD";

        /// <summary>
        /// NMCRRM.
        /// </summary>
        public const string NMCRRM = "NMCRRM";
    }

    /// <inheritdoc />
    public override string TableName => "F1525B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NMFETP", "NMFETP", JdeDataType.String, 6, true, true),
        new JdeField("NMDOCO", "NMDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NMAN8", "NMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("NMMCU", "NMMCU", JdeDataType.String, 24, true, true),
        new JdeField("NMGLC", "NMGLC", JdeDataType.String, 8, true, true),
        new JdeField("NMLNID", "NMLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("NMAGSN", "NMAGSN", JdeDataType.Numeric, null, true, true),
        new JdeField("NMFFC", "NMFFC", JdeDataType.String, 2),
        new JdeField("NMAG", "NMAG", JdeDataType.Numeric),
        new JdeField("NMFERT", "NMFERT", JdeDataType.Numeric),
        new JdeField("NMRTSC", "NMRTSC", JdeDataType.String, 2),
        new JdeField("NMAAPF", "NMAAPF", JdeDataType.String, 2),
        new JdeField("NMBRCD", "NMBRCD", JdeDataType.String, 8),
        new JdeField("NMFISD", "NMFISD", JdeDataType.String, 2),
        new JdeField("NMNGP", "NMNGP", JdeDataType.Numeric),
        new JdeField("NMGPT", "NMGPT", JdeDataType.String, 2),
        new JdeField("NMRSDC", "NMRSDC", JdeDataType.String, 2),
        new JdeField("NMMXP", "NMMXP", JdeDataType.Numeric),
        new JdeField("NMMPT", "NMMPT", JdeDataType.String, 2),
        new JdeField("NMCMXA", "NMCMXA", JdeDataType.Numeric),
        new JdeField("NMCMXP", "NMCMXP", JdeDataType.Numeric),
        new JdeField("NMHMXA", "NMHMXA", JdeDataType.Numeric),
        new JdeField("NMHMXP", "NMHMXP", JdeDataType.Numeric),
        new JdeField("NMCOPF", "NMCOPF", JdeDataType.String, 2),
        new JdeField("NMEFTB", "NMEFTB", JdeDataType.Numeric),
        new JdeField("NMEFTE", "NMEFTE", JdeDataType.Numeric),
        new JdeField("NMBCI", "NMBCI", JdeDataType.Numeric),
        new JdeField("NMRAIF", "NMRAIF", JdeDataType.String, 2),
        new JdeField("NMPPCF", "NMPPCF", JdeDataType.String, 2),
        new JdeField("NMSLEV", "NMSLEV", JdeDataType.Numeric),
        new JdeField("NMPTC", "NMPTC", JdeDataType.String, 6),
        new JdeField("NMTXA1", "NMTXA1", JdeDataType.String, 20),
        new JdeField("NMEXR1", "NMEXR1", JdeDataType.String, 4),
        new JdeField("NMURCD", "NMURCD", JdeDataType.String, 4),
        new JdeField("NMURDT", "NMURDT", JdeDataType.Numeric),
        new JdeField("NMURAT", "NMURAT", JdeDataType.Numeric),
        new JdeField("NMURAB", "NMURAB", JdeDataType.Numeric),
        new JdeField("NMURRF", "NMURRF", JdeDataType.String, 30),
        new JdeField("NMUSER", "NMUSER", JdeDataType.String, 20),
        new JdeField("NMPID", "NMPID", JdeDataType.String, 20),
        new JdeField("NMUPMJ", "NMUPMJ", JdeDataType.Numeric),
        new JdeField("NMUPMT", "NMUPMT", JdeDataType.Numeric),
        new JdeField("NMJOBN", "NMJOBN", JdeDataType.String, 20),
        new JdeField("NMCRCD", "NMCRCD", JdeDataType.String, 6),
        new JdeField("NMCRRM", "NMCRRM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1525B_0", "Primary Key on NMFETP, NMDOCO, NMAN8, NMMCU, NMGLC, NMAGSN, NMLNID", new[] { "NMFETP", "NMDOCO", "NMAN8", "NMMCU", "NMGLC", "NMAGSN", "NMLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1525B_2", "Index on NMBCI", new[] { "NMBCI" }),
        new JdeIndex("F1525B_3", "Index on NMDOCO, NMMCU", new[] { "NMDOCO", "NMMCU" })
    };
}
