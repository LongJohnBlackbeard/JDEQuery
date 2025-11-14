using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4008 - .
/// </summary>
public class F4008 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TATXA1.
        /// </summary>
        public const string TATXA1 = "TATXA1";

        /// <summary>
        /// TATAXA.
        /// </summary>
        public const string TATAXA = "TATAXA";

        /// <summary>
        /// TATA1.
        /// </summary>
        public const string TATA1 = "TATA1";

        /// <summary>
        /// TATXR1.
        /// </summary>
        public const string TATXR1 = "TATXR1";

        /// <summary>
        /// TATA2.
        /// </summary>
        public const string TATA2 = "TATA2";

        /// <summary>
        /// TATXR2.
        /// </summary>
        public const string TATXR2 = "TATXR2";

        /// <summary>
        /// TATA3.
        /// </summary>
        public const string TATA3 = "TATA3";

        /// <summary>
        /// TATXR3.
        /// </summary>
        public const string TATXR3 = "TATXR3";

        /// <summary>
        /// TATA4.
        /// </summary>
        public const string TATA4 = "TATA4";

        /// <summary>
        /// TATXR4.
        /// </summary>
        public const string TATXR4 = "TATXR4";

        /// <summary>
        /// TATA5.
        /// </summary>
        public const string TATA5 = "TATA5";

        /// <summary>
        /// TATXR5.
        /// </summary>
        public const string TATXR5 = "TATXR5";

        /// <summary>
        /// TAEFDJ.
        /// </summary>
        public const string TAEFDJ = "TAEFDJ";

        /// <summary>
        /// TAEFTJ.
        /// </summary>
        public const string TAEFTJ = "TAEFTJ";

        /// <summary>
        /// TAGL01.
        /// </summary>
        public const string TAGL01 = "TAGL01";

        /// <summary>
        /// TAGL02.
        /// </summary>
        public const string TAGL02 = "TAGL02";

        /// <summary>
        /// TAGL03.
        /// </summary>
        public const string TAGL03 = "TAGL03";

        /// <summary>
        /// TAGL04.
        /// </summary>
        public const string TAGL04 = "TAGL04";

        /// <summary>
        /// TAGL05.
        /// </summary>
        public const string TAGL05 = "TAGL05";

        /// <summary>
        /// TAITM.
        /// </summary>
        public const string TAITM = "TAITM";

        /// <summary>
        /// TALITM.
        /// </summary>
        public const string TALITM = "TALITM";

        /// <summary>
        /// TAAITM.
        /// </summary>
        public const string TAAITM = "TAAITM";

        /// <summary>
        /// TAUOM.
        /// </summary>
        public const string TAUOM = "TAUOM";

        /// <summary>
        /// TAFVTY.
        /// </summary>
        public const string TAFVTY = "TAFVTY";

        /// <summary>
        /// TAMTAX.
        /// </summary>
        public const string TAMTAX = "TAMTAX";

        /// <summary>
        /// TATC1.
        /// </summary>
        public const string TATC1 = "TATC1";

        /// <summary>
        /// TATC2.
        /// </summary>
        public const string TATC2 = "TATC2";

        /// <summary>
        /// TATC3.
        /// </summary>
        public const string TATC3 = "TATC3";

        /// <summary>
        /// TATC4.
        /// </summary>
        public const string TATC4 = "TATC4";

        /// <summary>
        /// TATC5.
        /// </summary>
        public const string TATC5 = "TATC5";

        /// <summary>
        /// TATT1.
        /// </summary>
        public const string TATT1 = "TATT1";

        /// <summary>
        /// TATT2.
        /// </summary>
        public const string TATT2 = "TATT2";

        /// <summary>
        /// TATT3.
        /// </summary>
        public const string TATT3 = "TATT3";

        /// <summary>
        /// TATT4.
        /// </summary>
        public const string TATT4 = "TATT4";

        /// <summary>
        /// TATT5.
        /// </summary>
        public const string TATT5 = "TATT5";
    }

    /// <inheritdoc />
    public override string TableName => "F4008";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TATXA1", "TATXA1", JdeDataType.String, 20, true, true),
        new JdeField("TATAXA", "TATAXA", JdeDataType.String, 60),
        new JdeField("TATA1", "TATA1", JdeDataType.Numeric),
        new JdeField("TATXR1", "TATXR1", JdeDataType.Numeric),
        new JdeField("TATA2", "TATA2", JdeDataType.Numeric),
        new JdeField("TATXR2", "TATXR2", JdeDataType.Numeric),
        new JdeField("TATA3", "TATA3", JdeDataType.Numeric),
        new JdeField("TATXR3", "TATXR3", JdeDataType.Numeric),
        new JdeField("TATA4", "TATA4", JdeDataType.Numeric),
        new JdeField("TATXR4", "TATXR4", JdeDataType.Numeric),
        new JdeField("TATA5", "TATA5", JdeDataType.Numeric),
        new JdeField("TATXR5", "TATXR5", JdeDataType.Numeric),
        new JdeField("TAEFDJ", "TAEFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TAEFTJ", "TAEFTJ", JdeDataType.Numeric),
        new JdeField("TAGL01", "TAGL01", JdeDataType.String, 8),
        new JdeField("TAGL02", "TAGL02", JdeDataType.String, 8),
        new JdeField("TAGL03", "TAGL03", JdeDataType.String, 8),
        new JdeField("TAGL04", "TAGL04", JdeDataType.String, 8),
        new JdeField("TAGL05", "TAGL05", JdeDataType.String, 8),
        new JdeField("TAITM", "TAITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TALITM", "TALITM", JdeDataType.String, 50),
        new JdeField("TAAITM", "TAAITM", JdeDataType.String, 50),
        new JdeField("TAUOM", "TAUOM", JdeDataType.String, 4),
        new JdeField("TAFVTY", "TAFVTY", JdeDataType.String, 2),
        new JdeField("TAMTAX", "TAMTAX", JdeDataType.Numeric),
        new JdeField("TATC1", "TATC1", JdeDataType.String, 2),
        new JdeField("TATC2", "TATC2", JdeDataType.String, 2),
        new JdeField("TATC3", "TATC3", JdeDataType.String, 2),
        new JdeField("TATC4", "TATC4", JdeDataType.String, 2),
        new JdeField("TATC5", "TATC5", JdeDataType.String, 2),
        new JdeField("TATT1", "TATT1", JdeDataType.String, 2),
        new JdeField("TATT2", "TATT2", JdeDataType.String, 2),
        new JdeField("TATT3", "TATT3", JdeDataType.String, 2),
        new JdeField("TATT4", "TATT4", JdeDataType.String, 2),
        new JdeField("TATT5", "TATT5", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4008_0", "Primary Key on TATXA1, TAITM, TAEFDJ", new[] { "TATXA1", "TAITM", "TAEFDJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4008_2", "Index on TATA1", new[] { "TATA1" })
    };
}
