using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0006DZ1 - .
/// </summary>
public class F0006DZ1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDUS.
        /// </summary>
        public const string SZEDUS = "SZEDUS";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZLNID.
        /// </summary>
        public const string SZLNID = "SZLNID";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZACTN.
        /// </summary>
        public const string SZACTN = "SZACTN";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZLNGP.
        /// </summary>
        public const string SZLNGP = "SZLNGP";

        /// <summary>
        /// SZDL01.
        /// </summary>
        public const string SZDL01 = "SZDL01";

        /// <summary>
        /// SZDL02.
        /// </summary>
        public const string SZDL02 = "SZDL02";

        /// <summary>
        /// SZDL03.
        /// </summary>
        public const string SZDL03 = "SZDL03";

        /// <summary>
        /// SZDL04.
        /// </summary>
        public const string SZDL04 = "SZDL04";

        /// <summary>
        /// SZDC.
        /// </summary>
        public const string SZDC = "SZDC";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZUPMT.
        /// </summary>
        public const string SZUPMT = "SZUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0006DZ1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZLNID", "SZLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZACTN", "SZACTN", JdeDataType.String, 2),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24, true, true),
        new JdeField("SZLNGP", "SZLNGP", JdeDataType.String, 4, true, true),
        new JdeField("SZDL01", "SZDL01", JdeDataType.String, 60),
        new JdeField("SZDL02", "SZDL02", JdeDataType.String, 60),
        new JdeField("SZDL03", "SZDL03", JdeDataType.String, 60),
        new JdeField("SZDL04", "SZDL04", JdeDataType.String, 60),
        new JdeField("SZDC", "SZDC", JdeDataType.String, 80),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZUPMT", "SZUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0006DZ1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN, SZLNID, SZMCU, SZLNGP", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN", "SZLNID", "SZMCU", "SZLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
