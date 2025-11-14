using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B107 - .
/// </summary>
public class F31B107 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FHNCFRMTID.
        /// </summary>
        public const string FHNCFRMTID = "FHNCFRMTID";

        /// <summary>
        /// FHNCFRMTNM.
        /// </summary>
        public const string FHNCFRMTNM = "FHNCFRMTNM";

        /// <summary>
        /// FHNCFRMTDS.
        /// </summary>
        public const string FHNCFRMTDS = "FHNCFRMTDS";

        /// <summary>
        /// FHWCRTR.
        /// </summary>
        public const string FHWCRTR = "FHWCRTR";

        /// <summary>
        /// FHNCFCC1.
        /// </summary>
        public const string FHNCFCC1 = "FHNCFCC1";

        /// <summary>
        /// FHNCFCC2.
        /// </summary>
        public const string FHNCFCC2 = "FHNCFCC2";

        /// <summary>
        /// FHNCFCC3.
        /// </summary>
        public const string FHNCFCC3 = "FHNCFCC3";

        /// <summary>
        /// FHURAB.
        /// </summary>
        public const string FHURAB = "FHURAB";

        /// <summary>
        /// FHURAT.
        /// </summary>
        public const string FHURAT = "FHURAT";

        /// <summary>
        /// FHURCD.
        /// </summary>
        public const string FHURCD = "FHURCD";

        /// <summary>
        /// FHURDT.
        /// </summary>
        public const string FHURDT = "FHURDT";

        /// <summary>
        /// FHURRF.
        /// </summary>
        public const string FHURRF = "FHURRF";

        /// <summary>
        /// FHWAB.
        /// </summary>
        public const string FHWAB = "FHWAB";

        /// <summary>
        /// FHWNUM.
        /// </summary>
        public const string FHWNUM = "FHWNUM";

        /// <summary>
        /// FHWCD.
        /// </summary>
        public const string FHWCD = "FHWCD";

        /// <summary>
        /// FHWMDT.
        /// </summary>
        public const string FHWMDT = "FHWMDT";

        /// <summary>
        /// FHWRF.
        /// </summary>
        public const string FHWRF = "FHWRF";

        /// <summary>
        /// FHUSER.
        /// </summary>
        public const string FHUSER = "FHUSER";

        /// <summary>
        /// FHUPMJ.
        /// </summary>
        public const string FHUPMJ = "FHUPMJ";

        /// <summary>
        /// FHUPMT.
        /// </summary>
        public const string FHUPMT = "FHUPMT";

        /// <summary>
        /// FHJOBN.
        /// </summary>
        public const string FHJOBN = "FHJOBN";

        /// <summary>
        /// FHMKEY.
        /// </summary>
        public const string FHMKEY = "FHMKEY";

        /// <summary>
        /// FHPID.
        /// </summary>
        public const string FHPID = "FHPID";
    }

    /// <inheritdoc />
    public override string TableName => "F31B107";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FHNCFRMTID", "FHNCFRMTID", JdeDataType.Numeric, null, true, true),
        new JdeField("FHNCFRMTNM", "FHNCFRMTNM", JdeDataType.String, 60),
        new JdeField("FHNCFRMTDS", "FHNCFRMTDS", JdeDataType.String, 60),
        new JdeField("FHWCRTR", "FHWCRTR", JdeDataType.Numeric),
        new JdeField("FHNCFCC1", "FHNCFCC1", JdeDataType.String, 20),
        new JdeField("FHNCFCC2", "FHNCFCC2", JdeDataType.String, 20),
        new JdeField("FHNCFCC3", "FHNCFCC3", JdeDataType.String, 20),
        new JdeField("FHURAB", "FHURAB", JdeDataType.Numeric),
        new JdeField("FHURAT", "FHURAT", JdeDataType.Numeric),
        new JdeField("FHURCD", "FHURCD", JdeDataType.String, 4),
        new JdeField("FHURDT", "FHURDT", JdeDataType.Numeric),
        new JdeField("FHURRF", "FHURRF", JdeDataType.String, 30),
        new JdeField("FHWAB", "FHWAB", JdeDataType.Numeric),
        new JdeField("FHWNUM", "FHWNUM", JdeDataType.Numeric),
        new JdeField("FHWCD", "FHWCD", JdeDataType.String, 6),
        new JdeField("FHWMDT", "FHWMDT", JdeDataType.Numeric),
        new JdeField("FHWRF", "FHWRF", JdeDataType.String, 60),
        new JdeField("FHUSER", "FHUSER", JdeDataType.String, 20),
        new JdeField("FHUPMJ", "FHUPMJ", JdeDataType.Numeric),
        new JdeField("FHUPMT", "FHUPMT", JdeDataType.Numeric),
        new JdeField("FHJOBN", "FHJOBN", JdeDataType.String, 20),
        new JdeField("FHMKEY", "FHMKEY", JdeDataType.String, 30),
        new JdeField("FHPID", "FHPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B107_0", "Primary Key on FHNCFRMTID", new[] { "FHNCFRMTID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B107_2", "Unique Index on FHNCFRMTNM", new[] { "FHNCFRMTNM" }, isUnique: true)
    };
}
