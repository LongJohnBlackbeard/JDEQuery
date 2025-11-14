using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R9004 - .
/// </summary>
public class F74R9004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRR74RUID.
        /// </summary>
        public const string CRR74RUID = "CRR74RUID";

        /// <summary>
        /// CRICUT.
        /// </summary>
        public const string CRICUT = "CRICUT";

        /// <summary>
        /// CRDCT.
        /// </summary>
        public const string CRDCT = "CRDCT";

        /// <summary>
        /// CRR74DOBJ.
        /// </summary>
        public const string CRR74DOBJ = "CRR74DOBJ";

        /// <summary>
        /// CRR74DSUB.
        /// </summary>
        public const string CRR74DSUB = "CRR74DSUB";

        /// <summary>
        /// CRR74COBJ.
        /// </summary>
        public const string CRR74COBJ = "CRR74COBJ";

        /// <summary>
        /// CRR74CSUB.
        /// </summary>
        public const string CRR74CSUB = "CRR74CSUB";

        /// <summary>
        /// CRR74CAFR.
        /// </summary>
        public const string CRR74CAFR = "CRR74CAFR";

        /// <summary>
        /// CRR74CATH.
        /// </summary>
        public const string CRR74CATH = "CRR74CATH";

        /// <summary>
        /// CRR74CCA1.
        /// </summary>
        public const string CRR74CCA1 = "CRR74CCA1";

        /// <summary>
        /// CRR74CCA2.
        /// </summary>
        public const string CRR74CCA2 = "CRR74CCA2";

        /// <summary>
        /// CRR74CCA3.
        /// </summary>
        public const string CRR74CCA3 = "CRR74CCA3";

        /// <summary>
        /// CRR74CCA4.
        /// </summary>
        public const string CRR74CCA4 = "CRR74CCA4";

        /// <summary>
        /// CRR74CCA5.
        /// </summary>
        public const string CRR74CCA5 = "CRR74CCA5";

        /// <summary>
        /// CRR74CLOD.
        /// </summary>
        public const string CRR74CLOD = "CRR74CLOD";

        /// <summary>
        /// CRR74ACCT.
        /// </summary>
        public const string CRR74ACCT = "CRR74ACCT";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRUPMT.
        /// </summary>
        public const string CRUPMT = "CRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R9004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRR74RUID", "CRR74RUID", JdeDataType.Numeric, null, true, true),
        new JdeField("CRICUT", "CRICUT", JdeDataType.String, 4),
        new JdeField("CRDCT", "CRDCT", JdeDataType.String, 4),
        new JdeField("CRR74DOBJ", "CRR74DOBJ", JdeDataType.String, 12),
        new JdeField("CRR74DSUB", "CRR74DSUB", JdeDataType.String, 16),
        new JdeField("CRR74COBJ", "CRR74COBJ", JdeDataType.String, 12),
        new JdeField("CRR74CSUB", "CRR74CSUB", JdeDataType.String, 16),
        new JdeField("CRR74CAFR", "CRR74CAFR", JdeDataType.String, 20),
        new JdeField("CRR74CATH", "CRR74CATH", JdeDataType.String, 20),
        new JdeField("CRR74CCA1", "CRR74CCA1", JdeDataType.String, 6),
        new JdeField("CRR74CCA2", "CRR74CCA2", JdeDataType.String, 6),
        new JdeField("CRR74CCA3", "CRR74CCA3", JdeDataType.String, 6),
        new JdeField("CRR74CCA4", "CRR74CCA4", JdeDataType.String, 20),
        new JdeField("CRR74CCA5", "CRR74CCA5", JdeDataType.String, 20),
        new JdeField("CRR74CLOD", "CRR74CLOD", JdeDataType.Numeric),
        new JdeField("CRR74ACCT", "CRR74ACCT", JdeDataType.String, 4),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRUPMT", "CRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R9004_0", "Primary Key on CRR74RUID", new[] { "CRR74RUID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74R9004_2", "Index on CRICUT, CRDCT, CRR74DOBJ, CRR74DSUB, CRR74CAFR, CRR74COBJ, CRR74CSUB, CRR74CATH", new[] { "CRICUT", "CRDCT", "CRR74DOBJ", "CRR74DSUB", "CRR74CAFR", "CRR74COBJ", "CRR74CSUB", "CRR74CATH" })
    };
}
