using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F10470 - .
/// </summary>
public class F10470 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSCNAM.
        /// </summary>
        public const string CSCNAM = "CSCNAM";

        /// <summary>
        /// CSSERK.
        /// </summary>
        public const string CSSERK = "CSSERK";

        /// <summary>
        /// CSCNBU.
        /// </summary>
        public const string CSCNBU = "CSCNBU";

        /// <summary>
        /// CSOSNM.
        /// </summary>
        public const string CSOSNM = "CSOSNM";

        /// <summary>
        /// CSSEQL.
        /// </summary>
        public const string CSSEQL = "CSSEQL";

        /// <summary>
        /// CSSEQV.
        /// </summary>
        public const string CSSEQV = "CSSEQV";

        /// <summary>
        /// CSSMCUS.
        /// </summary>
        public const string CSSMCUS = "CSSMCUS";

        /// <summary>
        /// CSSEFT.
        /// </summary>
        public const string CSSEFT = "CSSEFT";

        /// <summary>
        /// CSSVER.
        /// </summary>
        public const string CSSVER = "CSSVER";

        /// <summary>
        /// CSOTPA.
        /// </summary>
        public const string CSOTPA = "CSOTPA";

        /// <summary>
        /// CSLDA.
        /// </summary>
        public const string CSLDA = "CSLDA";

        /// <summary>
        /// CSSBLD.
        /// </summary>
        public const string CSSBLD = "CSSBLD";

        /// <summary>
        /// CSABIN.
        /// </summary>
        public const string CSABIN = "CSABIN";

        /// <summary>
        /// CSRNDG.
        /// </summary>
        public const string CSRNDG = "CSRNDG";

        /// <summary>
        /// CSFLT1.
        /// </summary>
        public const string CSFLT1 = "CSFLT1";

        /// <summary>
        /// CSFLT2.
        /// </summary>
        public const string CSFLT2 = "CSFLT2";

        /// <summary>
        /// CSFLT3.
        /// </summary>
        public const string CSFLT3 = "CSFLT3";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSJOBN.
        /// </summary>
        public const string CSJOBN = "CSJOBN";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSVERS.
        /// </summary>
        public const string CSVERS = "CSVERS";

        /// <summary>
        /// CSUPMJ.
        /// </summary>
        public const string CSUPMJ = "CSUPMJ";

        /// <summary>
        /// CSUPMT.
        /// </summary>
        public const string CSUPMT = "CSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F10470";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSCNAM", "CSCNAM", JdeDataType.String, 6, true, true),
        new JdeField("CSSERK", "CSSERK", JdeDataType.Numeric, null, true, true),
        new JdeField("CSCNBU", "CSCNBU", JdeDataType.String, 2),
        new JdeField("CSOSNM", "CSOSNM", JdeDataType.String, 20),
        new JdeField("CSSEQL", "CSSEQL", JdeDataType.String, 4),
        new JdeField("CSSEQV", "CSSEQV", JdeDataType.String, 20),
        new JdeField("CSSMCUS", "CSSMCUS", JdeDataType.String, 2),
        new JdeField("CSSEFT", "CSSEFT", JdeDataType.Numeric),
        new JdeField("CSSVER", "CSSVER", JdeDataType.String, 20),
        new JdeField("CSOTPA", "CSOTPA", JdeDataType.String, 6),
        new JdeField("CSLDA", "CSLDA", JdeDataType.String, 2),
        new JdeField("CSSBLD", "CSSBLD", JdeDataType.String, 2),
        new JdeField("CSABIN", "CSABIN", JdeDataType.String, 2),
        new JdeField("CSRNDG", "CSRNDG", JdeDataType.String, 2),
        new JdeField("CSFLT1", "CSFLT1", JdeDataType.String, 4),
        new JdeField("CSFLT2", "CSFLT2", JdeDataType.String, 4),
        new JdeField("CSFLT3", "CSFLT3", JdeDataType.String, 4),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSVERS", "CSVERS", JdeDataType.String, 20),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSUPMT", "CSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F10470_0", "Primary Key on CSCNAM, CSSERK", new[] { "CSCNAM", "CSSERK" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F10470_2", "Index on CSCNBU, CSCNAM, CSOSNM, CSSEQL, CSSEQV, CSSMCUS, CSSEFT, CSSVER, CSOTPA, CSLDA", new[] { "CSCNBU", "CSCNAM", "CSOSNM", "CSSEQL", "CSSEQV", "CSSMCUS", "CSSEFT", "CSSVER", "CSOTPA", "CSLDA" })
    };
}
