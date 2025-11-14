using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J30 - .
/// </summary>
public class F09J30 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JDJVNAME.
        /// </summary>
        public const string JDJVNAME = "JDJVNAME";

        /// <summary>
        /// JDJVDSC.
        /// </summary>
        public const string JDJVDSC = "JDJVDSC";

        /// <summary>
        /// JDMCU.
        /// </summary>
        public const string JDMCU = "JDMCU";

        /// <summary>
        /// JDCO.
        /// </summary>
        public const string JDCO = "JDCO";

        /// <summary>
        /// JDJVSTS.
        /// </summary>
        public const string JDJVSTS = "JDJVSTS";

        /// <summary>
        /// JDJVAPPR.
        /// </summary>
        public const string JDJVAPPR = "JDJVAPPR";

        /// <summary>
        /// JDANP.
        /// </summary>
        public const string JDANP = "JDANP";

        /// <summary>
        /// JDJVMIN.
        /// </summary>
        public const string JDJVMIN = "JDJVMIN";

        /// <summary>
        /// JDJVCC1.
        /// </summary>
        public const string JDJVCC1 = "JDJVCC1";

        /// <summary>
        /// JDJVCC2.
        /// </summary>
        public const string JDJVCC2 = "JDJVCC2";

        /// <summary>
        /// JDJVCC3.
        /// </summary>
        public const string JDJVCC3 = "JDJVCC3";

        /// <summary>
        /// JDJVCC4.
        /// </summary>
        public const string JDJVCC4 = "JDJVCC4";

        /// <summary>
        /// JDJVCC5.
        /// </summary>
        public const string JDJVCC5 = "JDJVCC5";

        /// <summary>
        /// JDJVCC6.
        /// </summary>
        public const string JDJVCC6 = "JDJVCC6";

        /// <summary>
        /// JDJVCC7.
        /// </summary>
        public const string JDJVCC7 = "JDJVCC7";

        /// <summary>
        /// JDJVCC8.
        /// </summary>
        public const string JDJVCC8 = "JDJVCC8";

        /// <summary>
        /// JDJVCC9.
        /// </summary>
        public const string JDJVCC9 = "JDJVCC9";

        /// <summary>
        /// JDJVCC10.
        /// </summary>
        public const string JDJVCC10 = "JDJVCC10";

        /// <summary>
        /// JDTORG.
        /// </summary>
        public const string JDTORG = "JDTORG";

        /// <summary>
        /// JDENTJ.
        /// </summary>
        public const string JDENTJ = "JDENTJ";

        /// <summary>
        /// JDUSER.
        /// </summary>
        public const string JDUSER = "JDUSER";

        /// <summary>
        /// JDUPMJ.
        /// </summary>
        public const string JDUPMJ = "JDUPMJ";

        /// <summary>
        /// JDUPMT.
        /// </summary>
        public const string JDUPMT = "JDUPMT";

        /// <summary>
        /// JDPID.
        /// </summary>
        public const string JDPID = "JDPID";

        /// <summary>
        /// JDMKEY.
        /// </summary>
        public const string JDMKEY = "JDMKEY";

        /// <summary>
        /// JDURAB.
        /// </summary>
        public const string JDURAB = "JDURAB";

        /// <summary>
        /// JDURCD.
        /// </summary>
        public const string JDURCD = "JDURCD";

        /// <summary>
        /// JDURAT.
        /// </summary>
        public const string JDURAT = "JDURAT";

        /// <summary>
        /// JDURDT.
        /// </summary>
        public const string JDURDT = "JDURDT";

        /// <summary>
        /// JDURRF.
        /// </summary>
        public const string JDURRF = "JDURRF";

        /// <summary>
        /// JDJVJNU1.
        /// </summary>
        public const string JDJVJNU1 = "JDJVJNU1";

        /// <summary>
        /// JDJVJNU2.
        /// </summary>
        public const string JDJVJNU2 = "JDJVJNU2";

        /// <summary>
        /// JDJVJNU3.
        /// </summary>
        public const string JDJVJNU3 = "JDJVJNU3";

        /// <summary>
        /// JDJVJST1.
        /// </summary>
        public const string JDJVJST1 = "JDJVJST1";

        /// <summary>
        /// JDJVJST2.
        /// </summary>
        public const string JDJVJST2 = "JDJVJST2";

        /// <summary>
        /// JDJVJST3.
        /// </summary>
        public const string JDJVJST3 = "JDJVJST3";

        /// <summary>
        /// JDJVJCH1.
        /// </summary>
        public const string JDJVJCH1 = "JDJVJCH1";

        /// <summary>
        /// JDJVJCH2.
        /// </summary>
        public const string JDJVJCH2 = "JDJVJCH2";

        /// <summary>
        /// JDJVJCH3.
        /// </summary>
        public const string JDJVJCH3 = "JDJVJCH3";

        /// <summary>
        /// JDJVJDT1.
        /// </summary>
        public const string JDJVJDT1 = "JDJVJDT1";

        /// <summary>
        /// JDJVJDT2.
        /// </summary>
        public const string JDJVJDT2 = "JDJVJDT2";

        /// <summary>
        /// JDJVJDT3.
        /// </summary>
        public const string JDJVJDT3 = "JDJVJDT3";

        /// <summary>
        /// JDJVDDA.
        /// </summary>
        public const string JDJVDDA = "JDJVDDA";

        /// <summary>
        /// JDJVMCO.
        /// </summary>
        public const string JDJVMCO = "JDJVMCO";

        /// <summary>
        /// JDJVAL.
        /// </summary>
        public const string JDJVAL = "JDJVAL";

        /// <summary>
        /// JDURCDJ01.
        /// </summary>
        public const string JDURCDJ01 = "JDURCDJ01";

        /// <summary>
        /// JDURCDJ02.
        /// </summary>
        public const string JDURCDJ02 = "JDURCDJ02";

        /// <summary>
        /// JDURCDJ03.
        /// </summary>
        public const string JDURCDJ03 = "JDURCDJ03";

        /// <summary>
        /// JDURCDJ04.
        /// </summary>
        public const string JDURCDJ04 = "JDURCDJ04";

        /// <summary>
        /// JDURCDJ05.
        /// </summary>
        public const string JDURCDJ05 = "JDURCDJ05";

        /// <summary>
        /// JDURNUMJ01.
        /// </summary>
        public const string JDURNUMJ01 = "JDURNUMJ01";

        /// <summary>
        /// JDURNUMJ02.
        /// </summary>
        public const string JDURNUMJ02 = "JDURNUMJ02";

        /// <summary>
        /// JDURNUMJ03.
        /// </summary>
        public const string JDURNUMJ03 = "JDURNUMJ03";

        /// <summary>
        /// JDURNUMJ04.
        /// </summary>
        public const string JDURNUMJ04 = "JDURNUMJ04";

        /// <summary>
        /// JDURNUMJ05.
        /// </summary>
        public const string JDURNUMJ05 = "JDURNUMJ05";

        /// <summary>
        /// JDURRFJ01.
        /// </summary>
        public const string JDURRFJ01 = "JDURRFJ01";

        /// <summary>
        /// JDURRFJ02.
        /// </summary>
        public const string JDURRFJ02 = "JDURRFJ02";

        /// <summary>
        /// JDURRFJ03.
        /// </summary>
        public const string JDURRFJ03 = "JDURRFJ03";

        /// <summary>
        /// JDURRFJ04.
        /// </summary>
        public const string JDURRFJ04 = "JDURRFJ04";

        /// <summary>
        /// JDURRFJ05.
        /// </summary>
        public const string JDURRFJ05 = "JDURRFJ05";

        /// <summary>
        /// JDURSTJ01.
        /// </summary>
        public const string JDURSTJ01 = "JDURSTJ01";

        /// <summary>
        /// JDURSTJ02.
        /// </summary>
        public const string JDURSTJ02 = "JDURSTJ02";

        /// <summary>
        /// JDURSTJ03.
        /// </summary>
        public const string JDURSTJ03 = "JDURSTJ03";

        /// <summary>
        /// JDURSTJ04.
        /// </summary>
        public const string JDURSTJ04 = "JDURSTJ04";

        /// <summary>
        /// JDURSTJ05.
        /// </summary>
        public const string JDURSTJ05 = "JDURSTJ05";

        /// <summary>
        /// JDURDTJ01.
        /// </summary>
        public const string JDURDTJ01 = "JDURDTJ01";

        /// <summary>
        /// JDURDTJ02.
        /// </summary>
        public const string JDURDTJ02 = "JDURDTJ02";

        /// <summary>
        /// JDURDTJ03.
        /// </summary>
        public const string JDURDTJ03 = "JDURDTJ03";

        /// <summary>
        /// JDURDTJ04.
        /// </summary>
        public const string JDURDTJ04 = "JDURDTJ04";

        /// <summary>
        /// JDURDTJ05.
        /// </summary>
        public const string JDURDTJ05 = "JDURDTJ05";

        /// <summary>
        /// JDURATJ01.
        /// </summary>
        public const string JDURATJ01 = "JDURATJ01";

        /// <summary>
        /// JDURATJ02.
        /// </summary>
        public const string JDURATJ02 = "JDURATJ02";

        /// <summary>
        /// JDURATJ03.
        /// </summary>
        public const string JDURATJ03 = "JDURATJ03";

        /// <summary>
        /// JDURATJ04.
        /// </summary>
        public const string JDURATJ04 = "JDURATJ04";

        /// <summary>
        /// JDURATJ05.
        /// </summary>
        public const string JDURATJ05 = "JDURATJ05";

        /// <summary>
        /// JDJVCOH.
        /// </summary>
        public const string JDJVCOH = "JDJVCOH";

        /// <summary>
        /// JDJVANOV.
        /// </summary>
        public const string JDJVANOV = "JDJVANOV";

        /// <summary>
        /// JDJVMINV.
        /// </summary>
        public const string JDJVMINV = "JDJVMINV";

        /// <summary>
        /// JDJVMCU.
        /// </summary>
        public const string JDJVMCU = "JDJVMCU";

        /// <summary>
        /// JDJVINDATE.
        /// </summary>
        public const string JDJVINDATE = "JDJVINDATE";

        /// <summary>
        /// JDJVOCD.
        /// </summary>
        public const string JDJVOCD = "JDJVOCD";
    }

    /// <inheritdoc />
    public override string TableName => "F09J30";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JDJVNAME", "JDJVNAME", JdeDataType.String, 40, true, true),
        new JdeField("JDJVDSC", "JDJVDSC", JdeDataType.String, 160),
        new JdeField("JDMCU", "JDMCU", JdeDataType.String, 24),
        new JdeField("JDCO", "JDCO", JdeDataType.String, 10),
        new JdeField("JDJVSTS", "JDJVSTS", JdeDataType.String, 6),
        new JdeField("JDJVAPPR", "JDJVAPPR", JdeDataType.String, 2),
        new JdeField("JDANP", "JDANP", JdeDataType.Numeric),
        new JdeField("JDJVMIN", "JDJVMIN", JdeDataType.Numeric),
        new JdeField("JDJVCC1", "JDJVCC1", JdeDataType.String, 20),
        new JdeField("JDJVCC2", "JDJVCC2", JdeDataType.String, 20),
        new JdeField("JDJVCC3", "JDJVCC3", JdeDataType.String, 20),
        new JdeField("JDJVCC4", "JDJVCC4", JdeDataType.String, 20),
        new JdeField("JDJVCC5", "JDJVCC5", JdeDataType.String, 20),
        new JdeField("JDJVCC6", "JDJVCC6", JdeDataType.String, 20),
        new JdeField("JDJVCC7", "JDJVCC7", JdeDataType.String, 20),
        new JdeField("JDJVCC8", "JDJVCC8", JdeDataType.String, 20),
        new JdeField("JDJVCC9", "JDJVCC9", JdeDataType.String, 20),
        new JdeField("JDJVCC10", "JDJVCC10", JdeDataType.String, 20),
        new JdeField("JDTORG", "JDTORG", JdeDataType.String, 20),
        new JdeField("JDENTJ", "JDENTJ", JdeDataType.Numeric),
        new JdeField("JDUSER", "JDUSER", JdeDataType.String, 20),
        new JdeField("JDUPMJ", "JDUPMJ", JdeDataType.Numeric),
        new JdeField("JDUPMT", "JDUPMT", JdeDataType.Numeric),
        new JdeField("JDPID", "JDPID", JdeDataType.String, 20),
        new JdeField("JDMKEY", "JDMKEY", JdeDataType.String, 30),
        new JdeField("JDURAB", "JDURAB", JdeDataType.Numeric),
        new JdeField("JDURCD", "JDURCD", JdeDataType.String, 4),
        new JdeField("JDURAT", "JDURAT", JdeDataType.Numeric),
        new JdeField("JDURDT", "JDURDT", JdeDataType.Numeric),
        new JdeField("JDURRF", "JDURRF", JdeDataType.String, 30),
        new JdeField("JDJVJNU1", "JDJVJNU1", JdeDataType.Numeric),
        new JdeField("JDJVJNU2", "JDJVJNU2", JdeDataType.Numeric),
        new JdeField("JDJVJNU3", "JDJVJNU3", JdeDataType.Numeric),
        new JdeField("JDJVJST1", "JDJVJST1", JdeDataType.String, 160),
        new JdeField("JDJVJST2", "JDJVJST2", JdeDataType.String, 160),
        new JdeField("JDJVJST3", "JDJVJST3", JdeDataType.String, 160),
        new JdeField("JDJVJCH1", "JDJVJCH1", JdeDataType.String, 2),
        new JdeField("JDJVJCH2", "JDJVJCH2", JdeDataType.String, 2),
        new JdeField("JDJVJCH3", "JDJVJCH3", JdeDataType.String, 2),
        new JdeField("JDJVJDT1", "JDJVJDT1", JdeDataType.Numeric),
        new JdeField("JDJVJDT2", "JDJVJDT2", JdeDataType.Numeric),
        new JdeField("JDJVJDT3", "JDJVJDT3", JdeDataType.Numeric),
        new JdeField("JDJVDDA", "JDJVDDA", JdeDataType.Numeric),
        new JdeField("JDJVMCO", "JDJVMCO", JdeDataType.String, 10),
        new JdeField("JDJVAL", "JDJVAL", JdeDataType.String, 40),
        new JdeField("JDURCDJ01", "JDURCDJ01", JdeDataType.String, 4),
        new JdeField("JDURCDJ02", "JDURCDJ02", JdeDataType.String, 4),
        new JdeField("JDURCDJ03", "JDURCDJ03", JdeDataType.String, 4),
        new JdeField("JDURCDJ04", "JDURCDJ04", JdeDataType.String, 4),
        new JdeField("JDURCDJ05", "JDURCDJ05", JdeDataType.String, 4),
        new JdeField("JDURNUMJ01", "JDURNUMJ01", JdeDataType.Numeric),
        new JdeField("JDURNUMJ02", "JDURNUMJ02", JdeDataType.Numeric),
        new JdeField("JDURNUMJ03", "JDURNUMJ03", JdeDataType.Numeric),
        new JdeField("JDURNUMJ04", "JDURNUMJ04", JdeDataType.Numeric),
        new JdeField("JDURNUMJ05", "JDURNUMJ05", JdeDataType.Numeric),
        new JdeField("JDURRFJ01", "JDURRFJ01", JdeDataType.String, 30),
        new JdeField("JDURRFJ02", "JDURRFJ02", JdeDataType.String, 30),
        new JdeField("JDURRFJ03", "JDURRFJ03", JdeDataType.String, 30),
        new JdeField("JDURRFJ04", "JDURRFJ04", JdeDataType.String, 30),
        new JdeField("JDURRFJ05", "JDURRFJ05", JdeDataType.String, 30),
        new JdeField("JDURSTJ01", "JDURSTJ01", JdeDataType.String, 160),
        new JdeField("JDURSTJ02", "JDURSTJ02", JdeDataType.String, 160),
        new JdeField("JDURSTJ03", "JDURSTJ03", JdeDataType.String, 160),
        new JdeField("JDURSTJ04", "JDURSTJ04", JdeDataType.String, 160),
        new JdeField("JDURSTJ05", "JDURSTJ05", JdeDataType.String, 160),
        new JdeField("JDURDTJ01", "JDURDTJ01", JdeDataType.Numeric),
        new JdeField("JDURDTJ02", "JDURDTJ02", JdeDataType.Numeric),
        new JdeField("JDURDTJ03", "JDURDTJ03", JdeDataType.Numeric),
        new JdeField("JDURDTJ04", "JDURDTJ04", JdeDataType.Numeric),
        new JdeField("JDURDTJ05", "JDURDTJ05", JdeDataType.Numeric),
        new JdeField("JDURATJ01", "JDURATJ01", JdeDataType.Numeric),
        new JdeField("JDURATJ02", "JDURATJ02", JdeDataType.Numeric),
        new JdeField("JDURATJ03", "JDURATJ03", JdeDataType.Numeric),
        new JdeField("JDURATJ04", "JDURATJ04", JdeDataType.Numeric),
        new JdeField("JDURATJ05", "JDURATJ05", JdeDataType.Numeric),
        new JdeField("JDJVCOH", "JDJVCOH", JdeDataType.String, 2),
        new JdeField("JDJVANOV", "JDJVANOV", JdeDataType.String, 2),
        new JdeField("JDJVMINV", "JDJVMINV", JdeDataType.Numeric),
        new JdeField("JDJVMCU", "JDJVMCU", JdeDataType.String, 24),
        new JdeField("JDJVINDATE", "JDJVINDATE", JdeDataType.Numeric),
        new JdeField("JDJVOCD", "JDJVOCD", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J30_0", "Primary Key on JDJVNAME", new[] { "JDJVNAME" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09J30_2", "Index on JDJVAL", new[] { "JDJVAL" }),
        new JdeIndex("F09J30_3", "Index on JDJVAPPR", new[] { "JDJVAPPR" }),
        new JdeIndex("F09J30_4", "Index on JDMCU", new[] { "JDMCU" })
    };
}
