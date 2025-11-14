using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F20103 - .
/// </summary>
public class F20103 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EPEMPLOYID.
        /// </summary>
        public const string EPEMPLOYID = "EPEMPLOYID";

        /// <summary>
        /// EPEMPLREF.
        /// </summary>
        public const string EPEMPLREF = "EPEMPLREF";

        /// <summary>
        /// EPMGRID.
        /// </summary>
        public const string EPMGRID = "EPMGRID";

        /// <summary>
        /// EPGRPPROF.
        /// </summary>
        public const string EPGRPPROF = "EPGRPPROF";

        /// <summary>
        /// EPMULTIEMP.
        /// </summary>
        public const string EPMULTIEMP = "EPMULTIEMP";

        /// <summary>
        /// EPMONEMPL.
        /// </summary>
        public const string EPMONEMPL = "EPMONEMPL";

        /// <summary>
        /// EPREIMMETH.
        /// </summary>
        public const string EPREIMMETH = "EPREIMMETH";

        /// <summary>
        /// EPREIMCRCY.
        /// </summary>
        public const string EPREIMCRCY = "EPREIMCRCY";

        /// <summary>
        /// EPAPPREQD.
        /// </summary>
        public const string EPAPPREQD = "EPAPPREQD";

        /// <summary>
        /// EPEFTJ.
        /// </summary>
        public const string EPEFTJ = "EPEFTJ";

        /// <summary>
        /// EPHMCUSRCE.
        /// </summary>
        public const string EPHMCUSRCE = "EPHMCUSRCE";

        /// <summary>
        /// EPEMSFLAG1.
        /// </summary>
        public const string EPEMSFLAG1 = "EPEMSFLAG1";

        /// <summary>
        /// EPEMSFLAG2.
        /// </summary>
        public const string EPEMSFLAG2 = "EPEMSFLAG2";

        /// <summary>
        /// EPEMSSTR10.
        /// </summary>
        public const string EPEMSSTR10 = "EPEMSSTR10";

        /// <summary>
        /// EPEMSSTR40.
        /// </summary>
        public const string EPEMSSTR40 = "EPEMSSTR40";

        /// <summary>
        /// EPEMSNUM10.
        /// </summary>
        public const string EPEMSNUM10 = "EPEMSNUM10";

        /// <summary>
        /// EPEMSDATE1.
        /// </summary>
        public const string EPEMSDATE1 = "EPEMSDATE1";

        /// <summary>
        /// EPPID.
        /// </summary>
        public const string EPPID = "EPPID";

        /// <summary>
        /// EPUSER.
        /// </summary>
        public const string EPUSER = "EPUSER";

        /// <summary>
        /// EPJOBN.
        /// </summary>
        public const string EPJOBN = "EPJOBN";

        /// <summary>
        /// EPUPMT.
        /// </summary>
        public const string EPUPMT = "EPUPMT";

        /// <summary>
        /// EPUPMJ.
        /// </summary>
        public const string EPUPMJ = "EPUPMJ";

        /// <summary>
        /// EPOSTP.
        /// </summary>
        public const string EPOSTP = "EPOSTP";
    }

    /// <inheritdoc />
    public override string TableName => "F20103";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EPEMPLOYID", "EPEMPLOYID", JdeDataType.Numeric, null, true, true),
        new JdeField("EPEMPLREF", "EPEMPLREF", JdeDataType.String, 20),
        new JdeField("EPMGRID", "EPMGRID", JdeDataType.Numeric),
        new JdeField("EPGRPPROF", "EPGRPPROF", JdeDataType.String, 10),
        new JdeField("EPMULTIEMP", "EPMULTIEMP", JdeDataType.String, 2),
        new JdeField("EPMONEMPL", "EPMONEMPL", JdeDataType.String, 2),
        new JdeField("EPREIMMETH", "EPREIMMETH", JdeDataType.String, 4),
        new JdeField("EPREIMCRCY", "EPREIMCRCY", JdeDataType.String, 6),
        new JdeField("EPAPPREQD", "EPAPPREQD", JdeDataType.String, 2),
        new JdeField("EPEFTJ", "EPEFTJ", JdeDataType.Numeric),
        new JdeField("EPHMCUSRCE", "EPHMCUSRCE", JdeDataType.String, 2),
        new JdeField("EPEMSFLAG1", "EPEMSFLAG1", JdeDataType.String, 2),
        new JdeField("EPEMSFLAG2", "EPEMSFLAG2", JdeDataType.String, 2),
        new JdeField("EPEMSSTR10", "EPEMSSTR10", JdeDataType.String, 20),
        new JdeField("EPEMSSTR40", "EPEMSSTR40", JdeDataType.String, 80),
        new JdeField("EPEMSNUM10", "EPEMSNUM10", JdeDataType.Numeric),
        new JdeField("EPEMSDATE1", "EPEMSDATE1", JdeDataType.Numeric),
        new JdeField("EPPID", "EPPID", JdeDataType.String, 20),
        new JdeField("EPUSER", "EPUSER", JdeDataType.String, 20),
        new JdeField("EPJOBN", "EPJOBN", JdeDataType.String, 20),
        new JdeField("EPUPMT", "EPUPMT", JdeDataType.Numeric),
        new JdeField("EPUPMJ", "EPUPMJ", JdeDataType.Numeric),
        new JdeField("EPOSTP", "EPOSTP", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F20103_0", "Primary Key on EPEMPLOYID", new[] { "EPEMPLOYID" }, isUnique: true, isPrimaryKey: true)
    };
}
