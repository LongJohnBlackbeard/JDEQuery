using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47182 - .
/// </summary>
public class F47182 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EDEDOC.
        /// </summary>
        public const string EDEDOC = "EDEDOC";

        /// <summary>
        /// EDEDCT.
        /// </summary>
        public const string EDEDCT = "EDEDCT";

        /// <summary>
        /// EDEKCO.
        /// </summary>
        public const string EDEKCO = "EDEKCO";

        /// <summary>
        /// EDEDLN.
        /// </summary>
        public const string EDEDLN = "EDEDLN";

        /// <summary>
        /// EDLITM.
        /// </summary>
        public const string EDLITM = "EDLITM";

        /// <summary>
        /// EDQTYCC.
        /// </summary>
        public const string EDQTYCC = "EDQTYCC";

        /// <summary>
        /// EDQTYOHC.
        /// </summary>
        public const string EDQTYOHC = "EDQTYOHC";

        /// <summary>
        /// EDUOM.
        /// </summary>
        public const string EDUOM = "EDUOM";

        /// <summary>
        /// EDQTYCC2.
        /// </summary>
        public const string EDQTYCC2 = "EDQTYCC2";

        /// <summary>
        /// EDQTYOHC2.
        /// </summary>
        public const string EDQTYOHC2 = "EDQTYOHC2";

        /// <summary>
        /// EDUOM2.
        /// </summary>
        public const string EDUOM2 = "EDUOM2";

        /// <summary>
        /// EDCONDATE.
        /// </summary>
        public const string EDCONDATE = "EDCONDATE";

        /// <summary>
        /// EDITM.
        /// </summary>
        public const string EDITM = "EDITM";

        /// <summary>
        /// EDAITM.
        /// </summary>
        public const string EDAITM = "EDAITM";

        /// <summary>
        /// EDCITM.
        /// </summary>
        public const string EDCITM = "EDCITM";

        /// <summary>
        /// EDLOTN.
        /// </summary>
        public const string EDLOTN = "EDLOTN";

        /// <summary>
        /// EDURCD.
        /// </summary>
        public const string EDURCD = "EDURCD";

        /// <summary>
        /// EDURDT.
        /// </summary>
        public const string EDURDT = "EDURDT";

        /// <summary>
        /// EDURAT.
        /// </summary>
        public const string EDURAT = "EDURAT";

        /// <summary>
        /// EDURAB.
        /// </summary>
        public const string EDURAB = "EDURAB";

        /// <summary>
        /// EDURRF.
        /// </summary>
        public const string EDURRF = "EDURRF";

        /// <summary>
        /// EDEDST.
        /// </summary>
        public const string EDEDST = "EDEDST";

        /// <summary>
        /// EDEDFT.
        /// </summary>
        public const string EDEDFT = "EDEDFT";

        /// <summary>
        /// EDEDDT.
        /// </summary>
        public const string EDEDDT = "EDEDDT";

        /// <summary>
        /// EDEDER.
        /// </summary>
        public const string EDEDER = "EDEDER";

        /// <summary>
        /// EDEDDL.
        /// </summary>
        public const string EDEDDL = "EDEDDL";

        /// <summary>
        /// EDEDBT.
        /// </summary>
        public const string EDEDBT = "EDEDBT";

        /// <summary>
        /// EDPNID.
        /// </summary>
        public const string EDPNID = "EDPNID";

        /// <summary>
        /// EDEDSP.
        /// </summary>
        public const string EDEDSP = "EDEDSP";

        /// <summary>
        /// EDEDTY.
        /// </summary>
        public const string EDEDTY = "EDEDTY";

        /// <summary>
        /// EDEDSQ.
        /// </summary>
        public const string EDEDSQ = "EDEDSQ";

        /// <summary>
        /// EDTORG.
        /// </summary>
        public const string EDTORG = "EDTORG";

        /// <summary>
        /// EDUSER.
        /// </summary>
        public const string EDUSER = "EDUSER";

        /// <summary>
        /// EDPID.
        /// </summary>
        public const string EDPID = "EDPID";

        /// <summary>
        /// EDJOBN.
        /// </summary>
        public const string EDJOBN = "EDJOBN";

        /// <summary>
        /// EDUPMJ.
        /// </summary>
        public const string EDUPMJ = "EDUPMJ";

        /// <summary>
        /// EDTDAY.
        /// </summary>
        public const string EDTDAY = "EDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F47182";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EDEDOC", "EDEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("EDEDCT", "EDEDCT", JdeDataType.String, 4, true, true),
        new JdeField("EDEKCO", "EDEKCO", JdeDataType.String, 10, true, true),
        new JdeField("EDEDLN", "EDEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("EDLITM", "EDLITM", JdeDataType.String, 50),
        new JdeField("EDQTYCC", "EDQTYCC", JdeDataType.Numeric),
        new JdeField("EDQTYOHC", "EDQTYOHC", JdeDataType.Numeric),
        new JdeField("EDUOM", "EDUOM", JdeDataType.String, 4),
        new JdeField("EDQTYCC2", "EDQTYCC2", JdeDataType.Numeric),
        new JdeField("EDQTYOHC2", "EDQTYOHC2", JdeDataType.Numeric),
        new JdeField("EDUOM2", "EDUOM2", JdeDataType.String, 4),
        new JdeField("EDCONDATE", "EDCONDATE", JdeDataType.Numeric),
        new JdeField("EDITM", "EDITM", JdeDataType.Numeric),
        new JdeField("EDAITM", "EDAITM", JdeDataType.String, 50),
        new JdeField("EDCITM", "EDCITM", JdeDataType.String, 50),
        new JdeField("EDLOTN", "EDLOTN", JdeDataType.String, 60),
        new JdeField("EDURCD", "EDURCD", JdeDataType.String, 4),
        new JdeField("EDURDT", "EDURDT", JdeDataType.Numeric),
        new JdeField("EDURAT", "EDURAT", JdeDataType.Numeric),
        new JdeField("EDURAB", "EDURAB", JdeDataType.Numeric),
        new JdeField("EDURRF", "EDURRF", JdeDataType.String, 30),
        new JdeField("EDEDST", "EDEDST", JdeDataType.String, 12),
        new JdeField("EDEDFT", "EDEDFT", JdeDataType.String, 20),
        new JdeField("EDEDDT", "EDEDDT", JdeDataType.Numeric),
        new JdeField("EDEDER", "EDEDER", JdeDataType.String, 2),
        new JdeField("EDEDDL", "EDEDDL", JdeDataType.Numeric),
        new JdeField("EDEDBT", "EDEDBT", JdeDataType.String, 30),
        new JdeField("EDPNID", "EDPNID", JdeDataType.String, 30),
        new JdeField("EDEDSP", "EDEDSP", JdeDataType.String, 2),
        new JdeField("EDEDTY", "EDEDTY", JdeDataType.String, 2),
        new JdeField("EDEDSQ", "EDEDSQ", JdeDataType.Numeric),
        new JdeField("EDTORG", "EDTORG", JdeDataType.String, 20),
        new JdeField("EDUSER", "EDUSER", JdeDataType.String, 20),
        new JdeField("EDPID", "EDPID", JdeDataType.String, 20),
        new JdeField("EDJOBN", "EDJOBN", JdeDataType.String, 20),
        new JdeField("EDUPMJ", "EDUPMJ", JdeDataType.Numeric),
        new JdeField("EDTDAY", "EDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47182_0", "Primary Key on EDEDOC, EDEDCT, EDEKCO, EDEDLN", new[] { "EDEDOC", "EDEDCT", "EDEKCO", "EDEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
