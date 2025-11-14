using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I791 - .
/// </summary>
public class F75I791 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ISPRP5.
        /// </summary>
        public const string ISPRP5 = "ISPRP5";

        /// <summary>
        /// ISITM.
        /// </summary>
        public const string ISITM = "ISITM";

        /// <summary>
        /// ISLITM.
        /// </summary>
        public const string ISLITM = "ISLITM";

        /// <summary>
        /// ISAITM.
        /// </summary>
        public const string ISAITM = "ISAITM";

        /// <summary>
        /// ISMCU.
        /// </summary>
        public const string ISMCU = "ISMCU";

        /// <summary>
        /// ISAN8V.
        /// </summary>
        public const string ISAN8V = "ISAN8V";

        /// <summary>
        /// ISLOCN.
        /// </summary>
        public const string ISLOCN = "ISLOCN";

        /// <summary>
        /// ISLOTN.
        /// </summary>
        public const string ISLOTN = "ISLOTN";

        /// <summary>
        /// ISLVLA.
        /// </summary>
        public const string ISLVLA = "ISLVLA";

        /// <summary>
        /// ISLVLB.
        /// </summary>
        public const string ISLVLB = "ISLVLB";

        /// <summary>
        /// ISPCST.
        /// </summary>
        public const string ISPCST = "ISPCST";

        /// <summary>
        /// ISPAMT.
        /// </summary>
        public const string ISPAMT = "ISPAMT";

        /// <summary>
        /// ISRATF.
        /// </summary>
        public const string ISRATF = "ISRATF";

        /// <summary>
        /// ISRATV.
        /// </summary>
        public const string ISRATV = "ISRATV";

        /// <summary>
        /// ISAN8.
        /// </summary>
        public const string ISAN8 = "ISAN8";

        /// <summary>
        /// ISGLC.
        /// </summary>
        public const string ISGLC = "ISGLC";

        /// <summary>
        /// ISGLPT.
        /// </summary>
        public const string ISGLPT = "ISGLPT";

        /// <summary>
        /// ISEFFF.
        /// </summary>
        public const string ISEFFF = "ISEFFF";

        /// <summary>
        /// ISEFFT.
        /// </summary>
        public const string ISEFFT = "ISEFFT";

        /// <summary>
        /// ISTX.
        /// </summary>
        public const string ISTX = "ISTX";

        /// <summary>
        /// ISINYN.
        /// </summary>
        public const string ISINYN = "ISINYN";

        /// <summary>
        /// ISRCYN.
        /// </summary>
        public const string ISRCYN = "ISRCYN";

        /// <summary>
        /// ISAISL.
        /// </summary>
        public const string ISAISL = "ISAISL";

        /// <summary>
        /// ISBIN.
        /// </summary>
        public const string ISBIN = "ISBIN";

        /// <summary>
        /// ISUSER.
        /// </summary>
        public const string ISUSER = "ISUSER";

        /// <summary>
        /// ISJOBN.
        /// </summary>
        public const string ISJOBN = "ISJOBN";

        /// <summary>
        /// ISPID.
        /// </summary>
        public const string ISPID = "ISPID";

        /// <summary>
        /// ISUPMJ.
        /// </summary>
        public const string ISUPMJ = "ISUPMJ";

        /// <summary>
        /// ISTDAY.
        /// </summary>
        public const string ISTDAY = "ISTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75I791";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ISPRP5", "ISPRP5", JdeDataType.String, 6, true, true),
        new JdeField("ISITM", "ISITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ISLITM", "ISLITM", JdeDataType.String, 50),
        new JdeField("ISAITM", "ISAITM", JdeDataType.String, 50),
        new JdeField("ISMCU", "ISMCU", JdeDataType.String, 24, true, true),
        new JdeField("ISAN8V", "ISAN8V", JdeDataType.Numeric, null, true, true),
        new JdeField("ISLOCN", "ISLOCN", JdeDataType.String, 40),
        new JdeField("ISLOTN", "ISLOTN", JdeDataType.String, 60),
        new JdeField("ISLVLA", "ISLVLA", JdeDataType.String, 6, true, true),
        new JdeField("ISLVLB", "ISLVLB", JdeDataType.String, 6),
        new JdeField("ISPCST", "ISPCST", JdeDataType.Numeric),
        new JdeField("ISPAMT", "ISPAMT", JdeDataType.Numeric),
        new JdeField("ISRATF", "ISRATF", JdeDataType.Numeric),
        new JdeField("ISRATV", "ISRATV", JdeDataType.Numeric),
        new JdeField("ISAN8", "ISAN8", JdeDataType.Numeric),
        new JdeField("ISGLC", "ISGLC", JdeDataType.String, 8),
        new JdeField("ISGLPT", "ISGLPT", JdeDataType.String, 8),
        new JdeField("ISEFFF", "ISEFFF", JdeDataType.Numeric),
        new JdeField("ISEFFT", "ISEFFT", JdeDataType.Numeric, null, true, true),
        new JdeField("ISTX", "ISTX", JdeDataType.String, 2),
        new JdeField("ISINYN", "ISINYN", JdeDataType.String, 2),
        new JdeField("ISRCYN", "ISRCYN", JdeDataType.String, 2),
        new JdeField("ISAISL", "ISAISL", JdeDataType.String, 16),
        new JdeField("ISBIN", "ISBIN", JdeDataType.String, 16),
        new JdeField("ISUSER", "ISUSER", JdeDataType.String, 20),
        new JdeField("ISJOBN", "ISJOBN", JdeDataType.String, 20),
        new JdeField("ISPID", "ISPID", JdeDataType.String, 20),
        new JdeField("ISUPMJ", "ISUPMJ", JdeDataType.Numeric),
        new JdeField("ISTDAY", "ISTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I791_0", "Primary Key on ISPRP5, ISITM, ISMCU, ISAN8V, ISLVLA, ISEFFT", new[] { "ISPRP5", "ISITM", "ISMCU", "ISAN8V", "ISLVLA", "ISEFFT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I791_2", "Index on ISITM, ISMCU, ISAN8V, ISLVLA, ISEFFT", new[] { "ISITM", "ISMCU", "ISAN8V", "ISLVLA", "ISEFFT" }),
        new JdeIndex("F75I791_3", "Index on ISPRP5, ISLVLA, ISEFFT", new[] { "ISPRP5", "ISLVLA", "ISEFFT" })
    };
}
