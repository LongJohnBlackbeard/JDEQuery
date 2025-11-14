using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F10471 - .
/// </summary>
public class F10471 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ERCNAM.
        /// </summary>
        public const string ERCNAM = "ERCNAM";

        /// <summary>
        /// ERSERK.
        /// </summary>
        public const string ERSERK = "ERSERK";

        /// <summary>
        /// ERLNID.
        /// </summary>
        public const string ERLNID = "ERLNID";

        /// <summary>
        /// ERCO.
        /// </summary>
        public const string ERCO = "ERCO";

        /// <summary>
        /// ERMCU.
        /// </summary>
        public const string ERMCU = "ERMCU";

        /// <summary>
        /// EROBJ.
        /// </summary>
        public const string EROBJ = "EROBJ";

        /// <summary>
        /// ERSUB.
        /// </summary>
        public const string ERSUB = "ERSUB";

        /// <summary>
        /// ERSBL.
        /// </summary>
        public const string ERSBL = "ERSBL";

        /// <summary>
        /// ERSBLT.
        /// </summary>
        public const string ERSBLT = "ERSBLT";

        /// <summary>
        /// ERWRBU.
        /// </summary>
        public const string ERWRBU = "ERWRBU";

        /// <summary>
        /// ERWROB.
        /// </summary>
        public const string ERWROB = "ERWROB";

        /// <summary>
        /// ERWRSB.
        /// </summary>
        public const string ERWRSB = "ERWRSB";

        /// <summary>
        /// ERDL01.
        /// </summary>
        public const string ERDL01 = "ERDL01";

        /// <summary>
        /// ERESBL.
        /// </summary>
        public const string ERESBL = "ERESBL";

        /// <summary>
        /// ERESBT.
        /// </summary>
        public const string ERESBT = "ERESBT";

        /// <summary>
        /// ERTMCU.
        /// </summary>
        public const string ERTMCU = "ERTMCU";

        /// <summary>
        /// ERTOBJ.
        /// </summary>
        public const string ERTOBJ = "ERTOBJ";

        /// <summary>
        /// ERTSUB.
        /// </summary>
        public const string ERTSUB = "ERTSUB";

        /// <summary>
        /// ERDL02.
        /// </summary>
        public const string ERDL02 = "ERDL02";

        /// <summary>
        /// ERELGR.
        /// </summary>
        public const string ERELGR = "ERELGR";

        /// <summary>
        /// ERPE01.
        /// </summary>
        public const string ERPE01 = "ERPE01";

        /// <summary>
        /// ERUSER.
        /// </summary>
        public const string ERUSER = "ERUSER";

        /// <summary>
        /// ERPID.
        /// </summary>
        public const string ERPID = "ERPID";

        /// <summary>
        /// ERJOBN.
        /// </summary>
        public const string ERJOBN = "ERJOBN";

        /// <summary>
        /// ERUPMJ.
        /// </summary>
        public const string ERUPMJ = "ERUPMJ";

        /// <summary>
        /// ERUPMT.
        /// </summary>
        public const string ERUPMT = "ERUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F10471";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ERCNAM", "ERCNAM", JdeDataType.String, 6, true, true),
        new JdeField("ERSERK", "ERSERK", JdeDataType.Numeric, null, true, true),
        new JdeField("ERLNID", "ERLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ERCO", "ERCO", JdeDataType.String, 10),
        new JdeField("ERMCU", "ERMCU", JdeDataType.String, 24),
        new JdeField("EROBJ", "EROBJ", JdeDataType.String, 12),
        new JdeField("ERSUB", "ERSUB", JdeDataType.String, 16),
        new JdeField("ERSBL", "ERSBL", JdeDataType.String, 16),
        new JdeField("ERSBLT", "ERSBLT", JdeDataType.String, 2),
        new JdeField("ERWRBU", "ERWRBU", JdeDataType.String, 24),
        new JdeField("ERWROB", "ERWROB", JdeDataType.String, 12),
        new JdeField("ERWRSB", "ERWRSB", JdeDataType.String, 16),
        new JdeField("ERDL01", "ERDL01", JdeDataType.String, 60),
        new JdeField("ERESBL", "ERESBL", JdeDataType.String, 16),
        new JdeField("ERESBT", "ERESBT", JdeDataType.String, 2),
        new JdeField("ERTMCU", "ERTMCU", JdeDataType.String, 24),
        new JdeField("ERTOBJ", "ERTOBJ", JdeDataType.String, 12),
        new JdeField("ERTSUB", "ERTSUB", JdeDataType.String, 16),
        new JdeField("ERDL02", "ERDL02", JdeDataType.String, 60),
        new JdeField("ERELGR", "ERELGR", JdeDataType.String, 4),
        new JdeField("ERPE01", "ERPE01", JdeDataType.Numeric),
        new JdeField("ERUSER", "ERUSER", JdeDataType.String, 20),
        new JdeField("ERPID", "ERPID", JdeDataType.String, 20),
        new JdeField("ERJOBN", "ERJOBN", JdeDataType.String, 20),
        new JdeField("ERUPMJ", "ERUPMJ", JdeDataType.Numeric),
        new JdeField("ERUPMT", "ERUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F10471_0", "Primary Key on ERCNAM, ERSERK, ERLNID", new[] { "ERCNAM", "ERSERK", "ERLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
