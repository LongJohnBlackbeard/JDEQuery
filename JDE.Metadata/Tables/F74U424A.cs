using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U424A - .
/// </summary>
public class F74U424A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PLDOCO.
        /// </summary>
        public const string PLDOCO = "PLDOCO";

        /// <summary>
        /// PLDCTO.
        /// </summary>
        public const string PLDCTO = "PLDCTO";

        /// <summary>
        /// PLKCOO.
        /// </summary>
        public const string PLKCOO = "PLKCOO";

        /// <summary>
        /// PLSFXO.
        /// </summary>
        public const string PLSFXO = "PLSFXO";

        /// <summary>
        /// PLLNID.
        /// </summary>
        public const string PLLNID = "PLLNID";

        /// <summary>
        /// PLICU.
        /// </summary>
        public const string PLICU = "PLICU";

        /// <summary>
        /// PLDGJ.
        /// </summary>
        public const string PLDGJ = "PLDGJ";

        /// <summary>
        /// PLMCU.
        /// </summary>
        public const string PLMCU = "PLMCU";

        /// <summary>
        /// PLOBJ.
        /// </summary>
        public const string PLOBJ = "PLOBJ";

        /// <summary>
        /// PLSUB.
        /// </summary>
        public const string PLSUB = "PLSUB";

        /// <summary>
        /// PLSBL.
        /// </summary>
        public const string PLSBL = "PLSBL";

        /// <summary>
        /// PLSBLT.
        /// </summary>
        public const string PLSBLT = "PLSBLT";

        /// <summary>
        /// PLLITM.
        /// </summary>
        public const string PLLITM = "PLLITM";

        /// <summary>
        /// PL74UAMT1.
        /// </summary>
        public const string PL74UAMT1 = "PL74UAMT1";

        /// <summary>
        /// PL74UAMT2.
        /// </summary>
        public const string PL74UAMT2 = "PL74UAMT2";

        /// <summary>
        /// PL74UGFL.
        /// </summary>
        public const string PL74UGFL = "PL74UGFL";

        /// <summary>
        /// PLEDSP.
        /// </summary>
        public const string PLEDSP = "PLEDSP";

        /// <summary>
        /// PLPID.
        /// </summary>
        public const string PLPID = "PLPID";

        /// <summary>
        /// PLABT1.
        /// </summary>
        public const string PLABT1 = "PLABT1";

        /// <summary>
        /// PLABR1.
        /// </summary>
        public const string PLABR1 = "PLABR1";

        /// <summary>
        /// PLABT2.
        /// </summary>
        public const string PLABT2 = "PLABT2";

        /// <summary>
        /// PLABR2.
        /// </summary>
        public const string PLABR2 = "PLABR2";

        /// <summary>
        /// PLABT3.
        /// </summary>
        public const string PLABT3 = "PLABT3";

        /// <summary>
        /// PLABR3.
        /// </summary>
        public const string PLABR3 = "PLABR3";

        /// <summary>
        /// PLABT4.
        /// </summary>
        public const string PLABT4 = "PLABT4";

        /// <summary>
        /// PLABR4.
        /// </summary>
        public const string PLABR4 = "PLABR4";

        /// <summary>
        /// PLUSER.
        /// </summary>
        public const string PLUSER = "PLUSER";

        /// <summary>
        /// PLJOBN.
        /// </summary>
        public const string PLJOBN = "PLJOBN";

        /// <summary>
        /// PLUPMJ.
        /// </summary>
        public const string PLUPMJ = "PLUPMJ";

        /// <summary>
        /// PLUPMT.
        /// </summary>
        public const string PLUPMT = "PLUPMT";

        /// <summary>
        /// PLMKEY.
        /// </summary>
        public const string PLMKEY = "PLMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F74U424A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PLDOCO", "PLDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PLDCTO", "PLDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PLKCOO", "PLKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PLSFXO", "PLSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PLLNID", "PLLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PLICU", "PLICU", JdeDataType.Numeric, null, true, true),
        new JdeField("PLDGJ", "PLDGJ", JdeDataType.Numeric),
        new JdeField("PLMCU", "PLMCU", JdeDataType.String, 24),
        new JdeField("PLOBJ", "PLOBJ", JdeDataType.String, 12),
        new JdeField("PLSUB", "PLSUB", JdeDataType.String, 16),
        new JdeField("PLSBL", "PLSBL", JdeDataType.String, 16),
        new JdeField("PLSBLT", "PLSBLT", JdeDataType.String, 2),
        new JdeField("PLLITM", "PLLITM", JdeDataType.String, 50),
        new JdeField("PL74UAMT1", "PL74UAMT1", JdeDataType.Numeric),
        new JdeField("PL74UAMT2", "PL74UAMT2", JdeDataType.Numeric),
        new JdeField("PL74UGFL", "PL74UGFL", JdeDataType.String, 2),
        new JdeField("PLEDSP", "PLEDSP", JdeDataType.String, 2),
        new JdeField("PLPID", "PLPID", JdeDataType.String, 20),
        new JdeField("PLABT1", "PLABT1", JdeDataType.String, 2),
        new JdeField("PLABR1", "PLABR1", JdeDataType.String, 24),
        new JdeField("PLABT2", "PLABT2", JdeDataType.String, 2),
        new JdeField("PLABR2", "PLABR2", JdeDataType.String, 24),
        new JdeField("PLABT3", "PLABT3", JdeDataType.String, 2),
        new JdeField("PLABR3", "PLABR3", JdeDataType.String, 24),
        new JdeField("PLABT4", "PLABT4", JdeDataType.String, 2),
        new JdeField("PLABR4", "PLABR4", JdeDataType.String, 24),
        new JdeField("PLUSER", "PLUSER", JdeDataType.String, 20),
        new JdeField("PLJOBN", "PLJOBN", JdeDataType.String, 20),
        new JdeField("PLUPMJ", "PLUPMJ", JdeDataType.Numeric),
        new JdeField("PLUPMT", "PLUPMT", JdeDataType.Numeric),
        new JdeField("PLMKEY", "PLMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U424A_0", "Primary Key on PLDOCO, PLDCTO, PLKCOO, PLSFXO, PLLNID, PLICU", new[] { "PLDOCO", "PLDCTO", "PLKCOO", "PLSFXO", "PLLNID", "PLICU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U424A_2", "Index on PLDOCO, PLDCTO, PLKCOO, PLSFXO, PLEDSP", new[] { "PLDOCO", "PLDCTO", "PLKCOO", "PLSFXO", "PLEDSP" }),
        new JdeIndex("F74U424A_3", "Index on PLDOCO, PLDCTO, PLKCOO, PLSFXO, PLMCU, PLOBJ, PLSUB, PLSBL, PLSBLT, PLLITM", new[] { "PLDOCO", "PLDCTO", "PLKCOO", "PLSFXO", "PLMCU", "PLOBJ", "PLSUB", "PLSBL", "PLSBLT", "PLLITM" }),
        new JdeIndex("F74U424A_4", "Index on PLDOCO, PLDCTO, PLKCOO, PLSFXO, PL74UGFL", new[] { "PLDOCO", "PLDCTO", "PLKCOO", "PLSFXO", "PL74UGFL" }),
        new JdeIndex("F74U424A_5", "Index on PLDOCO, PLDCTO, PLKCOO, PLSFXO, PLICU", new[] { "PLDOCO", "PLDCTO", "PLKCOO", "PLSFXO", "PLICU" })
    };
}
