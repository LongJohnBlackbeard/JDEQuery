using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79AU21 - .
/// </summary>
public class F79AU21 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GWCTID.
        /// </summary>
        public const string GWCTID = "GWCTID";

        /// <summary>
        /// GWJOBS.
        /// </summary>
        public const string GWJOBS = "GWJOBS";

        /// <summary>
        /// GWLNIX.
        /// </summary>
        public const string GWLNIX = "GWLNIX";

        /// <summary>
        /// GW79AGETY.
        /// </summary>
        public const string GW79AGETY = "GW79AGETY";

        /// <summary>
        /// GW79AGERID.
        /// </summary>
        public const string GW79AGERID = "GW79AGERID";

        /// <summary>
        /// GW79AGUM.
        /// </summary>
        public const string GW79AGUM = "GW79AGUM";

        /// <summary>
        /// GW79ASGQ.
        /// </summary>
        public const string GW79ASGQ = "GW79ASGQ";

        /// <summary>
        /// GW79AGCUM.
        /// </summary>
        public const string GW79AGCUM = "GW79AGCUM";

        /// <summary>
        /// GW79ACO2Q.
        /// </summary>
        public const string GW79ACO2Q = "GW79ACO2Q";

        /// <summary>
        /// GWURCD.
        /// </summary>
        public const string GWURCD = "GWURCD";

        /// <summary>
        /// GWURRF.
        /// </summary>
        public const string GWURRF = "GWURRF";

        /// <summary>
        /// GWURAB.
        /// </summary>
        public const string GWURAB = "GWURAB";

        /// <summary>
        /// GWURAT.
        /// </summary>
        public const string GWURAT = "GWURAT";

        /// <summary>
        /// GWURDT.
        /// </summary>
        public const string GWURDT = "GWURDT";

        /// <summary>
        /// GWPID.
        /// </summary>
        public const string GWPID = "GWPID";

        /// <summary>
        /// GWUSER.
        /// </summary>
        public const string GWUSER = "GWUSER";

        /// <summary>
        /// GWJOBN.
        /// </summary>
        public const string GWJOBN = "GWJOBN";

        /// <summary>
        /// GWUPMJ.
        /// </summary>
        public const string GWUPMJ = "GWUPMJ";

        /// <summary>
        /// GWTDAY.
        /// </summary>
        public const string GWTDAY = "GWTDAY";

        /// <summary>
        /// GW79AGCM.
        /// </summary>
        public const string GW79AGCM = "GW79AGCM";
    }

    /// <inheritdoc />
    public override string TableName => "F79AU21";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GWCTID", "GWCTID", JdeDataType.String, 30, true, true),
        new JdeField("GWJOBS", "GWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("GWLNIX", "GWLNIX", JdeDataType.Numeric, null, true, true),
        new JdeField("GW79AGETY", "GW79AGETY", JdeDataType.String, 20, true, true),
        new JdeField("GW79AGERID", "GW79AGERID", JdeDataType.Numeric),
        new JdeField("GW79AGUM", "GW79AGUM", JdeDataType.String, 30),
        new JdeField("GW79ASGQ", "GW79ASGQ", JdeDataType.Numeric),
        new JdeField("GW79AGCUM", "GW79AGCUM", JdeDataType.String, 4),
        new JdeField("GW79ACO2Q", "GW79ACO2Q", JdeDataType.Numeric),
        new JdeField("GWURCD", "GWURCD", JdeDataType.String, 4),
        new JdeField("GWURRF", "GWURRF", JdeDataType.String, 30),
        new JdeField("GWURAB", "GWURAB", JdeDataType.Numeric),
        new JdeField("GWURAT", "GWURAT", JdeDataType.Numeric),
        new JdeField("GWURDT", "GWURDT", JdeDataType.Numeric),
        new JdeField("GWPID", "GWPID", JdeDataType.String, 20),
        new JdeField("GWUSER", "GWUSER", JdeDataType.String, 20),
        new JdeField("GWJOBN", "GWJOBN", JdeDataType.String, 20),
        new JdeField("GWUPMJ", "GWUPMJ", JdeDataType.Numeric),
        new JdeField("GWTDAY", "GWTDAY", JdeDataType.Numeric),
        new JdeField("GW79AGCM", "GW79AGCM", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79AU21_0", "Primary Key on GWCTID, GWJOBS, GWLNIX, GW79AGETY", new[] { "GWCTID", "GWJOBS", "GWLNIX", "GW79AGETY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79AU21_2", "Index on GWUPMJ, GWTDAY", new[] { "GWUPMJ", "GWTDAY" }),
        new JdeIndex("F79AU21_3", "Index on GWJOBS, GWUPMJ", new[] { "GWJOBS", "GWUPMJ" })
    };
}
