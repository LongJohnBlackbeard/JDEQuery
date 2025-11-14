using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B940 - .
/// </summary>
public class F76B940 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SJJOBS.
        /// </summary>
        public const string SJJOBS = "SJJOBS";

        /// <summary>
        /// SJB76LECO.
        /// </summary>
        public const string SJB76LECO = "SJB76LECO";

        /// <summary>
        /// SJB76ATCT.
        /// </summary>
        public const string SJB76ATCT = "SJB76ATCT";

        /// <summary>
        /// SJDSC1.
        /// </summary>
        public const string SJDSC1 = "SJDSC1";

        /// <summary>
        /// SJCTRY.
        /// </summary>
        public const string SJCTRY = "SJCTRY";

        /// <summary>
        /// SJB76SPFY.
        /// </summary>
        public const string SJB76SPFY = "SJB76SPFY";

        /// <summary>
        /// SJB76SPRF.
        /// </summary>
        public const string SJB76SPRF = "SJB76SPRF";

        /// <summary>
        /// SJB76SPRT.
        /// </summary>
        public const string SJB76SPRT = "SJB76SPRT";

        /// <summary>
        /// SJGPDP.
        /// </summary>
        public const string SJGPDP = "SJGPDP";

        /// <summary>
        /// SJB76SBON.
        /// </summary>
        public const string SJB76SBON = "SJB76SBON";

        /// <summary>
        /// SJB76STID.
        /// </summary>
        public const string SJB76STID = "SJB76STID";

        /// <summary>
        /// SJB76PRST.
        /// </summary>
        public const string SJB76PRST = "SJB76PRST";

        /// <summary>
        /// SJEFTB.
        /// </summary>
        public const string SJEFTB = "SJEFTB";

        /// <summary>
        /// SJEFTE.
        /// </summary>
        public const string SJEFTE = "SJEFTE";

        /// <summary>
        /// SJUSER.
        /// </summary>
        public const string SJUSER = "SJUSER";

        /// <summary>
        /// SJPID.
        /// </summary>
        public const string SJPID = "SJPID";

        /// <summary>
        /// SJJOBN.
        /// </summary>
        public const string SJJOBN = "SJJOBN";

        /// <summary>
        /// SJUPMJ.
        /// </summary>
        public const string SJUPMJ = "SJUPMJ";

        /// <summary>
        /// SJUPMT.
        /// </summary>
        public const string SJUPMT = "SJUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B940";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SJJOBS", "SJJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("SJB76LECO", "SJB76LECO", JdeDataType.String, 10),
        new JdeField("SJB76ATCT", "SJB76ATCT", JdeDataType.String, 4),
        new JdeField("SJDSC1", "SJDSC1", JdeDataType.String, 60),
        new JdeField("SJCTRY", "SJCTRY", JdeDataType.Numeric),
        new JdeField("SJB76SPFY", "SJB76SPFY", JdeDataType.Numeric),
        new JdeField("SJB76SPRF", "SJB76SPRF", JdeDataType.Numeric),
        new JdeField("SJB76SPRT", "SJB76SPRT", JdeDataType.Numeric),
        new JdeField("SJGPDP", "SJGPDP", JdeDataType.Numeric),
        new JdeField("SJB76SBON", "SJB76SBON", JdeDataType.Numeric),
        new JdeField("SJB76STID", "SJB76STID", JdeDataType.Numeric),
        new JdeField("SJB76PRST", "SJB76PRST", JdeDataType.String, 2),
        new JdeField("SJEFTB", "SJEFTB", JdeDataType.Numeric),
        new JdeField("SJEFTE", "SJEFTE", JdeDataType.Numeric),
        new JdeField("SJUSER", "SJUSER", JdeDataType.String, 20),
        new JdeField("SJPID", "SJPID", JdeDataType.String, 20),
        new JdeField("SJJOBN", "SJJOBN", JdeDataType.String, 20),
        new JdeField("SJUPMJ", "SJUPMJ", JdeDataType.Numeric),
        new JdeField("SJUPMT", "SJUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B940_0", "Primary Key on SJJOBS", new[] { "SJJOBS" }, isUnique: true, isPrimaryKey: true)
    };
}
