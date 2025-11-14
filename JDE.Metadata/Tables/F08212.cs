using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08212 - .
/// </summary>
public class F08212 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SURPYR.
        /// </summary>
        public const string SURPYR = "SURPYR";

        /// <summary>
        /// SUUTID.
        /// </summary>
        public const string SUUTID = "SUUTID";

        /// <summary>
        /// SUISSN.
        /// </summary>
        public const string SUISSN = "SUISSN";

        /// <summary>
        /// SUSBID.
        /// </summary>
        public const string SUSBID = "SUSBID";

        /// <summary>
        /// SUSBIC.
        /// </summary>
        public const string SUSBIC = "SUSBIC";

        /// <summary>
        /// SUAIRI.
        /// </summary>
        public const string SUAIRI = "SUAIRI";

        /// <summary>
        /// SUTAXX.
        /// </summary>
        public const string SUTAXX = "SUTAXX";

        /// <summary>
        /// SURCK5.
        /// </summary>
        public const string SURCK5 = "SURCK5";

        /// <summary>
        /// SURECPTID.
        /// </summary>
        public const string SURECPTID = "SURECPTID";

        /// <summary>
        /// SURIBC.
        /// </summary>
        public const string SURIBC = "SURIBC";

        /// <summary>
        /// SU1095SCNT.
        /// </summary>
        public const string SU1095SCNT = "SU1095SCNT";

        /// <summary>
        /// SUAATR.
        /// </summary>
        public const string SUAATR = "SUAATR";

        /// <summary>
        /// SUATFC.
        /// </summary>
        public const string SUATFC = "SUATFC";

        /// <summary>
        /// SUIRSS.
        /// </summary>
        public const string SUIRSS = "SUIRSS";

        /// <summary>
        /// SUSPACUSN1.
        /// </summary>
        public const string SUSPACUSN1 = "SUSPACUSN1";

        /// <summary>
        /// SUSPACUSN2.
        /// </summary>
        public const string SUSPACUSN2 = "SUSPACUSN2";

        /// <summary>
        /// SUSPACUSN3.
        /// </summary>
        public const string SUSPACUSN3 = "SUSPACUSN3";

        /// <summary>
        /// SUSPACUSN4.
        /// </summary>
        public const string SUSPACUSN4 = "SUSPACUSN4";

        /// <summary>
        /// SUSPADUSN1.
        /// </summary>
        public const string SUSPADUSN1 = "SUSPADUSN1";

        /// <summary>
        /// SUSPADUSN2.
        /// </summary>
        public const string SUSPADUSN2 = "SUSPADUSN2";

        /// <summary>
        /// SUSPADUSN3.
        /// </summary>
        public const string SUSPADUSN3 = "SUSPADUSN3";

        /// <summary>
        /// SUSPADUSN4.
        /// </summary>
        public const string SUSPADUSN4 = "SUSPADUSN4";

        /// <summary>
        /// SUSPANUSN1.
        /// </summary>
        public const string SUSPANUSN1 = "SUSPANUSN1";

        /// <summary>
        /// SUSPANUSN2.
        /// </summary>
        public const string SUSPANUSN2 = "SUSPANUSN2";

        /// <summary>
        /// SUSPANUSN3.
        /// </summary>
        public const string SUSPANUSN3 = "SUSPANUSN3";

        /// <summary>
        /// SUSPANUSN4.
        /// </summary>
        public const string SUSPANUSN4 = "SUSPANUSN4";

        /// <summary>
        /// SUSPASUSN1.
        /// </summary>
        public const string SUSPASUSN1 = "SUSPASUSN1";

        /// <summary>
        /// SUSPASUSN2.
        /// </summary>
        public const string SUSPASUSN2 = "SUSPASUSN2";

        /// <summary>
        /// SUSPASUSN3.
        /// </summary>
        public const string SUSPASUSN3 = "SUSPASUSN3";

        /// <summary>
        /// SUSPASUSN4.
        /// </summary>
        public const string SUSPASUSN4 = "SUSPASUSN4";

        /// <summary>
        /// SUSPASUSN5.
        /// </summary>
        public const string SUSPASUSN5 = "SUSPASUSN5";

        /// <summary>
        /// SUSPASUSN6.
        /// </summary>
        public const string SUSPASUSN6 = "SUSPASUSN6";

        /// <summary>
        /// SUSPASUSN7.
        /// </summary>
        public const string SUSPASUSN7 = "SUSPASUSN7";

        /// <summary>
        /// SUSPASUSN8.
        /// </summary>
        public const string SUSPASUSN8 = "SUSPASUSN8";

        /// <summary>
        /// SUUSER.
        /// </summary>
        public const string SUUSER = "SUUSER";

        /// <summary>
        /// SUPID.
        /// </summary>
        public const string SUPID = "SUPID";

        /// <summary>
        /// SUJOBN.
        /// </summary>
        public const string SUJOBN = "SUJOBN";

        /// <summary>
        /// SUUPMJ.
        /// </summary>
        public const string SUUPMJ = "SUUPMJ";

        /// <summary>
        /// SUUPMT.
        /// </summary>
        public const string SUUPMT = "SUUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08212";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SURPYR", "SURPYR", JdeDataType.Numeric, null, true, true),
        new JdeField("SUUTID", "SUUTID", JdeDataType.String, 102, true, true),
        new JdeField("SUISSN", "SUISSN", JdeDataType.Numeric, null, true, true),
        new JdeField("SUSBID", "SUSBID", JdeDataType.Numeric),
        new JdeField("SUSBIC", "SUSBIC", JdeDataType.Numeric),
        new JdeField("SUAIRI", "SUAIRI", JdeDataType.String, 20),
        new JdeField("SUTAXX", "SUTAXX", JdeDataType.String, 40),
        new JdeField("SURCK5", "SURCK5", JdeDataType.Numeric),
        new JdeField("SURECPTID", "SURECPTID", JdeDataType.String, 40),
        new JdeField("SURIBC", "SURIBC", JdeDataType.String, 40),
        new JdeField("SU1095SCNT", "SU1095SCNT", JdeDataType.Numeric),
        new JdeField("SUAATR", "SUAATR", JdeDataType.String, 2),
        new JdeField("SUATFC", "SUATFC", JdeDataType.Numeric),
        new JdeField("SUIRSS", "SUIRSS", JdeDataType.String, 2),
        new JdeField("SUSPACUSN1", "SUSPACUSN1", JdeDataType.String, 2),
        new JdeField("SUSPACUSN2", "SUSPACUSN2", JdeDataType.String, 2),
        new JdeField("SUSPACUSN3", "SUSPACUSN3", JdeDataType.String, 2),
        new JdeField("SUSPACUSN4", "SUSPACUSN4", JdeDataType.String, 2),
        new JdeField("SUSPADUSN1", "SUSPADUSN1", JdeDataType.Numeric),
        new JdeField("SUSPADUSN2", "SUSPADUSN2", JdeDataType.Numeric),
        new JdeField("SUSPADUSN3", "SUSPADUSN3", JdeDataType.Numeric),
        new JdeField("SUSPADUSN4", "SUSPADUSN4", JdeDataType.Numeric),
        new JdeField("SUSPANUSN1", "SUSPANUSN1", JdeDataType.Numeric),
        new JdeField("SUSPANUSN2", "SUSPANUSN2", JdeDataType.Numeric),
        new JdeField("SUSPANUSN3", "SUSPANUSN3", JdeDataType.Numeric),
        new JdeField("SUSPANUSN4", "SUSPANUSN4", JdeDataType.Numeric),
        new JdeField("SUSPASUSN1", "SUSPASUSN1", JdeDataType.String, 60),
        new JdeField("SUSPASUSN2", "SUSPASUSN2", JdeDataType.String, 60),
        new JdeField("SUSPASUSN3", "SUSPASUSN3", JdeDataType.String, 60),
        new JdeField("SUSPASUSN4", "SUSPASUSN4", JdeDataType.String, 60),
        new JdeField("SUSPASUSN5", "SUSPASUSN5", JdeDataType.String, 20),
        new JdeField("SUSPASUSN6", "SUSPASUSN6", JdeDataType.String, 20),
        new JdeField("SUSPASUSN7", "SUSPASUSN7", JdeDataType.String, 20),
        new JdeField("SUSPASUSN8", "SUSPASUSN8", JdeDataType.String, 20),
        new JdeField("SUUSER", "SUUSER", JdeDataType.String, 20),
        new JdeField("SUPID", "SUPID", JdeDataType.String, 20),
        new JdeField("SUJOBN", "SUJOBN", JdeDataType.String, 20),
        new JdeField("SUUPMJ", "SUUPMJ", JdeDataType.Numeric),
        new JdeField("SUUPMT", "SUUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08212_0", "Primary Key on SURPYR, SUUTID, SUISSN", new[] { "SURPYR", "SUUTID", "SUISSN" }, isUnique: true, isPrimaryKey: true)
    };
}
