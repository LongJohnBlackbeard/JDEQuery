using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4078 - .
/// </summary>
public class F4078 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RHAN8.
        /// </summary>
        public const string RHAN8 = "RHAN8";

        /// <summary>
        /// RHITM.
        /// </summary>
        public const string RHITM = "RHITM";

        /// <summary>
        /// RHIGID.
        /// </summary>
        public const string RHIGID = "RHIGID";

        /// <summary>
        /// RHCGID.
        /// </summary>
        public const string RHCGID = "RHCGID";

        /// <summary>
        /// RHOGID.
        /// </summary>
        public const string RHOGID = "RHOGID";

        /// <summary>
        /// RHAST.
        /// </summary>
        public const string RHAST = "RHAST";

        /// <summary>
        /// RHMCU.
        /// </summary>
        public const string RHMCU = "RHMCU";

        /// <summary>
        /// RHEFTJ.
        /// </summary>
        public const string RHEFTJ = "RHEFTJ";

        /// <summary>
        /// RHEXDJ.
        /// </summary>
        public const string RHEXDJ = "RHEXDJ";

        /// <summary>
        /// RHTOSA.
        /// </summary>
        public const string RHTOSA = "RHTOSA";

        /// <summary>
        /// RHCRCD.
        /// </summary>
        public const string RHCRCD = "RHCRCD";

        /// <summary>
        /// RHTOQN.
        /// </summary>
        public const string RHTOQN = "RHTOQN";

        /// <summary>
        /// RHUOM.
        /// </summary>
        public const string RHUOM = "RHUOM";

        /// <summary>
        /// RHTOWT.
        /// </summary>
        public const string RHTOWT = "RHTOWT";

        /// <summary>
        /// RHWTUM.
        /// </summary>
        public const string RHWTUM = "RHWTUM";

        /// <summary>
        /// RHRBAM.
        /// </summary>
        public const string RHRBAM = "RHRBAM";

        /// <summary>
        /// RHRBPA.
        /// </summary>
        public const string RHRBPA = "RHRBPA";

        /// <summary>
        /// RHBNAD.
        /// </summary>
        public const string RHBNAD = "RHBNAD";

        /// <summary>
        /// RHRSTH.
        /// </summary>
        public const string RHRSTH = "RHRSTH";

        /// <summary>
        /// RHRHF1.
        /// </summary>
        public const string RHRHF1 = "RHRHF1";

        /// <summary>
        /// RHRHF2.
        /// </summary>
        public const string RHRHF2 = "RHRHF2";

        /// <summary>
        /// RHRHF3.
        /// </summary>
        public const string RHRHF3 = "RHRHF3";

        /// <summary>
        /// RHRHF4.
        /// </summary>
        public const string RHRHF4 = "RHRHF4";

        /// <summary>
        /// RHRHF5.
        /// </summary>
        public const string RHRHF5 = "RHRHF5";

        /// <summary>
        /// RHURDT.
        /// </summary>
        public const string RHURDT = "RHURDT";

        /// <summary>
        /// RHURAT.
        /// </summary>
        public const string RHURAT = "RHURAT";

        /// <summary>
        /// RHURC1.
        /// </summary>
        public const string RHURC1 = "RHURC1";

        /// <summary>
        /// RHCUMORD.
        /// </summary>
        public const string RHCUMORD = "RHCUMORD";

        /// <summary>
        /// RHUSER.
        /// </summary>
        public const string RHUSER = "RHUSER";

        /// <summary>
        /// RHPID.
        /// </summary>
        public const string RHPID = "RHPID";

        /// <summary>
        /// RHJOBN.
        /// </summary>
        public const string RHJOBN = "RHJOBN";

        /// <summary>
        /// RHUPMJ.
        /// </summary>
        public const string RHUPMJ = "RHUPMJ";

        /// <summary>
        /// RHTDAY.
        /// </summary>
        public const string RHTDAY = "RHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4078";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RHAN8", "RHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RHITM", "RHITM", JdeDataType.Numeric, null, true, true),
        new JdeField("RHIGID", "RHIGID", JdeDataType.Numeric, null, true, true),
        new JdeField("RHCGID", "RHCGID", JdeDataType.Numeric, null, true, true),
        new JdeField("RHOGID", "RHOGID", JdeDataType.Numeric, null, true, true),
        new JdeField("RHAST", "RHAST", JdeDataType.String, 16, true, true),
        new JdeField("RHMCU", "RHMCU", JdeDataType.String, 24, true, true),
        new JdeField("RHEFTJ", "RHEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("RHEXDJ", "RHEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("RHTOSA", "RHTOSA", JdeDataType.Numeric),
        new JdeField("RHCRCD", "RHCRCD", JdeDataType.String, 6),
        new JdeField("RHTOQN", "RHTOQN", JdeDataType.Numeric),
        new JdeField("RHUOM", "RHUOM", JdeDataType.String, 4),
        new JdeField("RHTOWT", "RHTOWT", JdeDataType.Numeric),
        new JdeField("RHWTUM", "RHWTUM", JdeDataType.String, 4),
        new JdeField("RHRBAM", "RHRBAM", JdeDataType.Numeric),
        new JdeField("RHRBPA", "RHRBPA", JdeDataType.Numeric),
        new JdeField("RHBNAD", "RHBNAD", JdeDataType.Numeric),
        new JdeField("RHRSTH", "RHRSTH", JdeDataType.String, 2),
        new JdeField("RHRHF1", "RHRHF1", JdeDataType.String, 2),
        new JdeField("RHRHF2", "RHRHF2", JdeDataType.Numeric),
        new JdeField("RHRHF3", "RHRHF3", JdeDataType.Numeric),
        new JdeField("RHRHF4", "RHRHF4", JdeDataType.String, 16),
        new JdeField("RHRHF5", "RHRHF5", JdeDataType.String, 6),
        new JdeField("RHURDT", "RHURDT", JdeDataType.Numeric),
        new JdeField("RHURAT", "RHURAT", JdeDataType.Numeric),
        new JdeField("RHURC1", "RHURC1", JdeDataType.String, 6),
        new JdeField("RHCUMORD", "RHCUMORD", JdeDataType.Numeric),
        new JdeField("RHUSER", "RHUSER", JdeDataType.String, 20),
        new JdeField("RHPID", "RHPID", JdeDataType.String, 20),
        new JdeField("RHJOBN", "RHJOBN", JdeDataType.String, 20),
        new JdeField("RHUPMJ", "RHUPMJ", JdeDataType.Numeric),
        new JdeField("RHTDAY", "RHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4078_0", "Primary Key on RHAN8, RHITM, RHIGID, RHCGID, RHOGID, RHAST, RHMCU, RHEFTJ, RHEXDJ", new[] { "RHAN8", "RHITM", "RHIGID", "RHCGID", "RHOGID", "RHAST", "RHMCU", "RHEFTJ", "RHEXDJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4078_2", "Index on RHAN8, RHAST, RHITM, SYS_NC00034$", new[] { "RHAN8", "RHAST", "RHITM", "SYS_NC00034$" })
    };
}
