using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08501 - .
/// </summary>
public class F08501 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HHAN8.
        /// </summary>
        public const string HHAN8 = "HHAN8";

        /// <summary>
        /// HHPLAN.
        /// </summary>
        public const string HHPLAN = "HHPLAN";

        /// <summary>
        /// HHPSTS.
        /// </summary>
        public const string HHPSTS = "HHPSTS";

        /// <summary>
        /// HHYVS.
        /// </summary>
        public const string HHYVS = "HHYVS";

        /// <summary>
        /// HHYBS.
        /// </summary>
        public const string HHYBS = "HHYBS";

        /// <summary>
        /// HHBENA.
        /// </summary>
        public const string HHBENA = "HHBENA";

        /// <summary>
        /// HHOFFS.
        /// </summary>
        public const string HHOFFS = "HHOFFS";

        /// <summary>
        /// HHDPLE.
        /// </summary>
        public const string HHDPLE = "HHDPLE";

        /// <summary>
        /// HHDMRE.
        /// </summary>
        public const string HHDMRE = "HHDMRE";

        /// <summary>
        /// HHDTTF.
        /// </summary>
        public const string HHDTTF = "HHDTTF";

        /// <summary>
        /// HHDDEC.
        /// </summary>
        public const string HHDDEC = "HHDDEC";

        /// <summary>
        /// HHDRET.
        /// </summary>
        public const string HHDRET = "HHDRET";

        /// <summary>
        /// HHTYRT.
        /// </summary>
        public const string HHTYRT = "HHTYRT";

        /// <summary>
        /// HHCODT.
        /// </summary>
        public const string HHCODT = "HHCODT";

        /// <summary>
        /// HHCOF.
        /// </summary>
        public const string HHCOF = "HHCOF";

        /// <summary>
        /// HHDPN1.
        /// </summary>
        public const string HHDPN1 = "HHDPN1";

        /// <summary>
        /// HHDPN2.
        /// </summary>
        public const string HHDPN2 = "HHDPN2";

        /// <summary>
        /// HHDPN3.
        /// </summary>
        public const string HHDPN3 = "HHDPN3";

        /// <summary>
        /// HHDPN4.
        /// </summary>
        public const string HHDPN4 = "HHDPN4";

        /// <summary>
        /// HHDPN5.
        /// </summary>
        public const string HHDPN5 = "HHDPN5";

        /// <summary>
        /// HHPPC1.
        /// </summary>
        public const string HHPPC1 = "HHPPC1";

        /// <summary>
        /// HHPPC2.
        /// </summary>
        public const string HHPPC2 = "HHPPC2";

        /// <summary>
        /// HHPPC3.
        /// </summary>
        public const string HHPPC3 = "HHPPC3";

        /// <summary>
        /// HHPPC4.
        /// </summary>
        public const string HHPPC4 = "HHPPC4";

        /// <summary>
        /// HHPPC5.
        /// </summary>
        public const string HHPPC5 = "HHPPC5";

        /// <summary>
        /// HHUSER.
        /// </summary>
        public const string HHUSER = "HHUSER";

        /// <summary>
        /// HHPID.
        /// </summary>
        public const string HHPID = "HHPID";

        /// <summary>
        /// HHUPMJ.
        /// </summary>
        public const string HHUPMJ = "HHUPMJ";

        /// <summary>
        /// HHJOBN.
        /// </summary>
        public const string HHJOBN = "HHJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08501";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HHAN8", "HHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("HHPLAN", "HHPLAN", JdeDataType.String, 16, true, true),
        new JdeField("HHPSTS", "HHPSTS", JdeDataType.String, 2),
        new JdeField("HHYVS", "HHYVS", JdeDataType.Numeric),
        new JdeField("HHYBS", "HHYBS", JdeDataType.Numeric),
        new JdeField("HHBENA", "HHBENA", JdeDataType.Numeric),
        new JdeField("HHOFFS", "HHOFFS", JdeDataType.Numeric),
        new JdeField("HHDPLE", "HHDPLE", JdeDataType.Numeric),
        new JdeField("HHDMRE", "HHDMRE", JdeDataType.Numeric),
        new JdeField("HHDTTF", "HHDTTF", JdeDataType.Numeric),
        new JdeField("HHDDEC", "HHDDEC", JdeDataType.Numeric),
        new JdeField("HHDRET", "HHDRET", JdeDataType.Numeric),
        new JdeField("HHTYRT", "HHTYRT", JdeDataType.String, 2),
        new JdeField("HHCODT", "HHCODT", JdeDataType.Numeric),
        new JdeField("HHCOF", "HHCOF", JdeDataType.String, 2),
        new JdeField("HHDPN1", "HHDPN1", JdeDataType.Numeric),
        new JdeField("HHDPN2", "HHDPN2", JdeDataType.Numeric),
        new JdeField("HHDPN3", "HHDPN3", JdeDataType.Numeric),
        new JdeField("HHDPN4", "HHDPN4", JdeDataType.Numeric),
        new JdeField("HHDPN5", "HHDPN5", JdeDataType.Numeric),
        new JdeField("HHPPC1", "HHPPC1", JdeDataType.String, 6),
        new JdeField("HHPPC2", "HHPPC2", JdeDataType.String, 6),
        new JdeField("HHPPC3", "HHPPC3", JdeDataType.String, 6),
        new JdeField("HHPPC4", "HHPPC4", JdeDataType.String, 6),
        new JdeField("HHPPC5", "HHPPC5", JdeDataType.String, 6),
        new JdeField("HHUSER", "HHUSER", JdeDataType.String, 20),
        new JdeField("HHPID", "HHPID", JdeDataType.String, 20),
        new JdeField("HHUPMJ", "HHUPMJ", JdeDataType.Numeric),
        new JdeField("HHJOBN", "HHJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08501_0", "Primary Key on HHAN8, HHPLAN", new[] { "HHAN8", "HHPLAN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08501_2", "Index on HHPLAN, HHAN8", new[] { "HHPLAN", "HHAN8" })
    };
}
